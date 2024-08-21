using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.OpenClosePrinciple
{
    /***
     * Classes should be open for extension but closed for modification
     */
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter<T>(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;

        public ColorSpecification(Color color) { 
            this._color = color;
        }

        public bool IsSatisfiedBy(Product entity)
        {
            return entity.Color == _color;
        }
    }

    public class SizeSpecification : ISpecification<Product> {
        private Size size;
        public SizeSpecification(Size size) { 
            this.size = size;
        }
        public bool IsSatisfiedBy(Product entity) { 
            return entity.Size == size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(nameof(first));
            this.second = second ?? throw new ArgumentNullException(nameof(second));
        }

        public bool IsSatisfiedBy(T entity)
        {
            return first.IsSatisfiedBy(entity) && second.IsSatisfiedBy(entity);
        }
    }

    public class BetterFilter : IFilter<Product>
    {

        public IEnumerable<Product> Filter<Product>(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfiedBy(item))
                {
                    yield return item;
                }
            }
                
        }
    }

    public class OpenClosedPrinciple
    {
        public static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);
            Product[] products = {apple, tree, house};
            var pf = new ProductFilter();

            Console.WriteLine("Green products (old): ");
            foreach(var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            var bf =new BetterFilter();
            Console.WriteLine("Green products (better): ");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            Console.WriteLine("Large blud items");
            foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)))){
                Console.WriteLine($" - {p.Name} is blue and large");
            }
        }
    }
}

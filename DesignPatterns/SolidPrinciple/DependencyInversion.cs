using SolidPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{

    /***
     * high level module shouldn't depend on low level module directly
     * use an interface for dependency
     */

    public enum Relationship
    {
        Parent, Child, Sibling
    }

    public class Person
    {
        public string Name;
    }

    // Interface that connects low level and high level
    public interface IRelationshoBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    //low-level as a Bad Practice, use interface instead
    //public class Relationships
    public class Relationships : IRelationshoBrowser
    {
        private List<(Person, Relationship, Person)> relations = new();
        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }
        // Don't do this
        // public List<(Person, Relationship, Person)> Relations => relations;

        // use interface to connect high level and low level
        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(x=>x.Item1.Name == name && x.Item2 == Relationship.Parent).Select(r=>r.Item3);
          
        }
    }


    public class DependencyInversion
    {
        // This high level code depends on relationship
        //public DependencyInversion(Relationships relationships)
        //{
        //    var relations = relationships.Relations;
        //    foreach(var r in relations.Where(x=>x.Item1.Name == "John" && x.Item2 == Relationship.Parent))
        //    {
        //        Console.WriteLine($"John has a child  called {r.Item3.Name}");
        //    }
        //}

        public DependencyInversion(IRelationshoBrowser browser)
        {
            foreach(var p in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {p.Name}");
            }
        }

        public static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new DependencyInversion(relationships);
        }
    }


}
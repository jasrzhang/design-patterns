using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;
    }

    public class CountryDiscountService : DiscountService
    {

        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "BE":
                        return 20;
                    default:
                        return 10;
                }
            }
        }
    }

    public class CodeDiscountService : DiscountService
    {
        public readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            _code = code;
        }
        public override int DiscountPercentage {
            get => 15;
        }
    }

    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;
        public CountryDiscountFactory(string countryIdentifier)
        {
            this._countryIdentifier = countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(this._countryIdentifier);
        }
    }

    public class CodeDiscountFacotry : DiscountFactory
    {
        private readonly Guid _code;
        public CodeDiscountFacotry(Guid code)
        {
            this._code = code;
        }
        public override DiscountService CreateDiscountService() => new CodeDiscountService(this._code);
    }

}

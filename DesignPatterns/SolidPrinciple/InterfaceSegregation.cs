using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    /***
     * Don't put too much into an interface; split into sepreate interfaces
     * YAGNI - You ain't going to Need It
     */

    public class Document
    {

    }

    /***
     *  This is bad practice as the old fasioned printer has to implement the method it doesn't use
     */
    //public interface IMachine {
    //    void Print(Document d);
    //    void Scan(Document d);
    //    void Fax(Document d);
    //}

    //public class MultiFunctionPrinter : IMachine
    //{
    //    public void Fax(Document d)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Print(Document d)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Scan(Document d)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class OldFashionedPrinter : IMachine
    //{
    //    public void Fax(Document d)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Print(Document d)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Scan(Document d)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    /**
     * right way to do it is 
     */

    public interface IPrinter
    {
        void Print();
    }
    public interface IScanner
    {
        void Scan();
    }
    public interface IFaxer
    {
        void Fax();
    }

    public interface IMultiFunctionDevice : IPrinter, IScanner, IFaxer
    {
      

    }

    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;
        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if(printer == null) throw new ArgumentNullException(paramName: nameof(printer));
            if(scanner == null) throw new ArgumentNullException(nameof(scanner));
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }

    public class InterfaceSegregation
    {
        public static void Main(string[] args)
        {

        }
    }
}

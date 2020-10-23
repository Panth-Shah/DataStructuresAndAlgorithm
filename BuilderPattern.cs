using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{
    public class BuilderPattern
    {

    }
    //Build Interface specifies metod for creating the different parts of the Project objects
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }

    //Concrete builder classes follow the vuilder interface and provides
    //specific implementation of the building steps
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public ConcreteBuilder()
        {
            this.Reset();
        }

        private void Reset()
        {
            this._product = new Product();
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }
        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
    }

    //It makes sense to use the builder patten only when your product are quite complex and require extensive configuration
    public class Product
    {
        private List<object> _parts = new List<object>();
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2);
            return "Product parts: " + str + "\n";
        }
    }
    //DIrector is only responsible for executing the building steps in a particular sequence.
    //It is helpful when producing roducts according to a specific order or configuration
    //This class is optional as even client can perform this work
    public class Director
    {
        public IBuilder Builder { get; set; }

        //Director can consturct several product variations using the same building step
        public void buildMinimalViableProduct()
        {
            this.Builder.BuildPartA();
        }
        public void buildFullFeaturedProduct()
        {
            this.Builder.BuildPartA();
            this.Builder.BuildPartB();
            this.Builder.BuildPartC();
        }
    }

}

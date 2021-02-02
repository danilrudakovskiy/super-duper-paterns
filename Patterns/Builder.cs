using System.Collections.Generic;

namespace Patterns
{
    public class Product
    {
        public List<string> Parts { get; set; } = new List<string>();
    }

    public interface IBuilder
    {
        void BuildA();
        void BuildB();
        Product GetProduct();
    }

    public class Builder : IBuilder
    {
        private Product Product { get; set; } = new Product();

        public void Reset()
        {
            Product = new Product();
        }

        public void BuildA()
        {
            Product.Parts.Add("A");
        }

        public void BuildB() => Product.Parts.Add("B");

        public Product GetProduct()
        {
            var result = Product;

            Reset();

            return result;
        }
    }

    public class Director
    {
        public IBuilder Builder { get; set; }

        public void BuildAB()
        {
            Builder.BuildA();
            Builder.BuildB();
        }
        
        public void BuildBA()
        {
            Builder.BuildB();
            Builder.BuildA();
        }
    }
}
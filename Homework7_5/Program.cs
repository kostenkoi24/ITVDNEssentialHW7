using System;
using System.Globalization;

namespace Homework7_5
{

    struct Notebook
    {
        string modelName;
        string manufacturerName;
        double cost;

        public Notebook(string modelName, string manufacturerName, double cost)
        {
            this.modelName = modelName;
            this.manufacturerName = manufacturerName;
            this.cost = cost;
        }

        public void ShowInfo()
        {
            RegionInfo myRI1 = new RegionInfo("ua-ua");

            Console.WriteLine($"Model name: {modelName} \nManufacturer name: {manufacturerName} \nCost: {cost} {myRI1.ISOCurrencySymbol}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Lenovo E470", "Lenovo", 21000.99);
            notebook.ShowInfo();
            Console.ReadKey();
            
        }
    }
}

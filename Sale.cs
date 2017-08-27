using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagement
{
    public class Sale
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public string SoldTo { get; set; }
        public string SoldWith { get; set; }
        public Product Product { get; set; }

        public Sale()
        {
            ID = XML.RandomId(6);
        }

        public void Add()
        {
            XDocument xDoc = XDocument.Load("Files/Sales.xml");

            XElement root = xDoc.Root;
            XElement element = XML.Serialize(this);
            root.Add(element);

            xDoc.Save("Files/Sales.xml");
        }

        public void Delete()
        {
            XDocument xDoc = XDocument.Load("Files/Sales.xml");

            XElement element = xDoc.Root.Elements("Sale").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.Remove();

            xDoc.Save("Files/Sales.xml");
        }

        public static Sale GetSingle(string id)
        {
            XDocument xDoc = XDocument.Load("Files/Sales.xml");
            XElement element = xDoc.Root.Elements("Sale").Where(a => (string)a.Element("ID") == id).FirstOrDefault();

            return XML.Deserialize<Sale>(element);
        }

        public static List<Sale> GetAll()
        {
            List<Sale> sales = new List<Sale>();


            XDocument xDoc = XDocument.Load("Files/Sales.xml");

            foreach (XElement el in xDoc.Root.Elements("Sale"))
            {
                Sale sale = new Sale();
                sale = XML.Deserialize<Sale>(el);

                sales.Add(sale);
            }

            return sales;
        }

        public void Edit()
        {
            XDocument xDoc = XDocument.Load("Files/Sales.xml");

            XElement element = xDoc.Root.Elements("Sale").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.ReplaceWith(XML.Serialize(this));

            xDoc.Save("Files/Sales.xml");

        }
    }
}

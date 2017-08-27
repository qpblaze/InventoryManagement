using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagement
{
    public class Product
    {
        public virtual string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Store { get; set; }
        public string Supplier { get; set; }
        public string BuyingPrice { get; set; }
        public string SellingPrice { get; set; }
        public int InStock { get; set; }
        public int MinStock { get; set; }

        public Product()
        {
            ID = XML.RandomId(6, true);
        }

        public virtual void Add()
        {
            XDocument xDoc = XDocument.Load("Files/Products.xml");

            XElement root = xDoc.Root;
            XElement element = XML.Serialize(this);
            root.Add(element);

            xDoc.Save("Files/Products.xml");
        }

        public virtual void Delete()
        {
            XDocument xDoc = XDocument.Load("Files/Products.xml");

            XElement element = xDoc.Root.Elements("Product").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.Remove();

            xDoc.Save("Files/Products.xml");
        }

        public static Product GetSingle(string id)
        {
            try
            {
                XDocument xDoc = XDocument.Load("Files/Products.xml");
                XElement element = xDoc.Root.Elements("Product").Where(a => (string)a.Element("ID") == id).FirstOrDefault();

                return XML.Deserialize<Product>(element);
            }
            catch(Exception ex)
            {
                using (FileStream fs = new FileStream("logs.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(DateTime.Now.ToString());
                        sw.WriteLine(ex.ToString());
                        sw.WriteLine();
                        sw.WriteLine();
                        sw.WriteLine();
                    }
                }
                return null;
            }
        }

        public static List<Product> GetAll()
        {
            List<Product> products = new List<Product>();


            XDocument xDoc = XDocument.Load("Files/Products.xml");

            foreach (XElement el in xDoc.Root.Elements("Product"))
            {
                Product product = new Product();
                product = XML.Deserialize<Product>(el);

                products.Add(product);
            }

            return products;
        }

        public virtual void Edit()
        {
            XDocument xDoc = XDocument.Load("Files/Products.xml");

            XElement element = xDoc.Root.Elements("Product").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.ReplaceWith(XML.Serialize(this));

            xDoc.Save("Files/Products.xml");

        }
    }
}

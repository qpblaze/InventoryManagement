using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagement
{
    public class Supplier
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Supplier()
        {
            ID = XML.RandomId(6);
        }

        public void Add()
        {
            XDocument xDoc = XDocument.Load("Files/Suppliers.xml");

            XElement root = xDoc.Root;
            XElement element = XML.Serialize(this);
            root.Add(element);

            xDoc.Save("Files/Suppliers.xml");
        }

        public void Delete()
        {
            XDocument xDoc = XDocument.Load("Files/Suppliers.xml");

            XElement element = xDoc.Root.Elements("Supplier").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.Remove();

            xDoc.Save("Files/Suppliers.xml");
        }

        public static Supplier GetSingle(string id)
        {
            XDocument xDoc = XDocument.Load("Files/Suppliers.xml");
            XElement element = xDoc.Root.Elements("Supplier").Where(a => (string)a.Element("ID") == id).FirstOrDefault();

            return XML.Deserialize<Supplier>(element);
        }

        public static List<Supplier> GetAll()
        {
            List<Supplier> suppliers = new List<Supplier>();


            XDocument xDoc = XDocument.Load("Files/Suppliers.xml");

            foreach (XElement el in xDoc.Root.Elements("Supplier"))
            {
                Supplier supplier = new Supplier();
                supplier = XML.Deserialize<Supplier>(el);

                suppliers.Add(supplier);
            }

            return suppliers;
        }

        public void Edit()
        {
            XDocument xDoc = XDocument.Load("Files/Suppliers.xml");

            XElement element = xDoc.Root.Elements("Supplier").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.ReplaceWith(XML.Serialize(this));

            xDoc.Save("Files/Suppliers.xml");
        }
    }
}

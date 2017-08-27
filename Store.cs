using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagement
{
    public class Store
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Store()
        {
            ID = XML.RandomId(6);
        }

        public void Add()
        {
            XDocument xDoc = XDocument.Load("Files/Stores.xml");

            XElement root = xDoc.Root;
            XElement element = XML.Serialize(this);
            root.Add(element);

            xDoc.Save("Files/Stores.xml");
        }

        public void Delete()
        {
            XDocument xDoc = XDocument.Load("Files/Stores.xml");

            XElement element = xDoc.Root.Elements("Store").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.Remove();

            xDoc.Save("Files/Stores.xml");
        }

        public static Store GetSingle(string id)
        {
            XDocument xDoc = XDocument.Load("Files/Stores.xml");
            XElement element = xDoc.Root.Elements("Store").Where(a => (string)a.Element("ID") == id).FirstOrDefault();

            return XML.Deserialize<Store>(element);
        }

        public static List<Store> GetAll()
        {
            List<Store> stores = new List<Store>();


            XDocument xDoc = XDocument.Load("Files/Stores.xml");

            foreach (XElement el in xDoc.Root.Elements("Store"))
            {
                Store store = new Store();
                store = XML.Deserialize<Store>(el);

                stores.Add(store);
            }

            return stores;
        }

        public void Edit()
        {
            XDocument xDoc = XDocument.Load("Files/Stores.xml");

            XElement element = xDoc.Root.Elements("Store").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.ReplaceWith(XML.Serialize(this));

            xDoc.Save("Files/Stores.xml");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagement
{
    public class Cost
    {
        public string ID { get; set; }
        public string Info { get; set; }
        public string Price { get; set; }
        public DateTime Date { get; set; }

        public Cost()
        {
            ID = XML.RandomId(6);
        }

        public void Add()
        {
            XDocument xDoc = XDocument.Load("Files/Costs.xml");

            XElement root = xDoc.Root;
            XElement element = XML.Serialize(this);
            root.Add(element);

            xDoc.Save("Files/Costs.xml");
        }

        public void Delete()
        {
            XDocument xDoc = XDocument.Load("Files/Costs.xml");

            XElement element = xDoc.Root.Elements("Cost").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.Remove();

            xDoc.Save("Files/Costs.xml");
        }

        public static Cost GetSingle(string id)
        {
            XDocument xDoc = XDocument.Load("Files/Costs.xml");
            XElement element = xDoc.Root.Elements("Cost").Where(a => (string)a.Element("ID") == id).FirstOrDefault();

            return XML.Deserialize<Cost>(element);
        }

        public static List<Cost> GetAll()
        {
            List<Cost> costs = new List<Cost>();


            XDocument xDoc = XDocument.Load("Files/Costs.xml");

            foreach (XElement el in xDoc.Root.Elements("Cost"))
            {
                Cost cost = new Cost();
                cost = XML.Deserialize<Cost>(el);

                costs.Add(cost);
            }

            return costs;
        }

        public void Edit()
        {
            XDocument xDoc = XDocument.Load("Files/Costs.xml");

            XElement element = xDoc.Root.Elements("Cost").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.ReplaceWith(XML.Serialize(this));

            xDoc.Save("Files/Costs.xml");

        }
    }
}

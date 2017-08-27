using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagement
{
    public class Category
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Category()
        {
            ID = XML.RandomId(6);
        }

        public void Add()
        {
            XDocument xDoc = XDocument.Load("Files/Categories.xml");

            XElement root = xDoc.Root;
            XElement element = XML.Serialize(this);
            root.Add(element);

            xDoc.Save("Files/Categories.xml");
        }

        public void Delete()
        {
            XDocument xDoc = XDocument.Load("Files/Categories.xml");

            XElement element = xDoc.Root.Elements("Category").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.Remove();

            xDoc.Save("Files/Categories.xml");
        }

        public static Category GetSingle(string id)
        {
            XDocument xDoc = XDocument.Load("Files/Categories.xml");
            XElement element = xDoc.Root.Elements("Category").Where(a => (string)a.Element("ID") == id).FirstOrDefault();

            return XML.Deserialize<Category>(element);
        }

        public static List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();


            XDocument xDoc = XDocument.Load("Files/Categories.xml");

            foreach (XElement el in xDoc.Root.Elements("Category"))
            {
                Category category = new Category();
                category = XML.Deserialize<Category>(el);

                categories.Add(category);
            }

            return categories;
        }

        public void Edit()
        {
            XDocument xDoc = XDocument.Load("Files/Categories.xml");

            XElement element = xDoc.Root.Elements("Category").Where(a => (string)a.Element("ID") == ID).FirstOrDefault();
            element.ReplaceWith(XML.Serialize(this));

            xDoc.Save("Files/Categories.xml");

        }
    }
}

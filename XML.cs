using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace InventoryManagement
{
    public class XML
    {
        public static XElement Serialize(object obj)
        {
            var doc = new XDocument();
            using (XmlWriter writer = doc.CreateWriter())
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(writer, obj, ns);
            }

            return doc.Root;
        }

        public static string RandomId(int length, bool prod = false)
        {
            Random random = new Random();
            string chars = null;
            if(prod == false)
                chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            else
                chars = "0123456789";
            
            string val = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

            while(val[0] == '0')
            {
                val = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            }

            return val;
            
        }

        public static T Deserialize<T>(XElement element)
        {
             var serializer = new XmlSerializer(typeof(T));
             return (T)serializer.Deserialize(element.CreateReader());
            
        }
    }
}

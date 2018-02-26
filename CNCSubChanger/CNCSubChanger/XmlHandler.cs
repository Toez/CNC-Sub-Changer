using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CNCSubChanger
{
    class XmlHandler
    {
        private XmlDocument doc;
        private XmlReader reader;
        private XmlWriter writer;
        private XmlNode root;
        private List<XmlNode> nodes;

        public XmlHandler()
        {

        }

        public string ReadXml(string path, string node)
        {
            doc = new XmlDocument();
            reader = XmlReader.Create(path);
            nodes = new List<XmlNode>();

            doc.Load(reader);
            root = doc.LastChild;
            ChildNodes(root);

            return nodes.Find(x => x.Name == node).InnerText;
        }

        public XmlNode ReturnXml(string path, string node)
        {
            doc = new XmlDocument();
            reader = XmlReader.Create(path);
            nodes = new List<XmlNode>();

            doc.Load(reader);
            root = doc.LastChild;
            ChildNodes(root);

            return nodes.Find(x => x.Name == node);
        }

        private void ChildNodes(XmlNode parent)
        {
            foreach (XmlNode child in parent)
            {
                nodes.Add(child);

                if (child.HasChildNodes)
                    ChildNodes(child);
            }
        }

        public void Write(string path, string value, string node)
        {
            writer = XmlWriter.Create(path);
            
            writer.Close();
        }
    }
}

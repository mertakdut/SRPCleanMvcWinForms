using System.IO;
using System.Xml;

namespace SRPCleanMvcWinForms
{
    public class SourceReader : ISourceReader
    {
        private XmlReader reader;

        public string Name
        {
            get { return reader.Name; }
        }

        public SourceReader Create(Stream stream)
        {
            reader = XmlReader.Create(stream);
            return this;
        }

        public bool Read()
        {
            return reader.Read();
        }

        public string GetAttribute(string attribute)
        {
            return reader.GetAttribute(attribute);
        }
    }
}

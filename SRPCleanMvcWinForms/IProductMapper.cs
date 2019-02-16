using System.Xml;

namespace SRPCleanMvcWinForms
{
    public interface IProductMapper
    {
        Product Map(XmlReader reader);
    }
}

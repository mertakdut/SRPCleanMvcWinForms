using System.Xml;

namespace SRPCleanMvcWinForms
{
    public interface IProductMapper
    {
        Product Map(ISourceReader reader);
    }
}

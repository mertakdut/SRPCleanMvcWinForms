using System.IO;

namespace SRPCleanMvcWinForms
{
    public interface ISourceProvider
    {
        Stream Load(string sourceIndicator);
    }
}

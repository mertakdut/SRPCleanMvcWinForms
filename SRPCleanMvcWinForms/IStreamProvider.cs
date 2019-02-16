using System.IO;

namespace SRPCleanMvcWinForms
{
    public interface IStreamProvider
    {
        Stream Load(string fileName);
    }
}

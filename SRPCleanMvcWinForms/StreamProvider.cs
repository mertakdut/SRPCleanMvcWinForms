using System.IO;

namespace SRPCleanMvcWinForms
{
    public class SourceProvider : ISourceProvider
    {
        public Stream Load(string fileName)
        {
            return new FileStream(fileName, FileMode.Open);
        }
    }
}

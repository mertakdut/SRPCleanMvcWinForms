using System.IO;

namespace SRPCleanMvcWinForms
{
    public class SourceProvider : ISourceProvider
    {
        public Stream Load(string sourceIndicator)
        {
            return new FileStream(sourceIndicator, FileMode.Open);
        }
    }
}

using System.IO;

namespace SRPCleanMvcWinForms
{
    public class StreamProvider : IStreamProvider
    {
        public Stream Load(string fileName)
        {
            return new FileStream(fileName, FileMode.Open);
        }
    }
}

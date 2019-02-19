using System.IO;

namespace SRPCleanMvcWinForms
{
    public interface ISourceReader
    {
        SourceReader Create(Stream stream);

        string Name { get; }

        string GetAttribute(string attribute);

        bool Read();
        
    }
}

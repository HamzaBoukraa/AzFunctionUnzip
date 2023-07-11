using System.IO;
using System.Threading.Tasks;

namespace AzFunctionUnzip.Abstractions
{
    public interface IFileProcessor
    {
        Task ProcessFile(Stream blobStream);
    }
}

using System.Collections.Generic;

namespace SRPCleanMvcWinForms
{
    public interface IProductManager
    {
        IEnumerable<Product> GetProducts(string fileName);
    }
}

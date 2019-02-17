using System.Collections.Generic;

namespace SRPCleanMvcWinForms
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string fileName);
    }
}

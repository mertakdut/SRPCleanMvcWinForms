using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SRPCleanMvcWinForms
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISourceProvider sourceProvider;
        private readonly IProductMapper productMapper;
        private readonly ISourceReader sourceReader;

        public ProductRepository()
        {
            this.sourceProvider = new SourceProvider();
            this.productMapper = new ProductMapper();
            this.sourceReader = new SourceReader();
        }

        public IEnumerable<Product> GetProducts(string fileName)
        {
            var products = new List<Product>();
            using (Stream stream = sourceProvider.Load(fileName))
            {
                var reader = sourceReader.Create(stream);
                while (reader.Read())
                {
                    var product = productMapper.Map(reader);

                    if (product != null)
                        products.Add(product);
                }
            }

            return products;
        }
    }
}

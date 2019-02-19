using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SRPCleanMvcWinForms
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISourceProvider sourceProvider;
        private readonly ISourceReader sourceReader;
        private readonly IProductMapper productMapper;

        public ProductRepository()
        {
            this.sourceProvider = new SourceProvider();
            this.sourceReader = new SourceReader();
            this.productMapper = new ProductMapper();
        }

        public IEnumerable<Product> GetProducts(string sourceIndicator)
        {
            var products = new List<Product>();
            using (Stream stream = sourceProvider.Load(sourceIndicator))
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

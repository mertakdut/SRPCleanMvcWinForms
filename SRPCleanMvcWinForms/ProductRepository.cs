using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace SRPCleanMvcWinForms
{
    public class ProductRepository : IProductRepository
    {
        private readonly IStreamProvider streamProvider;
        private readonly IProductMapper productMapper;

        public ProductRepository()
        {
            this.streamProvider = new StreamProvider();
            this.productMapper = new ProductMapper();
        }

        public IEnumerable<Product> GetProducts(string fileName)
        {
            var products = new List<Product>();
            using (Stream stream = streamProvider.Load(fileName))
            {
                var reader = XmlReader.Create(stream);
                while (reader.Read())
                {
                    if (reader.Name != "product")
                        continue;

                    var product = productMapper.Map(reader);
                    products.Add(product);
                }
            }

            return products;
        }
    }
}

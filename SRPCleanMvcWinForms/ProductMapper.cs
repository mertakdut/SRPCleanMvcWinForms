using System;

namespace SRPCleanMvcWinForms
{
    public class ProductMapper : IProductMapper
    {
        public Product Map(ISourceReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException("XML reader used when mapping cannot be null.");

            if (reader.Name != "product")
                return null;

            var product = new Product();

            product.Id = int.Parse(reader.GetAttribute("id"));
            product.Name = reader.GetAttribute("name");
            product.UnitPrice = decimal.Parse(reader.GetAttribute("unitPrice"));
            product.Discontinued = bool.Parse(reader.GetAttribute("discontinued"));

            return product;
        }
    }
}

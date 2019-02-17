namespace SRPCleanMvcWinForms
{
    public class ProductPresenter : IProductPresenter
    {
        private readonly IProductRepository productRepository;
        private readonly IProductView view;

        public ProductPresenter(IProductView view)
        {
            this.view = view;
            view.Initialize(this);

            productRepository = new ProductRepository();
        }

        public void BrowseForFileName()
        {
            var openedFileName = view.ShowOpenXmlFileDialog();
            if (!string.IsNullOrEmpty(openedFileName))
            {
                view.SetFileName(openedFileName);
            }
        }

        public void ShowProducts()
        {
            var products = productRepository.GetProducts(view.GetFileName());
            view.ShowProducts(products);
        }
    }
}

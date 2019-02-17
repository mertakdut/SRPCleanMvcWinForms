using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SRPCleanMvcWinForms
{
    public partial class XmlListerForm : Form, IProductView
    {
        #region Private members and constructors
        private IProductPresenter presenter;

        public XmlListerForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            presenter.BrowseForFileName();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            presenter.ShowProducts();
        }
        #endregion

        #region Public Methods
        public void Initialize(IProductPresenter presenter)
        {
            this.presenter = presenter;
        }

        public string ShowOpenXmlFileDialog()
        {
            openFileDialog1.Filter = "XML Document (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            return openFileDialog1.ShowDialog() == DialogResult.OK ? openFileDialog1.FileName : null;
        }

        public void SetFileName(string fileName)
        {
            txtFileName.Text = fileName;
            btnLoad.Enabled = true;
        }

        public string GetFileName()
        {
            return txtFileName.Text;
        }

        public void ShowProducts(IEnumerable<Product> products)
        {
            listView1.Items.Clear();
            foreach (Product product in products)
            {
                var item = new ListViewItem
                (
                    new[]
                    {
                        product.Id.ToString(),
                        product.Name,
                        product.UnitPrice.ToString(),
                        product.Discontinued.ToString()
                    }
                );

                listView1.Items.Add(item);
            }
        }
        #endregion
    }
}

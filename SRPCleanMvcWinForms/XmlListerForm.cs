using System;
using System.IO;
using System.Windows.Forms;

namespace SRPCleanMvcWinForms
{
    public partial class XmlListerForm : Form
    {
        private readonly IProductManager productManager;

        public XmlListerForm()
        {
            InitializeComponent();
            productManager = new ProductManager();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Document (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
                btnLoad.Enabled = true;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var fileName = txtFileName.Text;

            var products = productManager.GetProducts(fileName);
            foreach (var product in products)
            {
                var item = new ListViewItem
                (
                    new string[]
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
    }
}

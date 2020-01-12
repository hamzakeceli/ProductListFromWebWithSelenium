using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        ProductServicesForDb productServices = new ProductServicesForDb();
        ProductServicesForWeb ProductServicesForWeb = new ProductServicesForWeb();
        MallServices mallServices = new MallServices();
        List<Mall> checkedMalls = new List<Mall>();

        private void FormMain_Load(object sender, EventArgs e)
        {
            DatagridViewCreate();
            CheckedListCreat();
        }

        //db kayıtlı e ticaret merkezleri
        private void CheckedListCreat()
        {
            checkedListMalls.Items.Clear();
            var malls = mallServices.GetMalls();

            foreach (var mall in malls)
            {
                checkedListMalls.Items.Add(mall.MallName);
            }
        }

        private void DatagridViewCreate()
        {
            dataGridProductList.ColumnCount = 6;

            dataGridProductList.Columns[0].Name = "Ürün Adı";
            dataGridProductList.Columns[1].Name = "Fiyatı";
            dataGridProductList.Columns[2].Name = "İndirimli Fiyatı";
            dataGridProductList.Columns[3].Name = "Site Adı";
            dataGridProductList.Columns[4].Name = "Listeleme Tarihi";
            dataGridProductList.Columns[5].Name = "Anahtar Kelime";
        }

        private void btnProductListFromDb_Click(object sender, EventArgs e)
        {

            dataGridProductList.Rows.Clear();


            if (productServices.IsEmptyNameFilter(textBoxProductFilterForDb.Text))
            {
                MessageBox.Show("Lütfen filtreleme alanını doldurunuz");
            }

            else
            {
                List<Product> products = productServices.GetProductsByNameFilter(textBoxProductFilterForDb.Text);

                WriteToDataGridProducts(products);

            }

        }

        private void btnProductListFromWeb_Click(object sender, EventArgs e)
        {

            if (checkedListMalls.CheckedItems.Count > 0)

            {

                foreach (string mallNama in checkedListMalls.CheckedItems)
                {
                    var mall = mallServices.GetMall(mallNama);
                    checkedMalls.Add(mall);

                }


                foreach (var item in checkedMalls)
                {

                    var mall = mallServices.GetMall(item.MallName);
                    string filterString = textBoxProductFilterForWeb.Text;

                    List<Product> products = ProductServicesForWeb.GetProdutsFromWeb(mall, filterString);
                    WriteToDataGridProducts(products);


                }

            }
            else
            {
                MessageBox.Show("Lütfen en az bir tane E-ticaret seçin");
            }



        }

        public void WriteToDataGridProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                dataGridProductList.Rows.Add(
                                             product.ProductName,
                                             product.ProductPrice,
                                             product.DiscountedPrice,
                                             product.Mall.MallName,
                                             product.ListingDate,
                                             product.KeyValue
                                             );
            }
        }
    }
}

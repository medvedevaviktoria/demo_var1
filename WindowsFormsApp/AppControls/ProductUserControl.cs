using demo_var1.AppForms;
using demo_var1.AppModel;
using demo_var1.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_var1.AppControls
{
    public partial class ProductUserControl : UserControl
    {
        private Product _product;
        public ProductUserControl(Product product)
        {
            InitializeComponent();
            _product = product;
            FillInfo();
        }

        private void FillInfo()
        {
            categoryAndNameLabel.Text = $"{_product.Category.CategoryName} | {_product.ProductName.ProductNameName}";
            descriptionLabel1.Text = _product.Description;
            manufacturerIdLabel1.Text = $"Производитель: {_product.Manufacturer.ManufacturerName}";
            supplierIdLabel1.Text = $"Поставщик: {_product.Supplier.SupplierName}";
            unitOfMeasurmentIdLabel1.Text = $"Единица измерения: {_product.UnitOfMeasurment.UnitOfMeasurmentName}";
            stockLabel1.Text = $"Количество на складе: {_product.Stock} {_product.UnitOfMeasurment.UnitOfMeasurmentName}";
            realDiscountLabel1.Text = $"{_product.RealDiscount} %";
            pictureBoxPhoto.Image = GetImage();
            HighlightControl();
            GetPrice();
        }

        private void GetPrice()
        {
            if (_product.RealDiscount > 0)
            {
                labelOldPrice.Text = $"{_product.Price} руб.";
                labelOldPrice.Visible = true ;
                var newPrice = (((100 - _product.RealDiscount) / 100) * _product.Price);

                priceLabel1.Text = $"Цена: {newPrice} руб.";
            }
            else
            {
                labelOldPrice.Visible = false;
                priceLabel1.Text = $"Цена: {_product.Price} руб.";
            }
        }

        private void HighlightControl()
        {
            if (_product.RealDiscount > 7)
            {
                panel1.BackColor = ColorTranslator.FromHtml("#f1fcb2");
            }

            if (_product.Stock == 0)
            {
                panel1.BackColor = ColorTranslator.FromHtml("#f2b55c");
            }
        }

        private Image GetImage()
        {
            Image img;
            try
            {
                img = new Bitmap(Image.FromFile(Path.Combine(Application.StartupPath, "img", "picture.png"));
            }
            catch (FileNotFoundException ex)
            {
                img = Image.FromFile(Path.Combine(Application.StartupPath, "img", "picture.png");
            }
            return img;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            CreateUpdateProductForm createUpdateProductForm = new CreateUpdateProductForm(_product);
            DialogResult dialogResult = createUpdateProductForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                ContextManager.productForm.RefreshList();
            }
        }
    }
}

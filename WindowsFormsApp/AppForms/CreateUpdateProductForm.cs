using demo_var1.AppModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace demo_var1.AppForms
{
    public partial class CreateUpdateProductForm : Form
    {
        private Product _product;
        private bool addPhoto = false;
        private string newFileName;
        public CreateUpdateProductForm()
        {
            InitializeComponent();
            label1.Text = "\"Пиши-стирай\" - Добавление товара";
            Text = "\"Пиши-стирай\" - Добавление товара";
            _product = new Product();
            buttonDelete.Visible = false;
            realDiscountNumericUpDown.Maximum = maxDiscountNumericUpDown.Value;
        }

        public CreateUpdateProductForm(Product product)
        {
            InitializeComponent();
            label1.Text = "\"Пиши-стирай\" - Редактирование товара";
            Text = "\"Пиши-стирай\" - Редактирование товара";
            _product = product;
            buttonDelete.Visible = true;
        }

        private void CreateUpdateProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_var1DataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.demo_var1DataSet.Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_var1DataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.demo_var1DataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_var1DataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.demo_var1DataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_var1DataSet.UnitOfMeasurment". При необходимости она может быть перемещена или удалена.
            this.unitOfMeasurmentTableAdapter.Fill(this.demo_var1DataSet.UnitOfMeasurment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_var1DataSet.ProductName". При необходимости она может быть перемещена или удалена.
            this.productNameTableAdapter.Fill(this.demo_var1DataSet.ProductName);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_var1DataSet.Product". При необходимости она может быть перемещена или удалена.
            //this.productTableAdapter.Fill(this.demo_var1DataSet.Product);

            if (!_product.IsNew())
            {
                FillInfo();
                skuTextBox.ReadOnly = true;
            }
        }

        private void FillInfo()
        {
            skuTextBox.Text = _product.Sku;
            productNameIdComboBox.SelectedValue = _product.ProductNameId;
            unitOfMeasurmentIdComboBox.SelectedValue = _product.UnitOfMeasurmentId;
            priceNumericUpDown.Value = (decimal)_product.Price;
            maxDiscountNumericUpDown.Value = (decimal)_product.MaxDiscount;
            manufacturerIdComboBox.SelectedValue = _product.ManufacturerId;
            supplierIdComboBox.SelectedValue = _product.SupplierId;
            categoryIdComboBox.SelectedValue = _product.CategoryId;
            realDiscountNumericUpDown.Value = (decimal) _product.RealDiscount;
            stockNumericUpDown.Value = _product.Stock;
            descriptionTextBox.Text = _product.Description;
            photoTextBox.Text = _product.Photo;
        }

        private void maxDiscountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (maxDiscountNumericUpDown.Value > realDiscountNumericUpDown.Value)
            {
                realDiscountNumericUpDown.Maximum = maxDiscountNumericUpDown.Value;
            }
            else if (realDiscountNumericUpDown.Value > maxDiscountNumericUpDown.Value)
            {
                realDiscountNumericUpDown.Maximum = maxDiscountNumericUpDown.Value;
                realDiscountNumericUpDown.Value = realDiscountNumericUpDown.Maximum;
            }
        }

        private void FillModelFields(Product product)
        {
            product.Sku = skuTextBox.Text;
            product.ProductNameId = (int)productNameIdComboBox.SelectedValue;
            product.UnitOfMeasurmentId = (int)unitOfMeasurmentIdComboBox.SelectedValue;
            product.Price = (double)priceNumericUpDown.Value;
            product.MaxDiscount = (double)maxDiscountNumericUpDown.Value;
            product.ManufacturerId = (int)manufacturerIdComboBox.SelectedValue;
            product.SupplierId = (int)supplierIdComboBox.SelectedValue;
            product.CategoryId = (int)categoryIdComboBox.SelectedValue;
            product.RealDiscount = (double)realDiscountNumericUpDown.Value;
            product.Stock = (int)stockNumericUpDown.Value;
            product.Description = descriptionTextBox.Text;
            product.Photo = photoTextBox.Text;
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Изображения(*.jpg; *.jpeg)|*.jpg; *.jpeg";

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                newFileName = SaveFileFromDialog(openFileDialog1.FileName);
                photoTextBox.Text = newFileName;
                addPhoto = true;
            }
        }

        private string SaveFileFromDialog(string sourcePath)
        {
            Image originalImage = Image.FromFile(sourcePath);

            Size newImageSizes = GetNewImageSizes(originalImage);
            Bitmap resizedImage = new Bitmap(originalImage, newImageSizes.Width, newImageSizes.Height);
            string imageName = Guid.NewGuid().ToString().Substring(0,8) + ".jpg";
            string savePath = GetImagePath(imageName);

            resizedImage.Save(savePath);

            originalImage.Dispose();
            resizedImage.Dispose();

            return imageName;
        }
        private Size GetNewImageSizes(Image originalImage)
        {
            int maxWidth = 300;
            int maxHeight = 200;

            float ratioX = (float)maxWidth / originalImage.Width;
            float ratioY = (float)maxHeight / originalImage.Height;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            return new Size(newWidth, newHeight);
        }

        private string GetImagePath(string fileName)
        {
            return Path.Combine(Application.StartupPath, "img", fileName);
        }

        private void DeleteFile(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    File.Delete(GetImagePath(fileName));
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка удаления файла", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (addPhoto == true && !string.IsNullOrEmpty(newFileName))
            {
                DeleteFile(newFileName);
            }
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (var context = new ContextDB())
                {
                    string oldPhoto = photoTextBox.Text;
                    if (_product.IsNew())
                    {
                        FillModelFields(_product);
                        context.Products.Add(_product);
                    }
                    else
                    {
                        // Редактирование - загружаем из БД и обновляем
                        var productFromDb = context.Products.Find(_product.IdProduct);
                        if (productFromDb != null)
                        {
                            FillModelFields(productFromDb);
                        }
                    }
                    context.SaveChanges();
                    if (addPhoto == true && !string.IsNullOrEmpty(oldPhoto))
                    {
                        DeleteFile(oldPhoto);
                    }
                    MessageBox.Show("Успех", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                if (addPhoto == true && !string.IsNullOrEmpty(newFileName))
                {
                    DeleteFile(newFileName);
                }
                MessageBox.Show(ex.Message, "Ошибка сохранения", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }

        

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(skuTextBox.Text) || string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                return false;
            }

            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult toBeDeleted = MessageBox.Show("Удалить?", "Удалить?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (toBeDeleted == DialogResult.No)
            {
                return;
            }

            try
            {
                using (var context = new ContextDB())
                {
                    Product product = context.Products.Find(_product.IdProduct);

                    if (product != null)
                    {
                        string oldPhoto = photoTextBox.Text;

                        context.Products.Remove(product);
                        context.SaveChanges();

                        if (addPhoto == true && !string.IsNullOrEmpty(newFileName))
                        {
                            DeleteFile(newFileName);
                        }
                        if (!string.IsNullOrEmpty(oldPhoto))
                        {
                            DeleteFile(oldPhoto);
                        }
                        MessageBox.Show("Успех", "Успех", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                }  
            }
            catch (Exception ex)
            {
                if (addPhoto == true && !string.IsNullOrEmpty(newFileName))
                {
                    DeleteFile(newFileName);
                }
                MessageBox.Show("Товар находится в заказе. Его нельзя удалить", "Ошибка сохранения", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}

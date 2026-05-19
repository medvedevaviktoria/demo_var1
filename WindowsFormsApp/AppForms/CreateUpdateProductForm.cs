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
        private string oldFileName;
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
                
                if (!string.IsNullOrEmpty(_product.Photo))
                {
                    oldFileName = _product.Photo;
                }

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

            DialogResult toAddPhoto = openFileDialog1.ShowDialog();

            if (toAddPhoto == DialogResult.OK)
            {
                newFileName = SaveImageFromOpenDialog(openFileDialog1.FileName);
                photoTextBox.Text = newFileName;
                addPhoto = true;
            }
        }
        private string SaveImageFromOpenDialog(string sourcePath)
        {
            Image originalImage = Image.FromFile(sourcePath);
            Size newImageSizes = GetNewSizes(originalImage);

            Bitmap resizedImage = new Bitmap(originalImage, newImageSizes.Width, newImageSizes.Height);
            string fileName = Guid.NewGuid().ToString().Substring(0,8) + ".jpg";
            string savePath = GetPath(fileName);

            resizedImage.Save(savePath);

            resizedImage.Dispose();
            originalImage.Dispose();

            return fileName;
        }
        private string GetPath(string fileName)
        {
            return Path.Combine(Application.StartupPath, "img", fileName);
        }
        private Size GetNewSizes(Image originalImage)
        {
            int maxWidth = 300;
            int maxHeight = 200;

            float ratioX = (float)maxWidth / originalImage.Width;
            float ratioY = (float)maxHeight/ originalImage.Height;
            float ratio = Math.Min(ratioY, ratioX);

            int newWidth = (int)(ratio * originalImage.Width);
            int newHeight = (int)(ratio * originalImage.Height);

            return new Size(newWidth, newHeight);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (addPhoto == true && !string.IsNullOrEmpty(newFileName))
            {
                DeleteFile(newFileName);
            }
            DialogResult = DialogResult.Cancel;
        }

        private void DeleteFile(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    File.Delete(GetPath(fileName));
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("ошибка удаления файла", "ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                MessageBox.Show("поля не могут быть пустыми", "ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new ContextDB())
                {

                    if (_product.IsNew())
                    {
                        FillModelFields(_product);
                        context.Products.Add(_product);
                    }
                    else
                    {
                        var productFromDB = context.Products.Find(_product.IdProduct);

                        if (productFromDB != null)
                        {
                            FillModelFields(productFromDB);
                            if (addPhoto == true && !string.IsNullOrEmpty(oldFileName))
                            {
                                DeleteFile(oldFileName);
                            }
                        }
                    }
                    context.SaveChanges();

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
                MessageBox.Show(ex.Message, "ошибка сохранения", 
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
            DialogResult toBeDeleted = MessageBox.Show("удалить?", "удалить?", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (toBeDeleted == DialogResult.No)
            {
                return;
            }
            try
            {
                using (var context = new ContextDB())
                {
                    var productToDelete = context.Products.Find(_product.IdProduct);

                    if (productToDelete != null)
                    {

                        context.Products.Remove(productToDelete);
                        context.SaveChanges();

                        if (!string.IsNullOrEmpty(oldFileName))
                        {
                            DeleteFile(oldFileName);
                        }
                        if (addPhoto == true && !string.IsNullOrEmpty(newFileName))
                        {
                            DeleteFile(newFileName);
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
                MessageBox.Show(ex.Message, "ошибка удаления", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}

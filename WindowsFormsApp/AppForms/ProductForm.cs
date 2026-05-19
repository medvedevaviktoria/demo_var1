using demo_var1.AppControls;
using demo_var1.AppModel;
using demo_var1.AppServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demo_var1.AppForms
{
    public partial class ProductForm : Form
    {
        private List<Product> _products;
        public ProductForm()
        {
            InitializeComponent();
            ContextManager.productForm = this;
            SetFullName();
            ShowAdvancedPanel();
            ShowButtonAddProduct();
        }

        private void ShowButtonAddProduct()
        {
            if (ContextManager.user == null)
            {
                buttonAddProduct.Visible = false;
            }
            else if (ContextManager.user.IsAdmin())
            {
                buttonAddProduct.Visible = true;
            }
            else
            {
                buttonAddProduct.Visible = false;
            }
        }

        private void ShowAdvancedPanel()
        {
            if (ContextManager.user == null)
            {
                AdvancedPanel.Visible = false;
            }
            else if (ContextManager.user.IsAdmin() || ContextManager.user.IsManager())
            {
                AdvancedPanel.Visible = true;
            }
            else
            {
                AdvancedPanel.Visible = false;
            }
        }

        private void SetFullName()
        {
            if (ContextManager.user == null)
            {
                labelFullName.Text = "Гость";
            }
            else
            {
                labelFullName.Text = ContextManager.user.FullName;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            ContextManager.user = null;
            ContextManager.loginForm.Show();
            this.Hide();
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillCategories();
            RefreshList();
        }

        private void FillCategories()
        {
            List<Category> categories = Program.contextDB.Categories.ToList();
            Category category = new Category();
            category.CategoryName = "Все категории";
            categories.Insert(0, category);
            categoryBindingSource.DataSource = categories;
        }

        public void RefreshList()
        {
            ClearList();
            SelectList();
            ShowList();
        }

        private void ShowList()
        {
            foreach (Product product in _products)
            {
                flowLayoutPanel1.Controls.Add(new ProductUserControl(product));
            }
        }

        private void SelectList()
        {
            using (var context = new ContextDB())
            {
                IQueryable<Product> tmpProducts = context.Products.Include(p => p.Category)           // ← обязательно
            .Include(p => p.ProductName)        // ← обязательно
            .Include(p => p.Manufacturer)       // ← обязательно
            .Include(p => p.Supplier)           // ← обязательно
            .Include(p => p.UnitOfMeasurment);  // ← обязательно;

                string search = textBoxSearch.Text.Trim();

                if (!String.IsNullOrEmpty(search))
                {
                    tmpProducts = tmpProducts.Where(obj => DbFunctions.Like(obj.Category.CategoryName, "%" + search + "%")
                                                        || DbFunctions.Like(obj.ProductName.ProductNameName, "%" + search + "%")
                                                        || DbFunctions.Like(obj.Description, "%" + search + "%")
                                                        || DbFunctions.Like(obj.Manufacturer.ManufacturerName, "%" + search + "%")
                                                        || DbFunctions.Like(obj.Supplier.SupplierName, "%" + search + "%")
                                                        || DbFunctions.Like(obj.UnitOfMeasurment.UnitOfMeasurmentName, "%" + search + "%"));
                }


                bool lessPrice = radioButtonLess.Checked;

                if (lessPrice == false)
                {
                    tmpProducts = tmpProducts.OrderBy(p => p.Price);
                }
                else
                {
                    tmpProducts = tmpProducts.OrderByDescending(p => p.Price);
                }

                Category selectedCategory = (Category)comboBoxCategory.SelectedItem;
                if (selectedCategory != null && selectedCategory.IdCategory > 0)
                {
                    tmpProducts = tmpProducts.Where(p => p.CategoryId == selectedCategory.IdCategory);
                }




                _products = tmpProducts.ToList();
            }
                
        }

        private void ClearList()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void radioButtonLess_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            CreateUpdateProductForm createUpdateProductForm = new CreateUpdateProductForm();
            DialogResult dialogResult = createUpdateProductForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                RefreshList();
            }
        }
    }
}

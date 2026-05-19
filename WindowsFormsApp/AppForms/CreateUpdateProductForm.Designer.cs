namespace demo_var1.AppForms
{
    partial class CreateUpdateProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label skuLabel;
            System.Windows.Forms.Label productNameIdLabel;
            System.Windows.Forms.Label unitOfMeasurmentIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label maxDiscountLabel;
            System.Windows.Forms.Label manufacturerIdLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label realDiscountLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label photoLabel;
            this.demo_var1DataSet = new demo_var1.demo_var1DataSet();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNameIdComboBox = new System.Windows.Forms.ComboBox();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitOfMeasurmentIdComboBox = new System.Windows.Forms.ComboBox();
            this.unitOfMeasurmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxDiscountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.manufacturerIdComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realDiscountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.productTableAdapter = new demo_var1.demo_var1DataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new demo_var1.demo_var1DataSetTableAdapters.TableAdapterManager();
            this.manufacturerTableAdapter = new demo_var1.demo_var1DataSetTableAdapters.ManufacturerTableAdapter();
            this.productNameTableAdapter = new demo_var1.demo_var1DataSetTableAdapters.ProductNameTableAdapter();
            this.supplierTableAdapter = new demo_var1.demo_var1DataSetTableAdapters.SupplierTableAdapter();
            this.unitOfMeasurmentTableAdapter = new demo_var1.demo_var1DataSetTableAdapters.UnitOfMeasurmentTableAdapter();
            this.categoryTableAdapter = new demo_var1.demo_var1DataSetTableAdapters.CategoryTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            skuLabel = new System.Windows.Forms.Label();
            productNameIdLabel = new System.Windows.Forms.Label();
            unitOfMeasurmentIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            maxDiscountLabel = new System.Windows.Forms.Label();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            realDiscountLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.demo_var1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDiscountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realDiscountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // skuLabel
            // 
            skuLabel.AutoSize = true;
            skuLabel.Location = new System.Drawing.Point(193, 82);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new System.Drawing.Size(54, 15);
            skuLabel.TabIndex = 0;
            skuLabel.Text = "Артикул:";
            // 
            // productNameIdLabel
            // 
            productNameIdLabel.AutoSize = true;
            productNameIdLabel.Location = new System.Drawing.Point(193, 111);
            productNameIdLabel.Name = "productNameIdLabel";
            productNameIdLabel.Size = new System.Drawing.Size(141, 15);
            productNameIdLabel.TabIndex = 2;
            productNameIdLabel.Text = "Наименование продукта:";
            // 
            // unitOfMeasurmentIdLabel
            // 
            unitOfMeasurmentIdLabel.AutoSize = true;
            unitOfMeasurmentIdLabel.Location = new System.Drawing.Point(193, 140);
            unitOfMeasurmentIdLabel.Name = "unitOfMeasurmentIdLabel";
            unitOfMeasurmentIdLabel.Size = new System.Drawing.Size(117, 15);
            unitOfMeasurmentIdLabel.TabIndex = 4;
            unitOfMeasurmentIdLabel.Text = "Единица измерения:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(193, 166);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(37, 15);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Цена:";
            // 
            // maxDiscountLabel
            // 
            maxDiscountLabel.AutoSize = true;
            maxDiscountLabel.Location = new System.Drawing.Point(193, 195);
            maxDiscountLabel.Name = "maxDiscountLabel";
            maxDiscountLabel.Size = new System.Drawing.Size(172, 15);
            maxDiscountLabel.TabIndex = 8;
            maxDiscountLabel.Text = "Максимальный размер скидки:";
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Location = new System.Drawing.Point(193, 227);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(95, 15);
            manufacturerIdLabel.TabIndex = 10;
            manufacturerIdLabel.Text = "Производитель:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(193, 256);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(71, 15);
            supplierIdLabel.TabIndex = 12;
            supplierIdLabel.Text = "Поставщик:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(193, 285);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(104, 15);
            categoryIdLabel.TabIndex = 14;
            categoryIdLabel.Text = "Категория товара:";
            // 
            // realDiscountLabel
            // 
            realDiscountLabel.AutoSize = true;
            realDiscountLabel.Location = new System.Drawing.Point(193, 311);
            realDiscountLabel.Name = "realDiscountLabel";
            realDiscountLabel.Size = new System.Drawing.Size(124, 15);
            realDiscountLabel.TabIndex = 16;
            realDiscountLabel.Text = "Действующая скидка:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(193, 340);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(129, 15);
            stockLabel.TabIndex = 18;
            stockLabel.Text = "Количество на складе:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(193, 372);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 15);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Описание:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(193, 401);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(81, 15);
            photoLabel.TabIndex = 22;
            photoLabel.Text = "Изображение:";
            // 
            // demo_var1DataSet
            // 
            this.demo_var1DataSet.DataSetName = "demo_var1DataSet";
            this.demo_var1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.buttonBack.Location = new System.Drawing.Point(646, 30);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"Пиши-стирай\" - Список товаров";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.splitContainer1.Panel1.Controls.Add(this.buttonBack);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddPhoto);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(skuLabel);
            this.splitContainer1.Panel2.Controls.Add(this.skuTextBox);
            this.splitContainer1.Panel2.Controls.Add(productNameIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.productNameIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(unitOfMeasurmentIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.unitOfMeasurmentIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(priceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.priceNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(maxDiscountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.maxDiscountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(manufacturerIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.manufacturerIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(supplierIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.supplierIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(categoryIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.categoryIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(realDiscountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.realDiscountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(stockLabel);
            this.splitContainer1.Panel2.Controls.Add(this.stockNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(photoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(748, 724);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.buttonAddPhoto.Location = new System.Drawing.Point(529, 397);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(67, 23);
            this.buttonAddPhoto.TabIndex = 25;
            this.buttonAddPhoto.Text = "Файл";
            this.buttonAddPhoto.UseVisualStyleBackColor = false;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.buttonDelete.Location = new System.Drawing.Point(328, 506);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 23);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(196, 444);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(400, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // skuTextBox
            // 
            this.skuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Sku", true));
            this.skuTextBox.Location = new System.Drawing.Point(401, 79);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(195, 23);
            this.skuTextBox.TabIndex = 1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.demo_var1DataSet;
            // 
            // productNameIdComboBox
            // 
            this.productNameIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductNameId", true));
            this.productNameIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductNameId", true));
            this.productNameIdComboBox.DataSource = this.productNameBindingSource;
            this.productNameIdComboBox.DisplayMember = "ProductNameName";
            this.productNameIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameIdComboBox.FormattingEnabled = true;
            this.productNameIdComboBox.Location = new System.Drawing.Point(401, 108);
            this.productNameIdComboBox.Name = "productNameIdComboBox";
            this.productNameIdComboBox.Size = new System.Drawing.Size(195, 23);
            this.productNameIdComboBox.TabIndex = 3;
            this.productNameIdComboBox.ValueMember = "IdProductName";
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "ProductName";
            this.productNameBindingSource.DataSource = this.demo_var1DataSet;
            // 
            // unitOfMeasurmentIdComboBox
            // 
            this.unitOfMeasurmentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "UnitOfMeasurmentId", true));
            this.unitOfMeasurmentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "UnitOfMeasurmentId", true));
            this.unitOfMeasurmentIdComboBox.DataSource = this.unitOfMeasurmentBindingSource;
            this.unitOfMeasurmentIdComboBox.DisplayMember = "UnitOfMeasurmentName";
            this.unitOfMeasurmentIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitOfMeasurmentIdComboBox.FormattingEnabled = true;
            this.unitOfMeasurmentIdComboBox.Location = new System.Drawing.Point(401, 137);
            this.unitOfMeasurmentIdComboBox.Name = "unitOfMeasurmentIdComboBox";
            this.unitOfMeasurmentIdComboBox.Size = new System.Drawing.Size(195, 23);
            this.unitOfMeasurmentIdComboBox.TabIndex = 5;
            this.unitOfMeasurmentIdComboBox.ValueMember = "IdUnitOfMeasurment";
            // 
            // unitOfMeasurmentBindingSource
            // 
            this.unitOfMeasurmentBindingSource.DataMember = "UnitOfMeasurment";
            this.unitOfMeasurmentBindingSource.DataSource = this.demo_var1DataSet;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Price", true));
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(401, 166);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(195, 23);
            this.priceNumericUpDown.TabIndex = 7;
            // 
            // maxDiscountNumericUpDown
            // 
            this.maxDiscountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "MaxDiscount", true));
            this.maxDiscountNumericUpDown.Location = new System.Drawing.Point(401, 195);
            this.maxDiscountNumericUpDown.Name = "maxDiscountNumericUpDown";
            this.maxDiscountNumericUpDown.Size = new System.Drawing.Size(195, 23);
            this.maxDiscountNumericUpDown.TabIndex = 9;
            this.maxDiscountNumericUpDown.ValueChanged += new System.EventHandler(this.maxDiscountNumericUpDown_ValueChanged);
            // 
            // manufacturerIdComboBox
            // 
            this.manufacturerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ManufacturerId", true));
            this.manufacturerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerId", true));
            this.manufacturerIdComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIdComboBox.DisplayMember = "ManufacturerName";
            this.manufacturerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerIdComboBox.FormattingEnabled = true;
            this.manufacturerIdComboBox.Location = new System.Drawing.Point(401, 224);
            this.manufacturerIdComboBox.Name = "manufacturerIdComboBox";
            this.manufacturerIdComboBox.Size = new System.Drawing.Size(195, 23);
            this.manufacturerIdComboBox.TabIndex = 11;
            this.manufacturerIdComboBox.ValueMember = "IdManufacturer";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.demo_var1DataSet;
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.supplierBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupplierName";
            this.supplierIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(401, 253);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(195, 23);
            this.supplierIdComboBox.TabIndex = 13;
            this.supplierIdComboBox.ValueMember = "IdSupplier";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.demo_var1DataSet;
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "CategoryId", true));
            this.categoryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryId", true));
            this.categoryIdComboBox.DataSource = this.categoryBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(401, 282);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(195, 23);
            this.categoryIdComboBox.TabIndex = 15;
            this.categoryIdComboBox.ValueMember = "IdCategory";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.demo_var1DataSet;
            // 
            // realDiscountNumericUpDown
            // 
            this.realDiscountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "RealDiscount", true));
            this.realDiscountNumericUpDown.Location = new System.Drawing.Point(401, 311);
            this.realDiscountNumericUpDown.Name = "realDiscountNumericUpDown";
            this.realDiscountNumericUpDown.Size = new System.Drawing.Size(195, 23);
            this.realDiscountNumericUpDown.TabIndex = 17;
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(401, 340);
            this.stockNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(195, 23);
            this.stockNumericUpDown.TabIndex = 19;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(401, 369);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(195, 23);
            this.descriptionTextBox.TabIndex = 21;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(401, 398);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(122, 23);
            this.photoTextBox.TabIndex = 23;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderStatusTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PosTableAdapter = null;
            this.tableAdapterManager.ProductNameTableAdapter = this.productNameTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UnitOfMeasurmentTableAdapter = this.unitOfMeasurmentTableAdapter;
            this.tableAdapterManager.UpdateOrder = demo_var1.demo_var1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // productNameTableAdapter
            // 
            this.productNameTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // unitOfMeasurmentTableAdapter
            // 
            this.unitOfMeasurmentTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 724);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateUpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUpdateProduct";
            this.Load += new System.EventHandler(this.CreateUpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demo_var1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfMeasurmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDiscountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realDiscountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private demo_var1DataSet demo_var1DataSet;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private demo_var1DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private demo_var1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.ComboBox productNameIdComboBox;
        private System.Windows.Forms.ComboBox unitOfMeasurmentIdComboBox;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxDiscountNumericUpDown;
        private System.Windows.Forms.ComboBox manufacturerIdComboBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.NumericUpDown realDiscountNumericUpDown;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private demo_var1DataSetTableAdapters.ProductNameTableAdapter productNameTableAdapter;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private demo_var1DataSetTableAdapters.UnitOfMeasurmentTableAdapter unitOfMeasurmentTableAdapter;
        private System.Windows.Forms.BindingSource unitOfMeasurmentBindingSource;
        private demo_var1DataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private demo_var1DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private demo_var1DataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
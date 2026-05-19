namespace demo_var1.AppControls
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label realDiscountLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDiscount = new System.Windows.Forms.Panel();
            this.realDiscountLabel1 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelOldPrice = new System.Windows.Forms.Label();
            this.stockLabel1 = new System.Windows.Forms.Label();
            this.unitOfMeasurmentIdLabel1 = new System.Windows.Forms.Label();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.supplierIdLabel1 = new System.Windows.Forms.Label();
            this.manufacturerIdLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.categoryAndNameLabel = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.demo_var1DataSet = new demo_var1.demo_var1DataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new demo_var1.demo_var1DataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new demo_var1.demo_var1DataSetTableAdapters.TableAdapterManager();
            realDiscountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDiscount.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo_var1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // realDiscountLabel
            // 
            realDiscountLabel.AutoSize = true;
            realDiscountLabel.Location = new System.Drawing.Point(40, 63);
            realDiscountLabel.Name = "realDiscountLabel";
            realDiscountLabel.Size = new System.Drawing.Size(124, 15);
            realDiscountLabel.TabIndex = 0;
            realDiscountLabel.Text = "Действующая скидка:";
            realDiscountLabel.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDiscount);
            this.panel1.Controls.Add(this.panelInfo);
            this.panel1.Controls.Add(this.pictureBoxPhoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 221);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panelDiscount
            // 
            this.panelDiscount.Controls.Add(realDiscountLabel);
            this.panelDiscount.Controls.Add(this.realDiscountLabel1);
            this.panelDiscount.Location = new System.Drawing.Point(542, 3);
            this.panelDiscount.Name = "panelDiscount";
            this.panelDiscount.Size = new System.Drawing.Size(193, 212);
            this.panelDiscount.TabIndex = 2;
            this.panelDiscount.Click += new System.EventHandler(this.panel1_Click);
            // 
            // realDiscountLabel1
            // 
            this.realDiscountLabel1.AutoSize = true;
            this.realDiscountLabel1.Location = new System.Drawing.Point(81, 107);
            this.realDiscountLabel1.Name = "realDiscountLabel1";
            this.realDiscountLabel1.Size = new System.Drawing.Size(36, 15);
            this.realDiscountLabel1.TabIndex = 1;
            this.realDiscountLabel1.Text = "label1";
            this.realDiscountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.realDiscountLabel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelOldPrice);
            this.panelInfo.Controls.Add(this.stockLabel1);
            this.panelInfo.Controls.Add(this.unitOfMeasurmentIdLabel1);
            this.panelInfo.Controls.Add(this.priceLabel1);
            this.panelInfo.Controls.Add(this.supplierIdLabel1);
            this.panelInfo.Controls.Add(this.manufacturerIdLabel1);
            this.panelInfo.Controls.Add(this.descriptionLabel1);
            this.panelInfo.Controls.Add(this.categoryAndNameLabel);
            this.panelInfo.Location = new System.Drawing.Point(176, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(360, 212);
            this.panelInfo.TabIndex = 1;
            this.panelInfo.Click += new System.EventHandler(this.panel1_Click);
            // 
            // labelOldPrice
            // 
            this.labelOldPrice.AutoSize = true;
            this.labelOldPrice.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOldPrice.ForeColor = System.Drawing.Color.Red;
            this.labelOldPrice.Location = new System.Drawing.Point(116, 130);
            this.labelOldPrice.Name = "labelOldPrice";
            this.labelOldPrice.Size = new System.Drawing.Size(36, 15);
            this.labelOldPrice.TabIndex = 9;
            this.labelOldPrice.Text = "label1";
            this.labelOldPrice.Click += new System.EventHandler(this.panel1_Click);
            // 
            // stockLabel1
            // 
            this.stockLabel1.AutoSize = true;
            this.stockLabel1.Location = new System.Drawing.Point(15, 176);
            this.stockLabel1.Name = "stockLabel1";
            this.stockLabel1.Size = new System.Drawing.Size(36, 15);
            this.stockLabel1.TabIndex = 8;
            this.stockLabel1.Text = "label1";
            this.stockLabel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // unitOfMeasurmentIdLabel1
            // 
            this.unitOfMeasurmentIdLabel1.AutoSize = true;
            this.unitOfMeasurmentIdLabel1.Location = new System.Drawing.Point(15, 153);
            this.unitOfMeasurmentIdLabel1.Name = "unitOfMeasurmentIdLabel1";
            this.unitOfMeasurmentIdLabel1.Size = new System.Drawing.Size(36, 15);
            this.unitOfMeasurmentIdLabel1.TabIndex = 7;
            this.unitOfMeasurmentIdLabel1.Text = "label1";
            this.unitOfMeasurmentIdLabel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // priceLabel1
            // 
            this.priceLabel1.AutoSize = true;
            this.priceLabel1.Location = new System.Drawing.Point(15, 130);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(36, 15);
            this.priceLabel1.TabIndex = 6;
            this.priceLabel1.Text = "label1";
            this.priceLabel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // supplierIdLabel1
            // 
            this.supplierIdLabel1.AutoSize = true;
            this.supplierIdLabel1.Location = new System.Drawing.Point(15, 107);
            this.supplierIdLabel1.Name = "supplierIdLabel1";
            this.supplierIdLabel1.Size = new System.Drawing.Size(36, 15);
            this.supplierIdLabel1.TabIndex = 5;
            this.supplierIdLabel1.Text = "label1";
            this.supplierIdLabel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // manufacturerIdLabel1
            // 
            this.manufacturerIdLabel1.AutoSize = true;
            this.manufacturerIdLabel1.Location = new System.Drawing.Point(15, 84);
            this.manufacturerIdLabel1.Name = "manufacturerIdLabel1";
            this.manufacturerIdLabel1.Size = new System.Drawing.Size(36, 15);
            this.manufacturerIdLabel1.TabIndex = 3;
            this.manufacturerIdLabel1.Text = "label1";
            this.manufacturerIdLabel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.Location = new System.Drawing.Point(15, 32);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(335, 46);
            this.descriptionLabel1.TabIndex = 2;
            this.descriptionLabel1.Text = "label1";
            this.descriptionLabel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // categoryAndNameLabel
            // 
            this.categoryAndNameLabel.AutoSize = true;
            this.categoryAndNameLabel.Location = new System.Drawing.Point(15, 10);
            this.categoryAndNameLabel.Name = "categoryAndNameLabel";
            this.categoryAndNameLabel.Size = new System.Drawing.Size(36, 15);
            this.categoryAndNameLabel.TabIndex = 1;
            this.categoryAndNameLabel.Text = "label1";
            this.categoryAndNameLabel.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(167, 212);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.panel1_Click);
            // 
            // demo_var1DataSet
            // 
            this.demo_var1DataSet.DataSetName = "demo_var1DataSet";
            this.demo_var1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.demo_var1DataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderStatusTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PosTableAdapter = null;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UnitOfMeasurmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = demo_var1.demo_var1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(739, 221);
            this.panel1.ResumeLayout(false);
            this.panelDiscount.ResumeLayout(false);
            this.panelDiscount.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demo_var1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Panel panelDiscount;
        private System.Windows.Forms.Panel panelInfo;
        private demo_var1DataSet demo_var1DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private demo_var1DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private demo_var1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label stockLabel1;
        private System.Windows.Forms.Label unitOfMeasurmentIdLabel1;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Label supplierIdLabel1;
        private System.Windows.Forms.Label manufacturerIdLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label categoryAndNameLabel;
        private System.Windows.Forms.Label realDiscountLabel1;
        private System.Windows.Forms.Label labelOldPrice;
    }
}

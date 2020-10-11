namespace SMALL_LIBRARY_MANAGEMENT_SYSTEM
{
    partial class Update_Books
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
            System.Windows.Forms.Label book_IdLabel;
            System.Windows.Forms.Label book_NameLabel;
            System.Windows.Forms.Label book_AuthorLabel;
            System.Windows.Forms.Label purchase_DateLabel;
            System.Windows.Forms.Label book_PriceLabel;
            System.Windows.Forms.Label book__QuantityLabel;
            System.Windows.Forms.Label book_PublicationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Books));
            this.libraryDataSet = new SMALL_LIBRARY_MANAGEMENT_SYSTEM.libraryDataSet();
            this.addBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addBooksTableAdapter = new SMALL_LIBRARY_MANAGEMENT_SYSTEM.libraryDataSetTableAdapters.AddBooksTableAdapter();
            this.tableAdapterManager = new SMALL_LIBRARY_MANAGEMENT_SYSTEM.libraryDataSetTableAdapters.TableAdapterManager();
            this.addBooksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addBooksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.book_IdTextBox = new System.Windows.Forms.TextBox();
            this.book_NameTextBox = new System.Windows.Forms.TextBox();
            this.book_AuthorTextBox = new System.Windows.Forms.TextBox();
            this.purchase_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.book_PriceTextBox = new System.Windows.Forms.TextBox();
            this.book__QuantityTextBox = new System.Windows.Forms.TextBox();
            this.book_PublicationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            book_IdLabel = new System.Windows.Forms.Label();
            book_NameLabel = new System.Windows.Forms.Label();
            book_AuthorLabel = new System.Windows.Forms.Label();
            purchase_DateLabel = new System.Windows.Forms.Label();
            book_PriceLabel = new System.Windows.Forms.Label();
            book__QuantityLabel = new System.Windows.Forms.Label();
            book_PublicationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBooksBindingNavigator)).BeginInit();
            this.addBooksBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // book_IdLabel
            // 
            book_IdLabel.AutoSize = true;
            book_IdLabel.Location = new System.Drawing.Point(6, 20);
            book_IdLabel.Name = "book_IdLabel";
            book_IdLabel.Size = new System.Drawing.Size(47, 13);
            book_IdLabel.TabIndex = 1;
            book_IdLabel.Text = "Book Id:";
            // 
            // book_NameLabel
            // 
            book_NameLabel.AutoSize = true;
            book_NameLabel.Location = new System.Drawing.Point(6, 46);
            book_NameLabel.Name = "book_NameLabel";
            book_NameLabel.Size = new System.Drawing.Size(66, 13);
            book_NameLabel.TabIndex = 3;
            book_NameLabel.Text = "Book Name:";
            // 
            // book_AuthorLabel
            // 
            book_AuthorLabel.AutoSize = true;
            book_AuthorLabel.Location = new System.Drawing.Point(6, 72);
            book_AuthorLabel.Name = "book_AuthorLabel";
            book_AuthorLabel.Size = new System.Drawing.Size(69, 13);
            book_AuthorLabel.TabIndex = 5;
            book_AuthorLabel.Text = "Book Author:";
            // 
            // purchase_DateLabel
            // 
            purchase_DateLabel.AutoSize = true;
            purchase_DateLabel.Location = new System.Drawing.Point(6, 99);
            purchase_DateLabel.Name = "purchase_DateLabel";
            purchase_DateLabel.Size = new System.Drawing.Size(81, 13);
            purchase_DateLabel.TabIndex = 7;
            purchase_DateLabel.Text = "Purchase Date:";
            // 
            // book_PriceLabel
            // 
            book_PriceLabel.AutoSize = true;
            book_PriceLabel.Location = new System.Drawing.Point(6, 124);
            book_PriceLabel.Name = "book_PriceLabel";
            book_PriceLabel.Size = new System.Drawing.Size(62, 13);
            book_PriceLabel.TabIndex = 9;
            book_PriceLabel.Text = "Book Price:";
            // 
            // book__QuantityLabel
            // 
            book__QuantityLabel.AutoSize = true;
            book__QuantityLabel.Location = new System.Drawing.Point(6, 150);
            book__QuantityLabel.Name = "book__QuantityLabel";
            book__QuantityLabel.Size = new System.Drawing.Size(80, 13);
            book__QuantityLabel.TabIndex = 11;
            book__QuantityLabel.Text = "Book  Quantity:";
            // 
            // book_PublicationLabel
            // 
            book_PublicationLabel.AutoSize = true;
            book_PublicationLabel.Location = new System.Drawing.Point(6, 176);
            book_PublicationLabel.Name = "book_PublicationLabel";
            book_PublicationLabel.Size = new System.Drawing.Size(90, 13);
            book_PublicationLabel.TabIndex = 13;
            book_PublicationLabel.Text = "Book Publication:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addBooksBindingSource
            // 
            this.addBooksBindingSource.DataMember = "AddBooks";
            this.addBooksBindingSource.DataSource = this.libraryDataSet;
            // 
            // addBooksTableAdapter
            // 
            this.addBooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddBooksTableAdapter = this.addBooksTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SMALL_LIBRARY_MANAGEMENT_SYSTEM.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addBooksBindingNavigator
            // 
            this.addBooksBindingNavigator.AddNewItem = null;
            this.addBooksBindingNavigator.BindingSource = this.addBooksBindingSource;
            this.addBooksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.addBooksBindingNavigator.DeleteItem = null;
            this.addBooksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.addBooksBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.addBooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.addBooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.addBooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.addBooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.addBooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.addBooksBindingNavigator.Name = "addBooksBindingNavigator";
            this.addBooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.addBooksBindingNavigator.Size = new System.Drawing.Size(339, 25);
            this.addBooksBindingNavigator.TabIndex = 0;
            this.addBooksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addBooksBindingNavigatorSaveItem
            // 
            this.addBooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addBooksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("addBooksBindingNavigatorSaveItem.Image")));
            this.addBooksBindingNavigatorSaveItem.Name = "addBooksBindingNavigatorSaveItem";
            this.addBooksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.addBooksBindingNavigatorSaveItem.Text = "Save Data";
            this.addBooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.addBooksBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Change Update";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Exit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // book_IdTextBox
            // 
            this.book_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addBooksBindingSource, "Book Id", true));
            this.book_IdTextBox.Location = new System.Drawing.Point(102, 17);
            this.book_IdTextBox.Name = "book_IdTextBox";
            this.book_IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.book_IdTextBox.TabIndex = 2;
            // 
            // book_NameTextBox
            // 
            this.book_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addBooksBindingSource, "Book Name", true));
            this.book_NameTextBox.Location = new System.Drawing.Point(102, 43);
            this.book_NameTextBox.Name = "book_NameTextBox";
            this.book_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.book_NameTextBox.TabIndex = 4;
            // 
            // book_AuthorTextBox
            // 
            this.book_AuthorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addBooksBindingSource, "Book Author", true));
            this.book_AuthorTextBox.Location = new System.Drawing.Point(102, 69);
            this.book_AuthorTextBox.Name = "book_AuthorTextBox";
            this.book_AuthorTextBox.Size = new System.Drawing.Size(200, 20);
            this.book_AuthorTextBox.TabIndex = 6;
            // 
            // purchase_DateDateTimePicker
            // 
            this.purchase_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.addBooksBindingSource, "Purchase Date", true));
            this.purchase_DateDateTimePicker.Location = new System.Drawing.Point(102, 95);
            this.purchase_DateDateTimePicker.Name = "purchase_DateDateTimePicker";
            this.purchase_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.purchase_DateDateTimePicker.TabIndex = 8;
            // 
            // book_PriceTextBox
            // 
            this.book_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addBooksBindingSource, "Book Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.book_PriceTextBox.Location = new System.Drawing.Point(102, 121);
            this.book_PriceTextBox.Name = "book_PriceTextBox";
            this.book_PriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.book_PriceTextBox.TabIndex = 10;
            // 
            // book__QuantityTextBox
            // 
            this.book__QuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addBooksBindingSource, "Book  Quantity", true));
            this.book__QuantityTextBox.Location = new System.Drawing.Point(102, 147);
            this.book__QuantityTextBox.Name = "book__QuantityTextBox";
            this.book__QuantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.book__QuantityTextBox.TabIndex = 12;
            // 
            // book_PublicationTextBox
            // 
            this.book_PublicationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addBooksBindingSource, "Book Publication", true));
            this.book_PublicationTextBox.Location = new System.Drawing.Point(102, 173);
            this.book_PublicationTextBox.Name = "book_PublicationTextBox";
            this.book_PublicationTextBox.Size = new System.Drawing.Size(200, 20);
            this.book_PublicationTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(24, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(book_IdLabel);
            this.groupBox1.Controls.Add(this.book_IdTextBox);
            this.groupBox1.Controls.Add(book_NameLabel);
            this.groupBox1.Controls.Add(this.book_NameTextBox);
            this.groupBox1.Controls.Add(book_AuthorLabel);
            this.groupBox1.Controls.Add(this.book_AuthorTextBox);
            this.groupBox1.Controls.Add(purchase_DateLabel);
            this.groupBox1.Controls.Add(this.purchase_DateDateTimePicker);
            this.groupBox1.Controls.Add(book_PriceLabel);
            this.groupBox1.Controls.Add(this.book_PriceTextBox);
            this.groupBox1.Controls.Add(book__QuantityLabel);
            this.groupBox1.Controls.Add(this.book__QuantityTextBox);
            this.groupBox1.Controls.Add(book_PublicationLabel);
            this.groupBox1.Controls.Add(this.book_PublicationTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 208);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Update_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(339, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBooksBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Books";
            this.Load += new System.EventHandler(this.Update_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBooksBindingNavigator)).EndInit();
            this.addBooksBindingNavigator.ResumeLayout(false);
            this.addBooksBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource addBooksBindingSource;
        private libraryDataSetTableAdapters.AddBooksTableAdapter addBooksTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator addBooksBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton addBooksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox book_IdTextBox;
        private System.Windows.Forms.TextBox book_NameTextBox;
        private System.Windows.Forms.TextBox book_AuthorTextBox;
        private System.Windows.Forms.DateTimePicker purchase_DateDateTimePicker;
        private System.Windows.Forms.TextBox book_PriceTextBox;
        private System.Windows.Forms.TextBox book__QuantityTextBox;
        private System.Windows.Forms.TextBox book_PublicationTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
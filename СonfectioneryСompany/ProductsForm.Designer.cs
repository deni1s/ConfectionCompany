namespace СonfectioneryСompany
{
    partial class ProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updateButton = new System.Windows.Forms.Button();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.confectioneryCompanyDataSet = new СonfectioneryСompany.ConfectioneryCompanyDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new СonfectioneryСompany.ConfectioneryCompanyDataSetTableAdapters.ProductsTableAdapter();
            this.названиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateButton.Location = new System.Drawing.Point(246, 388);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(148, 35);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AutoGenerateColumns = false;
            this.productsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеПродуктаDataGridViewTextBoxColumn,
            this.информацияDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.productsDataGrid.DataSource = this.productsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGrid.Location = new System.Drawing.Point(27, 20);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.Size = new System.Drawing.Size(583, 343);
            this.productsDataGrid.TabIndex = 4;
            // 
            // confectioneryCompanyDataSet
            // 
            this.confectioneryCompanyDataSet.DataSetName = "ConfectioneryCompanyDataSet";
            this.confectioneryCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.confectioneryCompanyDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // названиеПродуктаDataGridViewTextBoxColumn
            // 
            this.названиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.HeaderText = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.Name = "названиеПродуктаDataGridViewTextBoxColumn";
            // 
            // информацияDataGridViewTextBoxColumn
            // 
            this.информацияDataGridViewTextBoxColumn.DataPropertyName = "Информация";
            this.информацияDataGridViewTextBoxColumn.HeaderText = "Информация";
            this.информацияDataGridViewTextBoxColumn.Name = "информацияDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 442);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.productsDataGrid);
            this.Name = "ProductsForm";
            this.Text = "Продукты";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView productsDataGrid;
        private ConfectioneryCompanyDataSet confectioneryCompanyDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ConfectioneryCompanyDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn информацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}
namespace СonfectioneryСompany
{
    partial class OrdersForm
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
            this.ordersDataGrid = new System.Windows.Forms.DataGridView();
            this.confectioneryCompanyDataSet = new СonfectioneryСompany.ConfectioneryCompanyDataSet();
            this.selectOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectOrdersTableAdapter = new СonfectioneryСompany.ConfectioneryCompanyDataSetTableAdapters.SelectOrdersTableAdapter();
            this.названиеИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateButton.Location = new System.Drawing.Point(244, 380);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(148, 35);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ordersDataGrid
            // 
            this.ordersDataGrid.AutoGenerateColumns = false;
            this.ordersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеИзделияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn});
            this.ordersDataGrid.DataSource = this.selectOrdersBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.ordersDataGrid.Location = new System.Drawing.Point(25, 12);
            this.ordersDataGrid.Name = "ordersDataGrid";
            this.ordersDataGrid.Size = new System.Drawing.Size(583, 343);
            this.ordersDataGrid.TabIndex = 2;
            // 
            // confectioneryCompanyDataSet
            // 
            this.confectioneryCompanyDataSet.DataSetName = "ConfectioneryCompanyDataSet";
            this.confectioneryCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectOrdersBindingSource
            // 
            this.selectOrdersBindingSource.DataMember = "SelectOrders";
            this.selectOrdersBindingSource.DataSource = this.confectioneryCompanyDataSet;
            // 
            // selectOrdersTableAdapter
            // 
            this.selectOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // названиеИзделияDataGridViewTextBoxColumn
            // 
            this.названиеИзделияDataGridViewTextBoxColumn.DataPropertyName = "Название изделия";
            this.названиеИзделияDataGridViewTextBoxColumn.HeaderText = "Название изделия";
            this.названиеИзделияDataGridViewTextBoxColumn.Name = "названиеИзделияDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Дата заказа";
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 428);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.ordersDataGrid);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView ordersDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private ConfectioneryCompanyDataSet confectioneryCompanyDataSet;
        private System.Windows.Forms.BindingSource selectOrdersBindingSource;
        private ConfectioneryCompanyDataSetTableAdapters.SelectOrdersTableAdapter selectOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}
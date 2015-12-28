namespace СonfectioneryСompany
{
    partial class CompositionForm
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
            this.compositionDataGrid = new System.Windows.Forms.DataGridView();
            this.confectioneryCompanyDataSet = new СonfectioneryСompany.ConfectioneryCompanyDataSet();
            this.selectConfectionProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectConfectionProductsTableAdapter = new СonfectioneryСompany.ConfectioneryCompanyDataSetTableAdapters.SelectConfectionProductsTableAdapter();
            this.названиеИзделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокХраненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.compositionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectConfectionProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateButton.Location = new System.Drawing.Point(244, 380);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(148, 35);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // compositionDataGrid
            // 
            this.compositionDataGrid.AutoGenerateColumns = false;
            this.compositionDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.compositionDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.compositionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compositionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеИзделияDataGridViewTextBoxColumn,
            this.названиеПродуктаDataGridViewTextBoxColumn,
            this.срокХраненияDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.compositionDataGrid.DataSource = this.selectConfectionProductsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.compositionDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.compositionDataGrid.Location = new System.Drawing.Point(27, 27);
            this.compositionDataGrid.Name = "compositionDataGrid";
            this.compositionDataGrid.Size = new System.Drawing.Size(583, 344);
            this.compositionDataGrid.TabIndex = 4;
            this.compositionDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compositionDataGrid_CellContentClick);
            // 
            // confectioneryCompanyDataSet
            // 
            this.confectioneryCompanyDataSet.DataSetName = "ConfectioneryCompanyDataSet";
            this.confectioneryCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectConfectionProductsBindingSource
            // 
            this.selectConfectionProductsBindingSource.DataMember = "SelectConfectionProducts";
            this.selectConfectionProductsBindingSource.DataSource = this.confectioneryCompanyDataSet;
            // 
            // selectConfectionProductsTableAdapter
            // 
            this.selectConfectionProductsTableAdapter.ClearBeforeFill = true;
            // 
            // названиеИзделияDataGridViewTextBoxColumn
            // 
            this.названиеИзделияDataGridViewTextBoxColumn.DataPropertyName = "Название изделия";
            this.названиеИзделияDataGridViewTextBoxColumn.HeaderText = "Название изделия";
            this.названиеИзделияDataGridViewTextBoxColumn.Name = "названиеИзделияDataGridViewTextBoxColumn";
            // 
            // названиеПродуктаDataGridViewTextBoxColumn
            // 
            this.названиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.HeaderText = "Название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.Name = "названиеПродуктаDataGridViewTextBoxColumn";
            // 
            // срокХраненияDataGridViewTextBoxColumn
            // 
            this.срокХраненияDataGridViewTextBoxColumn.DataPropertyName = "Срок хранения";
            this.срокХраненияDataGridViewTextBoxColumn.HeaderText = "Срок хранения";
            this.срокХраненияDataGridViewTextBoxColumn.Name = "срокХраненияDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // CompositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 436);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.compositionDataGrid);
            this.Name = "CompositionForm";
            this.Text = "Состав изделий";
            this.Load += new System.EventHandler(this.CompositionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compositionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectConfectionProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView compositionDataGrid;
        private ConfectioneryCompanyDataSet confectioneryCompanyDataSet;
        private System.Windows.Forms.BindingSource selectConfectionProductsBindingSource;
        private ConfectioneryCompanyDataSetTableAdapters.SelectConfectionProductsTableAdapter selectConfectionProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокХраненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}
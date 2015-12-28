namespace СonfectioneryСompany
{
    partial class ConfectionsForm
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
            this.confectionsDataGrid = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.confectioneryCompanyDataSet = new СonfectioneryСompany.ConfectioneryCompanyDataSet();
            this.confectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confectionsTableAdapter = new СonfectioneryСompany.ConfectioneryCompanyDataSetTableAdapters.ConfectionsTableAdapter();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.confectionsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // confectionsDataGrid
            // 
            this.confectionsDataGrid.AutoGenerateColumns = false;
            this.confectionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.confectionsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.confectionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confectionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.confectionsDataGrid.DataSource = this.confectionsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.confectionsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.confectionsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.confectionsDataGrid.Name = "confectionsDataGrid";
            this.confectionsDataGrid.Size = new System.Drawing.Size(583, 343);
            this.confectionsDataGrid.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateButton.Location = new System.Drawing.Point(231, 380);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(148, 35);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // confectioneryCompanyDataSet
            // 
            this.confectioneryCompanyDataSet.DataSetName = "ConfectioneryCompanyDataSet";
            this.confectioneryCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // confectionsBindingSource
            // 
            this.confectionsBindingSource.DataMember = "Confections";
            this.confectionsBindingSource.DataSource = this.confectioneryCompanyDataSet;
            // 
            // confectionsTableAdapter
            // 
            this.confectionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Название изделия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название изделия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Цена(руб_)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена(руб_)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Информация";
            this.dataGridViewTextBoxColumn5.HeaderText = "Информация";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn6.HeaderText = "id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // ConfectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 427);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.confectionsDataGrid);
            this.Name = "ConfectionsForm";
            this.Text = "Изделия";
            this.Load += new System.EventHandler(this.ConfectionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.confectionsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectioneryCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confectionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView confectionsDataGrid;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеИзделияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn информацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценарубDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ConfectioneryCompanyDataSet confectioneryCompanyDataSet;
        private System.Windows.Forms.BindingSource confectionsBindingSource;
        private ConfectioneryCompanyDataSetTableAdapters.ConfectionsTableAdapter confectionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
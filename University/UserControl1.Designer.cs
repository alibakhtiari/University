
namespace University
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aliDataSet = new University.aliDataSet();
            this.مشخصاتطرحBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.مشخصات_طرحTableAdapter = new University.aliDataSetTableAdapters.مشخصات_طرحTableAdapter();
            this.idNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.مشخصاتطرحBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNumberDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.executiveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.مشخصاتطرحBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(684, 483);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aliDataSet
            // 
            this.aliDataSet.DataSetName = "aliDataSet";
            this.aliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // مشخصاتطرحBindingSource
            // 
            this.مشخصاتطرحBindingSource.DataMember = "مشخصات طرح";
            this.مشخصاتطرحBindingSource.DataSource = this.aliDataSet;
            // 
            // مشخصات_طرحTableAdapter
            // 
            this.مشخصات_طرحTableAdapter.ClearBeforeFill = true;
            // 
            // idNumberDataGridViewTextBoxColumn
            // 
            this.idNumberDataGridViewTextBoxColumn.DataPropertyName = "id number";
            this.idNumberDataGridViewTextBoxColumn.HeaderText = "شماره";
            this.idNumberDataGridViewTextBoxColumn.Name = "idNumberDataGridViewTextBoxColumn";
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "project name";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "عنوان طرح";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            // 
            // executiveDataGridViewTextBoxColumn
            // 
            this.executiveDataGridViewTextBoxColumn.DataPropertyName = "executive";
            this.executiveDataGridViewTextBoxColumn.HeaderText = "مجری";
            this.executiveDataGridViewTextBoxColumn.Name = "executiveDataGridViewTextBoxColumn";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(684, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.مشخصاتطرحBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource مشخصاتطرحBindingSource;
        private aliDataSet aliDataSet;
        private aliDataSetTableAdapters.مشخصات_طرحTableAdapter مشخصات_طرحTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executiveDataGridViewTextBoxColumn;
    }
}

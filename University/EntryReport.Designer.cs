
namespace University
{
    partial class EntryReport
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
            this.aliDataSet = new University.aliDataSet();
            this.مشخصاتطرحBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.مشخصات_طرحTableAdapter = new University.aliDataSetTableAdapters.مشخصات_طرحTableAdapter();
            this.dataFilterDescriptorItem1 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem2 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem3 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem4 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem5 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem6 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem7 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem8 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem9 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem10 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem11 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem12 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem13 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem14 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem15 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem16 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem17 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem18 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem19 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem20 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem21 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem22 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem23 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem24 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem25 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem26 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem27 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem28 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem29 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.aliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.مشخصاتطرحBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataFilterDescriptorItem1
            // 
            this.dataFilterDescriptorItem1.DescriptorName = "id number";
            this.dataFilterDescriptorItem1.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem1.IsAutoGenerated = true;
            this.dataFilterDescriptorItem1.Name = "dataFilterDescriptorItem1";
            // 
            // dataFilterDescriptorItem2
            // 
            this.dataFilterDescriptorItem2.DescriptorName = "project name";
            this.dataFilterDescriptorItem2.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem2.IsAutoGenerated = true;
            this.dataFilterDescriptorItem2.Name = "dataFilterDescriptorItem2";
            // 
            // dataFilterDescriptorItem3
            // 
            this.dataFilterDescriptorItem3.DescriptorName = "executive";
            this.dataFilterDescriptorItem3.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem3.IsAutoGenerated = true;
            this.dataFilterDescriptorItem3.Name = "dataFilterDescriptorItem3";
            // 
            // dataFilterDescriptorItem4
            // 
            this.dataFilterDescriptorItem4.DescriptorName = "contract\'s year";
            this.dataFilterDescriptorItem4.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem4.IsAutoGenerated = true;
            this.dataFilterDescriptorItem4.Name = "dataFilterDescriptorItem4";
            // 
            // dataFilterDescriptorItem5
            // 
            this.dataFilterDescriptorItem5.DescriptorName = "group";
            this.dataFilterDescriptorItem5.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem5.IsAutoGenerated = true;
            this.dataFilterDescriptorItem5.Name = "dataFilterDescriptorItem5";
            // 
            // dataFilterDescriptorItem6
            // 
            this.dataFilterDescriptorItem6.DescriptorName = "faculty";
            this.dataFilterDescriptorItem6.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem6.IsAutoGenerated = true;
            this.dataFilterDescriptorItem6.Name = "dataFilterDescriptorItem6";
            // 
            // dataFilterDescriptorItem7
            // 
            this.dataFilterDescriptorItem7.DescriptorName = "demander";
            this.dataFilterDescriptorItem7.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem7.IsAutoGenerated = true;
            this.dataFilterDescriptorItem7.Name = "dataFilterDescriptorItem7";
            // 
            // dataFilterDescriptorItem8
            // 
            this.dataFilterDescriptorItem8.DescriptorName = "duration of contract";
            this.dataFilterDescriptorItem8.DescriptorType = typeof(double);
            this.dataFilterDescriptorItem8.IsAutoGenerated = true;
            this.dataFilterDescriptorItem8.Name = "dataFilterDescriptorItem8";
            // 
            // dataFilterDescriptorItem9
            // 
            this.dataFilterDescriptorItem9.DescriptorName = "budget";
            this.dataFilterDescriptorItem9.DescriptorType = typeof(double);
            this.dataFilterDescriptorItem9.IsAutoGenerated = true;
            this.dataFilterDescriptorItem9.Name = "dataFilterDescriptorItem9";
            // 
            // dataFilterDescriptorItem10
            // 
            this.dataFilterDescriptorItem10.DescriptorName = "benefit percentage";
            this.dataFilterDescriptorItem10.DescriptorType = typeof(byte);
            this.dataFilterDescriptorItem10.IsAutoGenerated = true;
            this.dataFilterDescriptorItem10.Name = "dataFilterDescriptorItem10";
            // 
            // dataFilterDescriptorItem11
            // 
            this.dataFilterDescriptorItem11.DescriptorName = "action";
            this.dataFilterDescriptorItem11.DescriptorType = typeof(bool);
            this.dataFilterDescriptorItem11.IsAutoGenerated = true;
            this.dataFilterDescriptorItem11.Name = "dataFilterDescriptorItem11";
            // 
            // dataFilterDescriptorItem12
            // 
            this.dataFilterDescriptorItem12.DescriptorName = "finish year";
            this.dataFilterDescriptorItem12.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem12.IsAutoGenerated = true;
            this.dataFilterDescriptorItem12.Name = "dataFilterDescriptorItem12";
            // 
            // dataFilterDescriptorItem13
            // 
            this.dataFilterDescriptorItem13.DescriptorName = "collegues";
            this.dataFilterDescriptorItem13.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem13.IsAutoGenerated = true;
            this.dataFilterDescriptorItem13.Name = "dataFilterDescriptorItem13";
            // 
            // dataFilterDescriptorItem14
            // 
            this.dataFilterDescriptorItem14.DescriptorName = "finantial phase1";
            this.dataFilterDescriptorItem14.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem14.IsAutoGenerated = true;
            this.dataFilterDescriptorItem14.Name = "dataFilterDescriptorItem14";
            // 
            // dataFilterDescriptorItem15
            // 
            this.dataFilterDescriptorItem15.DescriptorName = "date finantial phase1";
            this.dataFilterDescriptorItem15.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem15.IsAutoGenerated = true;
            this.dataFilterDescriptorItem15.Name = "dataFilterDescriptorItem15";
            // 
            // dataFilterDescriptorItem16
            // 
            this.dataFilterDescriptorItem16.DescriptorName = "finantial phase2";
            this.dataFilterDescriptorItem16.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem16.IsAutoGenerated = true;
            this.dataFilterDescriptorItem16.Name = "dataFilterDescriptorItem16";
            // 
            // dataFilterDescriptorItem17
            // 
            this.dataFilterDescriptorItem17.DescriptorName = "date finantial phase2";
            this.dataFilterDescriptorItem17.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem17.IsAutoGenerated = true;
            this.dataFilterDescriptorItem17.Name = "dataFilterDescriptorItem17";
            // 
            // dataFilterDescriptorItem18
            // 
            this.dataFilterDescriptorItem18.DescriptorName = "finantial phase3";
            this.dataFilterDescriptorItem18.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem18.IsAutoGenerated = true;
            this.dataFilterDescriptorItem18.Name = "dataFilterDescriptorItem18";
            // 
            // dataFilterDescriptorItem19
            // 
            this.dataFilterDescriptorItem19.DescriptorName = "date finantial phase3";
            this.dataFilterDescriptorItem19.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem19.IsAutoGenerated = true;
            this.dataFilterDescriptorItem19.Name = "dataFilterDescriptorItem19";
            // 
            // dataFilterDescriptorItem20
            // 
            this.dataFilterDescriptorItem20.DescriptorName = "finantial phase4";
            this.dataFilterDescriptorItem20.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem20.IsAutoGenerated = true;
            this.dataFilterDescriptorItem20.Name = "dataFilterDescriptorItem20";
            // 
            // dataFilterDescriptorItem21
            // 
            this.dataFilterDescriptorItem21.DescriptorName = "date finantial phase4";
            this.dataFilterDescriptorItem21.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem21.IsAutoGenerated = true;
            this.dataFilterDescriptorItem21.Name = "dataFilterDescriptorItem21";
            // 
            // dataFilterDescriptorItem22
            // 
            this.dataFilterDescriptorItem22.DescriptorName = "finantial phase5";
            this.dataFilterDescriptorItem22.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem22.IsAutoGenerated = true;
            this.dataFilterDescriptorItem22.Name = "dataFilterDescriptorItem22";
            // 
            // dataFilterDescriptorItem23
            // 
            this.dataFilterDescriptorItem23.DescriptorName = "date finantial5";
            this.dataFilterDescriptorItem23.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem23.IsAutoGenerated = true;
            this.dataFilterDescriptorItem23.Name = "dataFilterDescriptorItem23";
            // 
            // dataFilterDescriptorItem24
            // 
            this.dataFilterDescriptorItem24.DescriptorName = "finantial phase6";
            this.dataFilterDescriptorItem24.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem24.IsAutoGenerated = true;
            this.dataFilterDescriptorItem24.Name = "dataFilterDescriptorItem24";
            // 
            // dataFilterDescriptorItem25
            // 
            this.dataFilterDescriptorItem25.DescriptorName = "date finantial phase6";
            this.dataFilterDescriptorItem25.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem25.IsAutoGenerated = true;
            this.dataFilterDescriptorItem25.Name = "dataFilterDescriptorItem25";
            // 
            // dataFilterDescriptorItem26
            // 
            this.dataFilterDescriptorItem26.DescriptorName = "finantial phase sepordeh";
            this.dataFilterDescriptorItem26.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem26.IsAutoGenerated = true;
            this.dataFilterDescriptorItem26.Name = "dataFilterDescriptorItem26";
            // 
            // dataFilterDescriptorItem27
            // 
            this.dataFilterDescriptorItem27.DescriptorName = "date finantial sepordeh";
            this.dataFilterDescriptorItem27.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem27.IsAutoGenerated = true;
            this.dataFilterDescriptorItem27.Name = "dataFilterDescriptorItem27";
            // 
            // dataFilterDescriptorItem28
            // 
            this.dataFilterDescriptorItem28.DescriptorName = "sum";
            this.dataFilterDescriptorItem28.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem28.IsAutoGenerated = true;
            this.dataFilterDescriptorItem28.Name = "dataFilterDescriptorItem28";
            // 
            // dataFilterDescriptorItem29
            // 
            this.dataFilterDescriptorItem29.DescriptorName = "LastDate";
            this.dataFilterDescriptorItem29.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem29.IsAutoGenerated = true;
            this.dataFilterDescriptorItem29.Name = "dataFilterDescriptorItem29";
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
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 1;
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
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // EntryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EntryReport";
            this.Text = "EntryReport";
            this.Load += new System.EventHandler(this.EntryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.مشخصاتطرحBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private aliDataSet aliDataSet;
        private System.Windows.Forms.BindingSource مشخصاتطرحBindingSource;
        private aliDataSetTableAdapters.مشخصات_طرحTableAdapter مشخصات_طرحTableAdapter;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem1;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem2;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem3;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem4;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem5;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem6;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem7;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem8;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem9;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem10;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem11;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem12;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem13;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem14;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem15;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem16;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem17;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem18;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem19;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem20;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem21;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem22;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem23;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem24;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem25;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem26;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem27;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem28;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem29;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
    }
}
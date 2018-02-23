namespace SGTIN_DecodeEncode
{
    partial class Form1
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
            this.chooseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.product_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Serach = new System.Windows.Forms.Button();
            this.typeOfSGTIN_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfInvalidSGTIN96_EPCs = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.numberOfSearchedItems_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(12, 12);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(155, 26);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "Choose \"SGTIN EPC\" file";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 26);
            this.label1.TabIndex = 1;
            // 
            // product_ComboBox
            // 
            this.product_ComboBox.FormattingEnabled = true;
            this.product_ComboBox.Location = new System.Drawing.Point(12, 142);
            this.product_ComboBox.Name = "product_ComboBox";
            this.product_ComboBox.Size = new System.Drawing.Size(451, 21);
            this.product_ComboBox.TabIndex = 2;
            this.product_ComboBox.SelectedValueChanged += new System.EventHandler(this.product_ComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select item";
            // 
            // Serach
            // 
            this.Serach.Location = new System.Drawing.Point(12, 184);
            this.Serach.Name = "Serach";
            this.Serach.Size = new System.Drawing.Size(451, 25);
            this.Serach.TabIndex = 4;
            this.Serach.Text = "Serach";
            this.Serach.UseVisualStyleBackColor = true;
            this.Serach.Click += new System.EventHandler(this.Serach_Click);
            // 
            // typeOfSGTIN_ComboBox
            // 
            this.typeOfSGTIN_ComboBox.FormattingEnabled = true;
            this.typeOfSGTIN_ComboBox.Items.AddRange(new object[] {
            "SGTIN-96",
            "SGTIN-198",
            "SGTIN-64"});
            this.typeOfSGTIN_ComboBox.Location = new System.Drawing.Point(12, 77);
            this.typeOfSGTIN_ComboBox.Name = "typeOfSGTIN_ComboBox";
            this.typeOfSGTIN_ComboBox.Size = new System.Drawing.Size(155, 21);
            this.typeOfSGTIN_ComboBox.TabIndex = 5;
            this.typeOfSGTIN_ComboBox.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose decode type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Invalid SGTIN-96 EPCs:";
            // 
            // numberOfInvalidSGTIN96_EPCs
            // 
            this.numberOfInvalidSGTIN96_EPCs.AutoSize = true;
            this.numberOfInvalidSGTIN96_EPCs.Location = new System.Drawing.Point(198, 228);
            this.numberOfInvalidSGTIN96_EPCs.Name = "numberOfInvalidSGTIN96_EPCs";
            this.numberOfInvalidSGTIN96_EPCs.Size = new System.Drawing.Size(0, 13);
            this.numberOfInvalidSGTIN96_EPCs.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 291);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(451, 159);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Company";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product name";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial numbers";
            this.columnHeader1.Width = 209;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of searched items:";
            // 
            // numberOfSearchedItems_Label
            // 
            this.numberOfSearchedItems_Label.AutoSize = true;
            this.numberOfSearchedItems_Label.Location = new System.Drawing.Point(152, 272);
            this.numberOfSearchedItems_Label.Name = "numberOfSearchedItems_Label";
            this.numberOfSearchedItems_Label.Size = new System.Drawing.Size(0, 13);
            this.numberOfSearchedItems_Label.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 462);
            this.Controls.Add(this.numberOfSearchedItems_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numberOfInvalidSGTIN96_EPCs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeOfSGTIN_ComboBox);
            this.Controls.Add(this.Serach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseFile);
            this.Name = "Form1";
            this.Text = "SGTIN Encode/Decode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox product_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Serach;
        private System.Windows.Forms.ComboBox typeOfSGTIN_ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numberOfInvalidSGTIN96_EPCs;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numberOfSearchedItems_Label;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}


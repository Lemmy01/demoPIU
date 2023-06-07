namespace Interfata
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblLocalitate = new System.Windows.Forms.Label();
            this.localitateCBox = new System.Windows.Forms.ComboBox();
            this.anonimBox = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.afiseazaBtn = new System.Windows.Forms.Button();
            this.cautaBtn = new System.Windows.Forms.Button();
            this.radBtn1 = new System.Windows.Forms.RadioButton();
            this.radBtn2 = new System.Windows.Forms.RadioButton();
            this.radBtn3 = new System.Windows.Forms.RadioButton();
            this.llbRadio = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioPostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anonimColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cautaLBox = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(142, 80);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(109, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(36, 80);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(77, 13);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "NumePrenume";
            // 
            // lblLocalitate
            // 
            this.lblLocalitate.AutoSize = true;
            this.lblLocalitate.Location = new System.Drawing.Point(36, 136);
            this.lblLocalitate.Name = "lblLocalitate";
            this.lblLocalitate.Size = new System.Drawing.Size(53, 13);
            this.lblLocalitate.TabIndex = 2;
            this.lblLocalitate.Text = "Localitate";
            // 
            // localitateCBox
            // 
            this.localitateCBox.FormattingEnabled = true;
            this.localitateCBox.Items.AddRange(new object[] {
            "Suceava",
            "Iasi",
            "Bucuresti",
            "Radauti"});
            this.localitateCBox.Location = new System.Drawing.Point(142, 136);
            this.localitateCBox.Name = "localitateCBox";
            this.localitateCBox.Size = new System.Drawing.Size(121, 21);
            this.localitateCBox.TabIndex = 3;
            this.localitateCBox.SelectedIndexChanged += new System.EventHandler(this.localitateCBox_SelectedIndexChanged);
            // 
            // anonimBox
            // 
            this.anonimBox.AutoSize = true;
            this.anonimBox.Checked = true;
            this.anonimBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.anonimBox.Location = new System.Drawing.Point(42, 218);
            this.anonimBox.Name = "anonimBox";
            this.anonimBox.Size = new System.Drawing.Size(61, 17);
            this.anonimBox.TabIndex = 5;
            this.anonimBox.Text = "Anonim";
            this.anonimBox.UseVisualStyleBackColor = true;
            this.anonimBox.CheckedChanged += new System.EventHandler(this.anonimBox_CheckedChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(53, 280);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Adauga";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // afiseazaBtn
            // 
            this.afiseazaBtn.Location = new System.Drawing.Point(53, 333);
            this.afiseazaBtn.Name = "afiseazaBtn";
            this.afiseazaBtn.Size = new System.Drawing.Size(75, 23);
            this.afiseazaBtn.TabIndex = 7;
            this.afiseazaBtn.Text = "Afiseaza";
            this.afiseazaBtn.UseVisualStyleBackColor = true;
            this.afiseazaBtn.Click += new System.EventHandler(this.afiseazaBtn_Click);
            // 
            // cautaBtn
            // 
            this.cautaBtn.Location = new System.Drawing.Point(53, 387);
            this.cautaBtn.Name = "cautaBtn";
            this.cautaBtn.Size = new System.Drawing.Size(75, 23);
            this.cautaBtn.TabIndex = 8;
            this.cautaBtn.Text = "Cauta";
            this.cautaBtn.UseVisualStyleBackColor = true;
            this.cautaBtn.Click += new System.EventHandler(this.cautaBtn_Click);
            // 
            // radBtn1
            // 
            this.radBtn1.AutoSize = true;
            this.radBtn1.Location = new System.Drawing.Point(142, 180);
            this.radBtn1.Name = "radBtn1";
            this.radBtn1.Size = new System.Drawing.Size(61, 17);
            this.radBtn1.TabIndex = 10;
            this.radBtn1.TabStop = true;
            this.radBtn1.Text = "Trimitas";
            this.radBtn1.UseVisualStyleBackColor = true;
            // 
            // radBtn2
            // 
            this.radBtn2.AutoSize = true;
            this.radBtn2.Location = new System.Drawing.Point(253, 180);
            this.radBtn2.Name = "radBtn2";
            this.radBtn2.Size = new System.Drawing.Size(58, 17);
            this.radBtn2.TabIndex = 11;
            this.radBtn2.TabStop = true;
            this.radBtn2.Text = "DigiFM";
            this.radBtn2.UseVisualStyleBackColor = true;
            // 
            // radBtn3
            // 
            this.radBtn3.AutoSize = true;
            this.radBtn3.Location = new System.Drawing.Point(365, 180);
            this.radBtn3.Name = "radBtn3";
            this.radBtn3.Size = new System.Drawing.Size(82, 17);
            this.radBtn3.TabIndex = 12;
            this.radBtn3.TabStop = true;
            this.radBtn3.Text = "RomaniaFM";
            this.radBtn3.UseVisualStyleBackColor = true;
            // 
            // llbRadio
            // 
            this.llbRadio.AutoSize = true;
            this.llbRadio.Location = new System.Drawing.Point(39, 185);
            this.llbRadio.Name = "llbRadio";
            this.llbRadio.Size = new System.Drawing.Size(58, 13);
            this.llbRadio.TabIndex = 13;
            this.llbRadio.Text = "post Radio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeColumn,
            this.localitateColumn,
            this.radioPostColumn,
            this.anonimColumn});
            this.dataGridView1.Location = new System.Drawing.Point(508, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 449);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numeColumn
            // 
            this.numeColumn.HeaderText = "NumePrenume";
            this.numeColumn.Name = "numeColumn";
            // 
            // localitateColumn
            // 
            this.localitateColumn.HeaderText = "Localitate";
            this.localitateColumn.Name = "localitateColumn";
            // 
            // radioPostColumn
            // 
            this.radioPostColumn.HeaderText = "Post Radio";
            this.radioPostColumn.Name = "radioPostColumn";
            // 
            // anonimColumn
            // 
            this.anonimColumn.HeaderText = "Anonim";
            this.anonimColumn.Name = "anonimColumn";
            // 
            // cautaLBox
            // 
            this.cautaLBox.FormattingEnabled = true;
            this.cautaLBox.Location = new System.Drawing.Point(979, 90);
            this.cautaLBox.Name = "cautaLBox";
            this.cautaLBox.Size = new System.Drawing.Size(285, 186);
            this.cautaLBox.TabIndex = 15;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(989, 55);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 13);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "Nr:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 589);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cautaLBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.llbRadio);
            this.Controls.Add(this.radBtn3);
            this.Controls.Add(this.radBtn2);
            this.Controls.Add(this.radBtn1);
            this.Controls.Add(this.cautaBtn);
            this.Controls.Add(this.afiseazaBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.anonimBox);
            this.Controls.Add(this.localitateCBox);
            this.Controls.Add(this.lblLocalitate);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblLocalitate;
        private System.Windows.Forms.ComboBox localitateCBox;
        private System.Windows.Forms.CheckBox anonimBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button afiseazaBtn;
        private System.Windows.Forms.Button cautaBtn;
        private System.Windows.Forms.RadioButton radBtn1;
        private System.Windows.Forms.RadioButton radBtn2;
        private System.Windows.Forms.RadioButton radBtn3;
        private System.Windows.Forms.Label llbRadio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radioPostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anonimColumn;
        private System.Windows.Forms.ListBox cautaLBox;
        private System.Windows.Forms.Label lblCount;
    }
}


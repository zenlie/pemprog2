namespace P6_3_1184109
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dTanggal = new System.Windows.Forms.DateTimePicker();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbCewe = new System.Windows.Forms.RadioButton();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.cbProstud = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtName = new NumericCharControl.CharTextBox();
            this.txtNumber = new NumericCharControl.NumericTextBox();
            this.txtNPM = new NumericCharControl.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM INPUT MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "No Telepon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Program Studi";
            // 
            // dTanggal
            // 
            this.dTanggal.Location = new System.Drawing.Point(147, 132);
            this.dTanggal.Name = "dTanggal";
            this.dTanggal.Size = new System.Drawing.Size(200, 20);
            this.dTanggal.TabIndex = 8;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(147, 331);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(64, 17);
            this.rbLaki.TabIndex = 9;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbCewe
            // 
            this.rbCewe.AutoSize = true;
            this.rbCewe.Location = new System.Drawing.Point(262, 331);
            this.rbCewe.Name = "rbCewe";
            this.rbCewe.Size = new System.Drawing.Size(79, 17);
            this.rbCewe.TabIndex = 10;
            this.rbCewe.TabStop = true;
            this.rbCewe.Text = "Perempuan";
            this.rbCewe.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(147, 360);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 55);
            this.txtAlamat.TabIndex = 11;
            this.txtAlamat.Leave += new System.EventHandler(this.txtAlamat_Leave);
            // 
            // cbProstud
            // 
            this.cbProstud.FormattingEnabled = true;
            this.cbProstud.Location = new System.Drawing.Point(147, 471);
            this.cbProstud.Name = "cbProstud";
            this.cbProstud.Size = new System.Drawing.Size(149, 21);
            this.cbProstud.TabIndex = 12;
            this.cbProstud.Text = "--Pilih Program Studi--";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 18;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(147, 432);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 15;
            this.txtNumber.Leave += new System.EventHandler(this.txtNumber_Leave);
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(147, 67);
            this.txtNPM.MaxLength = 7;
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(100, 20);
            this.txtNPM.TabIndex = 13;
            this.txtNPM.Leave += new System.EventHandler(this.txtNPM_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 611);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.cbProstud);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.rbCewe);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.dTanggal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dTanggal;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbCewe;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.ComboBox cbProstud;
        private NumericCharControl.NumericTextBox txtNPM;
        private NumericCharControl.NumericTextBox txtNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epWrong;
        private NumericCharControl.CharTextBox txtName;
    }
}


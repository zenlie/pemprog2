namespace P3_4_1184109
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
            this.JudulForm = new System.Windows.Forms.Label();
            this.FormNama = new System.Windows.Forms.Label();
            this.FormJK = new System.Windows.Forms.Label();
            this.FormTLL = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.dtpTTL = new System.Windows.Forms.DateTimePicker();
            this.gbGroup = new System.Windows.Forms.GroupBox();
            this.komposer = new System.Windows.Forms.CheckBox();
            this.vokal = new System.Windows.Forms.CheckBox();
            this.drum = new System.Windows.Forms.CheckBox();
            this.piano = new System.Windows.Forms.CheckBox();
            this.konduktor = new System.Windows.Forms.CheckBox();
            this.saxophone = new System.Windows.Forms.CheckBox();
            this.gitar = new System.Windows.Forms.CheckBox();
            this.Biola = new System.Windows.Forms.CheckBox();
            this.gbJadwal = new System.Windows.Forms.GroupBox();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.gbGroup.SuspendLayout();
            this.gbJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // JudulForm
            // 
            this.JudulForm.AutoSize = true;
            this.JudulForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulForm.Location = new System.Drawing.Point(317, 71);
            this.JudulForm.Name = "JudulForm";
            this.JudulForm.Size = new System.Drawing.Size(195, 20);
            this.JudulForm.TabIndex = 0;
            this.JudulForm.Text = "FORM PENDAFTARAN";
            // 
            // FormNama
            // 
            this.FormNama.AutoSize = true;
            this.FormNama.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNama.Location = new System.Drawing.Point(225, 141);
            this.FormNama.Name = "FormNama";
            this.FormNama.Size = new System.Drawing.Size(139, 18);
            this.FormNama.TabIndex = 1;
            this.FormNama.Text = "Nama                       :";
            // 
            // FormJK
            // 
            this.FormJK.AutoSize = true;
            this.FormJK.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormJK.Location = new System.Drawing.Point(225, 180);
            this.FormJK.Name = "FormJK";
            this.FormJK.Size = new System.Drawing.Size(139, 18);
            this.FormJK.TabIndex = 2;
            this.FormJK.Text = "Jenis Kelamin          :";
            // 
            // FormTLL
            // 
            this.FormTLL.AutoSize = true;
            this.FormTLL.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTLL.Location = new System.Drawing.Point(225, 219);
            this.FormTLL.Name = "FormTLL";
            this.FormTLL.Size = new System.Drawing.Size(141, 18);
            this.FormTLL.TabIndex = 3;
            this.FormTLL.Text = "Tanggal Lahir            :";
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.ForeColor = System.Drawing.Color.Black;
            this.tbNama.Location = new System.Drawing.Point(376, 136);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(280, 23);
            this.tbNama.TabIndex = 4;
            // 
            // cbJK
            // 
            this.cbJK.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.cbJK.Location = new System.Drawing.Point(376, 176);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(280, 25);
            this.cbJK.TabIndex = 7;
            this.cbJK.Text = "--pilih jenis kelamin--";
            // 
            // dtpTTL
            // 
            this.dtpTTL.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTTL.Location = new System.Drawing.Point(376, 219);
            this.dtpTTL.Name = "dtpTTL";
            this.dtpTTL.Size = new System.Drawing.Size(280, 23);
            this.dtpTTL.TabIndex = 8;
            // 
            // gbGroup
            // 
            this.gbGroup.Controls.Add(this.komposer);
            this.gbGroup.Controls.Add(this.vokal);
            this.gbGroup.Controls.Add(this.drum);
            this.gbGroup.Controls.Add(this.piano);
            this.gbGroup.Controls.Add(this.konduktor);
            this.gbGroup.Controls.Add(this.saxophone);
            this.gbGroup.Controls.Add(this.gitar);
            this.gbGroup.Controls.Add(this.Biola);
            this.gbGroup.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGroup.Location = new System.Drawing.Point(64, 296);
            this.gbGroup.Name = "gbGroup";
            this.gbGroup.Size = new System.Drawing.Size(310, 239);
            this.gbGroup.TabIndex = 9;
            this.gbGroup.TabStop = false;
            this.gbGroup.Text = "Pilihan Kelas";
            // 
            // komposer
            // 
            this.komposer.AutoSize = true;
            this.komposer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.komposer.Location = new System.Drawing.Point(175, 187);
            this.komposer.Name = "komposer";
            this.komposer.Size = new System.Drawing.Size(91, 21);
            this.komposer.TabIndex = 7;
            this.komposer.Text = "Komposer";
            this.komposer.UseVisualStyleBackColor = true;
            // 
            // vokal
            // 
            this.vokal.AutoSize = true;
            this.vokal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vokal.Location = new System.Drawing.Point(175, 138);
            this.vokal.Name = "vokal";
            this.vokal.Size = new System.Drawing.Size(62, 21);
            this.vokal.TabIndex = 6;
            this.vokal.Text = "Vokal";
            this.vokal.UseVisualStyleBackColor = true;
            // 
            // drum
            // 
            this.drum.AutoSize = true;
            this.drum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drum.Location = new System.Drawing.Point(175, 89);
            this.drum.Name = "drum";
            this.drum.Size = new System.Drawing.Size(61, 21);
            this.drum.TabIndex = 5;
            this.drum.Text = "Drum";
            this.drum.UseVisualStyleBackColor = true;
            // 
            // piano
            // 
            this.piano.AutoSize = true;
            this.piano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piano.Location = new System.Drawing.Point(175, 40);
            this.piano.Name = "piano";
            this.piano.Size = new System.Drawing.Size(63, 21);
            this.piano.TabIndex = 4;
            this.piano.Text = "Piano";
            this.piano.UseVisualStyleBackColor = true;
            // 
            // konduktor
            // 
            this.konduktor.AutoSize = true;
            this.konduktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konduktor.Location = new System.Drawing.Point(25, 187);
            this.konduktor.Name = "konduktor";
            this.konduktor.Size = new System.Drawing.Size(92, 21);
            this.konduktor.TabIndex = 3;
            this.konduktor.Text = "Konduktor";
            this.konduktor.UseVisualStyleBackColor = true;
            // 
            // saxophone
            // 
            this.saxophone.AutoSize = true;
            this.saxophone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saxophone.Location = new System.Drawing.Point(25, 138);
            this.saxophone.Name = "saxophone";
            this.saxophone.Size = new System.Drawing.Size(98, 21);
            this.saxophone.TabIndex = 2;
            this.saxophone.Text = "Saxophone";
            this.saxophone.UseVisualStyleBackColor = true;
            // 
            // gitar
            // 
            this.gitar.AutoSize = true;
            this.gitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitar.Location = new System.Drawing.Point(25, 89);
            this.gitar.Name = "gitar";
            this.gitar.Size = new System.Drawing.Size(58, 21);
            this.gitar.TabIndex = 1;
            this.gitar.Text = "Gitar";
            this.gitar.UseVisualStyleBackColor = true;
            // 
            // Biola
            // 
            this.Biola.AutoSize = true;
            this.Biola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biola.Location = new System.Drawing.Point(25, 40);
            this.Biola.Name = "Biola";
            this.Biola.Size = new System.Drawing.Size(58, 21);
            this.Biola.TabIndex = 0;
            this.Biola.Text = "Biola";
            this.Biola.UseVisualStyleBackColor = true;
            // 
            // gbJadwal
            // 
            this.gbJadwal.Controls.Add(this.rbJadwal4);
            this.gbJadwal.Controls.Add(this.rbJadwal3);
            this.gbJadwal.Controls.Add(this.rbJadwal2);
            this.gbJadwal.Controls.Add(this.rbJadwal1);
            this.gbJadwal.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJadwal.Location = new System.Drawing.Point(426, 296);
            this.gbJadwal.Name = "gbJadwal";
            this.gbJadwal.Size = new System.Drawing.Size(357, 239);
            this.gbJadwal.TabIndex = 10;
            this.gbJadwal.TabStop = false;
            this.gbJadwal.Text = "Piihan Jadwal";
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJadwal4.Location = new System.Drawing.Point(24, 185);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(194, 21);
            this.rbJadwal4.TabIndex = 3;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu, 13.00 - 17.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJadwal3.Location = new System.Drawing.Point(24, 143);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(266, 21);
            this.rbJadwal3.TabIndex = 2;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Jumat dan Sabtu, 09.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJadwal2.Location = new System.Drawing.Point(24, 101);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(274, 21);
            this.rbJadwal2.TabIndex = 1;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa dan Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJadwal1.Location = new System.Drawing.Point(24, 59);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(258, 21);
            this.rbJadwal1.TabIndex = 0;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin dan Rabu, 14.00 - 16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // btnTampil
            // 
            this.btnTampil.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.Location = new System.Drawing.Point(286, 578);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(131, 35);
            this.btnTampil.TabIndex = 11;
            this.btnTampil.Text = "&Tampilkan";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.Location = new System.Drawing.Point(450, 578);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(131, 35);
            this.btnSelesai.TabIndex = 12;
            this.btnSelesai.Text = "&Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 649);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.gbJadwal);
            this.Controls.Add(this.gbGroup);
            this.Controls.Add(this.dtpTTL);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.FormTLL);
            this.Controls.Add(this.FormJK);
            this.Controls.Add(this.FormNama);
            this.Controls.Add(this.JudulForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "SM ENTERTAINMENT";
            this.gbGroup.ResumeLayout(false);
            this.gbGroup.PerformLayout();
            this.gbJadwal.ResumeLayout(false);
            this.gbJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JudulForm;
        private System.Windows.Forms.Label FormNama;
        private System.Windows.Forms.Label FormJK;
        private System.Windows.Forms.Label FormTLL;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtpTTL;
        private System.Windows.Forms.GroupBox gbGroup;
        private System.Windows.Forms.CheckBox komposer;
        private System.Windows.Forms.CheckBox vokal;
        private System.Windows.Forms.CheckBox drum;
        private System.Windows.Forms.CheckBox piano;
        private System.Windows.Forms.CheckBox konduktor;
        private System.Windows.Forms.CheckBox saxophone;
        private System.Windows.Forms.CheckBox gitar;
        private System.Windows.Forms.CheckBox Biola;
        private System.Windows.Forms.GroupBox gbJadwal;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnSelesai;
    }
}


﻿
namespace ClientReservasi_20180140108
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
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTlf = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(676, 66);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 0;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(676, 117);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(676, 167);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 2;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(676, 219);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(279, 40);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(298, 22);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(279, 95);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(298, 22);
            this.textBoxNama.TabIndex = 5;
            // 
            // textBoxNoTlf
            // 
            this.textBoxNoTlf.Location = new System.Drawing.Point(279, 148);
            this.textBoxNoTlf.Name = "textBoxNoTlf";
            this.textBoxNoTlf.Size = new System.Drawing.Size(298, 22);
            this.textBoxNoTlf.TabIndex = 6;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(279, 205);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(298, 22);
            this.textBoxJumlah.TabIndex = 7;
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(279, 270);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(298, 22);
            this.textBoxIDLokasi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Reservasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "NoTelfon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Lokasi";
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Location = new System.Drawing.Point(29, 320);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowHeadersWidth = 51;
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(722, 190);
            this.dtPemesanan.TabIndex = 14;
            this.dtPemesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellClick);
            this.dtPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxNoTlf);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Name = "Form1";
            this.Text = "Reservasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTlf;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtPemesanan;
    }
}


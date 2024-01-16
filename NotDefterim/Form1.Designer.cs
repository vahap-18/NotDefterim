using System;

namespace NotDefterim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altıÇiziliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üstüÇiziliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.büyütToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçütToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaplanRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yakınlaştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzaklaştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.dosyaAçToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            resources.ApplyResources(this.dosyaToolStripMenuItem, "dosyaToolStripMenuItem");
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Yeni_Dosya;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            resources.ApplyResources(this.yeniToolStripMenuItem, "yeniToolStripMenuItem");
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Dosya;
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            resources.ApplyResources(this.dosyaAçToolStripMenuItem, "dosyaAçToolStripMenuItem");
            this.dosyaAçToolStripMenuItem.Click += new System.EventHandler(this.dosyaAçToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Kaydet;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            resources.ApplyResources(this.kaydetToolStripMenuItem, "kaydetToolStripMenuItem");
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Kaydet;
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            resources.ApplyResources(this.farklıKaydetToolStripMenuItem, "farklıKaydetToolStripMenuItem");
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Image = global::NotDefterim.Properties.Resources.Çıkış;
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            resources.ApplyResources(this.çıkışToolStripMenuItem1, "çıkışToolStripMenuItem1");
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.ileriAlToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.tümünüSeçToolStripMenuItem,
            this.silToolStripMenuItem,
            this.bulToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            resources.ApplyResources(this.düzenleToolStripMenuItem, "düzenleToolStripMenuItem");
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Geri_Al;
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            resources.ApplyResources(this.geriAlToolStripMenuItem, "geriAlToolStripMenuItem");
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // ileriAlToolStripMenuItem
            // 
            this.ileriAlToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.İleri_Al;
            this.ileriAlToolStripMenuItem.Name = "ileriAlToolStripMenuItem";
            resources.ApplyResources(this.ileriAlToolStripMenuItem, "ileriAlToolStripMenuItem");
            this.ileriAlToolStripMenuItem.Click += new System.EventHandler(this.ileriAlToolStripMenuItem_Click);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Kes;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            resources.ApplyResources(this.kesToolStripMenuItem, "kesToolStripMenuItem");
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Kopyala;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            resources.ApplyResources(this.kopyalaToolStripMenuItem, "kopyalaToolStripMenuItem");
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Yapıştır;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            resources.ApplyResources(this.yapıştırToolStripMenuItem, "yapıştırToolStripMenuItem");
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Tümünü_seç;
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            resources.ApplyResources(this.tümünüSeçToolStripMenuItem, "tümünüSeçToolStripMenuItem");
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Sil;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            resources.ApplyResources(this.silToolStripMenuItem, "silToolStripMenuItem");
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Bul;
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            resources.ApplyResources(this.bulToolStripMenuItem, "bulToolStripMenuItem");
            this.bulToolStripMenuItem.Click += new System.EventHandler(this.bulToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalınToolStripMenuItem,
            this.italikToolStripMenuItem,
            this.altıÇiziliToolStripMenuItem,
            this.üstüÇiziliToolStripMenuItem,
            this.büyütToolStripMenuItem,
            this.küçütToolStripMenuItem});
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            resources.ApplyResources(this.çıkışToolStripMenuItem, "çıkışToolStripMenuItem");
            // 
            // kalınToolStripMenuItem
            // 
            this.kalınToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Bold;
            this.kalınToolStripMenuItem.Name = "kalınToolStripMenuItem";
            resources.ApplyResources(this.kalınToolStripMenuItem, "kalınToolStripMenuItem");
            this.kalınToolStripMenuItem.Click += new System.EventHandler(this.kalınToolStripMenuItem_Click);
            // 
            // italikToolStripMenuItem
            // 
            this.italikToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Italik;
            this.italikToolStripMenuItem.Name = "italikToolStripMenuItem";
            resources.ApplyResources(this.italikToolStripMenuItem, "italikToolStripMenuItem");
            this.italikToolStripMenuItem.Click += new System.EventHandler(this.italikToolStripMenuItem_Click);
            // 
            // altıÇiziliToolStripMenuItem
            // 
            this.altıÇiziliToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Altı_Çizili;
            this.altıÇiziliToolStripMenuItem.Name = "altıÇiziliToolStripMenuItem";
            resources.ApplyResources(this.altıÇiziliToolStripMenuItem, "altıÇiziliToolStripMenuItem");
            this.altıÇiziliToolStripMenuItem.Click += new System.EventHandler(this.altıÇiziliToolStripMenuItem_Click);
            // 
            // üstüÇiziliToolStripMenuItem
            // 
            this.üstüÇiziliToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Üstü_Çizili;
            this.üstüÇiziliToolStripMenuItem.Name = "üstüÇiziliToolStripMenuItem";
            resources.ApplyResources(this.üstüÇiziliToolStripMenuItem, "üstüÇiziliToolStripMenuItem");
            this.üstüÇiziliToolStripMenuItem.Click += new System.EventHandler(this.üstüÇiziliToolStripMenuItem_Click);
            // 
            // büyütToolStripMenuItem
            // 
            this.büyütToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Büyüt;
            this.büyütToolStripMenuItem.Name = "büyütToolStripMenuItem";
            resources.ApplyResources(this.büyütToolStripMenuItem, "büyütToolStripMenuItem");
            this.büyütToolStripMenuItem.Click += new System.EventHandler(this.büyütToolStripMenuItem_Click);
            // 
            // küçütToolStripMenuItem
            // 
            this.küçütToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Küçült;
            this.küçütToolStripMenuItem.Name = "küçütToolStripMenuItem";
            resources.ApplyResources(this.küçütToolStripMenuItem, "küçütToolStripMenuItem");
            this.küçütToolStripMenuItem.Click += new System.EventHandler(this.küçütToolStripMenuItem_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıTipiToolStripMenuItem,
            this.arkaplanRengiToolStripMenuItem,
            this.yazıTipiToolStripMenuItem1,
            this.yakınlaştırToolStripMenuItem,
            this.uzaklaştırToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            resources.ApplyResources(this.görünümToolStripMenuItem, "görünümToolStripMenuItem");
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Tema;
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            resources.ApplyResources(this.yazıTipiToolStripMenuItem, "yazıTipiToolStripMenuItem");
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);
            // 
            // arkaplanRengiToolStripMenuItem
            // 
            this.arkaplanRengiToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Tema;
            this.arkaplanRengiToolStripMenuItem.Name = "arkaplanRengiToolStripMenuItem";
            resources.ApplyResources(this.arkaplanRengiToolStripMenuItem, "arkaplanRengiToolStripMenuItem");
            this.arkaplanRengiToolStripMenuItem.Click += new System.EventHandler(this.arkaplanRengiToolStripMenuItem_Click);
            // 
            // yazıTipiToolStripMenuItem1
            // 
            this.yazıTipiToolStripMenuItem1.Image = global::NotDefterim.Properties.Resources.Yazı_Fontu;
            this.yazıTipiToolStripMenuItem1.Name = "yazıTipiToolStripMenuItem1";
            resources.ApplyResources(this.yazıTipiToolStripMenuItem1, "yazıTipiToolStripMenuItem1");
            this.yazıTipiToolStripMenuItem1.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem1_Click);
            // 
            // yakınlaştırToolStripMenuItem
            // 
            this.yakınlaştırToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Yakınlaştır;
            this.yakınlaştırToolStripMenuItem.Name = "yakınlaştırToolStripMenuItem";
            resources.ApplyResources(this.yakınlaştırToolStripMenuItem, "yakınlaştırToolStripMenuItem");
            this.yakınlaştırToolStripMenuItem.Click += new System.EventHandler(this.yakınlaştırToolStripMenuItem_Click);
            // 
            // uzaklaştırToolStripMenuItem
            // 
            this.uzaklaştırToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.Uzaklaştır;
            this.uzaklaştırToolStripMenuItem.Name = "uzaklaştırToolStripMenuItem";
            resources.ApplyResources(this.uzaklaştırToolStripMenuItem, "uzaklaştırToolStripMenuItem");
            this.uzaklaştırToolStripMenuItem.Click += new System.EventHandler(this.uzaklaştırToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programcıToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            resources.ApplyResources(this.yardımToolStripMenuItem, "yardımToolStripMenuItem");
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // programcıToolStripMenuItem
            // 
            this.programcıToolStripMenuItem.Image = global::NotDefterim.Properties.Resources.icons8_person_60;
            this.programcıToolStripMenuItem.Name = "programcıToolStripMenuItem";
            resources.ApplyResources(this.programcıToolStripMenuItem, "programcıToolStripMenuItem");
            this.programcıToolStripMenuItem.Click += new System.EventHandler(this.programcıToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Red;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Name = "richTextBox1";
            // 
            // textBox
            // 
            this.textBox.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.Name = "textBox";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ileriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yakınlaştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzaklaştırToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem arkaplanRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalınToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altıÇiziliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üstüÇiziliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem büyütToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küçütToolStripMenuItem;
    }
}


using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NotDefterim
{
    public partial class Form1 : Form
    {
        private int baseFontSize = 14; // Başlangıçta varsayılan metin boyutu
        private string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();
            UpdateButtonStates();

            // Otomatik kaydetme zamanlayıcısını oluşturun
            Timer autoSaveTimer = new Timer();
            autoSaveTimer.Interval = 20000; // 20 saniye (1000 milisaniye x 20)
            autoSaveTimer.Tick += AutoSaveTimer_Tick;
            autoSaveTimer.Start();

            // TextBox'a Enter tuşu basılınca metin aramasını tetikleyen olayı ekle
            textBox.KeyDown += TextBox_KeyDown;
        }

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            // Otomatik kaydetme işlemini gerçekleştirin
            AutoSave();

        }

        private void AutoSave()
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                File.WriteAllText(currentFilePath, richTextBox1.Text);

            }
        }

        // Yazı rengini değiştirmek için renk seçimi yapar
        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }
        private void arkaplanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog bgColor = new ColorDialog();
            if (bgColor.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = bgColor.Color;
            }
        }

        // Yazı tipini değiştirmek için font seçimi yapar
        private void yazıTipiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        // Dosya açma işlemi
        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }

        private void DosyaAc()
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = open.FileName;
                string oku = File.ReadAllText(open.FileName);
                richTextBox1.Text = oku;
            }
        }

        // Dosyayı kaydetme işlemi
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void Kaydet()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                FarkliKaydet();
            }
            else
            {
                // Mevcut dosya varsa, kaydet
                File.WriteAllText(currentFilePath, richTextBox1.Text);
                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi");
            }
        }

        // Dosyayı farklı kaydetme işlemi
        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FarkliKaydet();
        }

        private void FarkliKaydet()
        {
            // Dosya farklı kaydedilecekse, SaveFileDialog kullan
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                currentFilePath = saveFileDialog.FileName;
                MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi");
            }
        }

        // Yardım ile ilgili bilgi mesajı gösterir
        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Programcı frm = new Programcı();
            frm.ShowDialog();
        }

        // Metni yakınlaştırma işlemi
        private void yakınlaştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void ZoomIn()
        {
            baseFontSize += 1;
            richTextBox1.Font = new System.Drawing.Font("Consolas", baseFontSize);
            UpdateButtonStates();
        }

        // Metni uzaklaştırma işlemi
        private void uzaklaştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void ZoomOut()
        {
            if (baseFontSize > 1)
            {
                baseFontSize -= 1;
                richTextBox1.Font = new System.Drawing.Font("Consolas", baseFontSize);
                UpdateButtonStates();
            }
        }

        // Buton durumlarını güncelleme işlemi
        private void UpdateButtonStates()
        {
            uzaklaştırToolStripMenuItem.Enabled = baseFontSize > 1;
            yakınlaştırToolStripMenuItem.Enabled = baseFontSize < 200;
            geriAlToolStripMenuItem.Enabled = richTextBox1.CanUndo;
            ileriAlToolStripMenuItem.Enabled = richTextBox1.CanRedo;
            kesToolStripMenuItem.Enabled = richTextBox1.SelectionLength > 0;
            kopyalaToolStripMenuItem.Enabled = richTextBox1.SelectionLength > 0;
            yapıştırToolStripMenuItem.Enabled = Clipboard.ContainsText();
            tümünüSeçToolStripMenuItem.Enabled = richTextBox1.TextLength > 0;
            silToolStripMenuItem.Enabled = richTextBox1.SelectionLength > 0;
            bulToolStripMenuItem.Enabled = richTextBox1.Text.Length > 0;
        }

        // Geri alma işlemi
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformUndo();
        }

        private void PerformUndo()
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
                UpdateButtonStates();
            }
        }

        // İleri alma işlemi
        private void ileriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformRedo();
        }

        private void PerformRedo()
        {
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo();
                UpdateButtonStates();
            }
        }

        // Kesme işlemi
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void CutText()
        {
            richTextBox1.Cut();
            UpdateButtonStates();
        }

        // Kopyalama işlemi
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void CopyText()
        {
            richTextBox1.Copy();
            UpdateButtonStates();
        }

        // Yapıştırma işlemi
        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void PasteText()
        {
            richTextBox1.Paste();
            UpdateButtonStates();
        }

        // Tümünü seçme işlemi
        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllText();
        }

        private void SelectAllText()
        {
            richTextBox1.SelectAll();
            UpdateButtonStates();
        }

        // Seçili metni silme işlemi
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedText();
        }

        private void DeleteSelectedText()
        {
            richTextBox1.SelectedText = string.Empty;
            UpdateButtonStates();
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer Enter tuşuna basıldıysa ve TextBox içinde metin varsa, metin aramasını yap
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBox.Text))
            {
                SearchText(textBox.Text);
            }
        }

        // Metin arama işlemi
        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchText(textBox.Text);
        }

        private void SearchText(string searchTerm)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {
                int index = richTextBox1.Text.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase);

                if (index != -1)
                {
                    // Metinde bulunan ilk terimi seç
                    richTextBox1.Select(index, searchTerm.Length);
                    richTextBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Arama terimi bulunamadı.", "Arama Sonucu");
                }
            }
            else
            {
                MessageBox.Show("Arama terimi girmelisiniz.", "Arama Sonucu");
            }
        }


        // Yeni bir not defteri açma işlemi
        private void yeniNotDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void newFile()
        {
            Process.Start(Application.ExecutablePath);
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Eğer metin seçili ise
            if (richTextBox1.SelectionLength > 0)
            {
                // Kalın (bold) yazı tipini toggle (aç/kapat) et
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void italikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Eğer metin seçili ise
            if (richTextBox1.SelectionLength > 0)
            {
                // İtalik yazı stili toggle (aç/kapat) et
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                // Altı çizgili yazı stili toggle (aç/kapat) et
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void üstüÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                // Üstü çizgili yazı stili toggle (aç/kapat) et
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Strikeout ? FontStyle.Regular : FontStyle.Strikeout;

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void büyütToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                // Mevcut font boyutunu al ve +1 ekleyerek yeni bir font oluştur
                Font currentFont = richTextBox1.SelectionFont;
                float newSize = currentFont.Size + 1;
                Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);

                // Yeni fontu uygula
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void küçütToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {

                Font currentFont = richTextBox1.SelectionFont;
                float newSize = currentFont.Size - 1;
                Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);

                // Yeni fontu uygula
                richTextBox1.SelectionFont = newFont;
            }
        }
    }
}

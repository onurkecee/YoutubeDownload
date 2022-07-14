using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using System.IO;
using System.Net;

namespace YoutubeDownload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean format = true;

        private async void btnIndir_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text != "")
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Nereye İndirmek İstiyorsun ?" })
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        GetTitle();
                        MessageBox.Show("İndirme Başlatıldı. Lütfen Bekleyiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var yt = YouTube.Default;
                        var video = await yt.GetVideoAsync(txtUrl.Text);
                        File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                        var inputfile = new MediaToolkit.Model.MediaFile { Filename = fbd.SelectedPath + @"\" + video.FullName };
                        var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{fbd.SelectedPath + @"\" + video.FullName }.mp3" };


                        using (var enging = new Engine())
                        {
                            enging.GetMetadata(inputfile);
                            enging.Convert(inputfile, outputfile);
                        }

                        if (format == true)
                        {
                            File.Delete(fbd.SelectedPath + @"\" + video.FullName);
                        }
                        else
                        {
                            File.Delete($"{fbd.SelectedPath + @"\" + video.FullName}.mp3");
                        }

                        progressBar1.Value = 100;

                        MessageBox.Show("İndirme İşlemi Tamamlandı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Dosya Yolu Seçiniz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void radiomp3_CheckedChanged(object sender, EventArgs e)
        {
            format = true;
        }

        private void radiomp4_CheckedChanged(object sender, EventArgs e)
        {
            format = true;
        }

        void GetTitle()
        {
            WebRequest istek = HttpWebRequest.Create(txtUrl.Text);
            WebResponse yanit = istek.GetResponse();
            StreamReader sr = new StreamReader(yanit.GetResponseStream());
            string gelen = sr.ReadToEnd();
            int baslangic = gelen.IndexOf("<title>") + 7;
            int bitis = gelen.Substring(baslangic).IndexOf("</title>");
            string gelenbilgi = gelen.Substring(baslangic, bitis);
            lblYazi.Text = (gelenbilgi);
        }
    }
}

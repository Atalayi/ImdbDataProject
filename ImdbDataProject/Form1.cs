using HtmlAgilityPack;
using ImdbDataProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImdbDataProject
{
    public partial class Form1 : Form
    {
        ImdbDBContext dBContext;
        public Form1()
        {
            dBContext = new ImdbDBContext();
            InitializeComponent();
        }

        private void btnGetInfos_Click(object sender, EventArgs e)
        {

            string searchMovie = txtMovieName.Text.Replace(" ", "+").Trim();
            string link = $"https://www.imdb.com/search/title/?title={searchMovie}";

            WebClient webClient = new WebClient();
            var uri = new Uri(link);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";

            string html = webClient.DownloadString(link);
            HtmlAgilityPack.HtmlDocument document = new();
            document.LoadHtml(html);

            string movieID = document.DocumentNode.SelectSingleNode("//img[@class='loadlate']").Attributes["data-tconst"].Value;

            if (!dBContext.Set<Tblmovie>().Any(x => x.Id == movieID))
            {

                string movieName = document.DocumentNode.SelectSingleNode("//*[@id='main']/div/div[3]/div/div[1]/div[3]/h3/a").InnerText.Trim();
                string explanation = document.DocumentNode.SelectSingleNode("//*[@id='main']/div/div[3]/div/div[1]/div[3]/p[2]").InnerText.Trim();

                //İkinci link için ayrı yapı
                var uri2 = new Uri($"https://www.imdb.com/title/{movieID}");

                string html2 = webClient.DownloadString(uri2);
                HtmlAgilityPack.HtmlDocument documentExtra = new();
                documentExtra.LoadHtml(html2);

                var picture = documentExtra.DocumentNode.SelectSingleNode("//*[@id='__next']/main/div/section[1]/section/div[3]/section/section/div[3]/div[1]/div/div[1]/div/div[1]/img");

                if (picture != null)
                {
                    pctMovie.Load(picture.Attributes["src"].Value);
                }
                else
                {
                    pctMovie.Load("C:/Users/Semih/source/repos/ImdbDataProject/ImdbDataProject/default-bg.jpg");
                }

                var writers = documentExtra.DocumentNode.SelectNodes("//ul[@class='ipc-metadata-list ipc-metadata-list--dividers-all title-pc-list ipc-metadata-list--baseAlt']//li[2][@class='ipc-metadata-list__item']//div[@class='ipc-metadata-list-item__content-container']//ul[@class='ipc-inline-list ipc-inline-list--show-dividers ipc-inline-list--inline ipc-metadata-list-item__list-content baseAlt']//li//a");

                if (writers == null)
                    writers = documentExtra.DocumentNode.SelectNodes("//*[@id='__next']/main/div/section[1]/section/div[3]/section/section/div[3]/div[2]/div[1]/div[3]/ul/li[2]/div/ul");

                var directors = documentExtra.DocumentNode.SelectNodes("//ul[@class='ipc-metadata-list ipc-metadata-list--dividers-all title-pc-list ipc-metadata-list--baseAlt']//li[@class='ipc-metadata-list__item']//div[@class='ipc-metadata-list-item__content-container']//ul[@class='ipc-inline-list ipc-inline-list--show-dividers ipc-inline-list--inline ipc-metadata-list-item__list-content baseAlt']//li//a");

                var stars = documentExtra.DocumentNode.SelectNodes("//ul[@class='ipc-metadata-list ipc-metadata-list--dividers-all title-pc-list ipc-metadata-list--baseAlt']//li[3]//div//ul//li//a");

                if (stars == null)
                    stars = documentExtra.DocumentNode.SelectNodes("//div[@class='sc-910a7330-4 kcpPzf']//div[@class='sc-fa02f843-0 fjLeDR']//ul[@class='ipc-metadata-list ipc-metadata-list--dividers-all title-pc-list ipc-metadata-list--baseAlt']//li[2]//div[@class='ipc-metadata-list-item__content-container']//ul//li//a");

                string fullStars = "";
                lstStars.Items.Clear();

                if (stars != null)
                {
                    foreach (var item in stars)
                    {
                        if (!lstStars.Items.Contains(item.InnerText))
                        {
                            lstStars.Items.Add(item.InnerText);
                            fullStars += item.InnerText + ", ";
                        }
                    }
                }
                else
                {
                    fullStars = "-";
                }

                string fullDirectors = "";
                lstDirectors.Items.Clear();

                if (directors != null)
                {
                    foreach (var item in directors)
                    {
                        if (!lstDirectors.Items.Contains(item.InnerText))
                        {
                            lstDirectors.Items.Add(item.InnerText);
                            fullDirectors += item.InnerText + ", ";
                        }
                    }
                }
                else
                {
                    fullDirectors = "-";
                }

                string fullWriters = "";
                lstWriters.Items.Clear();

                if (writers != null)
                {
                    foreach (var item in writers)
                    {
                        if (!lstWriters.Items.Contains(item.InnerText))
                        {
                            lstWriters.Items.Add(item.InnerText);
                            fullWriters += item.InnerText + ", ";
                        }
                    }
                }
                else
                {
                    fullWriters = "-";
                }

                #region Fill Datas
                lblMovieName.Text = movieName;
                richtxtExplanation.Text = explanation;

                #region Download Pictures
                string path = @"C:\Users\Semih\source\repos\ImdbDataProject\ImdbDataProject\bin\Debug\net5.0-windows\\pictures\" + movieID + @"\";
                if (Directory.Exists(path) == false)
                    Directory.CreateDirectory(path);
                pctMovie.Image.Save(path + movieID + ".jpg");

                #endregion

                Tblmovie tblmovie = new Tblmovie();
                tblmovie.Id = movieID;
                tblmovie.Name = movieName;
                tblmovie.Picture = path;
                tblmovie.Explanation = explanation;
                tblmovie.Writer = fullWriters;
                tblmovie.Stars = fullStars;
                tblmovie.Director = fullDirectors;

                AddMovieInfos(tblmovie);
            }

            else
            {
                
                var localMovie = dBContext.Set<Tblmovie>().FirstOrDefault(x => x.Id == movieID);

                string appPath = @"C:\Users\Semih\source\repos\ImdbDataProject\ImdbDataProject\bin\Debug\net5.0-windows\\pictures\" + movieID + @"\";

                if (File.Exists(appPath + movieID + ".jpg"))

                    pctMovie.Image = new Bitmap(appPath + movieID + ".jpg");

                else pctMovie.Image = null;


                if (localMovie.Name != null)
                {
                    lblMovieName.Text = localMovie.Name;
                }
                else
                {
                    lblMovieName.Text = "";
                }


                richtxtExplanation.Text = localMovie.Explanation;


                lstWriters.Items.Clear();
                if (localMovie.Writer == null)
                {
                    lstWriters.Items.Add("Sonuç bulunamadı.");
                }
                else
                {
                    var localWriters = localMovie.Writer.Split(", ");
                    foreach (var item in localWriters)
                    {
                        lstWriters.Items.Add(item);
                    }
                }

                lstStars.Items.Clear();
                if (localMovie.Stars == null)
                {
                    lstStars.Items.Add("Sonuç bulunamadı.");
                }
                else
                {
                    var localStars = localMovie.Stars.Split(", ");
                    foreach (var item in localStars)
                    {
                        lstStars.Items.Add(item);
                    }
                }

                lstDirectors.Items.Clear();
                if (localMovie.Director == null)
                {
                    lstDirectors.Items.Add("Sonuç bulunamadı.");
                }
                else
                {
                    var localDirector = localMovie.Director.Split(", ");
                    foreach (var item in localDirector)
                    {
                        lstDirectors.Items.Add(item);
                    }
                }

                MessageBox.Show("Veri veritabanından alındı.");
            }
            #endregion

        }

        public void AddMovieInfos(Tblmovie p) // calling SaveStudentMethod for insert a new record    
        {
            using (ImdbDBContext dBContext = new ImdbDBContext())
            {
                try
                {
                    dBContext.Tblmovies.Add(p);
                    dBContext.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt işlemi yapılamadı.");
                }
            }
        }

        private void txtMovieName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGetInfos_Click(this, new EventArgs());
        }

    }
}

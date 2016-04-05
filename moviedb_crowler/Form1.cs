using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace moviedb_crowler
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
            
        }
        //string strbaglanti = "Data Source=RAMAZAN-PC\\SQLEXPRESS;Initial Catalog=movie_db;Integrated Security=True";
        //SqlConnection baglan;
        //SqlCommand cmd;

        public string tag;
        public string klass;
        public string film_yönetmen;
        public string film_yazar;
        public string film_oyuncu;
        public string film_dili;
        public string film_aciklama;
        public string film_imdb_puan;
        public string veristr;
        int sayfa = 1;
        int page;
        string turimdb="action";
        public string tagad;
        public int sayac = 0; 
        HtmlElementCollection hc;
       
        public void veri_yenilethemoviedb() 
        {
            sayfa++;
            webBrowser1.Refresh();
            webBrowser1.Navigate("https://www.themoviedb.org/movie?page=" + sayfa);
            webBrowser1.Refresh();
        }

       public void veri_yenileİMDB(string tur) 
        {
            page = sayfa + 50;
            webBrowser1.Refresh();
            webBrowser1.Navigate("http://www.imdb.com/search/title?genres="+tur+"&sort=moviemeter,asc&start="+page+"&title_type=feature");
            webBrowser1.Refresh();
        }
        
      public void veri_cekthemoviedb() 
        {      
            hc = webBrowser1.Document.All;
            foreach (HtmlElement veri in hc) //aldığım ilk verilerle işlem yaptım
            {
                if (veri.GetAttribute("classname").Contains("title"))
                {
                    listBox1.Items.Add(veri.InnerText);    
                }
                if (veri.GetAttribute("classname").Contains("release_date"))
                {  
                    listBox2.Items.Add(veri.InnerText);
                }
                if (veri.GetAttribute("classname").Contains("genres"))
                {  
                    listBox8.Items.Add(veri.InnerText);
                }
                if (veri.GetAttribute("classname").Contains("overview"))
                {
                      listBox4.Items.Add(veri.InnerText);
                }
                if (veri.GetAttribute("classname").Contains("vote_average"))
                {
                    listBox3.Items.Add(veri.InnerText);
                }
            }
           
        }

      public string tur_degistir(string gtur) 
      {
          switch (gtur)
          {
              case "action": turimdb = "comedy"; break;
              case "comedy": turimdb = "drama"; break;
              case "drama": turimdb = "war"; break;

              default: MessageBox.Show("tür değiştirilirken bir hata oldu");
                  break;
          }
          return turimdb;      
      }

      public void veri_cekimdb()
      {
          hc = webBrowser1.Document.GetElementsByTagName("td").GetElementsByName("title");


          foreach (HtmlElement veri in hc) //aldığım ilk verilerle işlem yaptım
          {
              if (veri.GetAttribute("href").Contains("/title/"))
              {
                  sayac++;
                  listBox1.Items.Add(veri.InnerText);

              }

              if (veri.GetAttribute("classname").Contains("year_type"))
              {


                  listBox2.Items.Add(veri.InnerText);

              }

              if (veri.GetAttribute("classname").Contains("value"))
              {


                  listBox3.Items.Add(veri.InnerText);

              }
              if (veri.GetAttribute("classname").Contains("outline"))
              {


                  listBox4.Items.Add(veri.InnerText);

              }
               if (veri.GetAttribute("classname").Contains("credit"))
              {


                  listBox5.Items.Add(veri.InnerText);

              }
               if (veri.GetAttribute("classname").Contains("genre"))
               {


                   listBox8.Items.Add(veri.InnerText);

               }
               if (veri.GetAttribute("classname").Contains("runtime"))
               {


                   listBox6.Items.Add(veri.InnerText);

               }
               if (!(sayac <= 5000)) 
               {
                   tur_degistir(turimdb);
               
               }
          }

      }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(webBrowser1);
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.AllowNavigation = true;
            webBrowser1.Navigate("https://www.themoviedb.org/movie");
      
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox_ARA.Text);
       
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            veri_yukle.Stop();
            data_cek.Stop();
            imdbveriyukle.Stop();
            imdb_veri_cek.Stop();
           
        }

        private void element1_ver_Click(object sender, EventArgs e)
        {
            veri_yukle.Start();
            data_cek.Start();
          
            
            //baglan = new SqlConnection(strbaglanti);
            //baglan.Open();

                     //try
                     //{
                     //    cmd = new SqlCommand("INSERT INTO [dbo].[Filmler] ([film_adi],[film_yılı],[yönetmenler],[yazarlar],[oyuncular],[film_dili],[film_aciklamasi],[imdb_puanı]) VALUES (@fadi,@fyil,@fyonetmen,@fyazar,@foyuncu,@fdil,@faciklama,@fpuan,)", baglan);
                     //    cmd.Parameters.AddWithValue("@fadi", film_adi);
                     //    cmd.Parameters.AddWithValue("@fyil", film_yil);
                     //    cmd.Parameters.AddWithValue("@fyonetmen", film_yönetmen);
                     //    cmd.Parameters.AddWithValue("@fyazar", film_yazar);
                     //    cmd.Parameters.AddWithValue("@foyuncu", film_oyuncu);
                     //    cmd.Parameters.AddWithValue("@fdil", film_dili);
                     //    cmd.Parameters.AddWithValue("@faciklama", film_aciklama);
                     //    cmd.Parameters.AddWithValue("@fpuan", film_imdb_puan);
                     //    cmd.ExecuteNonQuery();
                     //}
                     //catch(Exception hata)
                     //{
                     //    MessageBox.Show(hata.Message);
                     //}   
            //baglan.Close();
                 }

        private void timer1_Tick(object sender, EventArgs e)
        {
            veri_yenilethemoviedb();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            veri_cekthemoviedb();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            imdbveriyukle.Start();
            imdb_veri_cek.Start();

        }

        private void imdbveriyukle_Tick(object sender, EventArgs e)
        {
            veri_yenileİMDB(turimdb);
        }

        private void imdb_veri_cek_Tick(object sender, EventArgs e)
        {
            veri_cekimdb();
        }




             }
         }
            
         
             
      

        
    


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class DLG_Help : Form
    {
        
        public string FileName;
        public DLG_Help()
        {
            InitializeComponent();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void DLG_Help_Load(object sender, EventArgs e)
        {

            
            string curDir = Directory.GetCurrentDirectory();

            string ResourcesDir = @"C:\Users\201756835\Source\Repos\TP3-PictureViewer2\Resources\HTMLPage1.html";
                /*System.Reflection.Assembly.GetExecutingAssembly().Location + @"\..\..\Resources\" + FileName + ".html"*/;
            File.Exists(ResourcesDir);
            //File.Copy(ResourcesDir, curDir);
            //webBrowser1.Source = new Uri(new System.IO.FileInfo("page.html").FullName);
            //Uri UrlNavigate = new Uri(Tool.htm); 
            Uri UrlNavigate = new Uri(String.Format("file:///{0}/{1}.html", curDir, FileName));

            webBrowser1.Navigate(UrlNavigate);

            //webBrowser1.DocumentText = html;

            //string[] a = Assembly.GetEntryAssembly().GetManifestResourceNames();
            //foreach (string s in a) Debug.WriteLine("\t" + s);
            //string html = null;
            //using (var s = Assembly.GetExecutingAssembly().GetManifestResourceStream("[HTMLpage1.html]"))
            //using (var r = new StreamReader(s))
            //html = r.ReadToEnd();
            //webBrowser1.DocumentText = html;
        }
    }
}

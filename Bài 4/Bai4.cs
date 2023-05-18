using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Lab4
{
    
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }


      
        private void button2_Click(object sender, EventArgs e)
        {
            WebClient client  = new WebClient();

            client.DownloadFile(urlTB.Text, @"DownLoad.html");

        }

        private void viewBT_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri(urlTB.Text);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            var html = getHTML(urlTB.Text);
            ViewSource viewSoure = new ViewSource(html);
            viewSoure.Show();
        }




    }
}

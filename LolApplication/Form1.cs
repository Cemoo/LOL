using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiotSharp;
using System.Net;
using System.IO;

namespace LolApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string apiKey = "e083385e-3da0-4468-9d9e-02b1ae0865a2";
        private void Form1_Load(object sender, EventArgs e)
        {
            var req = WebRequest.Create("https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/RiotSchmick?api_key=e083385e-3da0-4468-9d9e-02b1ae0865a2");
            var response = (HttpWebResponse)req.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            richTextBox1.Text += responseString;
        }
    }
}

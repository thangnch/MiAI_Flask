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

namespace MiAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Ham goi HTTP Get len server
        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Goi len server va tra ve ket qua
            String server_ip = "192.168.8.108";
            String server_path = "http://" + server_ip + ":8000/hello_world?staff_id=" + textBox1.Text;
            String retStr = Get(server_path);

            // Hien thi noi dung tra ve len man hinh
            MessageBox.Show(retStr);
        }
    }
}

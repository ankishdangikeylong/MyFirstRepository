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
using System.Collections.Specialized;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			String result;
			string apiKey = txtapi.Text;
			string route = "v3";
			string sender_id = txtsender.Text;
			string message = txtmess.Text;
			string language = "english";
			string numbers = txtnum.Text;
			string flash = "0";
			

				String url = "https://www.fast2sms.com/dev/bulkV2?authorization=SO6koZAI8eSsHetNBIuVgmhZMta5bK2MKBspLql0jza9VksbDaje5VDHBjMs&route=v3&sender_id=FTWSMS&message=&language=english&flash=0&numbers=" + apiKey + "&route=" + route +"&sender_id=" + sender_id + "&message=" + message + "&language=" + language + "&numbers=" + numbers + "&flash=" + flash;
				//refer to parameters to complete correct url string

				StreamWriter myWriter = null;
				HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

				objRequest.Method = "POST";
				objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
				objRequest.ContentType = "application/x-www-form-urlencoded";
				try
				{
					myWriter = new StreamWriter(objRequest.GetRequestStream());
					myWriter.Write("https://www.fast2sms.com/dev/bulkV2?authorization=SO6koZAI8eSsHetNBIuVgmhZMta5bK2MKBspLql0jza9VksbDaje5VDHBjMs&route=v3&sender_id=FTWSMS&message=&language=english&flash=0&numbers=");
				}
				catch (Exception ex)
				{
				//return e.Message;
				MessageBox.Show(null, "the error is" + ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				finally
				{
					//myWriter.Close();
				}

				HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
				using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
				{
					result = sr.ReadToEnd();
					// Close and clean up the StreamReader
					sr.Close();
				}
			//return result;
			MessageBox.Show(result);

		}
	}
	}

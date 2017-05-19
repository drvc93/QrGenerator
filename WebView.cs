using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrGenerator
{
    public partial class WebView : Form
    {
         public string shtml ;
        public WebView()
        {
            InitializeComponent();
        }

        private void WebView_Load(object sender, EventArgs e)
        {
            IESetupFooter();
            webBrowser1.DocumentText = shtml;
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {   
            webBrowser1.Document.Body.Style = "zoom:300%;";
           
        }

        public void IESetupFooter()
        {

            string strKey = "Software\\Microsoft\\Internet Explorer\\PageSetup";
            bool bolWritable = true;
            string strName = "footer";
            object oValue = "Test Footer";
            RegistryKey oKey = Registry.CurrentUser.OpenSubKey(strKey, bolWritable);
            Console.Write(strKey);
            oKey.SetValue(strName, oValue);
            oKey.Close();
        }
    }
}

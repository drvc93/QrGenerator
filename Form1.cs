using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding.Windows.Forms;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace QrGenerator
{
    public partial class Form1 : Form
    {
        DataTable data;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            XDocument XML = new XDocument();


            // byte[] img = Convert.FromBase64String(
            string sCod = "";

            for (int i = 0; i < data.Rows.Count; i++)
            {
                sCod = data.Rows[i]["CodigoFitrro"].ToString();
                Bitmap b = GenerateQRCode(sCod, Color.Black, Color.White);
                Image img = (Image) b;
                img = resizeImage(img, 100, 100);
                img.Save("D:\\Imgsqr\\" + sCod + ".Jpeg", ImageFormat.Jpeg);




            }
            /* SaveFileDialog dialog = new SaveFileDialog();
             if (dialog.ShowDialog() == DialogResult.OK)
             {
                 b.Save(dialog.FileName + ".png", ImageFormat.Png);
             }*/
        }

        private Bitmap GenerateQRCode(string text, System.Drawing.Color DarkColor, System.Drawing.Color LightColor)
        {
            Gma.QrCodeNet.Encoding.QrEncoder Encoder = new Gma.QrCodeNet.Encoding.QrEncoder(Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.H);
            Gma.QrCodeNet.Encoding.QrCode Code = Encoder.Encode(text);
            Bitmap TempBMP = new Bitmap(Code.Matrix.Width, Code.Matrix.Height);
            // Bitmap TempBMP = new Bitmap(48, 48);
            for (int X = 0; X <= Code.Matrix.Width - 1; X++)
            {
                for (int Y = 0; Y <= Code.Matrix.Height - 1; Y++)
                {
                    if (Code.Matrix.InternalArray[X, Y])
                        TempBMP.SetPixel(X, Y, DarkColor);
                    else
                        TempBMP.SetPixel(X, Y, LightColor);
                }
            }
            return TempBMP;
        }

        private void btnAddCod_Click(object sender, EventArgs e)
        {

            if (gvCodigosLista.DataRowCount <= 0)
            {
                data = CreateDatatable();
                InsertData(1, txtCod.Text);

            }
            else
            {
                InsertData(data.Rows.Count + 1, txtCod.Text);
            }

            gvCodigos.DataSource = data;
        }

        public DataTable CreateDatatable()
        {
            DataTable table = new DataTable();

            DataColumn col1 = new DataColumn("Numero");
            DataColumn col2 = new DataColumn("CodigoFitrro");

            //col1.DataType = System.Type.GetType("System.Int");
            //col2.DataType = System.Type.GetType("System.String");

            table.Columns.Add(col1);
            table.Columns.Add(col2);

            return table;

        }

        public void InsertData(int nro, string cod)
        {
            int nrorow = 0;

            if (data.Rows.Count > 0)
            {
                nrorow = data.Rows.Count + 1;
            }

            DataRow row = data.NewRow();
            row[0] = nro;
            row[1] = cod;
            data.Rows.Add(row);
        }


        public static Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image) new_image);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[]) converter.ConvertTo(img, typeof(byte[]));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string html_head = " <body> ";
            string sBody = "";
            string sFoot = "</body>";
            string sCod = "";
            for (int i = 0; i < data.Rows.Count; i++)
            {
                sCod = data.Rows[i]["CodigoFitrro"].ToString();
                Bitmap b = GenerateQRCode(sCod, Color.Black, Color.White);
                //Image img = (Image)b;
                //img = resizeImage(img, 100, 100);
                //  img.Save("D:\\Imgsqr\\" + sCod + ".Jpeg", ImageFormat.Jpeg);
                //  string s = Convert.ToBase64String()
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                b.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] byteImage = ms.ToArray();

                string SigBase64 = Convert.ToBase64String(byteImage); //Get Base64

                sBody = sBody + " <img alt='Embedded Image'  src='data:image/jpeg;base64," + SigBase64 + "' /> <br /> <br /> ";


            }

            string Html = html_head + sBody + sFoot;

            Html = Html;

            WebView w = new WebView();
            w.shtml = Html;
            w.Show();
            
        }
    }
}

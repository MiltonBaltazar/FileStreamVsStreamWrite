using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteFile
{
    public partial class frmWrite : Form
    {
        public frmWrite()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rbtFileStream.Checked)
            {
                WriteFileStream();
            }
            if(rbtWriteStream.Checked)
            {
                StreamWriter();
            }
        }

        private void WriteFileStream()
        {
            string[] inLorem = new string[3];

            inLorem[0] = rtbInputFile1.Text;
            inLorem[1] = rtbInputFile2.Text;
            inLorem[2] = rtbInputFile3.Text;
           
            string fileIn = txtFullPath.Text;
            int max = (int)nudBucle.Value;
            int count = 1;
            pgbProgress.Maximum = max;
            pgbProgress.Value = 0;
            //StringBuilder str
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

            using (FileStream sw = new FileStream(fileIn, FileMode.Append))
            {
                byte[] byte2string;

                for(int index = 0; index < inLorem.Length; index++)
                {
                    while (count <= max)
                    {
                        byte2string = Encoding.UTF8.GetBytes(inLorem[index]);
                        //sw.WriteAsync(byte2string, 0, byte2string.Length);
                        sw.Write(byte2string, 0, byte2string.Length);
                        sw.Flush();

                        pgbProgress.Value = count;
                        count++;
                    }

                }

                byte2string = null;
                sw.Flush();
                sw.Dispose();                 
            }

            stop = new TimeSpan(DateTime.Now.Ticks);
            lblSeconds.Text = string.Format("Segundos: {0}", stop.Subtract(start).Seconds);
            lblMiliseconds.Text = string.Format("Milisegundos: {0}", stop.Subtract(start).TotalMilliseconds);
        }


        private void StreamWriter()
        {
            string[] inLorem = new string[3];

            inLorem[0] = rtbInputFile1.Text;
            inLorem[1] = rtbInputFile2.Text;
            inLorem[2] = rtbInputFile3.Text;

            string fileIn = txtFullPath.Text;
            int max = (int)nudBucle.Value;
            int count = 1;
            pgbProgress.Maximum = max;
            pgbProgress.Value = 0;
            //StringBuilder str
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

            using (StreamWriter sw = new StreamWriter(fileIn, true, Encoding.UTF8, 65536))
            {
                sw.AutoFlush = true;

                for (int index = 0; index < inLorem.Length; index++)
                {
                    while (count <= max)
                    {
                        sw.WriteLine(inLorem[index]);
                        pgbProgress.Value = count;
                        count++;
                    }

                }
                sw.Flush();
                sw.Dispose();
            }

            stop = new TimeSpan(DateTime.Now.Ticks);
            lblSeconds.Text = string.Format("Segundos: {0}", stop.Subtract(start).Seconds);
            lblMiliseconds.Text = string.Format("Milisegundos: {0}", stop.Subtract(start).TotalMilliseconds);
        }

        //private void FileRead()
        //{
        //    string textIn = rtbInputFile1.Text;
        //    string fileIn = txtFullPath.Text;

        //    using (var sr = new StringReader(txtFullPath.Text))
        //    {
        //        using (FileStream outputStream = new FileStream(fileIn, FileMode.Append))
        //        {
        //            char[] buffer = new char[10];
        //            int numChars;
        //            while ((numChars = sr.ReadBlock(buffer, 0, buffer.Length)) > 0)
        //            {
        //                char[] temp = new char[numChars];
        //                Array.Copy(buffer, 0, temp, 0, numChars);
        //                byte[] byteBuffer = Encoding.UTF8.GetBytes(temp);
        //                outputStream.Write(byteBuffer, 0, byteBuffer.Length);
        //            }
        //        }
        //    }
        //}

    }
}

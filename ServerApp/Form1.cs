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
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ServerApp
{

    public partial class Form1 : Form

    {
        //2 iş
        //ıo
        Thread t;  
        IPAddress ip;
        TcpListener listener;
        TcpClient client;
        NetworkStream ag;
        private StreamReader oku;
        StreamWriter yaz;
        public delegate void ricdegis(string text);
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }
       
        public void OkuBasla() // Port dinle
        {
            client = listener.AcceptTcpClient();
            ag = client.GetStream();
            while (true)
            {
                try
                {


                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch (Exception)
                {
                    //MessageBox.Show("başlamadı");
                }
            }
        }

        public void ekranabas(string yazi)
        {
            if (this.InvokeRequired)//thread
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, yazi);
            }
            else
            {

                yazi = "Client" + yazi;
                // yazi = “Client” +yazi;
                txtEkran.AppendText(yazi + "\n");
                    
            }
        }


        private void dinlemeye_basla() // 80 portu
        {
            try
            {
                ip = IPAddress.Parse("127.0.0.1");
                listener = new TcpListener(ip, 123);
                listener.Start();
                t = new Thread(new ThreadStart(OkuBasla));
                t.Start();
                txtEkran.AppendText(DateTime.Now.ToString() + "Dinleme baslatildi\n");
               
            }
            catch (Exception)
            {
                MessageBox.Show("dinleme Başlamadi");
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            dinlemeye_basla();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtGonder.Text == "")

                return;
            else
            {
                yaz = new StreamWriter(ag); //s ekrana yaz
                yaz.WriteLine(txtGonder.Text); 
                yaz.Flush();//tmpnb
                txtEkran.AppendText(txtGonder.Text + "\n");
                txtGonder.Text = "";
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
          
                ag.Close();
            
            
        }
    }
}

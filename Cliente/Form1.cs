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
using System.Threading;

namespace Cliente
{
    public partial class Form1 : Form
    {

        string output = "";
        NetworkStream stream_M = null;
        byte[] byte_M_Recibir = new byte[256];
        byte[] byte_M_Enviar = new byte[256];
        string mstrMessage;
        Thread M_R;

        public String GetlocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }

            return "127.0.0.1";
        }
        public void C_Manager()
        {

            try
            {
                TcpClient client = new TcpClient(IP_manager.Text, Convert.ToInt32(N_puerto.Text));
                stream_M = client.GetStream();
            }
            catch (Exception e_M)
            {
                output = "Error: " + e_M.ToString();
                MessageBox.Show(output);
            }

            B_C_M.Text = "Conectado a Manager";

        }
        public void Recibir_Manager()
        {
            while (true)
            {
                B_Recibir_M.Text = "En espera...";
                Thread.Sleep(1000);
                stream_M.Read(byte_M_Recibir, 0, byte_M_Recibir.Length);
                mstrMessage = Encoding.ASCII.GetString(byte_M_Recibir, 0, byte_M_Recibir.Length);
                mstrMessage = mstrMessage.Substring(0, 30);
                B_Recibir_M.Text = "Recibido";
                Mensaje_R_M.Text = mstrMessage;
            }
        }

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            IP_local.Text = GetlocalIp();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B_C_M_Click(object sender, EventArgs e)
        {
            C_Manager();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            M_R = new Thread(Recibir_Manager);
            M_R.Start();

        }

        private void B_Enviar_M_Click(object sender, EventArgs e)
        {
            byte_M_Enviar = System.Text.Encoding.ASCII.GetBytes(Mensaje_E_M.Text);
            stream_M.Write(byte_M_Enviar, 0, byte_M_Enviar.Length);

        }
    }
}

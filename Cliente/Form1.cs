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
using Newtonsoft.Json;

namespace Cliente
{
    public partial class Form1 : Form
    {
        //Socket listen = 
        
        public Form1()
        {
            InitializeComponent();
            
            
        }

      




        

        //public string recibirMensaje(string ip) {
        //    conectar = new IPEndPoint(IPAddress.Parse(ip), 6400);
        //    listen.Bind(conectar);
        //    //Numero maximo de conexciones
        //    listen.Listen(10);
        //    conexion = listen.Accept();

        //    byte[] recibir_mensaje = new byte[1000];
        //    string data = "";
        //    int array_size = 0;
        //    //Creamos exacatamente la longitud con el cuial no esta llegando el mensaje
        //    array_size = conexion.Receive(recibir_mensaje, 0, recibir_mensaje.Length, 0);
        //    //se ajusa justamente con la bits q necesitamos
        //    Array.Resize(ref recibir_mensaje, array_size);

        //    data = Encoding.Default.GetString(recibir_mensaje);
        //    return data;
        //}

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            // enviarMensaje("10.187.46.226");
            // recibirMensaje("10.187.46.226");

            //json();
            ConexionCliente cc = new ConexionCliente("10.187.46.226", 6400);
            cc.inicioSocket();
            cc.enviarMensaje(textBox1.Text);

            MessageBox.Show("hoal" + cc.recibirMensaje());
        }
        public void json() {
            string jsons = @"{
                   'x': 'Intel',
                   'y': '500W'
                   
                }";
            PC pc = JsonConvert.DeserializeObject<PC>(jsons);
            MessageBox.Show(pc.x);
        }
        struct PC
        {
            public string x;
            public string y;

            public PC(string x, string y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}

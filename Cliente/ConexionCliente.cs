using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace Cliente
{
    class ConexionCliente
    {
        IPEndPoint conectar;
        Socket socketCliente;
        IPHostEntry host;
        IPAddress ipAddress;

        public ConexionCliente()
        {

        }
        public ConexionCliente(string ip, int puerto)
        {
            host = Dns.GetHostEntry(ip);
            ipAddress = host.AddressList[0];
            conectar = new IPEndPoint(ipAddress, puerto);
            socketCliente = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }
       
        public void inicioSocket()
        {
            socketCliente.Connect(conectar);

        }
        public void enviarMensaje(string mensaje)
        {
         
            byte[] enviar_mensaje = new byte[100];
            
  
            enviar_mensaje = Encoding.Default.GetBytes(mensaje);
            socketCliente.Send(enviar_mensaje);

        }

        public string recibirMensaje() {
            string data;
            byte[] recibir_mensaje = new byte[1024];
            socketCliente.Receive(recibir_mensaje);
           
             return Encoding.Default.GetString(recibir_mensaje);
        }
    }
}

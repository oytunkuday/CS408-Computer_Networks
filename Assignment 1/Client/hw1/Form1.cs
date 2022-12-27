using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1
{
    public partial class Form1 : Form
    {
        bool terminating = false;
        bool connected = false;
        Socket clientsocket;
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void button1_connect_Click(object sender, EventArgs e)
        {
            clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            String IP = Ipbox.Text;
            int portNum;
            if(Int32.TryParse(Portbox.Text, out portNum))
            {
                try
                {
                    clientsocket.Connect(IP, portNum);
                    button2_disconnect.Enabled = true;
                    button1_connect.Enabled = false;
                    button_CreateAccount.Enabled = true;
                    connected = true;
                    clientlogs.AppendText("You are connected!\n");
                    
                    Thread receivethread = new Thread(Receive);
                    receivethread.Start();


                }
                catch
                {
                    clientlogs.AppendText("Couldn't connect to the server\n");
                }

            }
            else
            {
                clientlogs.AppendText("Check your port number\n");
            }

        }

        private void Receive()
        {
            while (connected)
            {
                try { 
                Byte[] buffer = new Byte[64];
                clientsocket.Receive(buffer);

                string incomingMessage = Encoding.Default.GetString(buffer);
                incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                    //incomingMessage = incomingMessage.Trim('\0');
                clientlogs.AppendText(incomingMessage);
                }
                catch
                {
                    if (!terminating)
                    {
                        clientlogs.AppendText("The server has disconnect\n");
                        button1_connect.Enabled = true;
                        //textBox3_message.Enabled = false;
                        //button2_send.Enabled = false;
                    }
                    clientsocket.Close();
                    connected = false;
                    button2_disconnect.Enabled = false;
                    button1_connect.Enabled = true;
                    button_CreateAccount.Enabled = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);

        }

        private void Passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_CreateAccount_Click(object sender, EventArgs e)
        {
            string name = Namebox.Text;
            string surname = Surnamebox.Text;
            string password = Passwordbox.Text;
            string username = Usernamebox.Text;
            if (name == "")
                clientlogs.AppendText("Please enter a name!\n");
            if (surname == "")
                clientlogs.AppendText("Please enter a surname!\n");
            if (username == "")
                clientlogs.AppendText("Please enter a username!\n");
            if (password == "")
                clientlogs.AppendText("Please enter a password!\n");
            if(name != "" && surname != "" && username != "" && password != "")
            {
                string userinfos = username + ";" + name + ";" +surname + ";" + password;
                Byte[] buffer = Encoding.Default.GetBytes(userinfos);
                clientsocket.Send(buffer);
            }

        }

        private void button2_disconnect_Click(object sender, EventArgs e)
        {
            connected = false;
            button2_disconnect.Enabled = false;
            button1_connect.Enabled = true;
            button_CreateAccount.Enabled = false;
            clientlogs.AppendText("Successfully disconnected!\n");
            clientsocket.Close();
        }
    }
}

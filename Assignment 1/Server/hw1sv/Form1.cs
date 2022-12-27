using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1sv
{
    public partial class Form1 : Form
    {
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> clientSockets = new List<Socket>();

        bool terminating = false;
        bool listening = false;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void Button_Listen_Click(object sender, EventArgs e)
        {
            int serverPort;

            if(Int32.TryParse(PorttextBox.Text, out serverPort))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(15);

                listening = true;
                Button_Listen.Enabled = false;
                Thread acceptThread = new Thread(Accept);
                acceptThread.Start();

                consolelogs.AppendText("Started listening on port: " + serverPort + "\n");

            }
            else
            {
                consolelogs.AppendText("Check the port number!\n");
            }



        }
        private void Accept()
        {
            while (listening)
            {
                try
                {
                    Socket newClient = serverSocket.Accept();
                    clientSockets.Add(newClient);
                    consolelogs.AppendText("A client has connected!\n");

                    Thread receiveThread = new Thread(() => Receive(newClient));
                    receiveThread.Start();

                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        consolelogs.AppendText("The socket stopped working.\n");
                    }
                }
                 
            }
        }

        private void Receive(Socket thisClient)
        {
            bool connected = true;

            while (connected && !terminating)
            {
                try
                {
                    Byte[] buffer1 = new Byte[64];
                    thisClient.Receive(buffer1);
                    string buffer1msg = Encoding.Default.GetString(buffer1);
                    buffer1msg = buffer1msg.Substring(0, buffer1msg.IndexOf("\0"));
                    //consolelogs.AppendText("Client: " + buffer1msg + "\n");
                    string userinfos = buffer1msg;
                    string username = userinfos.Substring(0, userinfos.IndexOf(";"));
                    if (!File.Exists("../../database.txt"))
                    {
                        File.Create("../../database.txt").Close();
                    }
                    var lines = File.ReadLines("../../database.txt");
                    bool Notinfile = true;

                    foreach (string line in lines)
                    {
                        if (line.Substring(0, line.IndexOf(";"))==username)
                        {
                            Notinfile = false;
                        }
                    }

                    if (Notinfile)
                    {
                        using (StreamWriter file = new StreamWriter("../../database.txt", append: true))
                        {
                            file.WriteLine(userinfos);
                            Notinfile = true;
                        }
                        consolelogs.AppendText(username + " has created an account!\n");
                        string message = "You have created a new account!\n";
                        Byte[] buffer = Encoding.Default.GetBytes(message);
                        thisClient.Send(buffer);
                    }
                    else
                    {
                        //user already exists
                        consolelogs.AppendText("An account with the username " + username + " already exists!\n");
                        string message = "There is already an account with this username!\n";
                        Byte[] buffer = Encoding.Default.GetBytes(message);
                        thisClient.Send(buffer);
                    }
                    
                }
            
                 catch
                {
                    if (!terminating)
                    {
                        consolelogs.AppendText("A client has disconnected!\n");
                    }
                    thisClient.Close();
                    clientSockets.Remove(thisClient);
                    connected = false;
                }
            }
        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            listening = false;
            terminating = true;
            Environment.Exit(0);
        }
    }
}

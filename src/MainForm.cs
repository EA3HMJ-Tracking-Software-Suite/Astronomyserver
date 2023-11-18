using DriverDish.Utilities;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using CosineKitty;


public enum OutputTypes : int
{
    Information,
    Command,
    Response,
    Error
}

namespace Astronomyserver
{
    public partial class MainForm : Form
    {
    #region Variables
       
 //       Sondas.Sondas mySondas = new Sondas.Sondas();
        //SimpleTcpServer server = new SimpleTcpServer("0.0.0.0:8889");
        DriverDish.Utilities.ServerTCP server = new DriverDish.Utilities.ServerTCP(8888);
  
        string IPclient, station, home;
        string astrodatas,sonda,targets;
        bool waitCLiente = true;
        Utils U = new Utils();
        Observer observer;
        AstroTime time;
        Body body = Body.Moon;
        public struct astro
        {
            public string name;
            public int pos;
            public astro(int p, string s)
            {
                name = s;
                pos = p;
            }
        }
        astro[] astros=new astro[11];
        #endregion
        #region Inicializacion y cierre
        public MainForm()
        {
            InitializeComponent();
            //  txtOutput.CheckForIllegalCrossThreadCalls = false;
            server.OnConnect += ClientConnected;
            server.OnDisconnect += ClientDisconnected;
            server.OnDataReceived += DataReceived;

            Body.Earth.ToString();
            this.Text += "(" + U.GetVersionApp() + ") ";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            sonda = "Jupiter";// Properties.Settings.Default.body;
            targets = "";
            for (int i = 0; i < cbSonda.Items.Count; i++)
            {
                astros[i] = new astro(i, cbSonda.Items[i].ToString());
                targets += cbSonda.Items[i].ToString() + ",";


            }

            cbSonda.SelectedItem = sonda;
            body= (Body)(cbSonda.SelectedIndex);
            

                tbHlatitud.Text = Properties.Settings.Default.Lat;
                tbHlongitud.Text = Properties.Settings.Default.Lon;
                tbHaltitude.Text = Properties.Settings.Default.Alt;
     
            home = tbHlongitud.Text + "," + tbHlatitud.Text + "," + tbHaltitude.Text;
            observer = new Observer(Convert.ToDouble(tbHlatitud.Text, new CultureInfo("en-US")), Convert.ToDouble(tbHlongitud.Text, new CultureInfo("en-US")), 1000*Convert.ToDouble(tbHaltitude.Text, new CultureInfo("en-US")));
            AddOutput(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
            //  timer1.Enabled = true;
            AddOutput("Start server");

            AddOutput("Running", OutputTypes.Response);


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            server.Stop();

 //           Properties.Settings.Default.body = sonda;// mySondas.SondasList[cbSonda.SelectedIndex].name;
  //          Properties.Settings.Default.Save();
        }
        #endregion
        #region Astronomy engine
        string GetDatas(Body body, AstroTime t)

            {
            double d = 0;
            AstroTime time = t;// new AstroTime(DateTime.UtcNow);
                // Equatorial equ_2000 = Astronomy.Equator(body, time, observer, EquatorEpoch.J2000, Aberration.Corrected);
                Equatorial equ_ofdate = Astronomy.Equator(body, time, observer, EquatorEpoch.OfDate, Aberration.Corrected);
                Topocentric hor = Astronomy.Horizon(time, observer, equ_ofdate.ra, equ_ofdate.dec, Refraction.None);
                Invoke(new MethodInvoker(() =>
                {
                    cbSonda.SelectedIndex = (int)body;
                    fecha.Text = t.ToString();
                    az.Text = hor.azimuth.ToString("F4", new CultureInfo("en-US"));
                    alt.Text = hor.altitude.ToString("F4", new CultureInfo("en-US"));
                    tbRa.Text = (hor.ra * 15.0).ToString("F5", new CultureInfo("en-US"));
                    tbDec.Text = hor.dec.ToString("F5", new CultureInfo("en-US"));
                }));
            string astrodatas = sonda + "," + fecha.Text + "," + az.Text + "," + alt.Text + ",";
            d = equ_ofdate.dist;
            astrodatas = astrodatas + d.ToString("F4", new CultureInfo("en-US")) + ",0.0";
            astrodatas = astrodatas + ", ," + "0" + "," + "0" + "," + "0" + "," + tbRa.Text + "," + tbDec.Text;
          //  AddOutput(astrodatas);
            return astrodatas; 
        }
        #endregion
        #region Time event
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = new AstroTime(DateTime.UtcNow);
           // Equatorial equ_2000 = Astronomy.Equator(body, time, observer, EquatorEpoch.J2000, Aberration.Corrected);
            Equatorial equ_ofdate = Astronomy.Equator(body, time, observer, EquatorEpoch.OfDate, Aberration.Corrected);
            Topocentric hor = Astronomy.Horizon(time, observer, equ_ofdate.ra, equ_ofdate.dec, Refraction.None);
            fecha.Text = DateTime.UtcNow.ToString();
            az.Text = hor.azimuth.ToString("F4", new CultureInfo("en-US"));
            alt.Text = hor.altitude.ToString("F4", new CultureInfo("en-US"));
            tbRa.Text = (hor.ra*15.0).ToString("F5", new CultureInfo("en-US"));
            tbDec.Text = hor.dec.ToString("F5", new CultureInfo("en-US"));
            if (hor.altitude < 0)
            {
                az.ForeColor = Color.Red;
                alt.ForeColor = Color.Red;
                tbDec.ForeColor = Color.Red;
                tbRa.ForeColor = Color.Red;
            }
            else
            {
                az.ForeColor = Color.Blue;
                alt.ForeColor = Color.Blue;
                tbDec.ForeColor = Color.Blue;
                tbRa.ForeColor = Color.Blue;
            }
            astrodatas = sonda + "," + fecha.Text + "," + az.Text + "," + alt.Text + ",";
            double d = equ_ofdate.dist;
            astrodatas = astrodatas + d.ToString("F4", new CultureInfo("en-US")) + ",0.0" ;
            astrodatas = astrodatas + ", ," + "0" + "," + "0" + "," + "0" + ","+ tbRa.Text + ","+ tbDec.Text;
        }
#endregion
    #region Cambio text
        private void cbSonda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
               // button1_Click(null, EventArgs.Empty);
            }
            body = (Body)(cbSonda.SelectedIndex );
            //myKernel.Frequency = mySondas.SondasList[cbSonda.SelectedIndex].freq;
            sonda = (string)(cbSonda.SelectedItem);// mySondas.SondasList[cbSonda.SelectedIndex].name;
        }
       
        private void tbHlatitud_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lat = tbHlatitud.Text;
            home = tbHlongitud.Text + "," + tbHlatitud.Text + "," + tbHaltitude.Text;
            observer = new Observer(Convert.ToDouble(tbHlatitud.Text, new CultureInfo("en-US")), Convert.ToDouble(tbHlongitud.Text, new CultureInfo("en-US")), 1000 * Convert.ToDouble(tbHaltitude.Text, new CultureInfo("en-US")));

            Properties.Settings.Default.Save();
        }
        private void tbHlongitud_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lon = tbHlongitud.Text;
            home = tbHlongitud.Text + "," + tbHlatitud.Text + "," + tbHaltitude.Text;
            observer = new Observer(Convert.ToDouble(tbHlatitud.Text, new CultureInfo("en-US")), Convert.ToDouble(tbHlongitud.Text, new CultureInfo("en-US")), 1000 * Convert.ToDouble(tbHaltitude.Text, new CultureInfo("en-US")));
            Properties.Settings.Default.Save();
        }
        private void tbHaltitude_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Alt = tbHaltitude.Text;
            home = tbHlongitud.Text + "," + tbHlatitud.Text + "," + tbHaltitude.Text;
            observer = new Observer(Convert.ToDouble(tbHlatitud.Text, new CultureInfo("en-US")), Convert.ToDouble(tbHlongitud.Text, new CultureInfo("en-US")), 1000 * Convert.ToDouble(tbHaltitude.Text, new CultureInfo("en-US")));
            Properties.Settings.Default.Save();
        }
        #endregion
    #region Botontes
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                AddOutput("Stop server", OutputTypes.Error);
                timer1.Enabled = false;
                server.Stop();
            }
            else
            {

                AddOutput("Start server");
                server.Start();
                AddOutput("Running", OutputTypes.Response);
            }
            Status();
        }
        private void Status()
        {
            if (timer1.Enabled)
            {
                btnStart.Text = "Stop server";
            } else
                btnStart.Text = "Start server";
        }


    /*    private void btnConvert_Click(object sender, EventArgs e)
        {
            Utils U = new Utils();
           
            double ra, dec;
            ra = U.HMSToHours(tbRA2000.Text);
            dec = U.DMSToDegrees(tbDec2000.Text);
            DateTime ddate = DateTime.Parse(tbTime.Text);
            if (chkJ2000.Checked)
                time = new AstroTime(ddate.Year, ddate.Month, ddate.Day, ddate.Hour, ddate.Minute, ddate.Second);//  DateTime.UtcNow);
            else
                time = new AstroTime(DateTime.UtcNow);
          //  tbTime.Text = time.ToString();
            // Equatorial equ_2000 = Astronomy.Equator(body, time, observer, EquatorEpoch.J2000, Aberration.Corrected);
            //Equatorial equ_ofdate = Astronomy.Equator(body, time, observer, EquatorEpoch.OfDate, Aberration.Corrected);
            Topocentric hor = Astronomy.Horizon(time, observer, ra, dec, Refraction.None);
            fecha.Text = DateTime.UtcNow.ToString();
            az.Text = hor.azimuth.ToString("F4", new CultureInfo("en-US"));
            alt.Text = hor.altitude.ToString("F4", new CultureInfo("en-US"));
            tbRa.Text = (hor.ra * 15.0).ToString("F5", new CultureInfo("en-US"));
            tbDec.Text = hor.dec.ToString("F5", new CultureInfo("en-US"));

        }*/
        #endregion

        #region Log
        public void AddOutput(string text, OutputTypes type = OutputTypes.Information)
        {
             Invoke(new MethodInvoker(() => { 
            // Impostazione Colore e sezione log
            switch (type)
            {
                case OutputTypes.Information:
                    {
                        this.txtOutput.SelectionColor = Color.Yellow;
                        break;
                    }

                case OutputTypes.Command:
                    {
                        this.txtOutput.SelectionColor = Color.White;
                        break;
                    }

                case OutputTypes.Response:
                    {
                        this.txtOutput.SelectionColor = Color.GreenYellow;
                        break;
                    }

                case OutputTypes.Error:
                    {
                        this.txtOutput.SelectionColor = Color.Red;
                        break;
                    }
            }

            this.txtOutput.SelectedText += text.TrimNewLine() + System.Environment.NewLine;
            this.txtOutput.ScrollToCaret();
            this.txtOutput.Refresh();
            }));
        }

        #endregion
    #region TCP server
        void ClientConnected(object sender, ClientConnectedArgs e)
        {
            AddOutput("[" + e.IpPort + "] client connected");
            IPclient = e.IpPort;
            server.Send(IPclient, "Astronomyerver (c) ea3hmj 2.021");
            server.Send(IPclient, "User:");
            waitCLiente = true;
        }
        void ClientDisconnected(object sender, ClientConnectedArgs e)
        {
            try
            {
                AddOutput("[" + e.IpPort + "] client disconnected ");
            }
            catch { }
        }
        void DataReceived(object sender, DataReceivedArgs e)
        {
            string data = e.inData;
            IPclient = e.IpPort;
            data = data.Substring(0, data.Length - 2);

           if (waitCLiente)
            {
                server.Send(IPclient, "Welcome " + data + " 'Help' to command use");
                station = data;
                AddOutput("[" + e.IpPort + "] user = " + data);
                waitCLiente = false;
                return;
            }


            if (data.ToLower() == "targets")
            {
                Thread.Sleep(100);
                server.Send(IPclient, targets + ",");
                AddOutput("[" + e.IpPort + "] " + data + " = " + targets);
            }
            else if (data.ToLower() == "stations")
            {
                server.Send(IPclient, station + ",");
                AddOutput("[" + e.IpPort + "] " + data + " = " + station);
            }

            else if (data.ToLower() == "home")
            {
                string ret = tbHlatitud.Text + "," + tbHlongitud.Text + "," + tbHaltitude.Text;
                server.Send(IPclient, ret);
                AddOutput("[" + e.IpPort + "] " + data + " = " + ret);
            }
            else if (data.ToLower() == "exit")
            {
                server.DisconnectClient(IPclient);
                //AddOutput(IPclient + " disconnected", OutputTypes.Response);
            }
            else if (data.ToLower() == "help")
            {
                string help = "\nAstronomyserver (c) ea3hmj 2.021\n\n";
                help += "spacecraft and major bodys ephemerides datas\n";
                help += "Commands:\n";
                help += "help     = this page\n";
                help += "targets  = <body> ephemerides\n";
                help += "stations = you callsing\n";
                help += "<body>   = Ephemerides datas (delimiter with ';'):\n";
                help += "home     = return Latitude, Longitude and Altitude (in Kms)\n";
                help += "exit     = End\n\n";
                server.Send(IPclient, help);
            }
            else //if (data.ToLower() == sonda.ToLower())
            {
                int i;
                if (data.IndexOf("?D") != -1)
                {
                    string sonda = data.Substring(0, data.IndexOf("?D"));
                    if ((i = cbSonda.Items.IndexOf(sonda)) >= 0)
                    {
                        string fecha = data.Substring(data.IndexOf("?D")+2);
                        DateTime newDate = DateTime.ParseExact(fecha, "yyyy MMM dd HH:mm:ss",new CultureInfo("en-US"));
                        //server.Send(IPclient, GetDatas((Body)i, new AstroTime(newDate)));
                        server.Send(IPclient, GetDatas((Body)i, new AstroTime(newDate.Year, newDate.Month, newDate.Day, newDate.Hour, newDate.Minute, newDate.Second)));
                        return;
                    }else
                        server.Send(IPclient, "!" + data);

                }
                else if ((i=cbSonda.Items.IndexOf(data) )>= 0)
                {
                            server.Send(IPclient, GetDatas((Body)i, new AstroTime(DateTime.UtcNow)));
                            return;
                }
                else
                    server.Send(IPclient, "!" + data);
            }
         }
  
        #endregion
    }
    static class Extensiones
    {
        public static string TrimNewLine(this string text)
        {
            var value = text;
            while (value.EndsWith(Environment.NewLine))
                value = value.Remove(value.LastIndexOf(Environment.NewLine));
            return value;
        }
    }
}

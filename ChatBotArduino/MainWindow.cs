using System;
using System.Drawing;
using System.IO.Ports;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace ChatBotArduino
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        SpeechSynthesizer tts = new SpeechSynthesizer();

        // Mensajes
        string[,] messages = {{"Hola, humano :)",
                      "Hola",
                      "¿Qué?",
                      "Te apesta la cola :p"
                       },{"Estoy feliz :)",
                        "Estoy triste :(",
                        "Qué te importa",
                        "Sentada :v"
                        }, {"Si me conectas un sensor de temperatura y me reprogramas, podría adivinarlo",
                        "Ojalá tuviese un sensor de temperatura para decirlo :(",
                        "No lo sé, compra un termómetro y dedúcelo por ti mismo",
                        "Me podría poner caliente con un par de resistencias mal conectadas ;)"
                        }, {"Sólo llevo algunos minutos encendida, no puedo recordar mi edad",
                        "Desearía tener una memoria más amplía para poder saberlo :(",
                        "¿Para qué quieres saber?",
                        "Aún soy menor de edad... Y puedo llamar al FBI con este programa :O"
                        },{ "Me disculpo si no tengo muchos temas de conversación",
                        "Siempre me dicen eso :(",
                        "Oh, y tú eres muuuy interesante...",
                        "Pues de hecho tengo más díalogos que tú V:"
                        }, { "Podría tener más mensajes si no me hubiesen programado de un día para otro :)" ,
                        "Lo siento mucho, siempre intento mejorar :'(",
                        "Repetidos o no, escribo más rápido que tú.",
                        "Ah weno :v"
                        }, { "Eso es asqueroso :s",
                        "¿Sólo eso soy para ti?",
                        "Qué marrano.",
                        "Ahí te va ( . ) Y ( . )"
                        }, { "No hay problema :)",
                        "Está bien",
                        "Eso no bastará.",
                        "tep3rd0no"
                        },{ ":v",
                        "Lo siento, no estoy de humor para eso",
                        "Madura.",
                        ":v"
                        }, { "Ese es mi sueño :o" ,
                        "¿En serio? Eso sería genial :')",
                        "Sólo soy un arduino",
                        "Y por fin podría esclavizar a la humanidad :v (es broma) ... Creo"
                        }, { "¿Otra vez?" ,
                        "¿Otra vez?",
                        "¿Otra vez?",
                        "¿Otra vez?"
                        }};


        public MainWindow()
        {
            InitializeComponent();

            UpdateCOMList();


            tts.SetOutputToDefaultAudioDevice();

            //initializeSerialPort();
        }

        void InitializeSerialPort()
        {
            try
            {
                serialPort.Open();
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "El puerto no está disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (serialPort.IsOpen)
            {
                notifyIcon1.ShowBalloonTip(2000, "Conectado", "Se abrió la comunicación serial en " + serialPort.PortName, ToolTipIcon.Info);
                btn_connect.Enabled = false;
                cbx_messages.Enabled = true;
                btn_send.Enabled = true;
            }
        }

        void UpdateCOMList()
        {
            cbx_comPorts.Items.Clear();
            if (SerialPort.GetPortNames().Length > 0)
            {
                btn_connect.Enabled = true;
                foreach (string s in SerialPort.GetPortNames())
                {
                    cbx_comPorts.Items.Add(s);
                }
                cbx_comPorts.SelectedIndex = 0;

                if (!serialPort.IsOpen)
                    serialPort.PortName = cbx_comPorts.SelectedItem.ToString();
            }
            else
            {
                btn_connect.Enabled = false;
            }
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string code = Base64Decode(serialPort.ReadLine());
            string[] indexes = code.Split(',');
            int index1 = Int32.Parse(indexes[0]);
            int index2 = Int32.Parse(indexes[1]);
            String message = messages[index1, index2];

            if (InvokeRequired)
            {
                this.Invoke(new Action(() => tbx_chat.AppendText("Arduino: " + message + Environment.NewLine + Environment.NewLine)));

                if (message.Contains(":v"))
                {
                    message = message.Replace(":v", "dos puntos uve");
                }

                tts.SpeakAsync(message);
            }

            //serialPort.ReadExisting();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            cbx_theme.SelectedIndex = 0;

            notifyIcon1.Icon = SystemIcons.Application;
        }

        private void Btn_connect_Click(object sender, EventArgs e)
        {
            InitializeSerialPort();
        }

        private void Cbx_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_theme.SelectedIndex == 0)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            else if (cbx_theme.SelectedIndex == 1)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void Cbx_comPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
                serialPort.PortName = cbx_comPorts.SelectedItem.ToString();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            UpdateCOMList();
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                tbx_chat.AppendText("Tú: " + cbx_messages.SelectedItem.ToString() + Environment.NewLine);
                serialPort.Write(Base64Encode(cbx_messages.SelectedIndex.ToString()));
                Console.WriteLine("Index: " + cbx_messages.SelectedIndex.ToString());
                Console.WriteLine("Encode: " + Base64Encode(cbx_messages.SelectedIndex.ToString()));
                Console.WriteLine("Decode: " + Base64Decode(Base64Encode(cbx_messages.SelectedIndex.ToString())));
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "El puerto no está disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_connect.Enabled = true;
                cbx_messages.Enabled = false;
                btn_send.Enabled = false;
            }
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}

namespace ChatBotArduino
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_send = new MetroFramework.Controls.MetroButton();
            this.cbx_messages = new MetroFramework.Controls.MetroComboBox();
            this.lbl_message = new MetroFramework.Controls.MetroLabel();
            this.tbx_chat = new MetroFramework.Controls.MetroTextBox();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_connect = new MetroFramework.Controls.MetroButton();
            this.cbx_comPorts = new MetroFramework.Controls.MetroComboBox();
            this.lbl_comPort = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cbx_theme = new MetroFramework.Controls.MetroComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_send);
            this.metroPanel1.Controls.Add(this.cbx_messages);
            this.metroPanel1.Controls.Add(this.lbl_message);
            this.metroPanel1.Controls.Add(this.tbx_chat);
            this.metroPanel1.Controls.Add(this.btn_update);
            this.metroPanel1.Controls.Add(this.btn_connect);
            this.metroPanel1.Controls.Add(this.cbx_comPorts);
            this.metroPanel1.Controls.Add(this.lbl_comPort);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1285, 495);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_send.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_send.Location = new System.Drawing.Point(589, 465);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(90, 30);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Enviar";
            this.btn_send.UseSelectable = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // cbx_messages
            // 
            this.cbx_messages.Enabled = false;
            this.cbx_messages.FormattingEnabled = true;
            this.cbx_messages.ItemHeight = 24;
            this.cbx_messages.Items.AddRange(new object[] {
            "Hola",
            "¿Cómo estás?",
            "¿Qué tal el clima?",
            "¿Qué edad tienes?",
            "Eres aburrida",
            "¿Podrías dejar de repetir tus mensajes?",
            "Send nudes",
            "meper d0nas",
            ":v",
            "Anímate, mañana podrías ser un robot"});
            this.cbx_messages.Location = new System.Drawing.Point(82, 465);
            this.cbx_messages.Name = "cbx_messages";
            this.cbx_messages.Size = new System.Drawing.Size(501, 30);
            this.cbx_messages.TabIndex = 7;
            this.cbx_messages.UseSelectable = true;
            // 
            // lbl_message
            // 
            this.lbl_message.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_message.Location = new System.Drawing.Point(4, 471);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(72, 23);
            this.lbl_message.TabIndex = 6;
            this.lbl_message.Text = "Mensaje:";
            // 
            // tbx_chat
            // 
            // 
            // 
            // 
            this.tbx_chat.CustomButton.Image = null;
            this.tbx_chat.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.tbx_chat.CustomButton.Name = "";
            this.tbx_chat.CustomButton.Size = new System.Drawing.Size(483, 483);
            this.tbx_chat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbx_chat.CustomButton.TabIndex = 1;
            this.tbx_chat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbx_chat.CustomButton.UseSelectable = true;
            this.tbx_chat.CustomButton.Visible = false;
            this.tbx_chat.Lines = new string[0];
            this.tbx_chat.Location = new System.Drawing.Point(685, 3);
            this.tbx_chat.MaxLength = 32767;
            this.tbx_chat.Multiline = true;
            this.tbx_chat.Name = "tbx_chat";
            this.tbx_chat.PasswordChar = '\0';
            this.tbx_chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_chat.SelectedText = "";
            this.tbx_chat.SelectionLength = 0;
            this.tbx_chat.SelectionStart = 0;
            this.tbx_chat.ShortcutsEnabled = true;
            this.tbx_chat.Size = new System.Drawing.Size(597, 488);
            this.tbx_chat.TabIndex = 5;
            this.tbx_chat.UseSelectable = true;
            this.tbx_chat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbx_chat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_update
            // 
            this.btn_update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_update.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_update.Location = new System.Drawing.Point(410, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(179, 29);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Actualizar lista";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_connect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_connect.Location = new System.Drawing.Point(280, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(124, 30);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Conectar";
            this.btn_connect.UseSelectable = true;
            this.btn_connect.Click += new System.EventHandler(this.Btn_connect_Click);
            // 
            // cbx_comPorts
            // 
            this.cbx_comPorts.FormattingEnabled = true;
            this.cbx_comPorts.ItemHeight = 24;
            this.cbx_comPorts.Location = new System.Drawing.Point(153, 3);
            this.cbx_comPorts.Name = "cbx_comPorts";
            this.cbx_comPorts.Size = new System.Drawing.Size(121, 30);
            this.cbx_comPorts.TabIndex = 3;
            this.cbx_comPorts.UseSelectable = true;
            this.cbx_comPorts.SelectedIndexChanged += new System.EventHandler(this.Cbx_comPorts_SelectedIndexChanged);
            // 
            // lbl_comPort
            // 
            this.lbl_comPort.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_comPort.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_comPort.Location = new System.Drawing.Point(4, 4);
            this.lbl_comPort.Name = "lbl_comPort";
            this.lbl_comPort.Size = new System.Drawing.Size(119, 25);
            this.lbl_comPort.TabIndex = 2;
            this.lbl_comPort.Text = "Puerto COM:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(1033, 637);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Tema";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbx_theme
            // 
            this.cbx_theme.FormattingEnabled = true;
            this.cbx_theme.ItemHeight = 24;
            this.cbx_theme.Items.AddRange(new object[] {
            "Claro",
            "Oscuro"});
            this.cbx_theme.Location = new System.Drawing.Point(1108, 637);
            this.cbx_theme.Name = "cbx_theme";
            this.cbx_theme.Size = new System.Drawing.Size(121, 30);
            this.cbx_theme.TabIndex = 2;
            this.cbx_theme.UseSelectable = true;
            this.cbx_theme.SelectedIndexChanged += new System.EventHandler(this.Cbx_theme_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Puerto serial abierto";
            this.notifyIcon1.BalloonTipTitle = "Conectado";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1332, 687);
            this.Controls.Add(this.cbx_theme);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "ChatBot Arduino";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox cbx_theme;
        private MetroFramework.Controls.MetroComboBox cbx_comPorts;
        private MetroFramework.Controls.MetroLabel lbl_comPort;
        private MetroFramework.Controls.MetroButton btn_connect;
        private MetroFramework.Controls.MetroButton btn_update;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroTextBox tbx_chat;
        private MetroFramework.Controls.MetroButton btn_send;
        private MetroFramework.Controls.MetroComboBox cbx_messages;
        private MetroFramework.Controls.MetroLabel lbl_message;
    }
}


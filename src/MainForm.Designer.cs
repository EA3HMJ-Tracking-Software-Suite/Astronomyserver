
namespace Astronomyserver
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.az = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.alt = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.tbHaltitude = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbHlongitud = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbHlatitud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.cbSonda = new System.Windows.Forms.ComboBox();
            this.tbRa = new System.Windows.Forms.TextBox();
            this.tbDec = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(520, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // az
            // 
            this.az.BackColor = System.Drawing.SystemColors.Window;
            this.az.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.az.ForeColor = System.Drawing.SystemColors.WindowText;
            this.az.Location = new System.Drawing.Point(74, 52);
            this.az.Margin = new System.Windows.Forms.Padding(4);
            this.az.Name = "az";
            this.az.ReadOnly = true;
            this.az.Size = new System.Drawing.Size(115, 30);
            this.az.TabIndex = 146;
            this.az.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(6, 94);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 25);
            this.Label2.TabIndex = 149;
            this.Label2.Text = "Alt";
            // 
            // alt
            // 
            this.alt.BackColor = System.Drawing.SystemColors.Window;
            this.alt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.alt.Location = new System.Drawing.Point(74, 90);
            this.alt.Margin = new System.Windows.Forms.Padding(4);
            this.alt.Name = "alt";
            this.alt.ReadOnly = true;
            this.alt.Size = new System.Drawing.Size(115, 30);
            this.alt.TabIndex = 148;
            this.alt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 54);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 25);
            this.Label1.TabIndex = 147;
            this.Label1.Text = "Az";
            // 
            // fecha
            // 
            this.fecha.BackColor = System.Drawing.Color.Black;
            this.fecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.fecha.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.Yellow;
            this.fecha.Location = new System.Drawing.Point(0, 0);
            this.fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(1005, 39);
            this.fecha.TabIndex = 253;
            this.fecha.Text = "24/12/2021";
            this.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHaltitude
            // 
            this.tbHaltitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbHaltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHaltitude.Location = new System.Drawing.Point(853, 129);
            this.tbHaltitude.Name = "tbHaltitude";
            this.tbHaltitude.Size = new System.Drawing.Size(140, 30);
            this.tbHaltitude.TabIndex = 260;
            this.tbHaltitude.Text = "300.00";
            this.tbHaltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHaltitude.TextChanged += new System.EventHandler(this.tbHaltitude_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(680, 132);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(164, 25);
            this.Label4.TabIndex = 259;
            this.Label4.Text = "Home Altitude(m)";
            // 
            // tbHlongitud
            // 
            this.tbHlongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbHlongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHlongitud.Location = new System.Drawing.Point(853, 91);
            this.tbHlongitud.Name = "tbHlongitud";
            this.tbHlongitud.Size = new System.Drawing.Size(140, 30);
            this.tbHlongitud.TabIndex = 258;
            this.tbHlongitud.Text = "2.01";
            this.tbHlongitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHlongitud.TextChanged += new System.EventHandler(this.tbHlongitud_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(680, 94);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(144, 25);
            this.Label3.TabIndex = 257;
            this.Label3.Text = "Home Longitud";
            // 
            // tbHlatitud
            // 
            this.tbHlatitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbHlatitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHlatitud.Location = new System.Drawing.Point(853, 53);
            this.tbHlatitud.Name = "tbHlatitud";
            this.tbHlatitud.Size = new System.Drawing.Size(140, 30);
            this.tbHlatitud.TabIndex = 256;
            this.tbHlatitud.Text = "41.57";
            this.tbHlatitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHlatitud.TextChanged += new System.EventHandler(this.tbHlatitud_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(680, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 255;
            this.label5.Text = "Home Latitud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 261;
            this.label6.Text = "Body";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.DarkBlue;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 167);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(5);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(1005, 514);
            this.txtOutput.TabIndex = 262;
            this.txtOutput.Text = "...";
            // 
            // cbSonda
            // 
            this.cbSonda.BackColor = System.Drawing.SystemColors.Window;
            this.cbSonda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSonda.Enabled = false;
            this.cbSonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSonda.FormattingEnabled = true;
            this.cbSonda.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Pluto",
            "Sun",
            "Moon"});
            this.cbSonda.Location = new System.Drawing.Point(520, 52);
            this.cbSonda.Name = "cbSonda";
            this.cbSonda.Size = new System.Drawing.Size(154, 33);
            this.cbSonda.TabIndex = 269;
            this.cbSonda.SelectedIndexChanged += new System.EventHandler(this.cbSonda_SelectedIndexChanged);
            // 
            // tbRa
            // 
            this.tbRa.BackColor = System.Drawing.SystemColors.Window;
            this.tbRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRa.ForeColor = System.Drawing.Color.Blue;
            this.tbRa.Location = new System.Drawing.Point(302, 51);
            this.tbRa.Margin = new System.Windows.Forms.Padding(4);
            this.tbRa.Name = "tbRa";
            this.tbRa.ReadOnly = true;
            this.tbRa.Size = new System.Drawing.Size(123, 30);
            this.tbRa.TabIndex = 270;
            this.tbRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDec
            // 
            this.tbDec.BackColor = System.Drawing.SystemColors.Window;
            this.tbDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDec.ForeColor = System.Drawing.Color.Blue;
            this.tbDec.Location = new System.Drawing.Point(302, 89);
            this.tbDec.Margin = new System.Windows.Forms.Padding(4);
            this.tbDec.Name = "tbDec";
            this.tbDec.ReadOnly = true;
            this.tbDec.Size = new System.Drawing.Size(123, 30);
            this.tbDec.TabIndex = 271;
            this.tbDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(204, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 273;
            this.label10.Text = "Dec now";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(204, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 272;
            this.label11.Text = "Ra now";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 681);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbRa);
            this.Controls.Add(this.tbDec);
            this.Controls.Add(this.cbSonda);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHaltitude);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tbHlongitud);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tbHlatitud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.az);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.alt);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Astronomyserver.App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.TextBox az;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox alt;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label fecha;
        internal System.Windows.Forms.TextBox tbHaltitude;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tbHlongitud;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tbHlatitud;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.ComboBox cbSonda;
        internal System.Windows.Forms.TextBox tbRa;
        internal System.Windows.Forms.TextBox tbDec;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
    }
}


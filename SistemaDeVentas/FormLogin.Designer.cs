namespace SistemaDeVentas
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTPASS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNLOG = new System.Windows.Forms.Button();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEmpleado
            // 
            this.BtnEmpleado.BackColor = System.Drawing.Color.Navy;
            this.BtnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEmpleado.Location = new System.Drawing.Point(3, 3);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Size = new System.Drawing.Size(119, 53);
            this.BtnEmpleado.TabIndex = 0;
            this.BtnEmpleado.Text = "Empleado";
            this.BtnEmpleado.UseVisualStyleBackColor = false;
            this.BtnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAdmin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEmpleado, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 264);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 59);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Maroon;
            this.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdmin.Location = new System.Drawing.Point(128, 3);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(119, 53);
            this.BtnAdmin.TabIndex = 1;
            this.BtnAdmin.Text = "Administrador";
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TXTPASS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTNLOG);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.textBoxuser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 450);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inicio de sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // TXTPASS
            // 
            this.TXTPASS.Location = new System.Drawing.Point(66, 203);
            this.TXTPASS.Name = "TXTPASS";
            this.TXTPASS.Size = new System.Drawing.Size(250, 27);
            this.TXTPASS.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // BTNLOG
            // 
            this.BTNLOG.Location = new System.Drawing.Point(63, 350);
            this.BTNLOG.Name = "BTNLOG";
            this.BTNLOG.Size = new System.Drawing.Size(247, 50);
            this.BTNLOG.TabIndex = 2;
            this.BTNLOG.Text = "Iniciar";
            this.BTNLOG.UseVisualStyleBackColor = true;
            this.BTNLOG.Click += new System.EventHandler(this.BTNLOG_Click);
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(63, 128);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(250, 27);
            this.textBoxuser.TabIndex = 3;
            this.textBoxuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnEmpleado;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnAdmin;
        private Panel panel1;
        private TextBox textBoxuser;
        private Button BTNLOG;
        private Label label3;
        private Label label2;
        private TextBox TXTPASS;
        private Label label1;
    }
}
namespace Cliente
{
    partial class Form1
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
            this.B_C_M = new System.Windows.Forms.Button();
            this.IP_local = new System.Windows.Forms.TextBox();
            this.N_puerto = new System.Windows.Forms.TextBox();
            this.IP_manager = new System.Windows.Forms.TextBox();
            this.IP_l = new System.Windows.Forms.Label();
            this.N_p = new System.Windows.Forms.Label();
            this.IP_m = new System.Windows.Forms.Label();
            this.B_Enviar_M = new System.Windows.Forms.Button();
            this.B_Recibir_M = new System.Windows.Forms.Button();
            this.Mensaje_E_M = new System.Windows.Forms.TextBox();
            this.Mensaje_R_M = new System.Windows.Forms.TextBox();
            this.l_E = new System.Windows.Forms.Label();
            this.l_R = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_C_M
            // 
            this.B_C_M.Location = new System.Drawing.Point(575, 172);
            this.B_C_M.Name = "B_C_M";
            this.B_C_M.Size = new System.Drawing.Size(125, 23);
            this.B_C_M.TabIndex = 0;
            this.B_C_M.Text = "Conectar a Manager";
            this.B_C_M.UseVisualStyleBackColor = true;
            this.B_C_M.Click += new System.EventHandler(this.B_C_M_Click);
            // 
            // IP_local
            // 
            this.IP_local.Location = new System.Drawing.Point(425, 87);
            this.IP_local.Name = "IP_local";
            this.IP_local.Size = new System.Drawing.Size(100, 20);
            this.IP_local.TabIndex = 1;
            // 
            // N_puerto
            // 
            this.N_puerto.Location = new System.Drawing.Point(425, 175);
            this.N_puerto.Name = "N_puerto";
            this.N_puerto.Size = new System.Drawing.Size(100, 20);
            this.N_puerto.TabIndex = 2;
            this.N_puerto.Text = "502";
            // 
            // IP_manager
            // 
            this.IP_manager.Location = new System.Drawing.Point(575, 87);
            this.IP_manager.Name = "IP_manager";
            this.IP_manager.Size = new System.Drawing.Size(100, 20);
            this.IP_manager.TabIndex = 3;
            this.IP_manager.Text = "192.168.";
            // 
            // IP_l
            // 
            this.IP_l.AutoSize = true;
            this.IP_l.Location = new System.Drawing.Point(422, 71);
            this.IP_l.Name = "IP_l";
            this.IP_l.Size = new System.Drawing.Size(46, 13);
            this.IP_l.TabIndex = 4;
            this.IP_l.Text = "IP Local";
            // 
            // N_p
            // 
            this.N_p.AutoSize = true;
            this.N_p.Location = new System.Drawing.Point(422, 159);
            this.N_p.Name = "N_p";
            this.N_p.Size = new System.Drawing.Size(53, 13);
            this.N_p.TabIndex = 5;
            this.N_p.Text = "N° Puerto";
            // 
            // IP_m
            // 
            this.IP_m.AutoSize = true;
            this.IP_m.Location = new System.Drawing.Point(572, 71);
            this.IP_m.Name = "IP_m";
            this.IP_m.Size = new System.Drawing.Size(62, 13);
            this.IP_m.TabIndex = 6;
            this.IP_m.Text = "IP Manager";
            // 
            // B_Enviar_M
            // 
            this.B_Enviar_M.Location = new System.Drawing.Point(36, 175);
            this.B_Enviar_M.Name = "B_Enviar_M";
            this.B_Enviar_M.Size = new System.Drawing.Size(75, 23);
            this.B_Enviar_M.TabIndex = 7;
            this.B_Enviar_M.Text = "Enviar";
            this.B_Enviar_M.UseVisualStyleBackColor = true;
            this.B_Enviar_M.Click += new System.EventHandler(this.B_Enviar_M_Click);
            // 
            // B_Recibir_M
            // 
            this.B_Recibir_M.Location = new System.Drawing.Point(36, 236);
            this.B_Recibir_M.Name = "B_Recibir_M";
            this.B_Recibir_M.Size = new System.Drawing.Size(75, 23);
            this.B_Recibir_M.TabIndex = 8;
            this.B_Recibir_M.Text = "Recibir";
            this.B_Recibir_M.UseVisualStyleBackColor = true;
            this.B_Recibir_M.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Mensaje_E_M
            // 
            this.Mensaje_E_M.Location = new System.Drawing.Point(149, 178);
            this.Mensaje_E_M.Name = "Mensaje_E_M";
            this.Mensaje_E_M.Size = new System.Drawing.Size(149, 20);
            this.Mensaje_E_M.TabIndex = 9;
            // 
            // Mensaje_R_M
            // 
            this.Mensaje_R_M.Location = new System.Drawing.Point(149, 239);
            this.Mensaje_R_M.Name = "Mensaje_R_M";
            this.Mensaje_R_M.Size = new System.Drawing.Size(149, 20);
            this.Mensaje_R_M.TabIndex = 10;
            // 
            // l_E
            // 
            this.l_E.AutoSize = true;
            this.l_E.Location = new System.Drawing.Point(171, 159);
            this.l_E.Name = "l_E";
            this.l_E.Size = new System.Drawing.Size(46, 13);
            this.l_E.TabIndex = 11;
            this.l_E.Text = "Enviado";
            // 
            // l_R
            // 
            this.l_R.AutoSize = true;
            this.l_R.Location = new System.Drawing.Point(171, 223);
            this.l_R.Name = "l_R";
            this.l_R.Size = new System.Drawing.Size(49, 13);
            this.l_R.TabIndex = 12;
            this.l_R.Text = "Recibido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_R);
            this.Controls.Add(this.l_E);
            this.Controls.Add(this.Mensaje_R_M);
            this.Controls.Add(this.Mensaje_E_M);
            this.Controls.Add(this.B_Recibir_M);
            this.Controls.Add(this.B_Enviar_M);
            this.Controls.Add(this.IP_m);
            this.Controls.Add(this.N_p);
            this.Controls.Add(this.IP_l);
            this.Controls.Add(this.IP_manager);
            this.Controls.Add(this.N_puerto);
            this.Controls.Add(this.IP_local);
            this.Controls.Add(this.B_C_M);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_C_M;
        private System.Windows.Forms.TextBox IP_local;
        private System.Windows.Forms.TextBox N_puerto;
        private System.Windows.Forms.TextBox IP_manager;
        private System.Windows.Forms.Label IP_l;
        private System.Windows.Forms.Label N_p;
        private System.Windows.Forms.Label IP_m;
        private System.Windows.Forms.Button B_Enviar_M;
        private System.Windows.Forms.Button B_Recibir_M;
        private System.Windows.Forms.TextBox Mensaje_E_M;
        private System.Windows.Forms.TextBox Mensaje_R_M;
        private System.Windows.Forms.Label l_E;
        private System.Windows.Forms.Label l_R;
    }
}


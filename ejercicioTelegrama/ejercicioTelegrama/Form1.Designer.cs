namespace ejercicioTelegrama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTelegrama = new TextBox();
            lblTexto = new Label();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnCalcularPrecio = new Button();
            rbtnOrdinario = new RadioButton();
            rbtnUrgente = new RadioButton();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(26, 54);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(537, 183);
            txtTelegrama.TabIndex = 0;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(26, 36);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(35, 15);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Texto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(26, 311);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Coste:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(87, 308);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(143, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(434, 276);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(129, 50);
            btnCalcularPrecio.TabIndex = 5;
            btnCalcularPrecio.Text = "Calcular";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // rbtnOrdinario
            // 
            rbtnOrdinario.AutoSize = true;
            rbtnOrdinario.Location = new Point(26, 262);
            rbtnOrdinario.Name = "rbtnOrdinario";
            rbtnOrdinario.Size = new Size(75, 19);
            rbtnOrdinario.TabIndex = 6;
            rbtnOrdinario.TabStop = true;
            rbtnOrdinario.Text = "Ordinario";
            rbtnOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbtnUrgente
            // 
            rbtnUrgente.AutoSize = true;
            rbtnUrgente.Location = new Point(126, 262);
            rbtnUrgente.Name = "rbtnUrgente";
            rbtnUrgente.Size = new Size(67, 19);
            rbtnUrgente.TabIndex = 7;
            rbtnUrgente.TabStop = true;
            rbtnUrgente.Text = "Urgente";
            rbtnUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 351);
            Controls.Add(rbtnUrgente);
            Controls.Add(rbtnOrdinario);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblTexto);
            Controls.Add(txtTelegrama);
            Name = "Form1";
            Text = "Practica Git Telegrama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private Label lblTexto;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnCalcularPrecio;
        private RadioButton rbtnOrdinario;
        private RadioButton rbtnUrgente;
    }
}

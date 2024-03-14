namespace AS2324_3F_INF_Prof_SommaNumeriWF
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
            txtNumero = new TextBox();
            label1 = new Label();
            btnAggiungi = new Button();
            lblRisultato = new Label();
            lblNNumeri = new Label();
            btnMedia = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(202, 72);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 79);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(358, 74);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(94, 29);
            btnAggiungi.TabIndex = 2;
            btnAggiungi.Text = "Add";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // lblRisultato
            // 
            lblRisultato.AutoSize = true;
            lblRisultato.Location = new Point(264, 196);
            lblRisultato.Name = "lblRisultato";
            lblRisultato.Size = new Size(151, 20);
            lblRisultato.TabIndex = 1;
            lblRisultato.Text = "Somma dei numeri ....";
            // 
            // lblNNumeri
            // 
            lblNNumeri.AutoSize = true;
            lblNNumeri.Location = new Point(264, 229);
            lblNNumeri.Name = "lblNNumeri";
            lblNNumeri.Size = new Size(146, 20);
            lblNNumeri.TabIndex = 1;
            lblNNumeri.Text = "Numero di numeri ....";
            // 
            // btnMedia
            // 
            btnMedia.Location = new Point(294, 297);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(94, 29);
            btnMedia.TabIndex = 3;
            btnMedia.Text = "Media";
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMedia);
            Controls.Add(btnAggiungi);
            Controls.Add(lblNNumeri);
            Controls.Add(lblRisultato);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Prof;14/03/24;3F; Raccolta di numeri dall'utente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private Button btnAggiungi;
        private Label lblRisultato;
        private Label lblNNumeri;
        private Button btnMedia;
    }
}

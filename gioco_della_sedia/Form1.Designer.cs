namespace gioco_della_sedia
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
            avviaGioco = new Button();
            label1 = new Label();
            lblStatoGioco = new Label();
            txtBambini = new Label();
            txtSedie = new Label();
            listBoxGiocatori = new ListBox();
            SuspendLayout();
            // 
            // avviaGioco
            // 
            avviaGioco.Location = new Point(280, 147);
            avviaGioco.Name = "avviaGioco";
            avviaGioco.Size = new Size(94, 29);
            avviaGioco.TabIndex = 0;
            avviaGioco.Text = "avvia";
            avviaGioco.UseVisualStyleBackColor = true;
            avviaGioco.Click += avviaGioco_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 204);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lblStatoGioco
            // 
            lblStatoGioco.AutoSize = true;
            lblStatoGioco.Location = new Point(382, 204);
            lblStatoGioco.Name = "lblStatoGioco";
            lblStatoGioco.Size = new Size(50, 20);
            lblStatoGioco.TabIndex = 2;
            lblStatoGioco.Text = "label2";
            // 
            // txtBambini
            // 
            txtBambini.AutoSize = true;
            txtBambini.Location = new Point(299, 246);
            txtBambini.Name = "txtBambini";
            txtBambini.Size = new Size(50, 20);
            txtBambini.TabIndex = 3;
            txtBambini.Text = "label2";
            // 
            // txtSedie
            // 
            txtSedie.AutoSize = true;
            txtSedie.Location = new Point(382, 246);
            txtSedie.Name = "txtSedie";
            txtSedie.Size = new Size(50, 20);
            txtSedie.TabIndex = 4;
            txtSedie.Text = "label2";
            // 
            // listBoxGiocatori
            // 
            listBoxGiocatori.FormattingEnabled = true;
            listBoxGiocatori.Location = new Point(545, 110);
            listBoxGiocatori.Name = "listBoxGiocatori";
            listBoxGiocatori.Size = new Size(150, 204);
            listBoxGiocatori.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxGiocatori);
            Controls.Add(txtSedie);
            Controls.Add(txtBambini);
            Controls.Add(lblStatoGioco);
            Controls.Add(label1);
            Controls.Add(avviaGioco);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button avviaGioco;
        private Label label1;
        private Label lblStatoGioco;
        private Label txtBambini;
        private Label txtSedie;
        private ListBox listBoxGiocatori;
    }
}

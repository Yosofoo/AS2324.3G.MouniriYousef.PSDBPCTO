namespace AS2324._3G.MouniriYousef.PSDBPCTO
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
            dgvGriglia = new DataGridView();
            btnElencaIta = new Button();
            btnGare = new Button();
            cmbScelta = new ComboBox();
            btnConferma = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGriglia).BeginInit();
            SuspendLayout();
            // 
            // dgvGriglia
            // 
            dgvGriglia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGriglia.Location = new Point(184, 177);
            dgvGriglia.Name = "dgvGriglia";
            dgvGriglia.RowHeadersWidth = 51;
            dgvGriglia.Size = new Size(1030, 309);
            dgvGriglia.TabIndex = 0;
            // 
            // btnElencaIta
            // 
            btnElencaIta.Location = new Point(184, 101);
            btnElencaIta.Name = "btnElencaIta";
            btnElencaIta.Size = new Size(279, 70);
            btnElencaIta.TabIndex = 1;
            btnElencaIta.Text = " Elenco Piloti ";
            btnElencaIta.UseVisualStyleBackColor = true;
            btnElencaIta.Click += btnElencaIta_Click;
            // 
            // btnGare
            // 
            btnGare.Location = new Point(558, 101);
            btnGare.Name = "btnGare";
            btnGare.Size = new Size(279, 70);
            btnGare.TabIndex = 2;
            btnGare.Text = " Elenco Gare";
            btnGare.UseVisualStyleBackColor = true;
            btnGare.Click += btnGare_Click;
            // 
            // cmbScelta
            // 
            cmbScelta.FormattingEnabled = true;
            cmbScelta.Items.AddRange(new object[] { "Elenco squadre non italiane ordinate per nome", "Elenco piloti Ducati ordinati per cognome e nome", "Elenco circuiti ordinati per nome" });
            cmbScelta.Location = new Point(924, 101);
            cmbScelta.Name = "cmbScelta";
            cmbScelta.Size = new Size(234, 28);
            cmbScelta.TabIndex = 3;
            // 
            // btnConferma
            // 
            btnConferma.Location = new Point(924, 142);
            btnConferma.Name = "btnConferma";
            btnConferma.Size = new Size(234, 29);
            btnConferma.TabIndex = 4;
            btnConferma.Text = "Conferma";
            btnConferma.UseVisualStyleBackColor = true;
            btnConferma.Click += btnConferma_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 533);
            Controls.Add(btnConferma);
            Controls.Add(cmbScelta);
            Controls.Add(btnGare);
            Controls.Add(btnElencaIta);
            Controls.Add(dgvGriglia);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvGriglia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGriglia;
        private Button btnElencaIta;
        private Button btnGare;
        private ComboBox cmbScelta;
        private Button btnConferma;
    }
}

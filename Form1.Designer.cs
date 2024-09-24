namespace veletlenszamok_20240924
{
    partial class Form1
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
            this.lbkezdo = new System.Windows.Forms.Label();
            this.lbveg = new System.Windows.Forms.Label();
            this.lblegnagy = new System.Windows.Forms.Label();
            this.lbnegy = new System.Windows.Forms.Label();
            this.lbdb = new System.Windows.Forms.Label();
            this.lbparatlanok = new System.Windows.Forms.Label();
            this.txveg = new System.Windows.Forms.TextBox();
            this.txkezdo = new System.Windows.Forms.TextBox();
            this.txnegy = new System.Windows.Forms.TextBox();
            this.btgeneral = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.txlegna = new System.Windows.Forms.TextBox();
            this.lbtomb = new System.Windows.Forms.Label();
            this.lbparatlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbkezdo
            // 
            this.lbkezdo.AutoSize = true;
            this.lbkezdo.ForeColor = System.Drawing.Color.Green;
            this.lbkezdo.Location = new System.Drawing.Point(101, 100);
            this.lbkezdo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbkezdo.Name = "lbkezdo";
            this.lbkezdo.Size = new System.Drawing.Size(115, 20);
            this.lbkezdo.TabIndex = 0;
            this.lbkezdo.Text = "Kezdő érték: ";
            // 
            // lbveg
            // 
            this.lbveg.AutoSize = true;
            this.lbveg.ForeColor = System.Drawing.Color.Green;
            this.lbveg.Location = new System.Drawing.Point(101, 142);
            this.lbveg.Name = "lbveg";
            this.lbveg.Size = new System.Drawing.Size(97, 20);
            this.lbveg.TabIndex = 1;
            this.lbveg.Text = "Vég érték: ";
            // 
            // lblegnagy
            // 
            this.lblegnagy.AutoSize = true;
            this.lblegnagy.ForeColor = System.Drawing.Color.Green;
            this.lblegnagy.Location = new System.Drawing.Point(101, 252);
            this.lblegnagy.Name = "lblegnagy";
            this.lblegnagy.Size = new System.Drawing.Size(164, 20);
            this.lblegnagy.TabIndex = 2;
            this.lblegnagy.Text = "Legnagyobb szám: ";
            // 
            // lbnegy
            // 
            this.lbnegy.AutoSize = true;
            this.lbnegy.ForeColor = System.Drawing.Color.Green;
            this.lbnegy.Location = new System.Drawing.Point(101, 294);
            this.lbnegy.Name = "lbnegy";
            this.lbnegy.Size = new System.Drawing.Size(177, 20);
            this.lbnegy.TabIndex = 3;
            this.lbnegy.Text = "Néggyel oszthatóak: ";
            // 
            // lbdb
            // 
            this.lbdb.AutoSize = true;
            this.lbdb.ForeColor = System.Drawing.Color.Green;
            this.lbdb.Location = new System.Drawing.Point(390, 297);
            this.lbdb.Name = "lbdb";
            this.lbdb.Size = new System.Drawing.Size(29, 20);
            this.lbdb.TabIndex = 4;
            this.lbdb.Text = "db";
            // 
            // lbparatlanok
            // 
            this.lbparatlanok.AutoSize = true;
            this.lbparatlanok.ForeColor = System.Drawing.Color.Green;
            this.lbparatlanok.Location = new System.Drawing.Point(101, 354);
            this.lbparatlanok.Name = "lbparatlanok";
            this.lbparatlanok.Size = new System.Drawing.Size(105, 20);
            this.lbparatlanok.TabIndex = 5;
            this.lbparatlanok.Text = "Páratlanok: ";
            // 
            // txveg
            // 
            this.txveg.BackColor = System.Drawing.Color.Khaki;
            this.txveg.Location = new System.Drawing.Point(221, 139);
            this.txveg.Name = "txveg";
            this.txveg.Size = new System.Drawing.Size(100, 26);
            this.txveg.TabIndex = 6;
            // 
            // txkezdo
            // 
            this.txkezdo.BackColor = System.Drawing.Color.Khaki;
            this.txkezdo.Location = new System.Drawing.Point(221, 94);
            this.txkezdo.Name = "txkezdo";
            this.txkezdo.Size = new System.Drawing.Size(100, 26);
            this.txkezdo.TabIndex = 7;
            // 
            // txnegy
            // 
            this.txnegy.BackColor = System.Drawing.Color.Khaki;
            this.txnegy.Enabled = false;
            this.txnegy.Location = new System.Drawing.Point(284, 291);
            this.txnegy.Name = "txnegy";
            this.txnegy.Size = new System.Drawing.Size(100, 26);
            this.txnegy.TabIndex = 8;
            // 
            // btgeneral
            // 
            this.btgeneral.ForeColor = System.Drawing.Color.Black;
            this.btgeneral.Location = new System.Drawing.Point(524, 139);
            this.btgeneral.Name = "btgeneral";
            this.btgeneral.Size = new System.Drawing.Size(148, 63);
            this.btgeneral.TabIndex = 9;
            this.btgeneral.Text = "Generálás";
            this.btgeneral.UseVisualStyleBackColor = true;
            this.btgeneral.Click += new System.EventHandler(this.btgeneral_Click);
            // 
            // btexit
            // 
            this.btexit.ForeColor = System.Drawing.Color.Black;
            this.btexit.Location = new System.Drawing.Point(524, 235);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(148, 63);
            this.btexit.TabIndex = 10;
            this.btexit.Text = "Kilépés";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // txlegna
            // 
            this.txlegna.BackColor = System.Drawing.Color.Khaki;
            this.txlegna.Enabled = false;
            this.txlegna.Location = new System.Drawing.Point(284, 252);
            this.txlegna.Name = "txlegna";
            this.txlegna.Size = new System.Drawing.Size(100, 26);
            this.txlegna.TabIndex = 11;
            // 
            // lbtomb
            // 
            this.lbtomb.AutoSize = true;
            this.lbtomb.Location = new System.Drawing.Point(101, 195);
            this.lbtomb.Name = "lbtomb";
            this.lbtomb.Size = new System.Drawing.Size(0, 20);
            this.lbtomb.TabIndex = 12;
            this.lbtomb.Visible = false;
            // 
            // lbparatlan
            // 
            this.lbparatlan.AutoSize = true;
            this.lbparatlan.Location = new System.Drawing.Point(217, 354);
            this.lbparatlan.Name = "lbparatlan";
            this.lbparatlan.Size = new System.Drawing.Size(0, 20);
            this.lbparatlan.TabIndex = 13;
            this.lbparatlan.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(694, 421);
            this.Controls.Add(this.lbparatlan);
            this.Controls.Add(this.lbtomb);
            this.Controls.Add(this.txlegna);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btgeneral);
            this.Controls.Add(this.txnegy);
            this.Controls.Add(this.txkezdo);
            this.Controls.Add(this.txveg);
            this.Controls.Add(this.lbparatlanok);
            this.Controls.Add(this.lbdb);
            this.Controls.Add(this.lbnegy);
            this.Controls.Add(this.lblegnagy);
            this.Controls.Add(this.lbveg);
            this.Controls.Add(this.lbkezdo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Véletlen számok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbkezdo;
        private System.Windows.Forms.Label lbveg;
        private System.Windows.Forms.Label lblegnagy;
        private System.Windows.Forms.Label lbnegy;
        private System.Windows.Forms.Label lbdb;
        private System.Windows.Forms.Label lbparatlanok;
        private System.Windows.Forms.TextBox txveg;
        private System.Windows.Forms.TextBox txkezdo;
        private System.Windows.Forms.TextBox txnegy;
        private System.Windows.Forms.Button btgeneral;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.TextBox txlegna;
        private System.Windows.Forms.Label lbtomb;
        private System.Windows.Forms.Label lbparatlan;
    }
}


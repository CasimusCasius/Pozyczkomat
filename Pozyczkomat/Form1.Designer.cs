namespace Pozyczkomat
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.BtnGiveCash = new System.Windows.Forms.Button();
            this.BtnRecieveCash = new System.Windows.Forms.Button();
            this.JoeGivesToBob = new System.Windows.Forms.Button();
            this.BobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(12, 9);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(35, 13);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "label1";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(12, 45);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(11, 81);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "label3";
            // 
            // BtnGiveCash
            // 
            this.BtnGiveCash.Location = new System.Drawing.Point(41, 104);
            this.BtnGiveCash.Name = "BtnGiveCash";
            this.BtnGiveCash.Size = new System.Drawing.Size(118, 47);
            this.BtnGiveCash.TabIndex = 3;
            this.BtnGiveCash.Text = "Daj 10 zł Joemu";
            this.BtnGiveCash.UseVisualStyleBackColor = true;
            this.BtnGiveCash.Click += new System.EventHandler(this.BtnGiveCash_Click);
            // 
            // BtnRecieveCash
            // 
            this.BtnRecieveCash.Location = new System.Drawing.Point(269, 104);
            this.BtnRecieveCash.Name = "BtnRecieveCash";
            this.BtnRecieveCash.Size = new System.Drawing.Size(118, 47);
            this.BtnRecieveCash.TabIndex = 4;
            this.BtnRecieveCash.Text = "Weź 5 zł od Boba";
            this.BtnRecieveCash.UseVisualStyleBackColor = true;
            this.BtnRecieveCash.Click += new System.EventHandler(this.BtnRecieveCash_Click);
            // 
            // JoeGivesToBob
            // 
            this.JoeGivesToBob.Location = new System.Drawing.Point(41, 186);
            this.JoeGivesToBob.Name = "JoeGivesToBob";
            this.JoeGivesToBob.Size = new System.Drawing.Size(118, 47);
            this.JoeGivesToBob.TabIndex = 5;
            this.JoeGivesToBob.Text = "Joe daje 10 zł Bobowi ";
            this.JoeGivesToBob.UseVisualStyleBackColor = true;
            this.JoeGivesToBob.Click += new System.EventHandler(this.JoeGivesToBob_Click);
            // 
            // BobGivesToJoe
            // 
            this.BobGivesToJoe.Location = new System.Drawing.Point(269, 186);
            this.BobGivesToJoe.Name = "BobGivesToJoe";
            this.BobGivesToJoe.Size = new System.Drawing.Size(118, 47);
            this.BobGivesToJoe.TabIndex = 6;
            this.BobGivesToJoe.Text = "Bob daje 5 zł Joemu";
            this.BobGivesToJoe.UseVisualStyleBackColor = true;
            this.BobGivesToJoe.Click += new System.EventHandler(this.BobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 270);
            this.Controls.Add(this.BobGivesToJoe);
            this.Controls.Add(this.JoeGivesToBob);
            this.Controls.Add(this.BtnRecieveCash);
            this.Controls.Add(this.BtnGiveCash);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Name = "Form1";
            this.Text = "Zabawa z Joe i Bobem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button BtnGiveCash;
        private System.Windows.Forms.Button BtnRecieveCash;
        private System.Windows.Forms.Button JoeGivesToBob;
        private System.Windows.Forms.Button BobGivesToJoe;
    }
}


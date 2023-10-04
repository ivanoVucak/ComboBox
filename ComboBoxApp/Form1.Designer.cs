namespace ComboBoxApp
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
            this.odaberiCb = new System.Windows.Forms.ComboBox();
            this.odabranoTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // odaberiCb
            // 
            this.odaberiCb.FormattingEnabled = true;
            this.odaberiCb.Items.AddRange(new object[] {
            "IT menadzment",
            "aplikativno programiranje",
            "internet programiranje",
            "informacioni sistemi"});
            this.odaberiCb.Location = new System.Drawing.Point(35, 34);
            this.odaberiCb.Name = "odaberiCb";
            this.odaberiCb.Size = new System.Drawing.Size(148, 21);
            this.odaberiCb.TabIndex = 0;
            this.odaberiCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // odabranoTb
            // 
            this.odabranoTb.Location = new System.Drawing.Point(21, 82);
            this.odabranoTb.Name = "odabranoTb";
            this.odabranoTb.Size = new System.Drawing.Size(193, 20);
            this.odabranoTb.TabIndex = 1;
            this.odabranoTb.Text = "Odabrali ste: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 134);
            this.Controls.Add(this.odabranoTb);
            this.Controls.Add(this.odaberiCb);
            this.Name = "Form1";
            this.Text = "Upotreba ComboBox kontrole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox odaberiCb;
        private System.Windows.Forms.TextBox odabranoTb;
    }
}


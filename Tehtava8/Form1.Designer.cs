namespace Tehtava8
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
            this.label1 = new System.Windows.Forms.Label();
            this.vastaus_label = new System.Windows.Forms.Label();
            this.numero_textBox = new System.Windows.Forms.TextBox();
            this.muuta_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna numero 1-3999 välistä ja muuta se roomalaiseksi";
            // 
            // vastaus_label
            // 
            this.vastaus_label.AutoSize = true;
            this.vastaus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastaus_label.Location = new System.Drawing.Point(21, 163);
            this.vastaus_label.Name = "vastaus_label";
            this.vastaus_label.Size = new System.Drawing.Size(90, 25);
            this.vastaus_label.TabIndex = 1;
            this.vastaus_label.Text = "Vastaus";
            this.vastaus_label.Visible = false;
            // 
            // numero_textBox
            // 
            this.numero_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_textBox.Location = new System.Drawing.Point(563, 112);
            this.numero_textBox.Name = "numero_textBox";
            this.numero_textBox.Size = new System.Drawing.Size(129, 31);
            this.numero_textBox.TabIndex = 2;
            // 
            // muuta_button
            // 
            this.muuta_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muuta_button.Location = new System.Drawing.Point(564, 163);
            this.muuta_button.Name = "muuta_button";
            this.muuta_button.Size = new System.Drawing.Size(128, 35);
            this.muuta_button.TabIndex = 3;
            this.muuta_button.Text = "Muuta";
            this.muuta_button.UseVisualStyleBackColor = true;
            this.muuta_button.Click += new System.EventHandler(this.muuta_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.muuta_button);
            this.Controls.Add(this.numero_textBox);
            this.Controls.Add(this.vastaus_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vastaus_label;
        private System.Windows.Forms.TextBox numero_textBox;
        private System.Windows.Forms.Button muuta_button;
    }
}


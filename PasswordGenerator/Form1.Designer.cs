namespace PasswordGenerator
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.passwordLengthSlider = new System.Windows.Forms.TrackBar();
            this.copyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(72, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(664, 64);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "label1";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLengthLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLengthLabel.Location = new System.Drawing.Point(68, 193);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(664, 64);
            this.passwordLengthLabel.TabIndex = 1;
            this.passwordLengthLabel.Text = "Password Length: 5";
            this.passwordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Location = new System.Drawing.Point(232, 283);
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.Size = new System.Drawing.Size(323, 56);
            this.passwordLengthSlider.TabIndex = 2;
            this.passwordLengthSlider.Scroll += new System.EventHandler(this.passwordLengthSlider_Scroll);
            // 
            // copyPasswordButton
            // 
            this.copyPasswordButton.BackColor = System.Drawing.Color.White;
            this.copyPasswordButton.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPasswordButton.ForeColor = System.Drawing.Color.Black;
            this.copyPasswordButton.Location = new System.Drawing.Point(242, 361);
            this.copyPasswordButton.Name = "copyPasswordButton";
            this.copyPasswordButton.Size = new System.Drawing.Size(299, 54);
            this.copyPasswordButton.TabIndex = 3;
            this.copyPasswordButton.Text = "Copy Password";
            this.copyPasswordButton.UseVisualStyleBackColor = false;
            this.copyPasswordButton.Click += new System.EventHandler(this.copyPasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.copyPasswordButton);
            this.Controls.Add(this.passwordLengthSlider);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.passwordLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TrackBar passwordLengthSlider;
        private System.Windows.Forms.Button copyPasswordButton;
    }
}


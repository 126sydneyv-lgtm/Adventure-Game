namespace Adventure_Game
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
            this.choice1Button = new System.Windows.Forms.Button();
            this.choice2Button = new System.Windows.Forms.Button();
            this.choice3Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choice1Button
            // 
            this.choice1Button.Location = new System.Drawing.Point(186, 317);
            this.choice1Button.Name = "choice1Button";
            this.choice1Button.Size = new System.Drawing.Size(75, 23);
            this.choice1Button.TabIndex = 0;
            this.choice1Button.Text = "button1";
            this.choice1Button.UseVisualStyleBackColor = true;
            this.choice1Button.Click += new System.EventHandler(this.choice1Button_Click);
            // 
            // choice2Button
            // 
            this.choice2Button.Location = new System.Drawing.Point(382, 317);
            this.choice2Button.Name = "choice2Button";
            this.choice2Button.Size = new System.Drawing.Size(75, 23);
            this.choice2Button.TabIndex = 1;
            this.choice2Button.Text = "button1";
            this.choice2Button.UseVisualStyleBackColor = true;
            this.choice2Button.Click += new System.EventHandler(this.choice2Button_Click);
            // 
            // choice3Button
            // 
            this.choice3Button.Location = new System.Drawing.Point(574, 317);
            this.choice3Button.Name = "choice3Button";
            this.choice3Button.Size = new System.Drawing.Size(75, 23);
            this.choice3Button.TabIndex = 2;
            this.choice3Button.Text = "button1";
            this.choice3Button.UseVisualStyleBackColor = true;
            this.choice3Button.Click += new System.EventHandler(this.choice3Button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(385, 114);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(44, 16);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.choice3Button);
            this.Controls.Add(this.choice2Button);
            this.Controls.Add(this.choice1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choice1Button;
        private System.Windows.Forms.Button choice2Button;
        private System.Windows.Forms.Button choice3Button;
        private System.Windows.Forms.Label outputLabel;
    }
}


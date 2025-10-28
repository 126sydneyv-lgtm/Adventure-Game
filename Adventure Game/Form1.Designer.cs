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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.choice1Button = new System.Windows.Forms.Button();
            this.choice2Button = new System.Windows.Forms.Button();
            this.choice3Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choice1Button
            // 
            this.choice1Button.AutoSize = true;
            this.choice1Button.Location = new System.Drawing.Point(209, 396);
            this.choice1Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choice1Button.Name = "choice1Button";
            this.choice1Button.Size = new System.Drawing.Size(84, 32);
            this.choice1Button.TabIndex = 0;
            this.choice1Button.Text = "button1";
            this.choice1Button.UseVisualStyleBackColor = true;
            this.choice1Button.Click += new System.EventHandler(this.choice1Button_Click);
            // 
            // choice2Button
            // 
            this.choice2Button.AutoSize = true;
            this.choice2Button.Location = new System.Drawing.Point(430, 396);
            this.choice2Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choice2Button.Name = "choice2Button";
            this.choice2Button.Size = new System.Drawing.Size(84, 32);
            this.choice2Button.TabIndex = 1;
            this.choice2Button.Text = "button1";
            this.choice2Button.UseVisualStyleBackColor = true;
            this.choice2Button.Click += new System.EventHandler(this.choice2Button_Click);
            // 
            // choice3Button
            // 
            this.choice3Button.AutoSize = true;
            this.choice3Button.Location = new System.Drawing.Point(646, 396);
            this.choice3Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choice3Button.Name = "choice3Button";
            this.choice3Button.Size = new System.Drawing.Size(84, 32);
            this.choice3Button.TabIndex = 2;
            this.choice3Button.Text = "button1";
            this.choice3Button.UseVisualStyleBackColor = true;
            this.choice3Button.Click += new System.EventHandler(this.choice3Button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(433, 142);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(51, 20);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.choice3Button);
            this.Controls.Add(this.choice2Button);
            this.Controls.Add(this.choice1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Into The Void";
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


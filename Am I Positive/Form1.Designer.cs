
namespace Am_I_Positive
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
            this.inputOutputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputOutputLabel
            // 
            this.inputOutputLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOutputLabel.Location = new System.Drawing.Point(96, 82);
            this.inputOutputLabel.Name = "inputOutputLabel";
            this.inputOutputLabel.Size = new System.Drawing.Size(258, 34);
            this.inputOutputLabel.TabIndex = 0;
            this.inputOutputLabel.Text = "Input an integer";
            // 
            // outputLabel
            // 
            this.outputLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(96, 296);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(615, 33);
            this.outputLabel.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.enterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(422, 191);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(105, 41);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(422, 82);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(105, 34);
            this.inputBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputOutputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputOutputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox inputBox;
    }
}


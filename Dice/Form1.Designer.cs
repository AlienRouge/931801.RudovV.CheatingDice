
namespace Dice
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
            this.playerCube1 = new System.Windows.Forms.TextBox();
            this.playerCube2 = new System.Windows.Forms.TextBox();
            this.playerCube3 = new System.Windows.Forms.TextBox();
            this.computerCube1 = new System.Windows.Forms.TextBox();
            this.computerCube2 = new System.Windows.Forms.TextBox();
            this.computerCube3 = new System.Windows.Forms.TextBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.winnerBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerCube1
            // 
            this.playerCube1.Location = new System.Drawing.Point(4, 22);
            this.playerCube1.Name = "playerCube1";
            this.playerCube1.Size = new System.Drawing.Size(22, 20);
            this.playerCube1.TabIndex = 0;
            // 
            // playerCube2
            // 
            this.playerCube2.Location = new System.Drawing.Point(32, 22);
            this.playerCube2.Name = "playerCube2";
            this.playerCube2.Size = new System.Drawing.Size(22, 20);
            this.playerCube2.TabIndex = 1;
            // 
            // playerCube3
            // 
            this.playerCube3.Location = new System.Drawing.Point(60, 22);
            this.playerCube3.Name = "playerCube3";
            this.playerCube3.Size = new System.Drawing.Size(22, 20);
            this.playerCube3.TabIndex = 2;
            // 
            // computerCube1
            // 
            this.computerCube1.Location = new System.Drawing.Point(113, 22);
            this.computerCube1.Name = "computerCube1";
            this.computerCube1.Size = new System.Drawing.Size(22, 20);
            this.computerCube1.TabIndex = 3;
            // 
            // computerCube2
            // 
            this.computerCube2.Location = new System.Drawing.Point(141, 22);
            this.computerCube2.Name = "computerCube2";
            this.computerCube2.Size = new System.Drawing.Size(22, 20);
            this.computerCube2.TabIndex = 4;
            // 
            // computerCube3
            // 
            this.computerCube3.Location = new System.Drawing.Point(169, 22);
            this.computerCube3.Name = "computerCube3";
            this.computerCube3.Size = new System.Drawing.Size(22, 20);
            this.computerCube3.TabIndex = 5;
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(72, 127);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(75, 23);
            this.RollButton.TabIndex = 6;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dices";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.playerCube3);
            this.panel1.Controls.Add(this.playerCube2);
            this.panel1.Controls.Add(this.computerCube1);
            this.panel1.Controls.Add(this.computerCube2);
            this.panel1.Controls.Add(this.computerCube3);
            this.panel1.Controls.Add(this.playerCube1);
            this.panel1.Location = new System.Drawing.Point(8, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 55);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Computer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Player";
            // 
            // winnerBox
            // 
            this.winnerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winnerBox.Location = new System.Drawing.Point(37, 102);
            this.winnerBox.Name = "winnerBox";
            this.winnerBox.Size = new System.Drawing.Size(139, 20);
            this.winnerBox.TabIndex = 10;
            this.winnerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(218, 159);
            this.Controls.Add(this.winnerBox);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "He is cheater!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerCube1;
        private System.Windows.Forms.TextBox playerCube2;
        private System.Windows.Forms.TextBox playerCube3;
        private System.Windows.Forms.TextBox computerCube1;
        private System.Windows.Forms.TextBox computerCube2;
        private System.Windows.Forms.TextBox computerCube3;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox winnerBox;
    }
}


namespace CST_150_Activity11
{
    partial class diceRollForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diceRollForm));
            this.rollBtn = new System.Windows.Forms.Button();
            this.dice1Txt = new System.Windows.Forms.TextBox();
            this.dice2Txt = new System.Windows.Forms.TextBox();
            this.dice1Lbl = new System.Windows.Forms.Label();
            this.dice2Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollBtn
            // 
            this.rollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBtn.ForeColor = System.Drawing.Color.Black;
            this.rollBtn.Location = new System.Drawing.Point(12, 12);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(115, 111);
            this.rollBtn.TabIndex = 0;
            this.rollBtn.Text = "Roll Dice";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dice1Txt
            // 
            this.dice1Txt.Location = new System.Drawing.Point(153, 103);
            this.dice1Txt.Name = "dice1Txt";
            this.dice1Txt.Size = new System.Drawing.Size(100, 20);
            this.dice1Txt.TabIndex = 1;
            // 
            // dice2Txt
            // 
            this.dice2Txt.Location = new System.Drawing.Point(269, 103);
            this.dice2Txt.Name = "dice2Txt";
            this.dice2Txt.Size = new System.Drawing.Size(100, 20);
            this.dice2Txt.TabIndex = 2;
            // 
            // dice1Lbl
            // 
            this.dice1Lbl.AutoSize = true;
            this.dice1Lbl.Location = new System.Drawing.Point(180, 87);
            this.dice1Lbl.Name = "dice1Lbl";
            this.dice1Lbl.Size = new System.Drawing.Size(38, 13);
            this.dice1Lbl.TabIndex = 3;
            this.dice1Lbl.Text = "Dice 1";
            // 
            // dice2Lbl
            // 
            this.dice2Lbl.AutoSize = true;
            this.dice2Lbl.Location = new System.Drawing.Point(303, 87);
            this.dice2Lbl.Name = "dice2Lbl";
            this.dice2Lbl.Size = new System.Drawing.Size(38, 13);
            this.dice2Lbl.TabIndex = 4;
            this.dice2Lbl.Text = "Dice 2";
            // 
            // diceRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::CST_150_Activity11.Properties.Resources.Activity11_BckGrd;
            this.ClientSize = new System.Drawing.Size(413, 165);
            this.Controls.Add(this.dice2Lbl);
            this.Controls.Add(this.dice1Lbl);
            this.Controls.Add(this.dice2Txt);
            this.Controls.Add(this.dice1Txt);
            this.Controls.Add(this.rollBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diceRollForm";
            this.Text = "Dice roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.TextBox dice1Txt;
        private System.Windows.Forms.TextBox dice2Txt;
        private System.Windows.Forms.Label dice1Lbl;
        private System.Windows.Forms.Label dice2Lbl;
    }
}


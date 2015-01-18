namespace Assigment1
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
            this.components = new System.ComponentModel.Container();
            this.pBoxDice2 = new System.Windows.Forms.PictureBox();
            this.pBoxDice1 = new System.Windows.Forms.PictureBox();
            this.btnThrowDice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblNextDraw = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScoreAfter = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxDice2
            // 
            this.pBoxDice2.BackgroundImage = global::Assigment1.Properties.Resources.Dice_1;
            this.pBoxDice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxDice2.Location = new System.Drawing.Point(241, 73);
            this.pBoxDice2.Name = "pBoxDice2";
            this.pBoxDice2.Size = new System.Drawing.Size(165, 147);
            this.pBoxDice2.TabIndex = 0;
            this.pBoxDice2.TabStop = false;
            // 
            // pBoxDice1
            // 
            this.pBoxDice1.BackgroundImage = global::Assigment1.Properties.Resources.Dice_1;
            this.pBoxDice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxDice1.Location = new System.Drawing.Point(241, 351);
            this.pBoxDice1.Name = "pBoxDice1";
            this.pBoxDice1.Size = new System.Drawing.Size(165, 147);
            this.pBoxDice1.TabIndex = 1;
            this.pBoxDice1.TabStop = false;
            // 
            // btnThrowDice
            // 
            this.btnThrowDice.Location = new System.Drawing.Point(117, 547);
            this.btnThrowDice.Name = "btnThrowDice";
            this.btnThrowDice.Size = new System.Drawing.Size(150, 118);
            this.btnThrowDice.TabIndex = 2;
            this.btnThrowDice.Text = "Throw Dice";
            this.btnThrowDice.UseVisualStyleBackColor = true;
            this.btnThrowDice.Click += new System.EventHandler(this.btnThrowDice_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(398, 547);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 118);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.BackColor = System.Drawing.Color.Transparent;
            this.lblRounds.Location = new System.Drawing.Point(114, 55);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(51, 13);
            this.lblRounds.TabIndex = 4;
            this.lblRounds.Text = "Round: 0";
            // 
            // lblNextDraw
            // 
            this.lblNextDraw.AutoSize = true;
            this.lblNextDraw.BackColor = System.Drawing.Color.Transparent;
            this.lblNextDraw.Location = new System.Drawing.Point(114, 88);
            this.lblNextDraw.Name = "lblNextDraw";
            this.lblNextDraw.Size = new System.Drawing.Size(67, 13);
            this.lblNextDraw.TabIndex = 5;
            this.lblNextDraw.Text = "Next to draw";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(114, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Player";
            // 
            // lblScoreAfter
            // 
            this.lblScoreAfter.AutoSize = true;
            this.lblScoreAfter.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreAfter.Location = new System.Drawing.Point(454, 55);
            this.lblScoreAfter.Name = "lblScoreAfter";
            this.lblScoreAfter.Size = new System.Drawing.Size(94, 13);
            this.lblScoreAfter.TabIndex = 7;
            this.lblScoreAfter.Text = "Score after rounds";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Location = new System.Drawing.Point(494, 111);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(13, 13);
            this.lblScore2.TabIndex = 8;
            this.lblScore2.Text = "0";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Transparent;
            this.lblScore1.Location = new System.Drawing.Point(494, 389);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(13, 13);
            this.lblScore1.TabIndex = 9;
            this.lblScore1.Text = "0";
            // 
            // myTimer
            // 
            this.myTimer.Interval = 1000;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assigment1.Properties.Resources.PoolTable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 731);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScoreAfter);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNextDraw);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnThrowDice);
            this.Controls.Add(this.pBoxDice1);
            this.Controls.Add(this.pBoxDice2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxDice2;
        private System.Windows.Forms.PictureBox pBoxDice1;
        private System.Windows.Forms.Button btnThrowDice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblNextDraw;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScoreAfter;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Timer myTimer;
    }
}


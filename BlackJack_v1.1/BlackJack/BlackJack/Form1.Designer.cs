namespace BlackJack
{
    partial class BlackJack
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
            this.dealerHand = new System.Windows.Forms.Label();
            this.playerHand = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnHIT = new System.Windows.Forms.Button();
            this.btnSTAND = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDEAL = new System.Windows.Forms.Button();
            this.lblUSERSUM = new System.Windows.Forms.Label();
            this.lblSUMCPU = new System.Windows.Forms.Label();
            this.winORLOSE = new System.Windows.Forms.Label();
            this.playAGAIN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 151);
            this.label1.TabIndex = 0;
            this.label1.Text = "Black Jack";
            // 
            // dealerHand
            // 
            this.dealerHand.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.dealerHand.ForeColor = System.Drawing.Color.White;
            this.dealerHand.Location = new System.Drawing.Point(520, 173);
            this.dealerHand.Name = "dealerHand";
            this.dealerHand.Size = new System.Drawing.Size(210, 40);
            this.dealerHand.TabIndex = 5;
            this.dealerHand.Text = "Dealer Hand";
            this.dealerHand.Click += new System.EventHandler(this.dealerHand_Click);
            // 
            // playerHand
            // 
            this.playerHand.BackColor = System.Drawing.Color.Transparent;
            this.playerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.playerHand.ForeColor = System.Drawing.Color.White;
            this.playerHand.Location = new System.Drawing.Point(520, 467);
            this.playerHand.Name = "playerHand";
            this.playerHand.Size = new System.Drawing.Size(210, 40);
            this.playerHand.TabIndex = 6;
            this.playerHand.Text = "Player Hand";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(474, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 206);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(642, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 206);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(642, 510);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 206);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(474, 510);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 206);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // btnHIT
            // 
            this.btnHIT.BackColor = System.Drawing.Color.Firebrick;
            this.btnHIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnHIT.Location = new System.Drawing.Point(820, 510);
            this.btnHIT.Name = "btnHIT";
            this.btnHIT.Size = new System.Drawing.Size(139, 90);
            this.btnHIT.TabIndex = 11;
            this.btnHIT.Text = "Hit";
            this.btnHIT.UseVisualStyleBackColor = false;
            this.btnHIT.Click += new System.EventHandler(this.btnHIT_Click);
            // 
            // btnSTAND
            // 
            this.btnSTAND.BackColor = System.Drawing.Color.Turquoise;
            this.btnSTAND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSTAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSTAND.Location = new System.Drawing.Point(820, 626);
            this.btnSTAND.Name = "btnSTAND";
            this.btnSTAND.Size = new System.Drawing.Size(139, 90);
            this.btnSTAND.TabIndex = 12;
            this.btnSTAND.Text = "Stand";
            this.btnSTAND.UseVisualStyleBackColor = false;
            this.btnSTAND.Click += new System.EventHandler(this.btnSTAND_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // btnDEAL
            // 
            this.btnDEAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDEAL.Location = new System.Drawing.Point(998, 538);
            this.btnDEAL.Name = "btnDEAL";
            this.btnDEAL.Size = new System.Drawing.Size(264, 139);
            this.btnDEAL.TabIndex = 15;
            this.btnDEAL.Text = "Deal";
            this.btnDEAL.UseVisualStyleBackColor = true;
            this.btnDEAL.Click += new System.EventHandler(this.btnDEAL_Click);
            // 
            // lblUSERSUM
            // 
            this.lblUSERSUM.AutoSize = true;
            this.lblUSERSUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblUSERSUM.Location = new System.Drawing.Point(723, 472);
            this.lblUSERSUM.Name = "lblUSERSUM";
            this.lblUSERSUM.Size = new System.Drawing.Size(35, 31);
            this.lblUSERSUM.TabIndex = 16;
            this.lblUSERSUM.Text = "   ";
            this.lblUSERSUM.Click += new System.EventHandler(this.lblSUM_Click);
            // 
            // lblSUMCPU
            // 
            this.lblSUMCPU.AutoSize = true;
            this.lblSUMCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSUMCPU.Location = new System.Drawing.Point(723, 178);
            this.lblSUMCPU.Name = "lblSUMCPU";
            this.lblSUMCPU.Size = new System.Drawing.Size(35, 31);
            this.lblSUMCPU.TabIndex = 17;
            this.lblSUMCPU.Text = "   ";
            this.lblSUMCPU.Click += new System.EventHandler(this.lblSUMCPU_Click);
            // 
            // winORLOSE
            // 
            this.winORLOSE.AutoSize = true;
            this.winORLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.winORLOSE.Location = new System.Drawing.Point(875, 264);
            this.winORLOSE.Name = "winORLOSE";
            this.winORLOSE.Size = new System.Drawing.Size(349, 63);
            this.winORLOSE.TabIndex = 18;
            this.winORLOSE.Text = "                       ";
            this.winORLOSE.Click += new System.EventHandler(this.winORLOSE_Click);
            // 
            // playAGAIN
            // 
            this.playAGAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playAGAIN.Location = new System.Drawing.Point(988, 368);
            this.playAGAIN.Name = "playAGAIN";
            this.playAGAIN.Size = new System.Drawing.Size(264, 139);
            this.playAGAIN.TabIndex = 19;
            this.playAGAIN.Text = "Play again?";
            this.playAGAIN.UseVisualStyleBackColor = true;
            this.playAGAIN.Click += new System.EventHandler(this.playAGAIN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.poker_table_background_green_color_47243_1068;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playAGAIN);
            this.Controls.Add(this.winORLOSE);
            this.Controls.Add(this.lblSUMCPU);
            this.Controls.Add(this.lblUSERSUM);
            this.Controls.Add(this.btnDEAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSTAND);
            this.Controls.Add(this.btnHIT);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerHand);
            this.Controls.Add(this.dealerHand);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "BlackJack";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dealerHand;
        private System.Windows.Forms.Label playerHand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnHIT;
        private System.Windows.Forms.Button btnSTAND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDEAL;
        private System.Windows.Forms.Label lblUSERSUM;
        private System.Windows.Forms.Label lblSUMCPU;
        private System.Windows.Forms.Label winORLOSE;
        private System.Windows.Forms.Button playAGAIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}


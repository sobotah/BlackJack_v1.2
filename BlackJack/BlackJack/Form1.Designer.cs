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
            this.btnEXIT = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 19);
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
            this.dealerHand.Location = new System.Drawing.Point(295, 160);
            this.dealerHand.Name = "dealerHand";
            this.dealerHand.Size = new System.Drawing.Size(210, 40);
            this.dealerHand.TabIndex = 5;
            this.dealerHand.Text = "Dealer Hand";
            // 
            // playerHand
            // 
            this.playerHand.BackColor = System.Drawing.Color.Transparent;
            this.playerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.playerHand.ForeColor = System.Drawing.Color.White;
            this.playerHand.Location = new System.Drawing.Point(295, 308);
            this.playerHand.Name = "playerHand";
            this.playerHand.Size = new System.Drawing.Size(210, 40);
            this.playerHand.TabIndex = 6;
            this.playerHand.Text = "Player Hand";
            // 
            // btnHIT
            // 
            this.btnHIT.BackColor = System.Drawing.Color.Firebrick;
            this.btnHIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnHIT.Location = new System.Drawing.Point(302, 433);
            this.btnHIT.Name = "btnHIT";
            this.btnHIT.Size = new System.Drawing.Size(117, 81);
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
            this.btnSTAND.Location = new System.Drawing.Point(416, 433);
            this.btnSTAND.Name = "btnSTAND";
            this.btnSTAND.Size = new System.Drawing.Size(117, 81);
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
            this.btnDEAL.Location = new System.Drawing.Point(286, 529);
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
            this.lblUSERSUM.Location = new System.Drawing.Point(498, 313);
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
            this.lblSUMCPU.Location = new System.Drawing.Point(498, 165);
            this.lblSUMCPU.Name = "lblSUMCPU";
            this.lblSUMCPU.Size = new System.Drawing.Size(35, 31);
            this.lblSUMCPU.TabIndex = 17;
            this.lblSUMCPU.Text = "   ";
            this.lblSUMCPU.Click += new System.EventHandler(this.lblSUMCPU_Click);
            // 
            // winORLOSE
            // 
            this.winORLOSE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.winORLOSE.BackColor = System.Drawing.Color.Transparent;
            this.winORLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.winORLOSE.ForeColor = System.Drawing.SystemColors.Control;
            this.winORLOSE.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.winORLOSE.Location = new System.Drawing.Point(247, 671);
            this.winORLOSE.Name = "winORLOSE";
            this.winORLOSE.Size = new System.Drawing.Size(349, 63);
            this.winORLOSE.TabIndex = 18;
            this.winORLOSE.Text = "                       ";
            this.winORLOSE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winORLOSE.Click += new System.EventHandler(this.winORLOSE_Click);
            // 
            // playAGAIN
            // 
            this.playAGAIN.BackColor = System.Drawing.Color.RosyBrown;
            this.playAGAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playAGAIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playAGAIN.Location = new System.Drawing.Point(286, 529);
            this.playAGAIN.Name = "playAGAIN";
            this.playAGAIN.Size = new System.Drawing.Size(264, 139);
            this.playAGAIN.TabIndex = 19;
            this.playAGAIN.Text = "Play again?";
            this.playAGAIN.UseVisualStyleBackColor = false;
            this.playAGAIN.Click += new System.EventHandler(this.playAGAIN_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(302, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 67);
            this.label3.TabIndex = 20;
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(302, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 66);
            this.label4.TabIndex = 21;
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.Black;
            this.btnEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnEXIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEXIT.Location = new System.Drawing.Point(720, 707);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(91, 45);
            this.btnEXIT.TabIndex = 22;
            this.btnEXIT.Text = "Exit";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.button1_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(618, 552);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(168, 91);
            this.restart.TabIndex = 23;
            this.restart.Text = " Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.poker_table_background_green_color_47243_1068;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 761);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.btnEXIT);
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
            this.Controls.Add(this.playerHand);
            this.Controls.Add(this.dealerHand);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "BlackJack";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dealerHand;
        private System.Windows.Forms.Label playerHand;
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
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button restart;
    }
}


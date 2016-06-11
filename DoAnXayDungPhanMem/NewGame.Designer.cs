namespace DoAnXayDungPhanMem
{
    partial class NewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.ptb_Start = new System.Windows.Forms.PictureBox();
            this.txt_Player2 = new System.Windows.Forms.TextBox();
            this.txt_Player1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_close = new System.Windows.Forms.PictureBox();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_Start
            // 
            this.ptb_Start.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Start.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Start.Image")));
            this.ptb_Start.Location = new System.Drawing.Point(144, 143);
            this.ptb_Start.Name = "ptb_Start";
            this.ptb_Start.Size = new System.Drawing.Size(76, 30);
            this.ptb_Start.TabIndex = 27;
            this.ptb_Start.TabStop = false;
            this.ptb_Start.MouseEnter += new System.EventHandler(this.ptb_Start_MouseEnter);
            this.ptb_Start.MouseLeave += new System.EventHandler(this.ptb_Start_MouseLeave);
            // 
            // txt_Player2
            // 
            this.txt_Player2.BackColor = System.Drawing.Color.Peru;
            this.txt_Player2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Player2.Location = new System.Drawing.Point(187, 99);
            this.txt_Player2.MaxLength = 8;
            this.txt_Player2.Name = "txt_Player2";
            this.txt_Player2.Size = new System.Drawing.Size(100, 20);
            this.txt_Player2.TabIndex = 26;
            // 
            // txt_Player1
            // 
            this.txt_Player1.BackColor = System.Drawing.Color.Peru;
            this.txt_Player1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Player1.Location = new System.Drawing.Point(187, 62);
            this.txt_Player1.MaxLength = 8;
            this.txt_Player1.Name = "txt_Player1";
            this.txt_Player1.Size = new System.Drawing.Size(100, 20);
            this.txt_Player1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên Người chơi 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Người chơi 1";
            // 
            // ptb_close
            // 
            this.ptb_close.BackColor = System.Drawing.Color.Transparent;
            this.ptb_close.Image = ((System.Drawing.Image)(resources.GetObject("ptb_close.Image")));
            this.ptb_close.Location = new System.Drawing.Point(317, 5);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(25, 25);
            this.ptb_close.TabIndex = 28;
            this.ptb_close.TabStop = false;
            this.ptb_close.Click += new System.EventHandler(this.ptb_close_Click);
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "Background.png");
            this.imglist.Images.SetKeyName(1, "BatDau.png");
            this.imglist.Images.SetKeyName(2, "BatDau_MouseOver.png");
            this.imglist.Images.SetKeyName(3, "Cancel.png");
            this.imglist.Images.SetKeyName(4, "Cancel_MouseOver.png");
            this.imglist.Images.SetKeyName(5, "CanMove.png");
            this.imglist.Images.SetKeyName(6, "cCancel.png");
            this.imglist.Images.SetKeyName(7, "cCancel_MouseOver.png");
            this.imglist.Images.SetKeyName(8, "ChapXong.png");
            this.imglist.Images.SetKeyName(9, "ChapXong_MouseOver.png");
            this.imglist.Images.SetKeyName(10, "ChoiLai.png");
            this.imglist.Images.SetKeyName(11, "ChoiLai_MouseOver.png");
            this.imglist.Images.SetKeyName(12, "Chuot.gif");
            this.imglist.Images.SetKeyName(13, "Close.png");
            this.imglist.Images.SetKeyName(14, "Close_MouseOver.png");
            this.imglist.Images.SetKeyName(15, "Del.png");
            this.imglist.Images.SetKeyName(16, "Del_MouseOver.png");
            this.imglist.Images.SetKeyName(17, "DiLai.png");
            this.imglist.Images.SetKeyName(18, "DiLai_MouseOver.png");
            this.imglist.Images.SetKeyName(19, "Exit.png");
            this.imglist.Images.SetKeyName(20, "Exit_MouseOver.png");
            this.imglist.Images.SetKeyName(21, "Ketquabg.png");
            this.imglist.Images.SetKeyName(22, "MessBox_bg1.png");
            this.imglist.Images.SetKeyName(23, "Mini.png");
            this.imglist.Images.SetKeyName(24, "Mini_MouseOver.png");
            this.imglist.Images.SetKeyName(25, "Newgame.png");
            this.imglist.Images.SetKeyName(26, "Newgame_MouseOver.png");
            this.imglist.Images.SetKeyName(27, "NotTurn.png");
            this.imglist.Images.SetKeyName(28, "Ok.png");
            this.imglist.Images.SetKeyName(29, "Ok_MouseOver.png");
            this.imglist.Images.SetKeyName(30, "Open.png");
            this.imglist.Images.SetKeyName(31, "Open_MouseOver.png");
            this.imglist.Images.SetKeyName(32, "Openbg.png");
            this.imglist.Images.SetKeyName(33, "OptBg.png");
            this.imglist.Images.SetKeyName(34, "Options.png");
            this.imglist.Images.SetKeyName(35, "Options_MouseOver.png");
            this.imglist.Images.SetKeyName(36, "Play.png");
            this.imglist.Images.SetKeyName(37, "Play_MouseOver.png");
            this.imglist.Images.SetKeyName(38, "Save.png");
            this.imglist.Images.SetKeyName(39, "Save_MouseOver.png");
            this.imglist.Images.SetKeyName(40, "Thoat.png");
            this.imglist.Images.SetKeyName(41, "Thoat_MouseOver.png");
            this.imglist.Images.SetKeyName(42, "Turning.png");
            this.imglist.Images.SetKeyName(43, "Undo.png");
            this.imglist.Images.SetKeyName(44, "Undo_MouseOver.png");
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 194);
            this.Controls.Add(this.ptb_close);
            this.Controls.Add(this.ptb_Start);
            this.Controls.Add(this.txt_Player2);
            this.Controls.Add(this.txt_Player1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewGame";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_NewGame";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Start;
        private System.Windows.Forms.TextBox txt_Player2;
        private System.Windows.Forms.TextBox txt_Player1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_close;
        private System.Windows.Forms.ImageList imglist;
    }
}


namespace AI3_A_Team_CSharp_Project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTitle1 = new System.Windows.Forms.PictureBox();
            this.mainExit = new System.Windows.Forms.PictureBox();
            this.libButton2 = new System.Windows.Forms.Button();
            this.libButton1 = new System.Windows.Forms.Button();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainTitle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitle1
            // 
            this.mainTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.mainTitle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainTitle1.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_cs_120px;
            this.mainTitle1.Location = new System.Drawing.Point(12, -1);
            this.mainTitle1.Name = "mainTitle1";
            this.mainTitle1.Size = new System.Drawing.Size(158, 131);
            this.mainTitle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainTitle1.TabIndex = 5;
            this.mainTitle1.TabStop = false;
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_close_window_96px;
            this.mainExit.Location = new System.Drawing.Point(365, 337);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(52, 54);
            this.mainExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainExit.TabIndex = 3;
            this.mainExit.TabStop = false;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            this.mainExit.MouseHover += new System.EventHandler(this.mainExit_MouseHover);
            // 
            // libButton2
            // 
            this.libButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.libButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.libButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.libButton2.ForeColor = System.Drawing.Color.White;
            this.libButton2.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_favorites_80px;
            this.libButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.libButton2.Location = new System.Drawing.Point(12, 269);
            this.libButton2.Name = "libButton2";
            this.libButton2.Size = new System.Drawing.Size(158, 122);
            this.libButton2.TabIndex = 2;
            this.libButton2.Text = "인기 대출도서";
            this.libButton2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.libButton2.UseVisualStyleBackColor = false;
            this.libButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // libButton1
            // 
            this.libButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.libButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.libButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.libButton1.ForeColor = System.Drawing.Color.White;
            this.libButton1.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_literature_80px_1;
            this.libButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.libButton1.Location = new System.Drawing.Point(12, 141);
            this.libButton1.Name = "libButton1";
            this.libButton1.Size = new System.Drawing.Size(158, 122);
            this.libButton1.TabIndex = 1;
            this.libButton1.Text = "도서 검색";
            this.libButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.libButton1.UseVisualStyleBackColor = false;
            this.libButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPic
            // 
            this.mainPic.BackColor = System.Drawing.SystemColors.Control;
            this.mainPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPic.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.books_g586cb9803_640;
            this.mainPic.Location = new System.Drawing.Point(-130, -1);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(721, 502);
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            this.mainPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.mainPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 403);
            this.ControlBox = false;
            this.Controls.Add(this.mainTitle1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.libButton2);
            this.Controls.Add(this.libButton1);
            this.Controls.Add(this.mainPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.mainTitle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.Button libButton1;
        private System.Windows.Forms.Button libButton2;
        private System.Windows.Forms.PictureBox mainExit;
        private System.Windows.Forms.PictureBox mainTitle1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


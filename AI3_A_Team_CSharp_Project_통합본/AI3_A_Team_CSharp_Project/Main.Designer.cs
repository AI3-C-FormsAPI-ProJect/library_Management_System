namespace AI3_A_Team_CSharp_Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.libButton2 = new System.Windows.Forms.Button();
            this.libButton1 = new System.Windows.Forms.Button();
            this.mainExit = new System.Windows.Forms.PictureBox();
            this.mainTitle1 = new System.Windows.Forms.PictureBox();
            this.mainPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTitle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_combo_chart_40px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(502, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 86);
            this.button3.TabIndex = 6;
            this.button3.Text = "대구시립도서관 도서 개수 통계";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // libButton2
            // 
            this.libButton2.BackColor = System.Drawing.Color.White;
            this.libButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.libButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libButton2.FlatAppearance.BorderSize = 0;
            this.libButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libButton2.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.libButton2.ForeColor = System.Drawing.Color.Black;
            this.libButton2.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_favorites_40px;
            this.libButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.libButton2.Location = new System.Drawing.Point(502, 152);
            this.libButton2.Name = "libButton2";
            this.libButton2.Size = new System.Drawing.Size(133, 86);
            this.libButton2.TabIndex = 2;
            this.libButton2.Text = "인기 대출도서";
            this.libButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.libButton2.UseVisualStyleBackColor = false;
            this.libButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // libButton1
            // 
            this.libButton1.BackColor = System.Drawing.Color.White;
            this.libButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.libButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libButton1.FlatAppearance.BorderSize = 0;
            this.libButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libButton1.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libButton1.ForeColor = System.Drawing.Color.Black;
            this.libButton1.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_literature_40px;
            this.libButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.libButton1.Location = new System.Drawing.Point(502, 59);
            this.libButton1.Name = "libButton1";
            this.libButton1.Size = new System.Drawing.Size(133, 87);
            this.libButton1.TabIndex = 1;
            this.libButton1.Text = "도서 검색";
            this.libButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.libButton1.UseVisualStyleBackColor = false;
            this.libButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.ErrorImage = null;
            this.mainExit.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_close_window_50px;
            this.mainExit.Location = new System.Drawing.Point(593, 362);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(46, 43);
            this.mainExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainExit.TabIndex = 3;
            this.mainExit.TabStop = false;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            this.mainExit.MouseHover += new System.EventHandler(this.mainExit_MouseHover);
            // 
            // mainTitle1
            // 
            this.mainTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.mainTitle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainTitle1.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_cs_120px;
            this.mainTitle1.Location = new System.Drawing.Point(277, 148);
            this.mainTitle1.Name = "mainTitle1";
            this.mainTitle1.Size = new System.Drawing.Size(130, 95);
            this.mainTitle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainTitle1.TabIndex = 5;
            this.mainTitle1.TabStop = false;
            // 
            // mainPic
            // 
            this.mainPic.BackColor = System.Drawing.SystemColors.Control;
            this.mainPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPic.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.books;
            this.mainPic.Location = new System.Drawing.Point(-3, -1);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(641, 414);
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            this.mainPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.mainPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 403);
            this.ControlBox = false;
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mainTitle1);
            this.Controls.Add(this.libButton2);
            this.Controls.Add(this.libButton1);
            this.Controls.Add(this.mainPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.mainExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTitle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.Button libButton1;
        private System.Windows.Forms.Button libButton2;
        private System.Windows.Forms.PictureBox mainExit;
        private System.Windows.Forms.PictureBox mainTitle1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


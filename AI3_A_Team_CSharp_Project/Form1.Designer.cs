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
            this.button1 = new System.Windows.Forms.Button();
            this.mainExit = new System.Windows.Forms.PictureBox();
            this.libButton2 = new System.Windows.Forms.Button();
            this.libButton1 = new System.Windows.Forms.Button();
            this.mainPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_favorites_40px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "인기 대출도서 조회";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // 
            // libButton2
            // 
            this.libButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.libButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.libButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libButton2.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.libButton2.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_combo_chart_40px;
            this.libButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.libButton2.Location = new System.Drawing.Point(12, 165);
            this.libButton2.Name = "libButton2";
            this.libButton2.Size = new System.Drawing.Size(158, 81);
            this.libButton2.TabIndex = 2;
            this.libButton2.Text = "대출도서 데이터 조회";
            this.libButton2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.libButton2.UseVisualStyleBackColor = false;
            this.libButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // libButton1
            // 
            this.libButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.libButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.libButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libButton1.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.libButton1.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.icons8_literature_40px;
            this.libButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.libButton1.Location = new System.Drawing.Point(12, 78);
            this.libButton1.Name = "libButton1";
            this.libButton1.Size = new System.Drawing.Size(158, 81);
            this.libButton1.TabIndex = 1;
            this.libButton1.Text = "도서관별 장서";
            this.libButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.libButton1.UseVisualStyleBackColor = false;
            this.libButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPic
            // 
            this.mainPic.BackColor = System.Drawing.SystemColors.Control;
            this.mainPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPic.Image = global::AI3_A_Team_CSharp_Project.Properties.Resources.bookshelves_gaa6ae3b3d_640;
            this.mainPic.Location = new System.Drawing.Point(-208, -8);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(721, 502);
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.libButton2);
            this.Controls.Add(this.libButton1);
            this.Controls.Add(this.mainPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.Button libButton1;
        private System.Windows.Forms.Button libButton2;
        private System.Windows.Forms.PictureBox mainExit;
        private System.Windows.Forms.Button button1;
    }
}


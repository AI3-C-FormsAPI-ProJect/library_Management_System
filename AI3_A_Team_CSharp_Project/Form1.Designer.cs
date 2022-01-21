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
            this.libButton1 = new System.Windows.Forms.Button();
            this.libButton2 = new System.Windows.Forms.Button();
            this.mainExit = new System.Windows.Forms.PictureBox();
            this.mainPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // libButton1
            // 
            this.libButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libButton1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.libButton1.Location = new System.Drawing.Point(34, 144);
            this.libButton1.Name = "libButton1";
            this.libButton1.Size = new System.Drawing.Size(163, 80);
            this.libButton1.TabIndex = 1;
            this.libButton1.Text = "도서관별 장서";
            this.libButton1.UseVisualStyleBackColor = true;
            this.libButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // libButton2
            // 
            this.libButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libButton2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.libButton2.Location = new System.Drawing.Point(221, 144);
            this.libButton2.Name = "libButton2";
            this.libButton2.Size = new System.Drawing.Size(172, 80);
            this.libButton2.TabIndex = 2;
            this.libButton2.Text = "대출 데이터 조회";
            this.libButton2.UseVisualStyleBackColor = true;
            this.libButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
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
            // mainPic
            // 
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
    }
}


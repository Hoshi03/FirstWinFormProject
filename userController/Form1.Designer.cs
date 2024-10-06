namespace userController
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
            this.userControl11 = new userController.UserControl1();
            this.userControl12 = new userController.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.label1text = "label1";
            this.userControl11.Location = new System.Drawing.Point(32, 52);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1236, 293);
            this.userControl11.TabIndex = 2;
            // 
            // userControl12
            // 
            this.userControl12.label1text = "label1";
            this.userControl12.Location = new System.Drawing.Point(32, 396);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(1236, 293);
            this.userControl12.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 794);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl12;
        private UserControl1 userControl11;
    }
}


namespace BalanceBoardDataAnalysis
{
    partial class Screen
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
            this.LabelTL = new System.Windows.Forms.Label();
            this.LabelTR = new System.Windows.Forms.Label();
            this.LabelBL = new System.Windows.Forms.Label();
            this.LabelBR = new System.Windows.Forms.Label();
            this.LabelOD = new System.Windows.Forms.Label();
            this.Filenamebox = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTL
            // 
            this.LabelTL.AutoSize = true;
            this.LabelTL.Location = new System.Drawing.Point(26, 44);
            this.LabelTL.Name = "LabelTL";
            this.LabelTL.Size = new System.Drawing.Size(47, 12);
            this.LabelTL.TabIndex = 0;
            this.LabelTL.Text = "TopLeft";
            // 
            // LabelTR
            // 
            this.LabelTR.AutoSize = true;
            this.LabelTR.Location = new System.Drawing.Point(192, 44);
            this.LabelTR.Name = "LabelTR";
            this.LabelTR.Size = new System.Drawing.Size(55, 12);
            this.LabelTR.TabIndex = 1;
            this.LabelTR.Text = "TopRight";
            // 
            // LabelBL
            // 
            this.LabelBL.AutoSize = true;
            this.LabelBL.Location = new System.Drawing.Point(26, 198);
            this.LabelBL.Name = "LabelBL";
            this.LabelBL.Size = new System.Drawing.Size(64, 12);
            this.LabelBL.TabIndex = 2;
            this.LabelBL.Text = "BottomLeft";
            // 
            // LabelBR
            // 
            this.LabelBR.AutoSize = true;
            this.LabelBR.Location = new System.Drawing.Point(192, 198);
            this.LabelBR.Name = "LabelBR";
            this.LabelBR.Size = new System.Drawing.Size(72, 12);
            this.LabelBR.TabIndex = 3;
            this.LabelBR.Text = "BottomRight";
            // 
            // LabelOD
            // 
            this.LabelOD.AutoSize = true;
            this.LabelOD.Location = new System.Drawing.Point(144, 118);
            this.LabelOD.Name = "LabelOD";
            this.LabelOD.Size = new System.Drawing.Size(49, 12);
            this.LabelOD.TabIndex = 4;
            this.LabelOD.Text = "OutData";
            this.LabelOD.Click += new System.EventHandler(this.LabelOD_Click);
            // 
            // Filenamebox
            // 
            this.Filenamebox.Location = new System.Drawing.Point(93, 94);
            this.Filenamebox.Name = "Filenamebox";
            this.Filenamebox.Size = new System.Drawing.Size(100, 21);
            this.Filenamebox.TabIndex = 5;
            this.Filenamebox.Text = "Default";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(91, 118);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(40, 12);
            this.LabelID.TabIndex = 6;
            this.LabelID.Text = "InData";
            this.LabelID.Click += new System.EventHandler(this.LabelID_Click);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.Filenamebox);
            this.Controls.Add(this.LabelOD);
            this.Controls.Add(this.LabelBR);
            this.Controls.Add(this.LabelBL);
            this.Controls.Add(this.LabelTR);
            this.Controls.Add(this.LabelTL);
            this.Name = "Screen";
            this.Text = "BalanceBoard";
            this.Load += new System.EventHandler(this.Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTL;
        private System.Windows.Forms.Label LabelTR;
        private System.Windows.Forms.Label LabelBL;
        private System.Windows.Forms.Label LabelBR;
        private System.Windows.Forms.Label LabelOD;
        private System.Windows.Forms.TextBox Filenamebox;
        private System.Windows.Forms.Label LabelID;
    }
}


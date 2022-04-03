
namespace CustomControls
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDarkThemes = new CustomControls.RJControls.RJToggleButton();
            this.rjToggleButton2 = new CustomControls.RJControls.RJToggleButton();
            this.rjToggleButton1 = new CustomControls.RJControls.RJToggleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dark theme";
            // 
            // tbDarkThemes
            // 
            this.tbDarkThemes.Location = new System.Drawing.Point(467, 139);
            this.tbDarkThemes.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbDarkThemes.Name = "tbDarkThemes";
            this.tbDarkThemes.OffBackColor = System.Drawing.Color.Gray;
            this.tbDarkThemes.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbDarkThemes.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbDarkThemes.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbDarkThemes.Size = new System.Drawing.Size(45, 24);
            this.tbDarkThemes.TabIndex = 2;
            this.tbDarkThemes.Text = "rjToggleButton3";
            this.tbDarkThemes.UseVisualStyleBackColor = true;
            this.tbDarkThemes.CheckedChanged += new System.EventHandler(this.tbDarkThemes_CheckedChanged);
            // 
            // rjToggleButton2
            // 
            this.rjToggleButton2.Checked = true;
            this.rjToggleButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton2.Location = new System.Drawing.Point(238, 183);
            this.rjToggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton2.Name = "rjToggleButton2";
            this.rjToggleButton2.OffBackColor = System.Drawing.Color.DimGray;
            this.rjToggleButton2.OffToggleColor = System.Drawing.Color.DarkGray;
            this.rjToggleButton2.OnBackColor = System.Drawing.Color.SeaGreen;
            this.rjToggleButton2.OnToggleColor = System.Drawing.Color.MediumSeaGreen;
            this.rjToggleButton2.Size = new System.Drawing.Size(129, 67);
            this.rjToggleButton2.SolidStyle = false;
            this.rjToggleButton2.TabIndex = 1;
            this.rjToggleButton2.Text = "rjToggleButton2";
            this.rjToggleButton2.UseVisualStyleBackColor = true;
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Checked = true;
            this.rjToggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjToggleButton1.Location = new System.Drawing.Point(238, 100);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Black;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Crimson;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.LightSteelBlue;
            this.rjToggleButton1.Size = new System.Drawing.Size(129, 67);
            this.rjToggleButton1.TabIndex = 0;
            this.rjToggleButton1.Text = "rjToggleButton1";
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDarkThemes);
            this.Controls.Add(this.rjToggleButton2);
            this.Controls.Add(this.rjToggleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJToggleButton rjToggleButton1;
        private RJControls.RJToggleButton rjToggleButton2;
        private RJControls.RJToggleButton tbDarkThemes;
        private System.Windows.Forms.Label label1;
    }
}


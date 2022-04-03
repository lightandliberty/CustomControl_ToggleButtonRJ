using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomControls.RJControls
{
    public class RJToggleButton : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;

        // 속성들
        public Color OnBackColor { get => onBackColor;       set { onBackColor = value; this.Invalidate();}}
        public Color OnToggleColor { get => onToggleColor;   set { onToggleColor = value; this.Invalidate();}}
        public Color OffBackColor { get => offBackColor;     set { offBackColor = value; this.Invalidate();}}
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate();}}

        //Constructor
        public RJToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //Method
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1; // 체크 상자의 높이 - 1
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);                         //              0 , 0에서 호의 길이Width, 호의길이Height의 사각형
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize); // 너비 - 세로길이, 0에서 호의 길이Width, 호의길이Height의 사각형

            // 호를 그리는데, Width의 길이만큼 호의 너비가 결정되고, Height의 길이만큼 호의 높이가 결정되고, 위치는 x,y의 위치를 기준으로 결정된다.
            GraphicsPath path = new GraphicsPath(); // path와 path사이의 점을 자동을 연결해 줌
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);   // Width 방향에서 시계 방향으로 90도만큼 오른쪽으로 회전한 후, 180도만큼 Sweep하는 호를 그림)
            path.AddArc(rightArc, 270, 180); // Width방향에서 시계방향으로 270도만큼 오른쪽으로 회전한 후, 180도만큼 Sweep하면 호가 그려짐
            path.CloseFigure();
            
            return path;
        }

        // override paint이벤트

        protected override void OnPaint(PaintEventArgs pEvent)
        {
            int toggleSize = this.Height - 5; // 안에 들어갈 원의 지름이므로, -1이 아니라 -5를 함.
            pEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pEvent.Graphics.Clear(this.Parent.BackColor);

            if(this.Checked)
            {
                // Draw the control surface
                // 바깥쪽 GraphicsPath객체로 그린 부분을 그림.(FillPath이므로, 채움) onBackColor = Color.MediumSlateBlue,
                pEvent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                // Draw the toggle
                // 안쪽 동그라미를 그림. (onToggleColor = Color.WhiteSmoke)
                pEvent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height - 1, 2, toggleSize, toggleSize));
            }
            else // OFF
            {
                // Draw the control surface
                // 패스를 채움. (offBackColor = Color.Gray)
                pEvent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                // Draw the toggle 안쪽 원을 채움. (offToggleColor = Color.Grainsboro)
                pEvent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }

    }
}

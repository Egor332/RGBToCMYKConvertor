using RGBToCMYKConvertor.Bezier;
using System.Windows.Forms;

namespace RGBToCMYKConvertor
{
    public partial class Form1 : Form
    {
        public Dictionary<string, BezierCurve> curves = new Dictionary<string, BezierCurve>();
        private BezierContorolPoint? _selectedControlPoint = null;
        public Form1()
        {
            InitializeComponent();
            BezierCurve cyanCurve = new BezierCurve(new PointF[] { new PointF(0, 0), new PointF(50, 100), new PointF(100, 150), new PointF(150, 150) }, Brushes.Cyan);
            BezierCurve magentaCurve = new BezierCurve(new PointF[] { new PointF(0, 0), new PointF(50, 50), new PointF(80, 150), new PointF(150, 170) }, Brushes.Magenta);
            BezierCurve yellowCurve = new BezierCurve(new PointF[] { new PointF(0, 0), new PointF(30, 70), new PointF(70, 120), new PointF(150, 130) }, Brushes.Yellow);
            BezierCurve blackCurve = new BezierCurve(new PointF[] { new PointF(0, 0), new PointF(40, 20), new PointF(100, 80), new PointF(150, 100) }, Brushes.Black);
            curves.Add(cyanRadioButton.Text, cyanCurve);
            curves.Add(magentaRadioButton.Text, magentaCurve);
            curves.Add(yellowRadioButton.Text, yellowCurve);
            curves.Add(blackRadioButton.Text, blackCurve);


        }

        private void curvePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(0, curvePictureBox.Height);
            e.Graphics.ScaleTransform(1, -1);
            var rb = this.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            BezierCurve activeCurve = curves[rb.Text];
            activeCurve.DrawCurve(e.Graphics);
            activeCurve.DrawControlPoints(e.Graphics);
            if (allCurvesCheckBox.Checked)
            {
                foreach (var curve in curves.Values)
                {
                    curve.DrawCurve(e.Graphics);
                }

            }
        }

        private void curvePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            var transformedLocation = new PointF(e.X, curvePictureBox.Height - e.Y);

            if (e.Button == MouseButtons.Left)
            {
                if (_selectedControlPoint != null)
                {
                    _selectedControlPoint.isSelected = false;
                    _selectedControlPoint = null;
                }
                else
                {
                    var rb = this.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
                    BezierCurve activeCurve = curves[rb.Text];
                    _selectedControlPoint = activeCurve.CheckControlPointClicked(transformedLocation);
                    if (_selectedControlPoint != null)
                    {
                        _selectedControlPoint.isSelected = true;
                    }
                }
            }
            curvePictureBox.Invalidate();
        }

        private void curvePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            var transformedLocation = new PointF(e.X, curvePictureBox.Height - e.Y);
            if (_selectedControlPoint != null)
            {
                _selectedControlPoint.MoveTo(transformedLocation);
                curvePictureBox.Invalidate();
            }

        }

        private void cyanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            curvePictureBox.Invalidate();
        }

        private void magentaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            curvePictureBox.Invalidate();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            curvePictureBox.Invalidate();
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            curvePictureBox.Invalidate();
        }

        private void allCurvesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            curvePictureBox.Invalidate();
        }
    }
}

using RGBToCMYKConvertor.Bezier;
using RGBToCMYKConvertor.DataManagers;
using RGBToCMYKConvertor.Displays;
using System.Windows.Forms;

namespace RGBToCMYKConvertor
{
    public partial class Form1 : Form
    {
        public Dictionary<string, BezierCurve> curves = new Dictionary<string, BezierCurve>();
        private BezierControlPoint? _selectedControlPoint = null;
        public ImageBase imageBase;
        public Form1()
        {
            InitializeComponent();
            BezierCurve cyanCurve = new BezierCurve(new PointF[] { new PointF(0, 0), new PointF(50, 100), new PointF(100, 150), new PointF(255, 150) }, Brushes.Cyan);
            BezierCurve magentaCurve = new BezierCurve(new PointF[] { new PointF(0, 0), new PointF(50, 50), new PointF(80, 150), new PointF(255, 170) }, Brushes.Magenta);
            BezierCurve yellowCurve = new BezierCurve(new PointF[] { new PointF(0, 0), new PointF(30, 70), new PointF(70, 120), new PointF(255, 130) }, Brushes.Yellow);
            BezierCurve blackCurve = new BezierCurve(new PointF[] { new PointF(0, 0), new PointF(40, 20), new PointF(100, 80), new PointF(255, 100) }, Brushes.Black);
            curves.Add(cyanRadioButton.Text, cyanCurve);
            curves.Add(magentaRadioButton.Text, magentaCurve);
            curves.Add(yellowRadioButton.Text, yellowCurve);
            curves.Add(blackRadioButton.Text, blackCurve);
            imageBase = new ImageBase("images/Mount_Hood.jpg", curves);


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
                    InvalidateImages();
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

        private void changeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgResult = dlg.ShowDialog();
            string filename;
            if (dlgResult == DialogResult.OK)
            {
                filename = dlg.FileName;
                imageBase = new ImageBase(filename, curves);
            }
            InvalidateImages();
        }

        private void originalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imageBase.original, new Rectangle(0, 0, originalPictureBox.Width, originalPictureBox.Height));
        }

        private void OverwriteAll()
        {
            foreach (BezierCurve curve in curves.Values)
            {
                curve.OverwriteYTable();
            }
            imageBase.ResetBitmaps();
        }

        private void InvalidateImages()
        {
            OverwriteAll();
            originalPictureBox.Invalidate();
            cyanPictureBox.Invalidate();
            magentaPictureBox.Invalidate();
            yellowPictureBox.Invalidate();
            blackPictureBox.Invalidate();
        }

        private void cyanPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imageBase.cyan, new Rectangle(0, 0, originalPictureBox.Width, originalPictureBox.Height));
        }

        private void magentaPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imageBase.magenta, new Rectangle(0, 0, originalPictureBox.Width, originalPictureBox.Height));
        }

        private void yellowPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imageBase.yellow, new Rectangle(0, 0, originalPictureBox.Width, originalPictureBox.Height));
        }

        private void blackPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imageBase.black, new Rectangle(0, 0, originalPictureBox.Width, originalPictureBox.Height));
        }

        private void saveCurveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Specify a file",
                Filter = "Text Files (*.txt)|*.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                MessageBox.Show($"Selected file: {fileName}");
                Transformer transformer = new Transformer();
                transformer.SaveCurves(curves.Values.ToList(), fileName);

            }
            curvePictureBox.Invalidate();
            InvalidateImages();
        }

        private void loadCurveButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgResult = dlg.ShowDialog();
            string filename;
            if (dlgResult == DialogResult.OK)
            {
                filename = dlg.FileName;
                Transformer transformer = new Transformer();
                transformer.LoadCurves(curves.Values.ToList<BezierCurve>(), filename);
            }
            curvePictureBox.Invalidate();
            InvalidateImages();
        }

        private void reduction0Button_Click(object sender, EventArgs e)
        {
            Transformer transformer = new Transformer();
            transformer.LoadCurves(curves.Values.ToList<BezierCurve>(), "curves/0reduction.txt");
            curvePictureBox.Invalidate();
            InvalidateImages();
        }

        private void reduction100Button_Click(object sender, EventArgs e)
        {
            Transformer transformer = new Transformer();
            transformer.LoadCurves(curves.Values.ToList<BezierCurve>(), "curves/100reduction.txt");
            curvePictureBox.Invalidate();
            InvalidateImages();
        }

        private void UCRButton_Click(object sender, EventArgs e)
        {
            Transformer transformer = new Transformer();
            transformer.LoadCurves(curves.Values.ToList<BezierCurve>(), "curves/UCR.txt");
            curvePictureBox.Invalidate();
            InvalidateImages();
        }

        private void GCRButton_Click(object sender, EventArgs e)
        {
            Transformer transformer = new Transformer();
            transformer.LoadCurves(curves.Values.ToList<BezierCurve>(), "curves/GCR.txt");
            curvePictureBox.Invalidate();
            InvalidateImages();
        }

        private void savePicturesButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select a folder to save files, it is better to create new directory";
                folderBrowser.ShowNewFolderButton = true; // Allow users to create a new folder if needed

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowser.SelectedPath;


                    imageBase.SaveAll(selectedPath);
                }
            }
        }
    }
}

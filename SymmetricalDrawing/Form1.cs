using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SymmetricalDrawing
{
    public partial class Form1 : Form
    {
        private Logic _logic;
        
        public Form1()
        {
            InitializeComponent();
            
            var pen = new Pen(Color.Lime)
            {
                LineJoin = LineJoin.Round,
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                Width = 1
            };
            _logic = new Logic(pictureBox, 5, pen, Color.Black);
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            if (penColorDialog.ShowDialog() == DialogResult.OK)
                _logic.Pen.Color = penColorDialog.Color;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                _logic.BackgroundColor = backgroundColorDialog.Color;
                MessageBox.Show("Clear for change background");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _logic.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox.Image.Save(saveFileDialog.FileName);
        }

        private void axesUpDown_ValueChanged(object sender, EventArgs e)
        {
            _logic.Axes = (int)axesUpDown.Value;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    clearButton_Click(clearButton, EventArgs.Empty);
                    break;
                case Keys.P:
                    penButton_Click(penButton, EventArgs.Empty);
                    break;
                case Keys.B:
                    backgroundButton_Click(backgroundButton, EventArgs.Empty);
                    break;
                case Keys.S:
                    saveButton_Click(saveButton, EventArgs.Empty);
                    break;
            }
        }

        private void thicknessUpDown_ValueChanged(object sender, EventArgs e)
        {
            _logic.Pen.Width = (int)thicknessUpDown.Value;
        }
    }
}
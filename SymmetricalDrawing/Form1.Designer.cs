namespace SymmetricalDrawing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.penButton = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.axesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.thicknessUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(692, 523);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightGray;
            this.clearButton.Location = new System.Drawing.Point(0, 499);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 24);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear (C)";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGray;
            this.saveButton.Location = new System.Drawing.Point(0, 469);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 24);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save (S)";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // penButton
            // 
            this.penButton.BackColor = System.Drawing.Color.LightGray;
            this.penButton.Location = new System.Drawing.Point(557, 0);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(135, 24);
            this.penButton.TabIndex = 3;
            this.penButton.Text = "Change pen color (P)";
            this.penButton.UseVisualStyleBackColor = false;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.BackColor = System.Drawing.Color.LightGray;
            this.backgroundButton.Location = new System.Drawing.Point(557, 30);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(135, 24);
            this.backgroundButton.TabIndex = 4;
            this.backgroundButton.Text = "Change background (B)";
            this.backgroundButton.UseVisualStyleBackColor = false;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // axesUpDown
            // 
            this.axesUpDown.Location = new System.Drawing.Point(44, 24);
            this.axesUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.axesUpDown.Name = "axesUpDown";
            this.axesUpDown.Size = new System.Drawing.Size(49, 20);
            this.axesUpDown.TabIndex = 5;
            this.axesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.axesUpDown.Value = new decimal(new int[] {5, 0, 0, 0});
            this.axesUpDown.ValueChanged += new System.EventHandler(this.axesUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numbers of axes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "PNG|*.png";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thickness";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thicknessUpDown
            // 
            this.thicknessUpDown.Location = new System.Drawing.Point(159, 24);
            this.thicknessUpDown.Maximum = new decimal(new int[] {15, 0, 0, 0});
            this.thicknessUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.thicknessUpDown.Name = "thicknessUpDown";
            this.thicknessUpDown.Size = new System.Drawing.Size(49, 20);
            this.thicknessUpDown.TabIndex = 8;
            this.thicknessUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thicknessUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            this.thicknessUpDown.ValueChanged += new System.EventHandler(this.thicknessUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 523);
            this.Controls.Add(this.thicknessUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axesUpDown);
            this.Controls.Add(this.backgroundButton);
            this.Controls.Add(this.penButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown thicknessUpDown;

        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private System.Windows.Forms.NumericUpDown axesUpDown;

        private System.Windows.Forms.Button penButton;

        private System.Windows.Forms.Button backgroundButton;

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ColorDialog penColorDialog;
        private System.Windows.Forms.ColorDialog backgroundColorDialog;

        private System.Windows.Forms.PictureBox pictureBox;

    #endregion
    }
}
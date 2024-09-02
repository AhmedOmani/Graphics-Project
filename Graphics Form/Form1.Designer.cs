namespace Graphics_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDrawLine = new Button();
            MidpointCircle = new Button();
            BresenhamCircle = new Button();
            SuspendLayout();
            // 
            // btnDrawLine
            // 
            btnDrawLine.BackColor = Color.CornflowerBlue;
            btnDrawLine.ForeColor = Color.White;
            btnDrawLine.Location = new Point(60, 483);
            btnDrawLine.Name = "btnDrawLine";
            btnDrawLine.Size = new Size(193, 46);
            btnDrawLine.TabIndex = 0;
            btnDrawLine.Text = "DrawLine";
            btnDrawLine.UseVisualStyleBackColor = false;
            btnDrawLine.Click += button1_Click;
            // 
            // MidpointCircle
            // 
            MidpointCircle.BackColor = Color.CornflowerBlue;
            MidpointCircle.ForeColor = Color.White;
            MidpointCircle.Location = new Point(393, 483);
            MidpointCircle.Name = "MidpointCircle";
            MidpointCircle.Size = new Size(193, 46);
            MidpointCircle.TabIndex = 1;
            MidpointCircle.Text = "DrawMidpointCircle";
            MidpointCircle.UseVisualStyleBackColor = false;
            MidpointCircle.Click += button2_Click;
            // 
            // BresenhamCircle
            // 
            BresenhamCircle.BackColor = Color.CornflowerBlue;
            BresenhamCircle.ForeColor = Color.White;
            BresenhamCircle.Location = new Point(716, 483);
            BresenhamCircle.Name = "BresenhamCircle";
            BresenhamCircle.Size = new Size(193, 46);
            BresenhamCircle.TabIndex = 2;
            BresenhamCircle.Text = "DrawBresenhamCircle";
            BresenhamCircle.UseVisualStyleBackColor = false;
            BresenhamCircle.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 569);
            Controls.Add(BresenhamCircle);
            Controls.Add(MidpointCircle);
            Controls.Add(btnDrawLine);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDrawLine;
        private Button MidpointCircle;
        private Button BresenhamCircle;
    }
}

namespace EltonBabayevFormsApp2
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(122, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email Check";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 93);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 0;
            label1.Text = "Email : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 92);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Email";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(46, 221);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}

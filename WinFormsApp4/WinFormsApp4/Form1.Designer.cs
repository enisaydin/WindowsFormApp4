namespace WinFormsApp4
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
            lst1 = new ListBox();
            lst2 = new ListBox();
            btnRight = new Button();
            btnLeft = new Button();
            btnClick = new Button();
            SuspendLayout();
            // 
            // lst1
            // 
            lst1.FormattingEnabled = true;
            lst1.Location = new Point(29, 21);
            lst1.Name = "lst1";
            lst1.Size = new Size(255, 384);
            lst1.TabIndex = 0;
            lst1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lst2
            // 
            lst2.FormattingEnabled = true;
            lst2.Location = new Point(496, 21);
            lst2.Name = "lst2";
            lst2.Size = new Size(274, 384);
            lst2.TabIndex = 1;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(301, 44);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(183, 55);
            btnRight.TabIndex = 2;
            btnRight.Text = ">>";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(301, 298);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(183, 61);
            btnLeft.TabIndex = 3;
            btnLeft.Text = "<<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(347, 187);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(94, 29);
            btnClick.TabIndex = 4;
            btnClick.Text = "Şehir Ekle";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClick);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(lst2);
            Controls.Add(lst1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst1;
        private ListBox lst2;
        private Button btnRight;
        private Button btnLeft;
        private Button btnClick;
    }
}

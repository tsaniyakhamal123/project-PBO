namespace nyoba_windows_form_app
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Kristen ITC", 8F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(55, 285);
            button1.Name = "button1";
            button1.Size = new Size(118, 37);
            button1.TabIndex = 4;
            button1.Text = "enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.AccessibleDescription = "";
            textBox1.AccessibleName = "";
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(26, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 24);
            textBox1.TabIndex = 5;
            textBox1.Text = "nama";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.MediumVioletRed;
            checkedListBox1.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.ForeColor = SystemColors.ControlLightLight;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(332, 149);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(325, 154);
            checkedListBox1.TabIndex = 10;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.GrayText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 25);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "penyakit";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logohealthyme_removebg_preview;
            pictureBox1.Location = new Point(26, -98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 10);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logohealthyme_removebg_preview1;
            pictureBox2.Location = new Point(36, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 30F);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 54);
            label1.TabIndex = 11;
            label1.Text = "HealtyMe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1147, 527);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        public CheckedListBox checkedListBox1;
    }
}

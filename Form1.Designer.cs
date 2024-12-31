namespace csharp_calculator
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
            TextBoxProblem = new TextBox();
            PadLayout = new TableLayoutPanel();
            ButtonAdd = new Button();
            ButtonCalculate = new Button();
            ButtonNumber0 = new Button();
            ButtonPoint = new Button();
            ButtonSubtract = new Button();
            ButtonNumber3 = new Button();
            ButtonNumber2 = new Button();
            ButtonNumber1 = new Button();
            ButtonMultiply = new Button();
            ButtonNumber6 = new Button();
            ButtonNumber5 = new Button();
            ButtonNumber4 = new Button();
            ButtonDivide = new Button();
            ButtonNumber9 = new Button();
            ButtonNumber8 = new Button();
            ButtonNumber7 = new Button();
            LabelInfo = new Label();
            MainToolTip = new ToolTip(components);
            PadLayout.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxProblem
            // 
            TextBoxProblem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxProblem.BorderStyle = BorderStyle.FixedSingle;
            TextBoxProblem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxProblem.Location = new Point(12, 12);
            TextBoxProblem.Name = "TextBoxProblem";
            TextBoxProblem.PlaceholderText = "Double click to reset";
            TextBoxProblem.ReadOnly = true;
            TextBoxProblem.Size = new Size(308, 55);
            TextBoxProblem.TabIndex = 0;
            MainToolTip.SetToolTip(TextBoxProblem, "Double click to reset");
            TextBoxProblem.DoubleClick += TextBoxProblem_DoubleClick;
            // 
            // PadLayout
            // 
            PadLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PadLayout.BackColor = Color.Transparent;
            PadLayout.ColumnCount = 4;
            PadLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PadLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PadLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PadLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PadLayout.Controls.Add(ButtonAdd, 3, 3);
            PadLayout.Controls.Add(ButtonCalculate, 2, 3);
            PadLayout.Controls.Add(ButtonNumber0, 1, 3);
            PadLayout.Controls.Add(ButtonPoint, 0, 3);
            PadLayout.Controls.Add(ButtonSubtract, 3, 2);
            PadLayout.Controls.Add(ButtonNumber3, 2, 2);
            PadLayout.Controls.Add(ButtonNumber2, 1, 2);
            PadLayout.Controls.Add(ButtonNumber1, 0, 2);
            PadLayout.Controls.Add(ButtonMultiply, 3, 1);
            PadLayout.Controls.Add(ButtonNumber6, 2, 1);
            PadLayout.Controls.Add(ButtonNumber5, 1, 1);
            PadLayout.Controls.Add(ButtonNumber4, 0, 1);
            PadLayout.Controls.Add(ButtonDivide, 3, 0);
            PadLayout.Controls.Add(ButtonNumber9, 2, 0);
            PadLayout.Controls.Add(ButtonNumber8, 1, 0);
            PadLayout.Controls.Add(ButtonNumber7, 0, 0);
            PadLayout.Location = new Point(12, 73);
            PadLayout.Name = "PadLayout";
            PadLayout.RowCount = 4;
            PadLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PadLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PadLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PadLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PadLayout.Size = new Size(308, 293);
            PadLayout.TabIndex = 1;
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.Silver;
            ButtonAdd.Dock = DockStyle.Fill;
            ButtonAdd.FlatStyle = FlatStyle.Popup;
            ButtonAdd.Font = new Font("Segoe UI", 12F);
            ButtonAdd.Location = new Point(234, 222);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(71, 68);
            ButtonAdd.TabIndex = 15;
            ButtonAdd.Text = "+";
            ButtonAdd.UseVisualStyleBackColor = false;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.BackColor = Color.SteelBlue;
            ButtonCalculate.Dock = DockStyle.Fill;
            ButtonCalculate.FlatStyle = FlatStyle.Popup;
            ButtonCalculate.Font = new Font("Segoe UI", 12F);
            ButtonCalculate.Location = new Point(157, 222);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(71, 68);
            ButtonCalculate.TabIndex = 14;
            ButtonCalculate.Text = "=";
            ButtonCalculate.UseVisualStyleBackColor = false;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // ButtonNumber0
            // 
            ButtonNumber0.BackColor = Color.Silver;
            ButtonNumber0.Dock = DockStyle.Fill;
            ButtonNumber0.FlatStyle = FlatStyle.Popup;
            ButtonNumber0.Font = new Font("Segoe UI", 12F);
            ButtonNumber0.Location = new Point(80, 222);
            ButtonNumber0.Name = "ButtonNumber0";
            ButtonNumber0.Size = new Size(71, 68);
            ButtonNumber0.TabIndex = 13;
            ButtonNumber0.Text = "0";
            ButtonNumber0.UseVisualStyleBackColor = false;
            ButtonNumber0.Click += ButtonNumber0_Click;
            // 
            // ButtonPoint
            // 
            ButtonPoint.BackColor = Color.Silver;
            ButtonPoint.Dock = DockStyle.Fill;
            ButtonPoint.FlatStyle = FlatStyle.Popup;
            ButtonPoint.Font = new Font("Segoe UI", 12F);
            ButtonPoint.Location = new Point(3, 222);
            ButtonPoint.Name = "ButtonPoint";
            ButtonPoint.Size = new Size(71, 68);
            ButtonPoint.TabIndex = 12;
            ButtonPoint.Text = ".";
            ButtonPoint.UseVisualStyleBackColor = false;
            ButtonPoint.Click += ButtonPoint_Click;
            // 
            // ButtonSubtract
            // 
            ButtonSubtract.BackColor = Color.Silver;
            ButtonSubtract.Dock = DockStyle.Fill;
            ButtonSubtract.FlatStyle = FlatStyle.Popup;
            ButtonSubtract.Font = new Font("Segoe UI", 12F);
            ButtonSubtract.Location = new Point(234, 149);
            ButtonSubtract.Name = "ButtonSubtract";
            ButtonSubtract.Size = new Size(71, 67);
            ButtonSubtract.TabIndex = 11;
            ButtonSubtract.Text = "-";
            ButtonSubtract.UseVisualStyleBackColor = false;
            ButtonSubtract.Click += ButtonSubtract_Click;
            // 
            // ButtonNumber3
            // 
            ButtonNumber3.BackColor = Color.Silver;
            ButtonNumber3.Dock = DockStyle.Fill;
            ButtonNumber3.FlatStyle = FlatStyle.Popup;
            ButtonNumber3.Font = new Font("Segoe UI", 12F);
            ButtonNumber3.Location = new Point(157, 149);
            ButtonNumber3.Name = "ButtonNumber3";
            ButtonNumber3.Size = new Size(71, 67);
            ButtonNumber3.TabIndex = 10;
            ButtonNumber3.Text = "3";
            ButtonNumber3.UseVisualStyleBackColor = false;
            ButtonNumber3.Click += ButtonNumber3_Click;
            // 
            // ButtonNumber2
            // 
            ButtonNumber2.BackColor = Color.Silver;
            ButtonNumber2.Dock = DockStyle.Fill;
            ButtonNumber2.FlatStyle = FlatStyle.Popup;
            ButtonNumber2.Font = new Font("Segoe UI", 12F);
            ButtonNumber2.Location = new Point(80, 149);
            ButtonNumber2.Name = "ButtonNumber2";
            ButtonNumber2.Size = new Size(71, 67);
            ButtonNumber2.TabIndex = 9;
            ButtonNumber2.Text = "2";
            ButtonNumber2.UseVisualStyleBackColor = false;
            ButtonNumber2.Click += ButtonNumber2_Click;
            // 
            // ButtonNumber1
            // 
            ButtonNumber1.BackColor = Color.Silver;
            ButtonNumber1.Dock = DockStyle.Fill;
            ButtonNumber1.FlatStyle = FlatStyle.Popup;
            ButtonNumber1.Font = new Font("Segoe UI", 12F);
            ButtonNumber1.Location = new Point(3, 149);
            ButtonNumber1.Name = "ButtonNumber1";
            ButtonNumber1.Size = new Size(71, 67);
            ButtonNumber1.TabIndex = 8;
            ButtonNumber1.Text = "1";
            ButtonNumber1.UseVisualStyleBackColor = false;
            ButtonNumber1.Click += ButtonNumber1_Click;
            // 
            // ButtonMultiply
            // 
            ButtonMultiply.BackColor = Color.Silver;
            ButtonMultiply.Dock = DockStyle.Fill;
            ButtonMultiply.FlatStyle = FlatStyle.Popup;
            ButtonMultiply.Font = new Font("Segoe UI", 12F);
            ButtonMultiply.Location = new Point(234, 76);
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.Size = new Size(71, 67);
            ButtonMultiply.TabIndex = 7;
            ButtonMultiply.Text = "×";
            ButtonMultiply.UseVisualStyleBackColor = false;
            ButtonMultiply.Click += ButtonMultiply_Click;
            // 
            // ButtonNumber6
            // 
            ButtonNumber6.BackColor = Color.Silver;
            ButtonNumber6.Dock = DockStyle.Fill;
            ButtonNumber6.FlatStyle = FlatStyle.Popup;
            ButtonNumber6.Font = new Font("Segoe UI", 12F);
            ButtonNumber6.Location = new Point(157, 76);
            ButtonNumber6.Name = "ButtonNumber6";
            ButtonNumber6.Size = new Size(71, 67);
            ButtonNumber6.TabIndex = 6;
            ButtonNumber6.Text = "6";
            ButtonNumber6.UseVisualStyleBackColor = false;
            ButtonNumber6.Click += ButtonNumber6_Click;
            // 
            // ButtonNumber5
            // 
            ButtonNumber5.BackColor = Color.Silver;
            ButtonNumber5.Dock = DockStyle.Fill;
            ButtonNumber5.FlatStyle = FlatStyle.Popup;
            ButtonNumber5.Font = new Font("Segoe UI", 12F);
            ButtonNumber5.Location = new Point(80, 76);
            ButtonNumber5.Name = "ButtonNumber5";
            ButtonNumber5.Size = new Size(71, 67);
            ButtonNumber5.TabIndex = 5;
            ButtonNumber5.Text = "5";
            ButtonNumber5.UseVisualStyleBackColor = false;
            ButtonNumber5.Click += ButtonNumber5_Click;
            // 
            // ButtonNumber4
            // 
            ButtonNumber4.BackColor = Color.Silver;
            ButtonNumber4.Dock = DockStyle.Fill;
            ButtonNumber4.FlatStyle = FlatStyle.Popup;
            ButtonNumber4.Font = new Font("Segoe UI", 12F);
            ButtonNumber4.Location = new Point(3, 76);
            ButtonNumber4.Name = "ButtonNumber4";
            ButtonNumber4.Size = new Size(71, 67);
            ButtonNumber4.TabIndex = 4;
            ButtonNumber4.Text = "4";
            ButtonNumber4.UseVisualStyleBackColor = false;
            ButtonNumber4.Click += ButtonNumber4_Click;
            // 
            // ButtonDivide
            // 
            ButtonDivide.BackColor = Color.Silver;
            ButtonDivide.Dock = DockStyle.Fill;
            ButtonDivide.FlatStyle = FlatStyle.Popup;
            ButtonDivide.Font = new Font("Segoe UI", 12F);
            ButtonDivide.Location = new Point(234, 3);
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.Size = new Size(71, 67);
            ButtonDivide.TabIndex = 3;
            ButtonDivide.Text = "÷";
            ButtonDivide.UseVisualStyleBackColor = false;
            ButtonDivide.Click += ButtonDivide_Click;
            // 
            // ButtonNumber9
            // 
            ButtonNumber9.BackColor = Color.Silver;
            ButtonNumber9.Dock = DockStyle.Fill;
            ButtonNumber9.FlatStyle = FlatStyle.Popup;
            ButtonNumber9.Font = new Font("Segoe UI", 12F);
            ButtonNumber9.Location = new Point(157, 3);
            ButtonNumber9.Name = "ButtonNumber9";
            ButtonNumber9.Size = new Size(71, 67);
            ButtonNumber9.TabIndex = 2;
            ButtonNumber9.Text = "9";
            ButtonNumber9.UseVisualStyleBackColor = false;
            ButtonNumber9.Click += ButtonNumber9_Click;
            // 
            // ButtonNumber8
            // 
            ButtonNumber8.BackColor = Color.Silver;
            ButtonNumber8.Dock = DockStyle.Fill;
            ButtonNumber8.FlatStyle = FlatStyle.Popup;
            ButtonNumber8.Font = new Font("Segoe UI", 12F);
            ButtonNumber8.Location = new Point(80, 3);
            ButtonNumber8.Name = "ButtonNumber8";
            ButtonNumber8.Size = new Size(71, 67);
            ButtonNumber8.TabIndex = 1;
            ButtonNumber8.Text = "8";
            ButtonNumber8.UseVisualStyleBackColor = false;
            ButtonNumber8.Click += ButtonNumber8_Click;
            // 
            // ButtonNumber7
            // 
            ButtonNumber7.BackColor = Color.Silver;
            ButtonNumber7.Dock = DockStyle.Fill;
            ButtonNumber7.FlatStyle = FlatStyle.Popup;
            ButtonNumber7.Font = new Font("Segoe UI", 12F);
            ButtonNumber7.Location = new Point(3, 3);
            ButtonNumber7.Name = "ButtonNumber7";
            ButtonNumber7.Size = new Size(71, 67);
            ButtonNumber7.TabIndex = 0;
            ButtonNumber7.Text = "7";
            ButtonNumber7.UseVisualStyleBackColor = false;
            ButtonNumber7.Click += ButtonNumber7_Click;
            // 
            // LabelInfo
            // 
            LabelInfo.AutoSize = true;
            LabelInfo.BackColor = Color.Transparent;
            LabelInfo.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInfo.Location = new Point(11, 369);
            LabelInfo.Name = "LabelInfo";
            LabelInfo.Size = new Size(291, 42);
            LabelInfo.TabIndex = 0;
            LabelInfo.Text = "Simple C# calculator: This project was an\r\nidea generated by an AI.";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(331, 416);
            Controls.Add(LabelInfo);
            Controls.Add(PadLayout);
            Controls.Add(TextBoxProblem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(353, 472);
            MinimumSize = new Size(353, 472);
            Name = "Form1";
            Text = "C# Calculator";
            PadLayout.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxProblem;
        private TableLayoutPanel PadLayout;
        private Label LabelInfo;
        private Button ButtonAdd;
        private Button ButtonCalculate;
        private Button ButtonNumber0;
        private Button ButtonPoint;
        private Button ButtonSubtract;
        private Button ButtonNumber3;
        private Button ButtonNumber2;
        private Button ButtonNumber1;
        private Button ButtonMultiply;
        private Button ButtonNumber6;
        private Button ButtonNumber5;
        private Button ButtonNumber4;
        private Button ButtonDivide;
        private Button ButtonNumber9;
        private Button ButtonNumber8;
        private Button ButtonNumber7;
        private ToolTip MainToolTip;
    }
}

namespace Calculatrice
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
            textField = new TextBox();
            btnDiv = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btnMulti = new Button();
            btnSous = new Button();
            btnAdd = new Button();
            bt6 = new Button();
            btn8 = new Button();
            bt5 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btnClear = new Button();
            btnDot = new Button();
            btnEgal = new Button();
            SuspendLayout();
            // 
            // textField
            // 
            textField.BackColor = SystemColors.Desktop;
            textField.BorderStyle = BorderStyle.None;
            textField.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textField.ForeColor = SystemColors.Info;
            textField.Location = new Point(12, 12);
            textField.Multiline = true;
            textField.Name = "textField";
            textField.ReadOnly = true;
            textField.Size = new Size(340, 56);
            textField.TabIndex = 0;
            textField.TextAlign = HorizontalAlignment.Right;
            textField.WordWrap = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.CornflowerBlue;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.ForeColor = Color.White;
            btnDiv.Location = new Point(289, 156);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(63, 47);
            btnDiv.TabIndex = 2;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.MouseClick += btnDiv_MouseClick;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ActiveCaptionText;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(199, 236);
            btn3.Name = "btn3";
            btn3.Size = new Size(63, 47);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.MouseClick += btn3_MouseClick;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaptionText;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(12, 236);
            btn1.Name = "btn1";
            btn1.Size = new Size(63, 47);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.MouseClick += btn1_MouseClick;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ActiveCaptionText;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(289, 236);
            btn4.Name = "btn4";
            btn4.Size = new Size(63, 47);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.MouseClick += btn4_MouseClick;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ActiveCaptionText;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(105, 236);
            btn2.Name = "btn2";
            btn2.Size = new Size(63, 47);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.MouseClick += btn2_MouseClick;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.CornflowerBlue;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMulti.ForeColor = Color.White;
            btnMulti.Location = new Point(199, 156);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(63, 47);
            btnMulti.TabIndex = 9;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.MouseClick += btnMulti_MouseClick;
            // 
            // btnSous
            // 
            btnSous.BackColor = Color.CornflowerBlue;
            btnSous.FlatStyle = FlatStyle.Flat;
            btnSous.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSous.ForeColor = Color.White;
            btnSous.Location = new Point(105, 156);
            btnSous.Name = "btnSous";
            btnSous.Size = new Size(63, 47);
            btnSous.TabIndex = 10;
            btnSous.Text = "-";
            btnSous.UseVisualStyleBackColor = false;
            btnSous.MouseClick += btnSous_MouseClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(12, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 47);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.MouseClick += btnAdd_MouseClick;
            // 
            // bt6
            // 
            bt6.BackColor = SystemColors.ActiveCaptionText;
            bt6.FlatStyle = FlatStyle.Flat;
            bt6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt6.ForeColor = SystemColors.ButtonHighlight;
            bt6.Location = new Point(105, 310);
            bt6.Name = "bt6";
            bt6.Size = new Size(63, 47);
            bt6.TabIndex = 15;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = false;
            bt6.MouseClick += btn6_MouseClick;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ActiveCaptionText;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(289, 310);
            btn8.Name = "btn8";
            btn8.Size = new Size(63, 47);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.MouseClick += btn8_MouseClick;
            // 
            // bt5
            // 
            bt5.BackColor = SystemColors.ActiveCaptionText;
            bt5.FlatStyle = FlatStyle.Flat;
            bt5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt5.ForeColor = SystemColors.ButtonHighlight;
            bt5.Location = new Point(12, 310);
            bt5.Name = "bt5";
            bt5.Size = new Size(63, 47);
            bt5.TabIndex = 13;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = false;
            bt5.MouseClick += btn5_MouseClick;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ActiveCaptionText;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(199, 310);
            btn7.Name = "btn7";
            btn7.Size = new Size(63, 47);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.MouseClick += btn7_MouseClick;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ActiveCaptionText;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(105, 390);
            btn0.Name = "btn0";
            btn0.Size = new Size(63, 47);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.MouseClick += btn0_MouseClick;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ActiveCaptionText;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(12, 390);
            btn9.Name = "btn9";
            btn9.Size = new Size(63, 47);
            btn9.TabIndex = 17;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.MouseClick += btn9_MouseClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Fuchsia;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(12, 88);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(63, 47);
            btnClear.TabIndex = 20;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.MouseClick += btnClear_MouseClick;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ActiveCaptionText;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.ForeColor = SystemColors.ButtonHighlight;
            btnDot.Location = new Point(199, 390);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(63, 47);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.MouseClick += btnDot_MouseClick;
            // 
            // btnEgal
            // 
            btnEgal.BackColor = Color.FromArgb(64, 0, 0);
            btnEgal.FlatStyle = FlatStyle.Flat;
            btnEgal.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEgal.ForeColor = SystemColors.ButtonHighlight;
            btnEgal.Location = new Point(291, 390);
            btnEgal.Name = "btnEgal";
            btnEgal.Size = new Size(63, 47);
            btnEgal.TabIndex = 22;
            btnEgal.Text = "=";
            btnEgal.UseVisualStyleBackColor = false;
            btnEgal.MouseClick += btnEgal_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(366, 458);
            ControlBox = false;
            Controls.Add(btnEgal);
            Controls.Add(btnDot);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(bt6);
            Controls.Add(btn8);
            Controls.Add(bt5);
            Controls.Add(btn7);
            Controls.Add(btnAdd);
            Controls.Add(btnSous);
            Controls.Add(btnMulti);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn3);
            Controls.Add(btnDiv);
            Controls.Add(textField);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Calculatrice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textField;
        private Button chiffre1;
        private Button btnDiv;
        private Button btn3;
        private Button btn1;
        private Button btn4;
        private Button btn2;
        private Button btnMulti;
        private Button btnSous;
        private Button btnAdd;
        private Button bt6;
        private Button btn8;
        private Button bt5;
        private Button btn7;
        private Button btn0;
        private Button btn9;
        private Button btnClear;
        private Button btnDot;
        private Button btnEgal;
    }
}

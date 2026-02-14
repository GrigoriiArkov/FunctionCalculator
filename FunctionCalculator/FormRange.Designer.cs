namespace FunctionCalculator
{
    partial class FormRange
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 59);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 0;
            label1.Text = "Границы интервала";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 43);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(307, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 43);
            textBox2.TabIndex = 2;
            textBox2.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(53, 272);
            button1.Name = "button1";
            button1.Size = new Size(255, 52);
            button1.TabIndex = 3;
            button1.Text = "Передать данные";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(323, 272);
            button2.Name = "button2";
            button2.Size = new Size(291, 52);
            button2.TabIndex = 4;
            button2.Text = "Отменить передачу";
            button2.UseVisualStyleBackColor = false;
            // 
            // FormRange
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRange";
            Text = "FormRange";
            Load += FormRange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
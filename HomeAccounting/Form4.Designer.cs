namespace HomeAccounting
{
    partial class Form4
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
            button2 = new Button();
            commentField = new TextBox();
            categoryField = new TextBox();
            summField = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(384, 361);
            button2.Name = "button2";
            button2.Size = new Size(204, 77);
            button2.TabIndex = 9;
            button2.Text = "Отобразить данные";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // commentField
            // 
            commentField.Location = new Point(445, 299);
            commentField.Multiline = true;
            commentField.Name = "commentField";
            commentField.Size = new Size(348, 56);
            commentField.TabIndex = 8;
            // 
            // categoryField
            // 
            categoryField.Location = new Point(445, 68);
            categoryField.Multiline = true;
            categoryField.Name = "categoryField";
            categoryField.Size = new Size(348, 54);
            categoryField.TabIndex = 7;
            // 
            // summField
            // 
            summField.Location = new Point(445, 186);
            summField.Multiline = true;
            summField.Name = "summField";
            summField.Size = new Size(348, 53);
            summField.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(594, 361);
            button1.Name = "button1";
            button1.Size = new Size(199, 77);
            button1.TabIndex = 5;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(445, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 10;
            label1.Text = "Категория";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(445, 140);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 11;
            label2.Text = "Сумма";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(445, 258);
            label3.Name = "label3";
            label3.Size = new Size(177, 29);
            label3.TabIndex = 12;
            label3.Text = "Комментарий";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(commentField);
            Controls.Add(categoryField);
            Controls.Add(summField);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox commentField;
        private TextBox categoryField;
        private TextBox summField;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
namespace HomeAccounting
{
    partial class Form9
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
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            commentField = new TextBox();
            categoryField = new TextBox();
            summField = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(616, 373);
            button1.Name = "button1";
            button1.Size = new Size(182, 77);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(406, 373);
            button2.Name = "button2";
            button2.Size = new Size(204, 77);
            button2.TabIndex = 4;
            button2.Text = "Отобразить данные";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(450, 258);
            label3.Name = "label3";
            label3.Size = new Size(177, 29);
            label3.TabIndex = 18;
            label3.Text = "Комментарий";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(450, 140);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 17;
            label2.Text = "Сумма";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(450, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 16;
            label1.Text = "Категория";
            // 
            // commentField
            // 
            commentField.Location = new Point(450, 299);
            commentField.Multiline = true;
            commentField.Name = "commentField";
            commentField.Size = new Size(348, 56);
            commentField.TabIndex = 15;
            // 
            // categoryField
            // 
            categoryField.Location = new Point(450, 68);
            categoryField.Multiline = true;
            categoryField.Name = "categoryField";
            categoryField.Size = new Size(348, 54);
            categoryField.TabIndex = 14;
            // 
            // summField
            // 
            summField.Location = new Point(450, 186);
            summField.Multiline = true;
            summField.Name = "summField";
            summField.Size = new Size(348, 53);
            summField.TabIndex = 13;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(commentField);
            Controls.Add(categoryField);
            Controls.Add(summField);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox commentField;
        private TextBox categoryField;
        private TextBox summField;
    }
}
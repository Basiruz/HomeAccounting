﻿namespace HomeAccounting
{
    partial class Form5
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
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            commentField = new TextBox();
            categoryField = new TextBox();
            summField = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(390, 367);
            button2.Name = "button2";
            button2.Size = new Size(204, 77);
            button2.TabIndex = 19;
            button2.Text = "Отобразить данные";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(616, 367);
            button3.Name = "button3";
            button3.Size = new Size(182, 77);
            button3.TabIndex = 15;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(450, 253);
            label3.Name = "label3";
            label3.Size = new Size(177, 29);
            label3.TabIndex = 25;
            label3.Text = "Комментарий";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(450, 135);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 24;
            label2.Text = "Сумма";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(450, 28);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 23;
            label1.Text = "Категория";
            // 
            // commentField
            // 
            commentField.Location = new Point(450, 294);
            commentField.Multiline = true;
            commentField.Name = "commentField";
            commentField.Size = new Size(348, 56);
            commentField.TabIndex = 22;
            // 
            // categoryField
            // 
            categoryField.Location = new Point(450, 63);
            categoryField.Multiline = true;
            categoryField.Name = "categoryField";
            categoryField.Size = new Size(348, 54);
            categoryField.TabIndex = 21;
            // 
            // summField
            // 
            summField.Location = new Point(450, 181);
            summField.Multiline = true;
            summField.Name = "summField";
            summField.Size = new Size(348, 53);
            summField.TabIndex = 20;
            // 
            // Form5
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
            Controls.Add(button3);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox commentField;
        private TextBox categoryField;
        private TextBox summField;
    }
}
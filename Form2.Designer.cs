namespace FeedbackCRUD
{
    partial class Form2
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
            label4 = new Label();
            button2 = new Button();
            RatingNumericValue = new NumericUpDown();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)RatingNumericValue).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 83);
            label4.Name = "label4";
            label4.Size = new Size(188, 25);
            label4.TabIndex = 16;
            label4.Text = "Update your feedback";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(317, 312);
            button2.Name = "button2";
            button2.Size = new Size(145, 38);
            button2.TabIndex = 15;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RatingNumericValue
            // 
            RatingNumericValue.Location = new Point(335, 178);
            RatingNumericValue.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            RatingNumericValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RatingNumericValue.Name = "RatingNumericValue";
            RatingNumericValue.Size = new Size(206, 31);
            RatingNumericValue.TabIndex = 14;
            RatingNumericValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(335, 220);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(206, 31);
            DescriptionTextBox.TabIndex = 13;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(335, 140);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(206, 31);
            NameTextBox.TabIndex = 12;
            NameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 223);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 11;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 181);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 10;
            label2.Text = "Rating";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 142);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(RatingNumericValue);
            Controls.Add(DescriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)RatingNumericValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button2;
        private NumericUpDown RatingNumericValue;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
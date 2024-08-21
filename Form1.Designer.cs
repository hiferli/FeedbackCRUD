namespace FeedbackCRUD
{
    partial class Feedback
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            button2 = new Button();
            RatingNumericValue = new NumericUpDown();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button6 = new Button();
            button5 = new Button();
            checkedListBox2 = new CheckedListBox();
            label6 = new Label();
            tabPage3 = new TabPage();
            checkedListBox1 = new CheckedListBox();
            button4 = new Button();
            button3 = new Button();
            label5 = new Label();
            tabPage4 = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RatingNumericValue).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(RatingNumericValue);
            tabPage1.Controls.Add(DescriptionTextBox);
            tabPage1.Controls.Add(NameTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Feedback";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 47);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 8;
            label4.Text = "Add your feedback";
            // 
            // button2
            // 
            button2.Location = new Point(288, 276);
            button2.Name = "button2";
            button2.Size = new Size(145, 38);
            button2.TabIndex = 7;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RatingNumericValue
            // 
            RatingNumericValue.Location = new Point(306, 142);
            RatingNumericValue.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            RatingNumericValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RatingNumericValue.Name = "RatingNumericValue";
            RatingNumericValue.Size = new Size(206, 31);
            RatingNumericValue.TabIndex = 6;
            RatingNumericValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(306, 184);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(206, 31);
            DescriptionTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(306, 104);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(206, 31);
            NameTextBox.TabIndex = 3;
            NameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 187);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 145);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Rating";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 106);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(checkedListBox2);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update Feedback";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(365, 335);
            button6.Name = "button6";
            button6.Size = new Size(160, 34);
            button6.TabIndex = 3;
            button6.Text = "Make Update(s)";
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(247, 335);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 2;
            button5.Text = "Load Data";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(6, 45);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(756, 284);
            checkedListBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 17);
            label6.Name = "label6";
            label6.Size = new Size(232, 25);
            label6.TabIndex = 0;
            label6.Text = "Select a feedback to update";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkedListBox1);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 388);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete Feedback";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(6, 45);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(756, 284);
            checkedListBox1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(365, 335);
            button4.Name = "button4";
            button4.Size = new Size(163, 34);
            button4.TabIndex = 3;
            button4.Text = "Confirm Deletion";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(247, 335);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Load Data";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 17);
            label5.Name = "label5";
            label5.Size = new Size(276, 25);
            label5.TabIndex = 1;
            label5.Text = "Select the feedback to be deleted";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 388);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Show Feedbacks";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(318, 348);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Load Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(756, 339);
            dataGridView1.TabIndex = 0;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Feedback";
            Text = "Feedback Form";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RatingNumericValue).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label5;
        private Button button4;
        private Button button3;
        private CheckedListBox checkedListBox1;
        private Button button5;
        private CheckedListBox checkedListBox2;
        private Label label6;
        private Label label4;
        private Button button2;
        private NumericUpDown RatingNumericValue;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button6;
    }
}

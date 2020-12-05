
namespace InvoiceManager
{
    partial class Form1
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
            this.readFileButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupByNamesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(12, 56);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(86, 25);
            this.readFileButton.TabIndex = 0;
            this.readFileButton.Text = "Read file";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 30);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(775, 20);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.Text = "C:\\Users\\Marcin\\source\\repos\\ProgrammingLanguagesASL01\\invoices.txt";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 9);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(50, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "File path:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 88);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(775, 350);
            this.resultTextBox.TabIndex = 3;
            // 
            // groupByNamesButton
            // 
            this.groupByNamesButton.Location = new System.Drawing.Point(105, 56);
            this.groupByNamesButton.Name = "groupByNamesButton";
            this.groupByNamesButton.Size = new System.Drawing.Size(95, 26);
            this.groupByNamesButton.TabIndex = 4;
            this.groupByNamesButton.Text = "Group by names";
            this.groupByNamesButton.UseVisualStyleBackColor = true;
            this.groupByNamesButton.Click += new System.EventHandler(this.groupByNamesButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Group by names";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupByNamesButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.readFileButton);
            this.Name = "Form1";
            this.Text = "Invoice manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button groupByNamesButton;
        private System.Windows.Forms.Button button1;
    }
}


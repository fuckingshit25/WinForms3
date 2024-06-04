namespace WinForms_Тема3
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
            button = new System.Windows.Forms.Button();
            NumbersFromFile = new System.Windows.Forms.TextBox();
            ConverterButton = new System.Windows.Forms.Button();
            ConverterNumbers = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button
            // 
            button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button.Location = new System.Drawing.Point(101, 56);
            button.Name = "button";
            button.Size = new System.Drawing.Size(308, 51);
            button.TabIndex = 0;
            button.Text = "Считать числа из файла";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // NumbersFromFile
            // 
            NumbersFromFile.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NumbersFromFile.Location = new System.Drawing.Point(101, 113);
            NumbersFromFile.Name = "NumbersFromFile";
            NumbersFromFile.Size = new System.Drawing.Size(308, 39);
            NumbersFromFile.TabIndex = 1;
            // 
            // ConverterButton
            // 
            ConverterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ConverterButton.Location = new System.Drawing.Point(101, 158);
            ConverterButton.Name = "ConverterButton";
            ConverterButton.Size = new System.Drawing.Size(308, 51);
            ConverterButton.TabIndex = 2;
            ConverterButton.Text = "Перевести в 5-ричную систему";
            ConverterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            ConverterButton.UseVisualStyleBackColor = true;
            ConverterButton.Click += ConverterButton_Click;
            // 
            // ConverterNumbers
            // 
            ConverterNumbers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ConverterNumbers.Location = new System.Drawing.Point(101, 215);
            ConverterNumbers.Name = "ConverterNumbers";
            ConverterNumbers.Size = new System.Drawing.Size(308, 39);
            ConverterNumbers.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(513, 308);
            Controls.Add(ConverterNumbers);
            Controls.Add(ConverterButton);
            Controls.Add(NumbersFromFile);
            Controls.Add(button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox NumbersFromFile;
        private System.Windows.Forms.Button ConverterButton;
        private System.Windows.Forms.TextBox ConverterNumbers;
    }
}

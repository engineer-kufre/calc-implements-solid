namespace CalculatorUI
{
    partial class CalcuatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcuatorForm));
            this.numberNine = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.numberSeven = new System.Windows.Forms.Button();
            this.numberEight = new System.Windows.Forms.Button();
            this.numberSix = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.numberFour = new System.Windows.Forms.Button();
            this.numberFive = new System.Windows.Forms.Button();
            this.numberThree = new System.Windows.Forms.Button();
            this.numberZero = new System.Windows.Forms.Button();
            this.numberTwo = new System.Windows.Forms.Button();
            this.numberOne = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.subView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberNine
            // 
            this.numberNine.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberNine.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.numberNine.FlatAppearance.BorderSize = 0;
            this.numberNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberNine.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberNine.ForeColor = System.Drawing.Color.White;
            this.numberNine.Location = new System.Drawing.Point(0, 111);
            this.numberNine.Margin = new System.Windows.Forms.Padding(0);
            this.numberNine.Name = "numberNine";
            this.numberNine.Size = new System.Drawing.Size(60, 60);
            this.numberNine.TabIndex = 0;
            this.numberNine.Text = "9";
            this.numberNine.UseVisualStyleBackColor = false;
            this.numberNine.Click += new System.EventHandler(this.number_click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(120, 111);
            this.clearButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 60);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.mutation_click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backspaceButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.backspaceButton.ForeColor = System.Drawing.Color.White;
            this.backspaceButton.Location = new System.Drawing.Point(60, 111);
            this.backspaceButton.Margin = new System.Windows.Forms.Padding(0);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(60, 60);
            this.backspaceButton.TabIndex = 0;
            this.backspaceButton.Text = "<";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.mutation_click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.multiplyButton.ForeColor = System.Drawing.Color.White;
            this.multiplyButton.Location = new System.Drawing.Point(180, 111);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(0);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(60, 60);
            this.multiplyButton.TabIndex = 0;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.operator_click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divideButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.divideButton.ForeColor = System.Drawing.Color.White;
            this.divideButton.Location = new System.Drawing.Point(240, 111);
            this.divideButton.Margin = new System.Windows.Forms.Padding(0);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(60, 60);
            this.divideButton.TabIndex = 0;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.operator_click);
            // 
            // changeSignButton
            // 
            this.changeSignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.changeSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeSignButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.changeSignButton.ForeColor = System.Drawing.Color.White;
            this.changeSignButton.Location = new System.Drawing.Point(240, 171);
            this.changeSignButton.Margin = new System.Windows.Forms.Padding(0);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Size = new System.Drawing.Size(60, 60);
            this.changeSignButton.TabIndex = 0;
            this.changeSignButton.Text = "+/-";
            this.changeSignButton.UseVisualStyleBackColor = false;
            this.changeSignButton.Click += new System.EventHandler(this.mutation_click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(180, 171);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 60);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.operator_click);
            // 
            // numberSeven
            // 
            this.numberSeven.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberSeven.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberSeven.ForeColor = System.Drawing.Color.White;
            this.numberSeven.Location = new System.Drawing.Point(60, 171);
            this.numberSeven.Margin = new System.Windows.Forms.Padding(0);
            this.numberSeven.Name = "numberSeven";
            this.numberSeven.Size = new System.Drawing.Size(60, 60);
            this.numberSeven.TabIndex = 0;
            this.numberSeven.Text = "7";
            this.numberSeven.UseVisualStyleBackColor = false;
            this.numberSeven.Click += new System.EventHandler(this.number_click);
            // 
            // numberEight
            // 
            this.numberEight.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberEight.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberEight.ForeColor = System.Drawing.Color.White;
            this.numberEight.Location = new System.Drawing.Point(120, 171);
            this.numberEight.Margin = new System.Windows.Forms.Padding(0);
            this.numberEight.Name = "numberEight";
            this.numberEight.Size = new System.Drawing.Size(60, 60);
            this.numberEight.TabIndex = 0;
            this.numberEight.Text = "8";
            this.numberEight.UseVisualStyleBackColor = false;
            this.numberEight.Click += new System.EventHandler(this.number_click);
            // 
            // numberSix
            // 
            this.numberSix.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberSix.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberSix.ForeColor = System.Drawing.Color.White;
            this.numberSix.Location = new System.Drawing.Point(0, 171);
            this.numberSix.Margin = new System.Windows.Forms.Padding(0);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(60, 60);
            this.numberSix.TabIndex = 0;
            this.numberSix.Text = "6";
            this.numberSix.UseVisualStyleBackColor = false;
            this.numberSix.Click += new System.EventHandler(this.number_click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(54)))), ((int)(((byte)(124)))));
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.equalButton.ForeColor = System.Drawing.Color.White;
            this.equalButton.Location = new System.Drawing.Point(240, 231);
            this.equalButton.Margin = new System.Windows.Forms.Padding(0);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(60, 120);
            this.equalButton.TabIndex = 0;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equal_click);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtractButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.subtractButton.ForeColor = System.Drawing.Color.White;
            this.subtractButton.Location = new System.Drawing.Point(180, 231);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(0);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(60, 60);
            this.subtractButton.TabIndex = 0;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.operator_click);
            // 
            // numberFour
            // 
            this.numberFour.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberFour.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberFour.ForeColor = System.Drawing.Color.White;
            this.numberFour.Location = new System.Drawing.Point(60, 231);
            this.numberFour.Margin = new System.Windows.Forms.Padding(0);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(60, 60);
            this.numberFour.TabIndex = 0;
            this.numberFour.Text = "4";
            this.numberFour.UseVisualStyleBackColor = false;
            this.numberFour.Click += new System.EventHandler(this.number_click);
            // 
            // numberFive
            // 
            this.numberFive.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberFive.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberFive.ForeColor = System.Drawing.Color.White;
            this.numberFive.Location = new System.Drawing.Point(120, 231);
            this.numberFive.Margin = new System.Windows.Forms.Padding(0);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(60, 60);
            this.numberFive.TabIndex = 0;
            this.numberFive.Text = "5";
            this.numberFive.UseVisualStyleBackColor = false;
            this.numberFive.Click += new System.EventHandler(this.number_click);
            // 
            // numberThree
            // 
            this.numberThree.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberThree.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberThree.ForeColor = System.Drawing.Color.White;
            this.numberThree.Location = new System.Drawing.Point(0, 231);
            this.numberThree.Margin = new System.Windows.Forms.Padding(0);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(60, 60);
            this.numberThree.TabIndex = 0;
            this.numberThree.Text = "3";
            this.numberThree.UseVisualStyleBackColor = false;
            this.numberThree.Click += new System.EventHandler(this.number_click);
            // 
            // numberZero
            // 
            this.numberZero.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberZero.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberZero.ForeColor = System.Drawing.Color.White;
            this.numberZero.Location = new System.Drawing.Point(0, 291);
            this.numberZero.Margin = new System.Windows.Forms.Padding(0);
            this.numberZero.Name = "numberZero";
            this.numberZero.Size = new System.Drawing.Size(60, 60);
            this.numberZero.TabIndex = 0;
            this.numberZero.Text = "0";
            this.numberZero.UseVisualStyleBackColor = false;
            this.numberZero.Click += new System.EventHandler(this.number_click);
            // 
            // numberTwo
            // 
            this.numberTwo.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberTwo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberTwo.ForeColor = System.Drawing.Color.White;
            this.numberTwo.Location = new System.Drawing.Point(120, 291);
            this.numberTwo.Margin = new System.Windows.Forms.Padding(0);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(60, 60);
            this.numberTwo.TabIndex = 0;
            this.numberTwo.Text = "2";
            this.numberTwo.UseVisualStyleBackColor = false;
            this.numberTwo.Click += new System.EventHandler(this.number_click);
            // 
            // numberOne
            // 
            this.numberOne.BackColor = System.Drawing.SystemColors.Desktop;
            this.numberOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numberOne.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.numberOne.ForeColor = System.Drawing.Color.White;
            this.numberOne.Location = new System.Drawing.Point(60, 291);
            this.numberOne.Margin = new System.Windows.Forms.Padding(0);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(60, 60);
            this.numberOne.TabIndex = 0;
            this.numberOne.Text = "1";
            this.numberOne.UseVisualStyleBackColor = false;
            this.numberOne.Click += new System.EventHandler(this.number_click);
            // 
            // decimalPoint
            // 
            this.decimalPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.decimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decimalPoint.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.decimalPoint.ForeColor = System.Drawing.Color.White;
            this.decimalPoint.Location = new System.Drawing.Point(180, 291);
            this.decimalPoint.Margin = new System.Windows.Forms.Padding(0);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(60, 60);
            this.decimalPoint.TabIndex = 0;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = false;
            this.decimalPoint.Click += new System.EventHandler(this.number_click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(0, 1);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(300, 51);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.clearEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearEntryButton.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.clearEntryButton.Location = new System.Drawing.Point(209, 51);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(91, 61);
            this.clearEntryButton.TabIndex = 0;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = false;
            this.clearEntryButton.Click += new System.EventHandler(this.mutation_click);
            // 
            // subView
            // 
            this.subView.AutoSize = true;
            this.subView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subView.ForeColor = System.Drawing.Color.Black;
            this.subView.Location = new System.Drawing.Point(12, 69);
            this.subView.Name = "subView";
            this.subView.Size = new System.Drawing.Size(0, 28);
            this.subView.TabIndex = 2;
            // 
            // CalcuatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 351);
            this.Controls.Add(this.subView);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberZero);
            this.Controls.Add(this.numberThree);
            this.Controls.Add(this.numberFive);
            this.Controls.Add(this.numberFour);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.numberSix);
            this.Controls.Add(this.numberEight);
            this.Controls.Add(this.numberSeven);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeSignButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.numberNine);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "CalcuatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numberNine;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button changeSignButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button numberSeven;
        private System.Windows.Forms.Button numberEight;
        private System.Windows.Forms.Button numberSix;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button numberFour;
        private System.Windows.Forms.Button numberFive;
        private System.Windows.Forms.Button numberThree;
        private System.Windows.Forms.Button numberZero;
        private System.Windows.Forms.Button numberTwo;
        private System.Windows.Forms.Button numberOne;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Label subView;
    }
}


namespace Fibonacci
{
    partial class FibonacciCalculator
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
            this.asyncPanel = new System.Windows.Forms.Panel();
            this.calcAsyncLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.getFibLabel = new System.Windows.Forms.Label();
            this.asyncResultLabel = new System.Windows.Forms.Label();
            this.syncPanel = new System.Windows.Forms.Panel();
            this.syncResultLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.nextNumberButton = new System.Windows.Forms.Button();
            this.calcSyncLabel = new System.Windows.Forms.Label();
            this.asyncPanel.SuspendLayout();
            this.syncPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // asyncPanel
            // 
            this.asyncPanel.Controls.Add(this.asyncResultLabel);
            this.asyncPanel.Controls.Add(this.getFibLabel);
            this.asyncPanel.Controls.Add(this.calculateButton);
            this.asyncPanel.Controls.Add(this.inputTextBox);
            this.asyncPanel.Controls.Add(this.calcAsyncLabel);
            this.asyncPanel.Location = new System.Drawing.Point(24, 24);
            this.asyncPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.asyncPanel.Name = "asyncPanel";
            this.asyncPanel.Size = new System.Drawing.Size(472, 154);
            this.asyncPanel.TabIndex = 0;
            // 
            // calcAsyncLabel
            // 
            this.calcAsyncLabel.AutoSize = true;
            this.calcAsyncLabel.Location = new System.Drawing.Point(40, 16);
            this.calcAsyncLabel.Name = "calcAsyncLabel";
            this.calcAsyncLabel.Size = new System.Drawing.Size(190, 20);
            this.calcAsyncLabel.TabIndex = 0;
            this.calcAsyncLabel.Text = "Calculate Asynchronously";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(176, 56);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(176, 26);
            this.inputTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(48, 96);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 39);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // getFibLabel
            // 
            this.getFibLabel.AutoSize = true;
            this.getFibLabel.Location = new System.Drawing.Point(40, 56);
            this.getFibLabel.Name = "getFibLabel";
            this.getFibLabel.Size = new System.Drawing.Size(134, 20);
            this.getFibLabel.TabIndex = 3;
            this.getFibLabel.Text = "Get Fibonacci of: ";
            // 
            // asyncResultLabel
            // 
            this.asyncResultLabel.AutoSize = true;
            this.asyncResultLabel.Location = new System.Drawing.Point(184, 104);
            this.asyncResultLabel.Name = "asyncResultLabel";
            this.asyncResultLabel.Size = new System.Drawing.Size(55, 20);
            this.asyncResultLabel.TabIndex = 4;
            this.asyncResultLabel.Text = "Result";
            // 
            // syncPanel
            // 
            this.syncPanel.Controls.Add(this.syncResultLabel);
            this.syncPanel.Controls.Add(this.displayLabel);
            this.syncPanel.Controls.Add(this.nextNumberButton);
            this.syncPanel.Controls.Add(this.calcSyncLabel);
            this.syncPanel.Location = new System.Drawing.Point(24, 208);
            this.syncPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.syncPanel.Name = "syncPanel";
            this.syncPanel.Size = new System.Drawing.Size(472, 154);
            this.syncPanel.TabIndex = 5;
            // 
            // syncResultLabel
            // 
            this.syncResultLabel.AutoSize = true;
            this.syncResultLabel.Location = new System.Drawing.Point(184, 56);
            this.syncResultLabel.Name = "syncResultLabel";
            this.syncResultLabel.Size = new System.Drawing.Size(55, 20);
            this.syncResultLabel.TabIndex = 4;
            this.syncResultLabel.Text = "Result";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(40, 56);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(134, 20);
            this.displayLabel.TabIndex = 3;
            this.displayLabel.Text = "Get Fibonacci of: ";
            // 
            // nextNumberButton
            // 
            this.nextNumberButton.Location = new System.Drawing.Point(48, 96);
            this.nextNumberButton.Name = "nextNumberButton";
            this.nextNumberButton.Size = new System.Drawing.Size(112, 39);
            this.nextNumberButton.TabIndex = 2;
            this.nextNumberButton.Text = "Next Number";
            this.nextNumberButton.UseVisualStyleBackColor = true;
            this.nextNumberButton.Click += new System.EventHandler(this.nextNumberButton_Click);
            // 
            // calcSyncLabel
            // 
            this.calcSyncLabel.AutoSize = true;
            this.calcSyncLabel.Location = new System.Drawing.Point(40, 16);
            this.calcSyncLabel.Name = "calcSyncLabel";
            this.calcSyncLabel.Size = new System.Drawing.Size(182, 20);
            this.calcSyncLabel.TabIndex = 0;
            this.calcSyncLabel.Text = "Calculate Synchronously";
            // 
            // FibonacciCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 383);
            this.Controls.Add(this.syncPanel);
            this.Controls.Add(this.asyncPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FibonacciCalculator";
            this.Text = "Fibonacci Calculator";
            this.asyncPanel.ResumeLayout(false);
            this.asyncPanel.PerformLayout();
            this.syncPanel.ResumeLayout(false);
            this.syncPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel asyncPanel;
        private System.Windows.Forms.Label calcAsyncLabel;
        private System.Windows.Forms.Label asyncResultLabel;
        private System.Windows.Forms.Label getFibLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Panel syncPanel;
        private System.Windows.Forms.Label syncResultLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button nextNumberButton;
        private System.Windows.Forms.Label calcSyncLabel;
    }
}


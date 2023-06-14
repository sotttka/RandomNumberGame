
namespace RandomNumberGame
{
    partial class GameForm
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
            this.tryGuessNumber = new MaterialSkin.Controls.MaterialRaisedButton();
            this.answerLabel = new System.Windows.Forms.Label();
            this.inputGuessNumber = new System.Windows.Forms.TextBox();
            this.inputNumberTitle = new System.Windows.Forms.Label();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tryGuessNumber
            // 
            this.tryGuessNumber.Depth = 0;
            this.tryGuessNumber.Location = new System.Drawing.Point(12, 140);
            this.tryGuessNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.tryGuessNumber.Name = "tryGuessNumber";
            this.tryGuessNumber.Primary = true;
            this.tryGuessNumber.Size = new System.Drawing.Size(576, 42);
            this.tryGuessNumber.TabIndex = 0;
            this.tryGuessNumber.Text = "Угадать число";
            this.tryGuessNumber.UseVisualStyleBackColor = true;
            this.tryGuessNumber.Click += new System.EventHandler(this.tryGuessNumber_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerLabel.Location = new System.Drawing.Point(12, 76);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(178, 32);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Какой то ответ";
            // 
            // inputGuessNumber
            // 
            this.inputGuessNumber.Location = new System.Drawing.Point(135, 111);
            this.inputGuessNumber.Name = "inputGuessNumber";
            this.inputGuessNumber.Size = new System.Drawing.Size(453, 23);
            this.inputGuessNumber.TabIndex = 2;
            // 
            // inputNumberTitle
            // 
            this.inputNumberTitle.AutoSize = true;
            this.inputNumberTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNumberTitle.Location = new System.Drawing.Point(12, 111);
            this.inputNumberTitle.Name = "inputNumberTitle";
            this.inputNumberTitle.Size = new System.Drawing.Size(117, 21);
            this.inputNumberTitle.TabIndex = 3;
            this.inputNumberTitle.Text = "Введите число:";
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.attemptsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attemptsLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.attemptsLabel.Location = new System.Drawing.Point(12, 185);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(0, 21);
            this.attemptsLabel.TabIndex = 4;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 213);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.inputNumberTitle);
            this.Controls.Add(this.inputGuessNumber);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.tryGuessNumber);
            this.Name = "GameForm";
            this.Sizable = false;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton tryGuessNumber;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox inputGuessNumber;
        private System.Windows.Forms.Label inputNumberTitle;
        private System.Windows.Forms.Label attemptsLabel;
    }
}


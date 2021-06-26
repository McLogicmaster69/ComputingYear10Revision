
namespace ComputingYear10Revision
{
    partial class Revision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revision));
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.UserAnswer = new System.Windows.Forms.TextBox();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.CorrectBtn = new System.Windows.Forms.Button();
            this.IncorrectBtn = new System.Windows.Forms.Button();
            this.AnswerLbl = new System.Windows.Forms.Label();
            this.CompareAnswerLbl = new System.Windows.Forms.Label();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.UserNumberInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UserNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.Location = new System.Drawing.Point(12, 12);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(385, 335);
            this.QuestionLbl.TabIndex = 0;
            this.QuestionLbl.Text = "Question";
            // 
            // UserAnswer
            // 
            this.UserAnswer.Location = new System.Drawing.Point(403, 12);
            this.UserAnswer.Multiline = true;
            this.UserAnswer.Name = "UserAnswer";
            this.UserAnswer.Size = new System.Drawing.Size(385, 335);
            this.UserAnswer.TabIndex = 1;
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.BackColor = System.Drawing.Color.Yellow;
            this.AnswerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerBtn.Location = new System.Drawing.Point(12, 353);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(776, 85);
            this.AnswerBtn.TabIndex = 3;
            this.AnswerBtn.Text = "ANSWER";
            this.AnswerBtn.UseVisualStyleBackColor = false;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // CorrectBtn
            // 
            this.CorrectBtn.BackColor = System.Drawing.Color.Lime;
            this.CorrectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectBtn.Location = new System.Drawing.Point(403, 353);
            this.CorrectBtn.Name = "CorrectBtn";
            this.CorrectBtn.Size = new System.Drawing.Size(385, 85);
            this.CorrectBtn.TabIndex = 4;
            this.CorrectBtn.Text = "CORRECT";
            this.CorrectBtn.UseVisualStyleBackColor = false;
            this.CorrectBtn.Visible = false;
            this.CorrectBtn.Click += new System.EventHandler(this.CorrectBtn_Click);
            // 
            // IncorrectBtn
            // 
            this.IncorrectBtn.BackColor = System.Drawing.Color.Red;
            this.IncorrectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectBtn.Location = new System.Drawing.Point(12, 353);
            this.IncorrectBtn.Name = "IncorrectBtn";
            this.IncorrectBtn.Size = new System.Drawing.Size(385, 85);
            this.IncorrectBtn.TabIndex = 5;
            this.IncorrectBtn.Text = "INCORRECT";
            this.IncorrectBtn.UseVisualStyleBackColor = false;
            this.IncorrectBtn.Visible = false;
            this.IncorrectBtn.Click += new System.EventHandler(this.IncorrectBtn_Click);
            // 
            // AnswerLbl
            // 
            this.AnswerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLbl.Location = new System.Drawing.Point(12, 12);
            this.AnswerLbl.Name = "AnswerLbl";
            this.AnswerLbl.Size = new System.Drawing.Size(385, 335);
            this.AnswerLbl.TabIndex = 6;
            this.AnswerLbl.Text = "Answer";
            this.AnswerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AnswerLbl.Visible = false;
            // 
            // CompareAnswerLbl
            // 
            this.CompareAnswerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareAnswerLbl.Location = new System.Drawing.Point(403, 12);
            this.CompareAnswerLbl.Name = "CompareAnswerLbl";
            this.CompareAnswerLbl.Size = new System.Drawing.Size(385, 335);
            this.CompareAnswerLbl.TabIndex = 7;
            this.CompareAnswerLbl.Text = "Answer";
            this.CompareAnswerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompareAnswerLbl.Visible = false;
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.BackColor = System.Drawing.Color.Yellow;
            this.ContinueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueBtn.Location = new System.Drawing.Point(12, 353);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(776, 85);
            this.ContinueBtn.TabIndex = 8;
            this.ContinueBtn.Text = "CONTINUE";
            this.ContinueBtn.UseVisualStyleBackColor = false;
            this.ContinueBtn.Visible = false;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // UserNumberInput
            // 
            this.UserNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNumberInput.Location = new System.Drawing.Point(406, 156);
            this.UserNumberInput.Name = "UserNumberInput";
            this.UserNumberInput.Size = new System.Drawing.Size(382, 38);
            this.UserNumberInput.TabIndex = 9;
            // 
            // Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserNumberInput);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.CompareAnswerLbl);
            this.Controls.Add(this.AnswerLbl);
            this.Controls.Add(this.IncorrectBtn);
            this.Controls.Add(this.CorrectBtn);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.UserAnswer);
            this.Controls.Add(this.QuestionLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Revision";
            this.Text = "Revision";
            this.Load += new System.EventHandler(this.Revision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserNumberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLbl;
        private System.Windows.Forms.TextBox UserAnswer;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Button CorrectBtn;
        private System.Windows.Forms.Button IncorrectBtn;
        private System.Windows.Forms.Label AnswerLbl;
        private System.Windows.Forms.Label CompareAnswerLbl;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.NumericUpDown UserNumberInput;
    }
}


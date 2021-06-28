
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
            this.Background = new System.Windows.Forms.PictureBox();
            this.statsLbl = new System.Windows.Forms.Label();
            this.NumOfQuestions = new System.Windows.Forms.Label();
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.CurrentQuestion = new System.Windows.Forms.Label();
            this.Percent = new System.Windows.Forms.Label();
            this.Choice1 = new System.Windows.Forms.Button();
            this.Choice2 = new System.Windows.Forms.Button();
            this.Choice3 = new System.Windows.Forms.Button();
            this.Choice4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLbl.Location = new System.Drawing.Point(12, 12);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(385, 335);
            this.QuestionLbl.TabIndex = 0;
            this.QuestionLbl.Text = "Question";
            this.QuestionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AnswerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.CorrectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.IncorrectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.ContinueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Background.Location = new System.Drawing.Point(794, 12);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(138, 426);
            this.Background.TabIndex = 10;
            this.Background.TabStop = false;
            // 
            // statsLbl
            // 
            this.statsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.statsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLbl.Location = new System.Drawing.Point(794, 15);
            this.statsLbl.Name = "statsLbl";
            this.statsLbl.Size = new System.Drawing.Size(138, 32);
            this.statsLbl.TabIndex = 11;
            this.statsLbl.Text = "STATS";
            this.statsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumOfQuestions
            // 
            this.NumOfQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NumOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfQuestions.Location = new System.Drawing.Point(794, 104);
            this.NumOfQuestions.Name = "NumOfQuestions";
            this.NumOfQuestions.Size = new System.Drawing.Size(138, 57);
            this.NumOfQuestions.TabIndex = 12;
            this.NumOfQuestions.Text = "QUESTIONS";
            this.NumOfQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectLabel.Location = new System.Drawing.Point(794, 161);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(138, 57);
            this.CorrectLabel.TabIndex = 13;
            this.CorrectLabel.Text = "CORRECT";
            this.CorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentQuestion
            // 
            this.CurrentQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentQuestion.Location = new System.Drawing.Point(794, 47);
            this.CurrentQuestion.Name = "CurrentQuestion";
            this.CurrentQuestion.Size = new System.Drawing.Size(138, 57);
            this.CurrentQuestion.TabIndex = 14;
            this.CurrentQuestion.Text = "CURRENT";
            this.CurrentQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(794, 218);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(138, 57);
            this.Percent.TabIndex = 15;
            this.Percent.Text = "PERCENT";
            this.Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Choice1
            // 
            this.Choice1.BackColor = System.Drawing.Color.Red;
            this.Choice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choice1.Location = new System.Drawing.Point(408, 104);
            this.Choice1.Name = "Choice1";
            this.Choice1.Size = new System.Drawing.Size(380, 38);
            this.Choice1.TabIndex = 16;
            this.Choice1.Text = "1";
            this.Choice1.UseVisualStyleBackColor = false;
            this.Choice1.Click += new System.EventHandler(this.Choice1_Click);
            // 
            // Choice2
            // 
            this.Choice2.BackColor = System.Drawing.Color.Red;
            this.Choice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choice2.Location = new System.Drawing.Point(408, 148);
            this.Choice2.Name = "Choice2";
            this.Choice2.Size = new System.Drawing.Size(380, 38);
            this.Choice2.TabIndex = 17;
            this.Choice2.Text = "2";
            this.Choice2.UseVisualStyleBackColor = false;
            this.Choice2.Click += new System.EventHandler(this.Choice2_Click);
            // 
            // Choice3
            // 
            this.Choice3.BackColor = System.Drawing.Color.Red;
            this.Choice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choice3.Location = new System.Drawing.Point(408, 192);
            this.Choice3.Name = "Choice3";
            this.Choice3.Size = new System.Drawing.Size(380, 38);
            this.Choice3.TabIndex = 18;
            this.Choice3.Text = "3";
            this.Choice3.UseVisualStyleBackColor = false;
            this.Choice3.Click += new System.EventHandler(this.Choice3_Click);
            // 
            // Choice4
            // 
            this.Choice4.BackColor = System.Drawing.Color.Red;
            this.Choice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choice4.Location = new System.Drawing.Point(408, 236);
            this.Choice4.Name = "Choice4";
            this.Choice4.Size = new System.Drawing.Size(380, 38);
            this.Choice4.TabIndex = 19;
            this.Choice4.Text = "4";
            this.Choice4.UseVisualStyleBackColor = false;
            this.Choice4.Click += new System.EventHandler(this.Choice4_Click);
            // 
            // Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.Choice4);
            this.Controls.Add(this.Choice3);
            this.Controls.Add(this.Choice2);
            this.Controls.Add(this.Choice1);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.CurrentQuestion);
            this.Controls.Add(this.CorrectLabel);
            this.Controls.Add(this.NumOfQuestions);
            this.Controls.Add(this.statsLbl);
            this.Controls.Add(this.Background);
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
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
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
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Label statsLbl;
        private System.Windows.Forms.Label NumOfQuestions;
        private System.Windows.Forms.Label CorrectLabel;
        private System.Windows.Forms.Label CurrentQuestion;
        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.Button Choice1;
        private System.Windows.Forms.Button Choice2;
        private System.Windows.Forms.Button Choice3;
        private System.Windows.Forms.Button Choice4;
    }
}


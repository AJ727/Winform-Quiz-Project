namespace Project_4
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
            this.components = new System.ComponentModel.Container();
            this.timerQuiz = new System.Windows.Forms.Timer(this.components);
            this.tabObject = new System.Windows.Forms.TabControl();
            this.quizTab = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnShowGrade = new System.Windows.Forms.Button();
            this.labAllTypes = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstMyAnswer = new System.Windows.Forms.ListBox();
            this.gpQuestion = new System.Windows.Forms.GroupBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.cboQtype = new System.Windows.Forms.ComboBox();
            this.radA = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.labTime = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.gradeTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.totalGradeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.correctAnswerLBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gradeTabMyAnswerLbox = new System.Windows.Forms.ListBox();
            this.tabObject.SuspendLayout();
            this.quizTab.SuspendLayout();
            this.gpQuestion.SuspendLayout();
            this.gradeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerQuiz
            // 
            this.timerQuiz.Interval = 1500;
            this.timerQuiz.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabObject
            // 
            this.tabObject.Controls.Add(this.quizTab);
            this.tabObject.Controls.Add(this.gradeTab);
            this.tabObject.Location = new System.Drawing.Point(1, 2);
            this.tabObject.Name = "tabObject";
            this.tabObject.SelectedIndex = 0;
            this.tabObject.Size = new System.Drawing.Size(576, 429);
            this.tabObject.TabIndex = 19;
            this.tabObject.SelectedIndexChanged += new System.EventHandler(this.tabObject_SelectedIndexChanged);
            // 
            // quizTab
            // 
            this.quizTab.Controls.Add(this.btnInsert);
            this.quizTab.Controls.Add(this.btnReplace);
            this.quizTab.Controls.Add(this.btnShowGrade);
            this.quizTab.Controls.Add(this.labAllTypes);
            this.quizTab.Controls.Add(this.btnExit);
            this.quizTab.Controls.Add(this.lstMyAnswer);
            this.quizTab.Controls.Add(this.gpQuestion);
            this.quizTab.Controls.Add(this.labTime);
            this.quizTab.Controls.Add(this.btnSubmit);
            this.quizTab.Controls.Add(this.label1);
            this.quizTab.Controls.Add(this.btnDelete);
            this.quizTab.Controls.Add(this.btnDelAll);
            this.quizTab.Location = new System.Drawing.Point(4, 22);
            this.quizTab.Name = "quizTab";
            this.quizTab.Padding = new System.Windows.Forms.Padding(3);
            this.quizTab.Size = new System.Drawing.Size(568, 403);
            this.quizTab.TabIndex = 0;
            this.quizTab.Text = "Quiz";
            this.quizTab.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(149, 333);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 44);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(35, 333);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(100, 44);
            this.btnReplace.TabIndex = 20;
            this.btnReplace.Text = "Replace ";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnShowGrade
            // 
            this.btnShowGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGrade.Location = new System.Drawing.Point(260, 327);
            this.btnShowGrade.Name = "btnShowGrade";
            this.btnShowGrade.Size = new System.Drawing.Size(100, 57);
            this.btnShowGrade.TabIndex = 19;
            this.btnShowGrade.Text = "Show Grade";
            this.btnShowGrade.UseVisualStyleBackColor = true;
            this.btnShowGrade.Click += new System.EventHandler(this.btnShowGrade_Click);
            // 
            // labAllTypes
            // 
            this.labAllTypes.AutoSize = true;
            this.labAllTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAllTypes.Location = new System.Drawing.Point(31, 34);
            this.labAllTypes.Name = "labAllTypes";
            this.labAllTypes.Size = new System.Drawing.Size(75, 20);
            this.labAllTypes.TabIndex = 17;
            this.labAllTypes.Text = "Q Types: ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(448, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 44);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstMyAnswer
            // 
            this.lstMyAnswer.BackColor = System.Drawing.Color.Navy;
            this.lstMyAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMyAnswer.ForeColor = System.Drawing.Color.Aqua;
            this.lstMyAnswer.FormattingEnabled = true;
            this.lstMyAnswer.ItemHeight = 25;
            this.lstMyAnswer.Location = new System.Drawing.Point(385, 107);
            this.lstMyAnswer.Name = "lstMyAnswer";
            this.lstMyAnswer.Size = new System.Drawing.Size(163, 179);
            this.lstMyAnswer.TabIndex = 0;
            // 
            // gpQuestion
            // 
            this.gpQuestion.Controls.Add(this.chkC);
            this.gpQuestion.Controls.Add(this.chkB);
            this.gpQuestion.Controls.Add(this.label2);
            this.gpQuestion.Controls.Add(this.chkA);
            this.gpQuestion.Controls.Add(this.cboQtype);
            this.gpQuestion.Controls.Add(this.radA);
            this.gpQuestion.Controls.Add(this.radC);
            this.gpQuestion.Controls.Add(this.radB);
            this.gpQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gpQuestion.Location = new System.Drawing.Point(35, 83);
            this.gpQuestion.Name = "gpQuestion";
            this.gpQuestion.Size = new System.Drawing.Size(201, 228);
            this.gpQuestion.TabIndex = 8;
            this.gpQuestion.TabStop = false;
            this.gpQuestion.Text = "Question";
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkC.Location = new System.Drawing.Point(114, 179);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(48, 30);
            this.chkC.TabIndex = 10;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB.Location = new System.Drawing.Point(114, 144);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(47, 30);
            this.chkB.TabIndex = 9;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "This is a question of";
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkA.Location = new System.Drawing.Point(114, 107);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(47, 30);
            this.chkA.TabIndex = 8;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // cboQtype
            // 
            this.cboQtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboQtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQtype.ForeColor = System.Drawing.Color.White;
            this.cboQtype.FormattingEnabled = true;
            this.cboQtype.Items.AddRange(new object[] {
            "Multiple Choice",
            "Multiple Answers"});
            this.cboQtype.Location = new System.Drawing.Point(13, 61);
            this.cboQtype.Name = "cboQtype";
            this.cboQtype.Size = new System.Drawing.Size(175, 28);
            this.cboQtype.TabIndex = 13;
            this.cboQtype.SelectedIndexChanged += new System.EventHandler(this.cboQtype_SelectedIndexChanged);
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Enabled = false;
            this.radA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radA.Location = new System.Drawing.Point(38, 107);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(46, 30);
            this.radA.TabIndex = 4;
            this.radA.TabStop = true;
            this.radA.Text = "A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Enabled = false;
            this.radC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC.Location = new System.Drawing.Point(38, 179);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(47, 30);
            this.radC.TabIndex = 6;
            this.radC.TabStop = true;
            this.radC.Text = "C";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Enabled = false;
            this.radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radB.Location = new System.Drawing.Point(38, 143);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(46, 30);
            this.radB.TabIndex = 5;
            this.radB.TabStop = true;
            this.radB.Text = "B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.White;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.ForeColor = System.Drawing.Color.Blue;
            this.labTime.Location = new System.Drawing.Point(459, 24);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(89, 63);
            this.labTime.TabIndex = 16;
            this.labTime.Text = "15";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(260, 130);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 44);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Time left:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(260, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 44);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAll.Location = new System.Drawing.Point(260, 255);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(100, 44);
            this.btnDelAll.TabIndex = 12;
            this.btnDelAll.Text = "Delete All";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // gradeTab
            // 
            this.gradeTab.Controls.Add(this.label6);
            this.gradeTab.Controls.Add(this.totalGradeLabel);
            this.gradeTab.Controls.Add(this.label4);
            this.gradeTab.Controls.Add(this.correctAnswerLBox);
            this.gradeTab.Controls.Add(this.label3);
            this.gradeTab.Controls.Add(this.gradeTabMyAnswerLbox);
            this.gradeTab.Location = new System.Drawing.Point(4, 22);
            this.gradeTab.Name = "gradeTab";
            this.gradeTab.Padding = new System.Windows.Forms.Padding(3);
            this.gradeTab.Size = new System.Drawing.Size(568, 403);
            this.gradeTab.TabIndex = 1;
            this.gradeTab.Text = "Grade";
            this.gradeTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(113, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Grade:";
            // 
            // totalGradeLabel
            // 
            this.totalGradeLabel.AutoSize = true;
            this.totalGradeLabel.BackColor = System.Drawing.Color.White;
            this.totalGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGradeLabel.ForeColor = System.Drawing.Color.Crimson;
            this.totalGradeLabel.Location = new System.Drawing.Point(299, 17);
            this.totalGradeLabel.Name = "totalGradeLabel";
            this.totalGradeLabel.Size = new System.Drawing.Size(58, 63);
            this.totalGradeLabel.TabIndex = 17;
            this.totalGradeLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correct Answer:";
            // 
            // correctAnswerLBox
            // 
            this.correctAnswerLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswerLBox.FormattingEnabled = true;
            this.correctAnswerLBox.ItemHeight = 24;
            this.correctAnswerLBox.Location = new System.Drawing.Point(309, 137);
            this.correctAnswerLBox.Name = "correctAnswerLBox";
            this.correctAnswerLBox.Size = new System.Drawing.Size(192, 196);
            this.correctAnswerLBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "My Answer:";
            // 
            // gradeTabMyAnswerLbox
            // 
            this.gradeTabMyAnswerLbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTabMyAnswerLbox.FormattingEnabled = true;
            this.gradeTabMyAnswerLbox.ItemHeight = 24;
            this.gradeTabMyAnswerLbox.Location = new System.Drawing.Point(67, 137);
            this.gradeTabMyAnswerLbox.Name = "gradeTabMyAnswerLbox";
            this.gradeTabMyAnswerLbox.Size = new System.Drawing.Size(185, 196);
            this.gradeTabMyAnswerLbox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 424);
            this.Controls.Add(this.tabObject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabObject.ResumeLayout(false);
            this.quizTab.ResumeLayout(false);
            this.quizTab.PerformLayout();
            this.gpQuestion.ResumeLayout(false);
            this.gpQuestion.PerformLayout();
            this.gradeTab.ResumeLayout(false);
            this.gradeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerQuiz;
        private System.Windows.Forms.TabControl tabObject;
        private System.Windows.Forms.TabPage quizTab;
        private System.Windows.Forms.TabPage gradeTab;
        private System.Windows.Forms.Label labAllTypes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstMyAnswer;
        private System.Windows.Forms.GroupBox gpQuestion;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.ComboBox cboQtype;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnShowGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox correctAnswerLBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox gradeTabMyAnswerLbox;
        private System.Windows.Forms.Label totalGradeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReplace;
    }
}


// Austin Pickart
// Project_4 - Simple Quiz

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_4
{
    public partial class Form1 : Form
    {
        public int count = 15;
        // Class properties - default Qnum to 1 and QuestionTotal to 6
        private int Qnum { get; set; } = 1; 
        private int QuestionTotal { get; set; } = 6;
        private List<string> correctAns { get; set; }

        public Form1() // when the form is constructed, initialize these functions/settings
        {
            InitializeComponent();
            btnShowGrade.Enabled = false; // disabled until all 6 q's answered or time's up
            cboQtype.SelectedIndex = 0; // ensure the combobox is set to the 0th index, aka Radio buttons
            gpQuestion.Text = updateQuestionInfo();
            correctAns = new List<string>(); // this list will be populated with correct answers
            randNumGenerator(); // generate the correct answers and add them to the correct answer listbox
            timerQuiz.Enabled = true;
            tabObject.SelectedIndex = 0;
            foreach (string ans in correctAns)
            {
                correctAnswerLBox.Items.Add(ans);
            }
        }

        //------ START OF EVENT HANDLER FUNCTIONS ------//
        Random randNum = new Random(); // declare an instance here, because declaring it multiple times ends up resulting in the same result (mostly)

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            labTime.Text = count.ToString();
            // if the timer reaches 0, disable buttons and the timer
            if (count == 0)
            {
                endQuiz();
                MessageBox.Show("Time out. Check your grade", "Out of Time");
            }
        }

        // when clicked, open the 2nd tab (index of 1)
        private void btnShowGrade_Click(object sender, EventArgs e)
        {
            tabObject.SelectedIndex = 1;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (isRequiredActionConditions())
            {
                int selectedIndex = lstMyAnswer.SelectedIndex;
                lstMyAnswer.Items[selectedIndex] = WhichAnswerIsSelected();
                gradeTabMyAnswerLbox.Items[selectedIndex] = WhichAnswerIsSelected(); // need to replace in both boxes
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // check if a radio or checkbox is selected, the items in the listbox are greater than 0, and the selected item is greater than zero
            if (isRequiredActionConditions())
            {
                int selectedIndex = lstMyAnswer.SelectedIndex; // get index of selected element
                if (Qnum <= 6)
                {
                    if (WhichAnswerIsSelected() == "")
                    {
                        MessageBox.Show("You must select an answer to submit!", "CANNOT SUBMIT");
                    }
                    else
                    {
                        // INSERT instead of ADD
                        lstMyAnswer.Items.Insert(selectedIndex, WhichAnswerIsSelected());
                        gradeTabMyAnswerLbox.Items.Insert(selectedIndex, WhichAnswerIsSelected());
                        Qnum++;

                        if (Qnum <= 6)
                        {
                            gpQuestion.Text = updateQuestionInfo();
                        }

                        else // Quiz ends
                        {
                            endQuiz();
                            MessageBox.Show("You have answered and submitted all questions.", "Quiz Completed");
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes ALL forms
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Qnum <= 6)
            {
                if (WhichAnswerIsSelected() == "")
                {
                    MessageBox.Show("You must select an answer to submit!", "CANNOT SUBMIT");
                }

                else
                {
                    lstMyAnswer.Items.Add(WhichAnswerIsSelected());
                    gradeTabMyAnswerLbox.Items.Add(WhichAnswerIsSelected()); // add to the gradeTabMyAnswer listbox
                    Qnum++;
                    if (Qnum <= 6)
                        gpQuestion.Text = updateQuestionInfo();
                    else // Quiz ends
                    {
                        endQuiz();
                        MessageBox.Show("You have answered and submitted all questions.", "Quiz Completed");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstMyAnswer.SelectedIndex != -1) // check if a valid index is selected
            {
                lstMyAnswer.Items.Remove(lstMyAnswer.SelectedItem);
                lstMyAnswer.SelectedIndex = -1; // remove the blue highlight selector off of the listbox
                gpQuestion.Text = updateQuestionInfo(decrement: true); // optional parameter usage
                btnSubmit.Enabled = true;
                cboQtype.Enabled = true;
                timerQuiz.Enabled = true;

                if (Qnum == 6)
                {
                    if (cboQtype.SelectedIndex == 0)
                    {
                        SetMultipleChoice(true);
                        SetMultipleAnswer(false);
                    }
                    else
                    {
                        SetMultipleChoice(false);
                        SetMultipleAnswer(true);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select an answer to delete!", "CANNOT DELETE");
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lstMyAnswer.Items.Clear(); // clear everything from the listbox
            Qnum = 1; // reset Qnum to 1
            gpQuestion.Text = updateQuestionInfo();
            ResetAnswerSelection();
            btnSubmit.Enabled = true;
            cboQtype.Enabled = true;
            timerQuiz.Enabled = true;

            cboQtype.SelectedIndex = 0; // reset question type to Multiple Choice
            SetMultipleChoice(true);
            SetMultipleAnswer(false);
        }

        private void cboQtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeQuestionType();
            // Be sure to disable all radio buttons and enable all check boxes at design time,
            // and when the form is loaded, initialize the combo to "multiple choice".
            // Because this initialization changes the selected index, the above method will be
            // called for the very first time.
        }

        // disables clicking on the grade tab, until the quiz is done or time is up
        private void tabObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if the second tab is selected, the timer is 0, and the show grade button is enabled --> allow the tab to be opened
            if (tabObject.SelectedIndex == 1 && (count == 0 || btnShowGrade.Enabled == true))
            {
                tabObject.SelectedIndex = 1;
            }
            // else don't allow user to click on the tab, keep the 1st tab open only
            else
            {
                tabObject.SelectedIndex = 0;
            }

        }

        //------ END OF EVENT HANDLER FUNCTIONS ------//


        //------ START OF HELPER FUNCTIONS ------//

        // if optional parameter "decrement" is true decrement by 1, otherwise maintain regular functionality
        private string updateQuestionInfo(bool decrement = false)
        {
            return "Question " + (decrement ? (--Qnum).ToString() : Qnum.ToString()) + " of " + QuestionTotal.ToString();
        }

        // returns true if either a radio or checkbox is selected
        private bool isRadioOrCheckboxSelected() 
        {
            foreach (Control control in gpQuestion.Controls)
            {
                if (control is RadioButton) // if the control is a radiobutton, cast it to that type
                {
                    RadioButton r = control as RadioButton;
                    if (r.Checked)
                    {
                        return true;
                    }

                }

                if (control is CheckBox)
                {
                    CheckBox c = control as CheckBox;
                    if (c.Checked)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool isRequiredActionConditions()
        {
            return isRadioOrCheckboxSelected() && lstMyAnswer.Items.Count >= 1 && lstMyAnswer.SelectedItems.Count > 0;
        }

        // randomly generates the Question Type, and then concatenates the corresponding letter to the label
        private string randTypeGenerator()
        {
            int Qtype = randNum.Next(1,3); // will return 1 or 2

            if(Qtype == 1) // multiple choice
            {
                labAllTypes.Text += "A";
                return "A";
            }

            else // multiple answer
            {
                labAllTypes.Text += "C";
                return "C";
            }

        }

        private void randNumGenerator()
        {                   
            for(int i = 0; i < 6; i++)
            {
                int answer = randNum.Next(1, 4); // for single "A" type questions
                int num_of_answers = randNum.Next(2, 4); // whether the correct answer will have 2 answers or 3 answers

                string answerType = randTypeGenerator(); // get answer type from randTypeGenerator method (returns "A" or "C")
                if (answerType.Equals("A")) // multiple choice
                {
                    correctAns.Add(convertToGrade(answer));
                }

                else // multiple answer
                {
                    // use the answer to determine HOW MANY answers there will be (2 --> 2 answers B and C)
                    switch (num_of_answers)
                    {
                        case 2: // will have 2 answers
                            string twoAnswers = convertToGrade(randNum.Next(4, 7));
                            correctAns.Add(twoAnswers);
                            break;
                        case 3: // will have 3 answers
                            string threeAnswers = convertToGrade(7); // only 1 possible triple answer
                            correctAns.Add(threeAnswers);
                            break;
                        default: // in case the other 2 cases are ignored for some reason
                            string defaultAnswer = convertToGrade(randNum.Next(4, 7));
                            correctAns.Add(defaultAnswer);
                            break;
                    }
                }
            }           
        }

        private string convertToGrade(int i)
        {
            switch (i)
            {
                case 1: // single answers
                    return "A";

                case 2:
                    return "B";

                case 3:
                    return "C";

                case 4: // double answers
                    return "AB";

                case 5:
                    return "AC";

                case 6:
                    return "BC";

                case 7: // triple answer
                    return "ABC";

                default:
                    return "BC";
            }
        }

        private string gradeQuiz()
        {
            int grade = 0; // 10 pts for each question right
            for (int i = 0; i < gradeTabMyAnswerLbox.Items.Count; i++)
            {
                // if the answer in the listbox is equal to the corresponding answer in the correctAns list, add 10 points
                if (gradeTabMyAnswerLbox.Items[i].Equals(correctAns[i]))
                {
                    grade += 10;
                }
            }
            return grade.ToString();
        } 

        private string WhichAnswerIsSelected()
        {
            string myAns = "";

            if (radA.Checked)
                myAns = "A";
            else if (radB.Checked)
                myAns = "B";
            else if (radC.Checked)
                myAns = "C";

            if (chkA.Checked)
                myAns += "A";
            if (chkB.Checked)
                myAns += "B";
            if (chkC.Checked)
                myAns += "C";

            return myAns;
        }

        //------ END OF HELPER FUNCTIONS ------//

        //------ All functions below deal with setting/resetting controls and application state ------//

        private void endQuiz()
        {
            timerQuiz.Enabled = false; // disable the timer
            ResetAnswerSelection(); // reset all answers
            cboQtype.SelectedIndex = 0; // reset question type to Multiple Choice
            SetMultipleChoice(false); // disable multiple choice
            SetMultipleAnswer(false); // disable multiple answer 
            disableButtons();
            btnShowGrade.Enabled = true; // not enabled until all 6 q's answered or time's up
            totalGradeLabel.Text = gradeQuiz(); // grade the quiz
        }

        private void disableButtons()
        {
            btnSubmit.Enabled = false;
            btnDelete.Enabled = false;
            btnDelAll.Enabled = false;
            btnReplace.Enabled = false;
            btnInsert.Enabled = false;
            cboQtype.Enabled = false;
        }

        private void ChangeQuestionType()
        {
            chkA.Enabled = !chkA.Enabled;
            chkB.Enabled = !chkB.Enabled;
            chkC.Enabled = !chkC.Enabled;
            radA.Enabled = !radA.Enabled;
            radB.Enabled = !radB.Enabled;
            radC.Enabled = !radC.Enabled;
            // unchecks all applicable controls
            ResetAnswerSelection();
        }

        private void SetMultipleChoice(bool on_off)
        {
            radA.Enabled = on_off;
            radB.Enabled = on_off;
            radC.Enabled = on_off;
        }

        private void SetMultipleAnswer(bool on_off)
        {
            chkA.Enabled = on_off;
            chkB.Enabled = on_off;
            chkC.Enabled = on_off;
        }

        private void ResetAnswerSelection()
        {
            chkA.Checked = false;
            chkB.Checked = false;
            chkC.Checked = false;
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
        }

    }
}

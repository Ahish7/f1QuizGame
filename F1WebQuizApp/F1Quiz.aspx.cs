using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace F1WebQuizApp
{
    public partial class F1Quiz : System.Web.UI.Page
    {
        // variables for quiz game
        int totalQuestions = 8;
        string correctAnswer;
        int questionNumber;
        int score;
        int percentage;
        
        ArrayList quizQuestions;
        ArrayList usedQuestions;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["QuestionNumber"] == null)
                {
                    Session["QuestionNumber"] = 0;
                }

                // Check if the total questions are reached
                
                //Response.Write(">script>alert('Quiz ended, you scored: ' + " + score.ToString() + ")</script>");

                // check if the score exists
                if (Session["Score"] != null)
                {
                    score = (int)Session["Score"];
                    
                }
                else
                {
                    Session["Score"] = 0; 
                }

                //update the score
                lblScore.Text = "Score: " + score;

                QuizArray();
            }
            

            
        }

        protected void QuizArray()
        {
            quizQuestions = new ArrayList
            {
                "Who is the current world drivers champion?",
                "Which team is the current constructors champion?",
                "Who is Charels LeClerc's team mate?",
                "Name the track that is Charels LeClerc's home race?",
                "How many drivers championship did Lewis Hamilton win?",
                "What is Yuki Tusnoda's driver number?",
                "How many team are there on the grid?",
                "Valtteri Bottas and Zhou Guanyu are drivers for which F1 team?",

            };

            usedQuestions = new ArrayList();

            //create a session so it saves the quiz array every time the page reloads
            Session["QuizQuestions"] = quizQuestions;
            Session["UsedQuestions"] = usedQuestions;

            DisplayRandomQuestion();
            
        }

       
        protected void DisplayRandomQuestion()
        {
            if(quizQuestions.Count > 0)
            {
                Random rmd = new Random();
                //int randomIndex = rmd.Next(0, quizQuestions.Count);
                int randomIndex = GetRandomUnusedQuestionIndex(rmd);

                // get random string value
                string randomQuestion = quizQuestions[randomIndex].ToString();

                //save the current question and the answer
                Session["CurrentQuestion"] = randomQuestion;

                //sets the correctAnsewer before dispalying it
                correctAnswer = GetCorrectAnswer(randomQuestion);

                // Store correctAnswer in the session
                Session["CorrectAnswer"] = correctAnswer;

                // add the asked questions to the used questiosn array list
                usedQuestions.Add(randomQuestion);

                // remove the asked questions
                quizQuestions.RemoveAt(randomIndex);

                lblQuestion.Text = randomQuestion;

                //display answer options

                DisplayAnswerOptions();
            }
            else
            {
                lblQuestion.Text = "There was no questions in the array";
            }
        }

        private int GetRandomUnusedQuestionIndex(Random rmd)
        {
            int randomIndex;
            do
            {
                randomIndex = rmd.Next(0, quizQuestions.Count);
            }
            while (usedQuestions.Contains(quizQuestions[randomIndex]));

            return randomIndex;
        }

        protected void DisplayAnswerOptions()
        {
            rbtnOptions.Items.Clear();

            string currentQuestion = (string)Session["CurrentQuestion"];

            if (currentQuestion != null)
            {
                if (currentQuestion == "Who is the current world drivers champion?")
                {
                    rbtnOptions.Items.Add("Sergio Perez");
                    rbtnOptions.Items.Add("Max Verstappen");
                    rbtnOptions.Items.Add("Charles LeClerc");
                    rbtnOptions.Items.Add("Lewis Hamilton");

                    // Set correct answer for this question
                    correctAnswer = "Max Verstappen";
                }
                else if (currentQuestion == "Which team is the current constructors champion?")
                {
                    rbtnOptions.Items.Add("Ferrari");
                    rbtnOptions.Items.Add("Mercedes-Benz");
                    rbtnOptions.Items.Add("McLaren");
                    rbtnOptions.Items.Add("Oracle Red Bull Racing");

                    // Set correct answer for this question
                    correctAnswer = "Oracle Red Bull Racing";
                }
                else if (currentQuestion == "Who is Charels LeClerc's team mate?")
                {
                    rbtnOptions.Items.Add("Carlos Sainz");
                    rbtnOptions.Items.Add("Alexander Albone");
                    rbtnOptions.Items.Add("George Russell");
                    rbtnOptions.Items.Add("Sebastian Vettel");

                    // Set correct answer for this question
                    correctAnswer = "Carlos Sainz";
                }
                else if (currentQuestion == "Name the track that is Charels LeClerc's home race?")
                {
                    rbtnOptions.Items.Add("Monza");
                    rbtnOptions.Items.Add("Jeddah");
                    rbtnOptions.Items.Add("Interlagos");
                    rbtnOptions.Items.Add("Monaco");

                    // Set correct answer for this question
                    correctAnswer = "Monaco";
                }
                else if (currentQuestion == "How many drivers championship did Lewis Hamilton win?")
                {
                    rbtnOptions.Items.Add("8");
                    rbtnOptions.Items.Add("6");
                    rbtnOptions.Items.Add("7");
                    rbtnOptions.Items.Add("9");

                    // Set correct answer for this question
                    correctAnswer = "7";
                }
                else if (currentQuestion == "What is Yuki Tusnoda's driver number?")
                {
                    rbtnOptions.Items.Add("7");
                    rbtnOptions.Items.Add("10");
                    rbtnOptions.Items.Add("11");
                    rbtnOptions.Items.Add("22");

                    correctAnswer = "11";
                }
                else if (currentQuestion == "How many team are there on the grid?")
                {
                    rbtnOptions.Items.Add("7");
                    rbtnOptions.Items.Add("10");
                    rbtnOptions.Items.Add("20");
                    rbtnOptions.Items.Add("9");

                    correctAnswer = "10";
                }
                else if (currentQuestion == "Valtteri Bottas and Zhou Guanyu are drivers for which F1 team?")
                {
                    rbtnOptions.Items.Add("McLaren");
                    rbtnOptions.Items.Add("Alfa Romeo");
                    rbtnOptions.Items.Add("Alpine");
                    rbtnOptions.Items.Add("Williams");

                    correctAnswer = "Alfa Romeo";
                }
                

            }

        }


        protected string GetCorrectAnswer(string question)
        {
            if (question == "Who is the current world drivers champion?")
            {
                return "Max Verstappen";
            }
            else if (question == "Which team is the current constructors champion?")
            {
                return "Oracle Red Bull Racing";
            }
            else if (question == "Who is Charels LeClerc's team mate?")
            {
                return "Carlos Sainz";
            }
            else if (question == "Name the track that is Charels LeClerc's home race?")
            {
                return "Monaco";
            }
            else if(question == "How many drivers championship did Lewis Hamilton win?")
            {
                return "7";
            }
            else if(question == "What is Yuki Tusnoda's driver number?")
            {
                return "22";
            }
            else if(question == "How many team are there on the grid?")
            {
                return "10";
            }
            else if(question == "Valtteri Bottas and Zhou Guanyu are drivers for which F1 team?")
            {
                return "Alfa Romeo";
            }

            // Default case, you may want to handle this according to your application logic
            return "No Correct Answer Found";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //retrieve the current score in the seesion
            int score = (int)Session["Score"];
            int questionNumber = (int)Session["QuestionNumber"];

            // Retrieve correctAnswer from the session
            string correctAnswer = (string)Session["CorrectAnswer"];
            if (rbtnOptions.SelectedValue == correctAnswer)
            {
                Session["Score"] = (int)Session["Score"] + 1;
                Session["QuestionNumber"] = (int)Session["QuestionNumber"] + 1;
               
            }
            else
            {
                Session["Score"] = Math.Max((int)Session["Score"] - 1, 0);
                Session["QuestionNumber"] = (int)Session["QuestionNumber"] + 1;
            }

            //// Store the updated score in the session
            //Session["Score"] = score;

            //// Display the updated score on the page
            //lblScore.Text = "Score: " + score.ToString();

            if ((int)Session["QuestionNumber"] == totalQuestions)
            {
                // Display final score and end the quiz
                Response.Write("<script>alert('Quiz endede!, you scored: ' + " + (score + 1).ToString() + " + ' out of ' + " + totalQuestions.ToString() + ")</script>");
                rbtnOptions.ClearSelection();
                score = 0;
            }
            else
            {
                // Redirect to refresh the page and show the next question
                Response.Redirect("~/F1Quiz.aspx");
            }
        }
    }
}



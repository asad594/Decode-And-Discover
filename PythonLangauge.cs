using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDiscovers
{
    internal class PythonLangauge : Languages
    {
        private readonly Form1 _form;
        public PythonLangauge(Form1 form) : base(form) => _form = form;




        //chapter 1 questions
        public override void Chap1CodeQuestions1()
        {
            _form.CodeQuestion1.Visible = true;
            _form.Q1opt1.Visible = true;
            _form.Q1opt2.Visible = true;
            _form.Q1opt3.Visible = true;
            _form.Q1opt4.Visible = true;

            //correct indez 2
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "What is the full form of Python?",
                    new[] { "Programming Hyper Terminal Online", "Programmed Text Handler Output Network", "Python is not an acronym", "Powerful Typing Hybrid Online Network" }
                ),
                (
                    "Why was Python developed?",
                    new[] { "To replace C", "To write operating systems", "To make programming easier and more readable", "To only build web servers" }
                ),
                (
                    "What is a key design goal of Python?",
                    new[] { "To make it complex and fast", "To support only system-level programming", "To emphasize code readability and simplicity", "To be used only for games" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter11;
                _form.Q1opt1.Parent = _form.HorrorChapter11;
                _form.Q1opt2.Parent = _form.HorrorChapter11;
                _form.Q1opt3.Parent = _form.HorrorChapter11;
                _form.Q1opt4.Parent = _form.HorrorChapter11;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter11;
                _form.Q1opt1.Parent = _form.CrimeChapter11;
                _form.Q1opt2.Parent = _form.CrimeChapter11;
                _form.Q1opt3.Parent = _form.CrimeChapter11;
                _form.Q1opt4.Parent = _form.CrimeChapter11;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter11;
                _form.Q1opt1.Parent = _form.FunnyChapter11;
                _form.Q1opt2.Parent = _form.FunnyChapter11;
                _form.Q1opt3.Parent = _form.FunnyChapter11;
                _form.Q1opt4.Parent = _form.FunnyChapter11;
            }

            _form.CodeQuestion1.Text = selected.Question;
            _form.Q1opt1.Text = selected.Options[0];
            _form.Q1opt2.Text = selected.Options[1];
            _form.Q1opt3.Text = selected.Options[2];
            _form.Q1opt4.Text = selected.Options[3];
        }

        public override void Chap1CodeQuestions2()
        {
            _form.Q1opt1.Visible = false;
            _form.Q1opt2.Visible = false;
            _form.Q1opt3.Visible = false;
            _form.Q1opt4.Visible = false;
            _form.Q2opt1.Visible = true;
            _form.Q2opt2.Visible = true;
            _form.Q2opt3.Visible = true;
            _form.Q2opt4.Visible = true;

            //correct index 0
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "What does the input() function do in Python?",
                    new[] { "Takes input from the user", "Prints text to the screen", "Declares a variable", "Defines a function" }
                ),
                (
                    "Why is print() used in Python?",
                    new[] { "To display output to the console", "To read data from a file", "To accept user input", "To send email" }
                ),
                (
                    "What is the purpose of len()?",
                    new[] { "To find the length of an object", "To count variables", "To clear memory", "To reverse a string" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter11;
                _form.Q2opt1.Parent = _form.HorrorChapter11;
                _form.Q2opt2.Parent = _form.HorrorChapter11;
                _form.Q2opt3.Parent = _form.HorrorChapter11;
                _form.Q2opt4.Parent = _form.HorrorChapter11;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter11;
                _form.Q2opt1.Parent = _form.CrimeChapter11;
                _form.Q2opt2.Parent = _form.CrimeChapter11;
                _form.Q2opt3.Parent = _form.CrimeChapter11;
                _form.Q2opt4.Parent = _form.CrimeChapter11;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter11;
                _form.Q2opt1.Parent = _form.FunnyChapter11;
                _form.Q2opt2.Parent = _form.FunnyChapter11;
                _form.Q2opt3.Parent = _form.FunnyChapter11;
                _form.Q2opt4.Parent = _form.FunnyChapter11;
            }

            _form.CodeQuestion1.Text = selected.Question;
            _form.Q2opt1.Text = selected.Options[0];
            _form.Q2opt2.Text = selected.Options[1];
            _form.Q2opt3.Text = selected.Options[2];
            _form.Q2opt4.Text = selected.Options[3];
        }

        public override void Chap1CodeQuestions3()
        {
            _form.Q2opt1.Visible = false;
            _form.Q2opt2.Visible = false;
            _form.Q2opt3.Visible = false;
            _form.Q2opt4.Visible = false;
            _form.Q3opt1.Visible = true;
            _form.Q3opt2.Visible = true;
            _form.Q3opt3.Visible = true;
            _form.Q3opt4.Visible = true;

            //correct index 1
            var questions = new List<(string Question, string[] Options)>
            {
                 (
                    "Which is the correct syntax to print 'Hello' in Python?",
                    new[] { "print('Hello'):", "print('Hello')", "echo 'Hello'", "System.out.println('Hello');" }
                ),
                (
                    "How do you start a function in Python?",
                    new[] { "function myFunc():", "def myFunc():", "func myFunc()", "void myFunc()" }
                ),
                (
                    "Which is the correct way to take user input?",
                    new[] { "input =()", "input()", "scanf()", "read()" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter12;
                _form.Q3opt1.Parent = _form.HorrorChapter12;
                _form.Q3opt2.Parent = _form.HorrorChapter12;
                _form.Q3opt3.Parent = _form.HorrorChapter12;
                _form.Q3opt4.Parent = _form.HorrorChapter12;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter12;
                _form.Q3opt1.Parent = _form.CrimeChapter12;
                _form.Q3opt2.Parent = _form.CrimeChapter12;
                _form.Q3opt3.Parent = _form.CrimeChapter12;
                _form.Q3opt4.Parent = _form.CrimeChapter12;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter11;
                _form.Q3opt1.Parent = _form.FunnyChapter11;
                _form.Q3opt2.Parent = _form.FunnyChapter11;
                _form.Q3opt3.Parent = _form.FunnyChapter11;
                _form.Q3opt4.Parent = _form.FunnyChapter11;
            }


            _form.CodeQuestion1.Text = selected.Question;
            _form.Q3opt1.Text = selected.Options[0];
            _form.Q3opt2.Text = selected.Options[1];
            _form.Q3opt3.Text = selected.Options[2];
            _form.Q3opt4.Text = selected.Options[3];
        }

        public override void Chap1CodeQuestions4()
        {
            _form.Q3opt1.Visible = false;
            _form.Q3opt2.Visible = false;
            _form.Q3opt3.Visible = false;
            _form.Q3opt4.Visible = false;
            _form.Q4opt1.Visible = true;
            _form.Q4opt2.Visible = true;
            _form.Q4opt3.Visible = true;
            _form.Q4opt4.Visible = true;

            //correct index 2
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "What is the output of: print(3 + 4 * 2)?",
                    new[] { "14", "11", "11", "7" }
                ),
                (
                    "What does this print: print(\"Python\" + str(3))?",
                    new[] { "Python3.0", "Python+3", "Python3", "3Python" }
                ),
                (
                    "Output of: print(type(5.0))?",
                    new[] { "<class 'int'>", "<class 'str'>", "<class 'float'>", "<float>" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter12;
                _form.Q4opt1.Parent = _form.HorrorChapter12;
                _form.Q4opt2.Parent = _form.HorrorChapter12;
                _form.Q4opt3.Parent = _form.HorrorChapter12;
                _form.Q4opt4.Parent = _form.HorrorChapter12;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter12;
                _form.Q4opt1.Parent = _form.CrimeChapter12;
                _form.Q4opt2.Parent = _form.CrimeChapter12;
                _form.Q4opt3.Parent = _form.CrimeChapter12;
                _form.Q4opt4.Parent = _form.CrimeChapter12;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter12;
                _form.Q4opt1.Parent = _form.FunnyChapter12;
                _form.Q4opt2.Parent = _form.FunnyChapter12;
                _form.Q4opt3.Parent = _form.FunnyChapter12;
                _form.Q4opt4.Parent = _form.FunnyChapter12;
            }


            _form.CodeQuestion1.Text = selected.Question;
            _form.Q4opt1.Text = selected.Options[0];
            _form.Q4opt2.Text = selected.Options[1];
            _form.Q4opt3.Text = selected.Options[2];
            _form.Q4opt4.Text = selected.Options[3];
        }

        public override void Chap1CodeQuestions5()
        {
            _form.Q4opt1.Visible = false;
            _form.Q4opt2.Visible = false;
            _form.Q4opt3.Visible = false;
            _form.Q4opt4.Visible = false;
            _form.Q5opt1.Visible = true;
            _form.Q5opt2.Visible = true;
            _form.Q5opt3.Visible = true;
            _form.Q5opt4.Visible = true;

            //correct index 3
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "How to get the output: Hello World?",
                    new[] { "echo Hello World", "System.out.println(\"Hello World\")", "print Hello World", "print(\"Hello World\")" }
                ),
                (
                    "Which code gives: Total = 15?",
                    new[] { "print(\"15 = Total\")", "print(\"Total: \" + 15)", "print('Total = ' 15)", "print(\"Total = \" + str(10 + 5))" }
                ),
                (
                    "How to get the output: Python123?",
                    new[] { "print(123 + 'Python')", "print('123' + 'Python')", "print('Python' + 1 + 2 + 3)", "print('Python' + str(1) + str(2) + str(3))" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter13;
                _form.Q5opt1.Parent = _form.HorrorChapter13;
                _form.Q5opt2.Parent = _form.HorrorChapter13;
                _form.Q5opt3.Parent = _form.HorrorChapter13;
                _form.Q5opt4.Parent = _form.HorrorChapter13;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter13;
                _form.Q5opt1.Parent = _form.CrimeChapter13;
                _form.Q5opt2.Parent = _form.CrimeChapter13;
                _form.Q5opt3.Parent = _form.CrimeChapter13;
                _form.Q5opt4.Parent = _form.CrimeChapter13;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter12;
                _form.Q5opt1.Parent = _form.FunnyChapter12;
                _form.Q5opt2.Parent = _form.FunnyChapter12;
                _form.Q5opt3.Parent = _form.FunnyChapter12;
                _form.Q5opt4.Parent = _form.FunnyChapter12;
            }

           

            _form.CodeQuestion1.Text = selected.Question;
            _form.Q5opt1.Text = selected.Options[0];
            _form.Q5opt2.Text = selected.Options[1];
            _form.Q5opt3.Text = selected.Options[2];
            _form.Q5opt4.Text = selected.Options[3];
        }
















        //Chapter 2 questions
        public override void Chap2CodeQuestions1()
        {
            _form.CodeQuestion1.Visible = true;
            _form.Q6opt1.Visible = true;
            _form.Q6opt2.Visible = true;
            _form.Q6opt3.Visible = true;
            _form.Q6opt4.Visible = true;

            //correct index 1
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "Which is the correct syntax for a for loop in Python?",
                    new[] { "for i to 5:", "for i in range(5):", "for (i=0; i<5; i++):", "foreach i in 5:" }
                ),
                (
                    "How do you write a while loop in Python?",
                    new[] { "while (i < 10)", "while i < 10:", "while i < 10 then", "loop while i < 10" }
                ),
                (
                    "Which of these is a valid for loop?",
                    new[] { "for i = 0 to 5:", "for i in range(0, 5):", "for i < 5:", "repeat i from 0 to 5:" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter21;
                _form.Q6opt1.Parent = _form.HorrorChapter21;
                _form.Q6opt2.Parent = _form.HorrorChapter21;
                _form.Q6opt3.Parent = _form.HorrorChapter21;
                _form.Q6opt4.Parent = _form.HorrorChapter21;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter21;
                _form.Q6opt1.Parent = _form.CrimeChapter21;
                _form.Q6opt2.Parent = _form.CrimeChapter21;
                _form.Q6opt3.Parent = _form.CrimeChapter21;
                _form.Q6opt4.Parent = _form.CrimeChapter21;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter21;
                _form.Q6opt1.Parent = _form.FunnyChapter21;
                _form.Q6opt2.Parent = _form.FunnyChapter21;
                _form.Q6opt3.Parent = _form.FunnyChapter21;
                _form.Q6opt4.Parent = _form.FunnyChapter21;
            }

            

            _form.CodeQuestion1.Text = selected.Question;
            _form.Q6opt1.Text = selected.Options[0];
            _form.Q6opt2.Text = selected.Options[1];
            _form.Q6opt3.Text = selected.Options[2];
            _form.Q6opt4.Text = selected.Options[3];
        }

        public override void Chap2CodeQuestions2()
        {
            _form.Q6opt1.Visible = false;
            _form.Q6opt2.Visible = false;
            _form.Q6opt3.Visible = false;
            _form.Q6opt4.Visible = false;
            _form.Q7opt1.Visible = true;
            _form.Q7opt2.Visible = true;
            _form.Q7opt3.Visible = true;
            _form.Q7opt4.Visible = true;

            //correct index 3
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "Which is the correct if statement syntax in Python?",
                    new[] { "if (x > 5) then", "if x > 5 then", "if x > 5 {", "if x > 5:" }
                ),
                (
                    "How do you write an if-else block?",
                    new[] { "if x: else x:", "if (x) else (y)", "if x then y", "if x == 10:\n    print('Yes')\nelse:\n    print('No')" }
                ),
                (
                    "Correct syntax for checking equality?",
                    new[] { "if x = 10:", "if (x = 10)", "if x is 10:", "if x == 10:" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter21;
                _form.Q7opt1.Parent = _form.HorrorChapter21;
                _form.Q7opt2.Parent = _form.HorrorChapter21;
                _form.Q7opt3.Parent = _form.HorrorChapter21;
                _form.Q7opt4.Parent = _form.HorrorChapter21;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter21;
                _form.Q7opt1.Parent = _form.CrimeChapter21;
                _form.Q7opt2.Parent = _form.CrimeChapter21;
                _form.Q7opt3.Parent = _form.CrimeChapter21;
                _form.Q7opt4.Parent = _form.CrimeChapter21;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter21;
                _form.Q7opt1.Parent = _form.FunnyChapter21;
                _form.Q7opt2.Parent = _form.FunnyChapter21;
                _form.Q7opt3.Parent = _form.FunnyChapter21;
                _form.Q7opt4.Parent = _form.FunnyChapter21;
            }

            

            _form.CodeQuestion1.Text = selected.Question;
            _form.Q7opt1.Text = selected.Options[0];
            _form.Q7opt2.Text = selected.Options[1];
            _form.Q7opt3.Text = selected.Options[2];
            _form.Q7opt4.Text = selected.Options[3];
        }

        public override void Chap2CodeQuestions3()
        {
            _form.Q7opt1.Visible = false;
            _form.Q7opt2.Visible = false;
            _form.Q7opt3.Visible = false;
            _form.Q7opt4.Visible = false;
            _form.Q8opt1.Visible = true;
            _form.Q8opt2.Visible = true;
            _form.Q8opt3.Visible = true;
            _form.Q8opt4.Visible = true;

            //correct index 0
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "What does a condition do in Python?",
                    new[] { "It decides whether to run a block of code", "It loops a code forever", "It ends the program", "It defines a function" }
                ),
                (
                    "Why are conditions used in code?",
                    new[] { "To make decisions", "To repeat code", "To store data", "To format strings" }
                ),
                (
                    "What is the role of 'if' in Python?",
                    new[] { "To check if a condition is true", "To stop a loop", "To run a function", "To write output" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter22;
                _form.Q8opt1.Parent = _form.HorrorChapter22;
                _form.Q8opt2.Parent = _form.HorrorChapter22;
                _form.Q8opt3.Parent = _form.HorrorChapter22;
                _form.Q8opt4.Parent = _form.HorrorChapter22;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter21;
                _form.Q8opt1.Parent = _form.CrimeChapter21;
                _form.Q8opt2.Parent = _form.CrimeChapter21;
                _form.Q8opt3.Parent = _form.CrimeChapter21;
                _form.Q8opt4.Parent = _form.CrimeChapter21;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter21;
                _form.Q8opt1.Parent = _form.FunnyChapter21;
                _form.Q8opt2.Parent = _form.FunnyChapter21;
                _form.Q8opt3.Parent = _form.FunnyChapter21;
                _form.Q8opt4.Parent = _form.FunnyChapter21;
            }

            

            _form.CodeQuestion1.Text = selected.Question;
            _form.Q8opt1.Text = selected.Options[0];
            _form.Q8opt2.Text = selected.Options[1];
            _form.Q8opt3.Text = selected.Options[2];
            _form.Q8opt4.Text = selected.Options[3];
        }

        public override void Chap2CodeQuestions4()
        {
            _form.Q8opt1.Visible = false;
            _form.Q8opt2.Visible = false;
            _form.Q8opt3.Visible = false;
            _form.Q8opt4.Visible = false;
            _form.Q9opt1.Visible = true;
            _form.Q9opt2.Visible = true;
            _form.Q9opt3.Visible = true;
            _form.Q9opt4.Visible = true;

            //correct index 2
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "How many times will this run: for i in range(3)?",
                    new[] { "4 times", "0 times", "3 times", "5 times" }
                ),
                (
                    "What is the correct condition to run a loop 5 times?",
                    new[] { "i <= 5", "i == 5", "i in range(5)", "i != 5" }
                ),
                (
                    "When will this while loop stop? while x < 3:",
                    new[] { "Never", "After x becomes 0", "When x reaches 3", "When x is negative" }
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter22;
                _form.Q9opt1.Parent = _form.HorrorChapter22;
                _form.Q9opt2.Parent = _form.HorrorChapter22;
                _form.Q9opt3.Parent = _form.HorrorChapter22;
                _form.Q9opt4.Parent = _form.HorrorChapter22;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter31;
                _form.Q9opt1.Parent = _form.CrimeChapter31;
                _form.Q9opt2.Parent = _form.CrimeChapter31;
                _form.Q9opt3.Parent = _form.CrimeChapter31;
                _form.Q9opt4.Parent = _form.CrimeChapter31;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter12;
                _form.Q9opt1.Parent = _form.FunnyChapter12;
                _form.Q9opt2.Parent = _form.FunnyChapter12;
                _form.Q9opt3.Parent = _form.FunnyChapter12;
                _form.Q9opt4.Parent = _form.FunnyChapter12;
            }

            

            _form.CodeQuestion1.Text = selected.Question;
            _form.Q9opt1.Text = selected.Options[0];
            _form.Q9opt2.Text = selected.Options[1];
            _form.Q9opt3.Text = selected.Options[2];
            _form.Q9opt4.Text = selected.Options[3];
        }

        public override void Chap2CodeQuestions5()
        {
            _form.Q9opt1.Visible = false;
            _form.Q9opt2.Visible = false;
            _form.Q9opt3.Visible = false;
            _form.Q9opt4.Visible = false;
            _form.Q10opt1.Visible = true;
            _form.Q10opt2.Visible = true;
            _form.Q10opt3.Visible = true;
            _form.Q10opt4.Visible = true;

            //correct  index 3
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "What is the output of: for i in range(2): print(i)?",
                    new[] { "2 1", "1 2", "1 2 3", "0\n1" }
                ),
                (
                    "What does this print?\nfor i in range(1, 4): print(i * 2)",
                    new[] { "1 2 3", "4 6 8", "2 4 6 8", "2\n4\n6" }
                ),
                (
                     "What is the output of: i=1; while i<=3: print(i); i+=1",
                     new[] { "0 1 2", "1 1 1", "2 3 4", "1\n2\n3" } 
                )
            };

            Random rnd = new Random();
            int index = rnd.Next(questions.Count);
            var selected = questions[index];

            if (_form.Story == "Horror")
            {
                _form.CodeQuestion1.Parent = _form.HorrorChapter23;
                _form.Q10opt1.Parent = _form.HorrorChapter23;
                _form.Q10opt2.Parent = _form.HorrorChapter23;
                _form.Q10opt3.Parent = _form.HorrorChapter23;
                _form.Q10opt4.Parent = _form.HorrorChapter23;
            }
            else if (_form.Story == "Crime")
            {
                _form.CodeQuestion1.Parent = _form.CrimeChapter31;
                _form.Q10opt1.Parent = _form.CrimeChapter31;
                _form.Q10opt2.Parent = _form.CrimeChapter31;
                _form.Q10opt3.Parent = _form.CrimeChapter31;
                _form.Q10opt4.Parent = _form.CrimeChapter31;
            }
            else if (_form.Story == "Funny")
            {
                _form.CodeQuestion1.Parent = _form.FunnyChapter12;
                _form.Q10opt1.Parent = _form.FunnyChapter12;
                _form.Q10opt2.Parent = _form.FunnyChapter12;
                _form.Q10opt3.Parent = _form.FunnyChapter12;
                _form.Q10opt4.Parent = _form.FunnyChapter12;
            }

            

            _form.CodeQuestion1.Text = selected.Question;
            _form.Q10opt1.Text = selected.Options[0];
            _form.Q10opt2.Text = selected.Options[1];
            _form.Q10opt3.Text = selected.Options[2];
            _form.Q10opt4.Text = selected.Options[3];
        }



    }
}



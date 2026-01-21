using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDiscovers
{
    internal class CsharpLanguage : Languages
    {
        private readonly Form1 _form;
        public CsharpLanguage(Form1 form) : base(form) => _form = form;



        //chapter 1 questions
        public override void Chap1CodeQuestions1()
        {
            _form.CodeQuestion1.Visible = true;
            _form.Q1opt1.Visible = true;
            _form.Q1opt2.Visible = true;
            _form.Q1opt3.Visible = true;
            _form.Q1opt4.Visible = true;

            //correct indez 2 / option c 
            var questions = new List<(string Question, string[] Options)>
            {
                ("What is the full form of C#?",new[] { "Compiled Sharp", "Code-Sharp", "C# is not an acronym", "Control Sharp" }),
                ("Why was C# developed?",new[] { "To replace Java", "To run on Linux systems only", "To develop secure and scalable applications on the .NET framework", "To work only on embedded devices" }),
                ("Which of the following is a goal of C#?",new[] { "To work only with gaming engines", "To serve as a markup language", "To provide modern, simple, and object-oriented programming on .NET", "To be used only for scripting in browsers" })
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

            //correct index 0 / option a
            var questions = new List<(string Question, string[] Options)>
            {
                ("What is the purpose of Console.WriteLine() in C#?",new[] { "To display output on the screen", "To read input from the user", "To clear the console", "To write text to a file" }),
                ("Why is Console.ReadLine() used?",new[] { "To take input from the user", "To print user data", "To pause execution", "To delete previous output" }),
                ("What does Console.Write() do?",new[] { "It displays text without a new line", "It adds a new line after the text", "It clears the screen", "It opens a file for writing" })
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

            //correct index 1 / option b
            var questions = new List<(string Question, string[] Options)>
            {
                ("Which is the correct syntax to display 'Hello' in C#?",new[] { "Console.WriteLine('Hello')", "Console.WriteLine(\"Hello\");", "print('Hello')", "WriteLine('Hello')" }),
                ("Which syntax correctly declares a variable of type int?",new[] { "int = number 5;", "int number = 5;", "integer number = 5", "number int = 5;" }),
                ("How do you create a comment in C#?",new[] { "# This is a comment", "// This is a comment;", "/* This is a comment */;", "<!-- This is a comment -->" })
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

            //correct index 2 / option c
            var questions = new List<(string Question, string[] Options)>
            {
                ("What will be the output?\nConsole.WriteLine(2 + 3 + \"C#\");",new[] { "C#5", "23C#", "5C#", "C#23" }),
                ("What will be printed?\nConsole.WriteLine(\"C#\" + 4 + 1);",new[] { "5C#", "C#5", "C#41", "C#14" }),
                ("What is the output of this?\nConsole.WriteLine(\"Result: \" + true);",new[] { "trueResult", "Result=true", "Result: True", "True: Result" })
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

            //correct index 3 / option d
            var questions = new List<(string Question, string[] Options)>
            {
                ("How can you print: Programming is fun?",new[] { "Console.print(\"Programming is fun\")", "print(\"Programming is fun\")", "Console.Write(\"Programming is fun\")", "Console.WriteLine(\"Programming is fun\");" }),
                ("Which code gives output: Total = 30?",new[] { "Console.WriteLine(\"30 = Total\");", "Console.WriteLine(30 + \" = Total\");", "Console.WriteLine(Total + 30);", "Console.WriteLine(\"Total = \" + (10 + 20));" }),
                ("How to display: Hello123?",new[] { "Console.WriteLine(\"Hello\" + (1 * 2 * 3));", "Console.WriteLine(123 + \"Hello\");", "Console.WriteLine(\"123Hello\");", "Console.WriteLine(\"Hello\" + 1 + 2 + 3);" })
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

            //correct index 1 / option b
            var questions = new List<(string Question, string[] Options)>
            {
                 (
                    "Which is the correct syntax for a for loop in C#?",
                    new[] { "for (int i = 0; i < 5)", "for (int i = 0; i < 5; i++)", "for i in 0..5", "for (i = 0; i < 5)" }
                ),
                (
                    "Which is the correct while loop syntax in C#?",
                    new[] { "while i < 5:", "while (i < 5)", "while i < 5", "loop while (i < 5)" }
                ),
                (
                    "How do you write a foreach loop in C#?",
                    new[] { "foreach i in items:", "foreach (items as i)", "foreach (var i in items)", "foreach i : items" }
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

            //correct index 3 / option d
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "What is the correct way to write an if statement in C#?",
                    new[] { "if x > 5 then", "if (x > 5):", "if x > 5", "if (x > 5) { }" }
                ),
                (
                    "How do you write an if-else condition in C#?",
                    new[] { "if x > 5:\n print(x)", "if (x > 5) then", "if x > 5 { print(x) }", "if (x > 5) { Console.WriteLine(x); } else { Console.WriteLine(0); }" }
                ),
                (
                    "Which syntax is valid for checking equality in C#?",
                    new[] { "if (x = 10)", "if x == 10 then", "if x is 10", "if (x == 10)" }
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

            //correct index 0 / option a
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "What is the purpose of a condition in C#?",
                    new[] { "To check if a statement is true or false", "To repeat code", "To store values", "To handle errors" }
                ),
                (
                    "Why do we use conditions in programming?",
                    new[] { "To control decision-making", "To loop through data", "To return values", "To define classes" }
                ),
                (
                    "What happens when an if condition is true?",
                    new[] { "The code inside the if block runs", "The program ends", "An error is thrown", "It starts a loop" }
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

            //correct index 2 / option c
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "How many times does this run: for(int i = 0; i < 3; i++)",
                    new[] { "4", "2", "3", "5" }
                ),
                (
                    "Which condition keeps the loop running until i reaches 5?",
                    new[] { "i = 5", "i > 5", "i < 5", "i == 5" }
                ),
                (
                    "How many times will the loop run? for (int i = 1; i <= 4; i++)",
                    new[] { "2", "0", "4", "5" }
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

            //correct  index 3 / option d
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "Output of: for(int i=1; i<=3; i++) Console.Write(i);",
                    new[] { "1234", "012", "111", "123" }
                ),
                (
                    "What does this print: int i=0; while(i<2) { Console.Write(i); i++; }",
                    new[] { "00", "12", "11", "01" }
                ),
                (
                    "What is the output: for(int i=1; i<=3; i++) Console.WriteLine(i);",
                    new[] { "1 2 3", "1-2-3", "123", "1\n2\n3" }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDiscovers
{
    internal class JavaLanguage : Languages
    {
        private readonly Form1 _form;
        public JavaLanguage(Form1 form) : base(form) => _form = form;


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
                ("What is the full form of JAVA?", new[] { "Just Another Virtual Application", "Java Automatic Virtual Application","Java is not an acronym", "Java Application Virtual Architecture"}),
                ("Why was Java developed?", new[] {"For gaming only", "For system-level programming only", " To create platform-independent, secure applications", "For mobile devices only"}),
                ("What type of programming language is Java?", new[] { "Low-level and compiled", "Assembly-level and scripted", "High-level, object-oriented, and platform-independent", "Database query language"})
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
                ("Which method is used in Java to print output on the screen?", new[] { "System.out.println()", "print.output()", "output()", "echo()"}),
                ("Which class is commonly used to take input from the user in Java?", new[] {"Scanner", "InputReader", "SystemInput", "Keyboard"}),
                ("Which package must be imported to use the Scanner class?", new[] { "java.util.*", "java.util.input.*", "java.io.*", "java.scan.*]"})
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
                ("What does System.in represent in Java?", new[] { "Keyboard output", "Standard input stream", "Screen output", "Error message"}),
                ("What is the difference between System.out.print() and System.out.println()?", new[] { "No difference", "println() adds a new line at the en", "print() adds a new line automatically", "println() prints in bold"}),
                ("What is the main purpose of using .next methods in Java (e.g., next(), nextInt(),\n nextLine()) when working with the Scanner class?", new[] { "To display output on the screen", "To take input from the user", "To import Java packages", "To declare new variables"})
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
                ("What is the output of the following code?\nSystem.out.println(3 + 4 + \"Java\");", new[] { "Java34", "Java7", "7Java", "34Java" }),
                ("What will be printed?\nSystem.out.println(\"Java\" + 1 + 2);",new[] { "3Java", "Java3", "Java12", "12Java" }),
                ("What does this print?\nSystem.out.println(\"Hello\" + ' ' + \"World\");",new[] { "HelloWorld", "Hello+World", "Hello World", "Hello' 'World" })
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
                ("How can you get this output: Java is fun?",new[] { "System.out.println('Java is fun');", "print(\"Java is fun\")", "System.out.println(Java is fun);", "System.out.println(\"Java is fun\");" }),
                ("Which line gives the output: Sum = 15?",new[] { "System.out.println(\"Sum = \" + 5 + 10);", "System.out.println(\"Sum = \" + (5 * 3));", "System.out.println(\"Sum = 5 + 10\");", "System.out.println(\"Sum = \" + (5 + 10));" }),
                ("How can you print: Result: true?",new[] { "System.out.println(Result: true);", "System.out.print(\"true: Result\");", "System.out.println(\"true = Result\");", "System.out.println(\"Result: \" + true);" })
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
                    "Which is the correct syntax for a for loop in Java?",
                    new[] { "for i in 0..5", "for(int i = 0; i < 5; i++)", "for (i = 0; i < 5)", "foreach (int i : arr)" }
                ),
                (
                    "Which is the correct while loop syntax in Java?",
                    new[] { "while i < 5:", "while(i < 5)", "while i < 5", "loop while(i < 5)" }
                ),
                (
                    "How do you write a for-each loop in Java?",
                    new[] { "for each (i in arr)", "for(String s : arr)", "foreach (arr as i)", "for item in arr" }
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
                    "What is the correct way to write an if statement in Java?",
                    new[] { "if x > 5 then", "if (x > 5):", "if x > 5", "if (x > 5) { }" }
                ),
                (
                    "How do you write an if-else condition in Java?",
                    new[] { "if x > 5:\n print(x)", "if (x > 5) then", "if x > 5 { print(x); }", "if (x > 5) { System.out.println(x); } else { System.out.println(0); }" }
                ),
                (
                    "Which syntax is valid for checking equality in Java?",
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

            //correct index 0
            var questions = new List<(string Question, string[] Options)>
            {
                (
                    "What is the purpose of a condition in Java?",
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

            //correct index 2
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

            //correct  index 3
            var questions = new List<(string Question, string[] Options)>
            {
                 (
                    "Output of: for(int i=1; i<=3; i++) System.out.print(i);",
                    new[] { "1234", "012", "111", "123" }
                ),
                (
                    "What does this print: int i=0; while(i<2) { System.out.print(i); i++; }",
                    new[] { "00", "12", "11", "01" }
                ),
                (
                    "What is the output: for(int i=1; i<=3; i++) System.out.println(i);",
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

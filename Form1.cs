using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecodeAndDiscovers
{
    public partial class Form1 : Form
    {
        public string Story, Lang;
        public int Chapter;
        public string StoredPlayerName;

        //Game Setups
        public Form1()
        {
            InitializeComponent();
            new IntroSetup(this).GameIntro();
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).GetPlayerName();

        }


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string playerName = PlayerName.Text; 

            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Please enter your name!");
                return;
            }

            StoredPlayerName = playerName;
            new IntroSetup(this).StorySelection();
           
        }

        private void EndGame_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).GameIntro();
        }

        //Story Selection
        private void MiniHorrorCoverBtn_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).LanguageSelection();
            Story = "Horror";
        }
        private void MiniFunnyCoverBtn_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).LanguageSelection();
            Story = "Funny";
        }
        private void MiniCrimeCoverBtn_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).LanguageSelection();
            Story = "Crime";
        }



        //Languages Selection 
        private void JavaBtn_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).StartStory();
            Lang = "Java";

            if(Story == "Crime")
            {
                new CrimeStory(this).StoryCoverDisplay();
            }
            else if(Story == "Funny")
            {
                new FunnyStory(this).StoryCoverDisplay();
            }
            else if(Story == "Horror")
            {
                new HorrorStory(this).StoryCoverDisplay();
            }
        }

        private void PythonBtn_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).StartStory();
            Lang = "Python";

            if (Story == "Crime")
            {
                new CrimeStory(this).StoryCoverDisplay();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).StoryCoverDisplay();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).StoryCoverDisplay();
            }
        }

        private void CsharpBtn_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).StartStory();
            Lang = "Csharp";

            if (Story == "Crime")
            {
                new CrimeStory(this).StoryCoverDisplay();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).StoryCoverDisplay();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).StoryCoverDisplay();
            }
        }



        //Game Background Story Starts        
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).StoryBackground();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).StoryBackground();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).StoryBackground();
            }
        }
        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).StoryBackground1();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).StoryBackground1();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).StoryBackground1();
            }
        }
        private void NextBtn1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).StoryBackground2();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).StoryBackground2();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).StoryBackground2();
            }
        }
        private void NextBtn2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).StoryBackground3();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).StoryBackground3();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).StoryBackground3();
            }
        }              
        private void NextBtn3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).StoryBackground4();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).StoryBackground4();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).StoryBackground4();
            }
        }


        //Story Chapters
        //chapter 1 starts 
        private void NextBtn4_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).ChapterCoverDisplay();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).ChapterCoverDisplay();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).ChapterCoverDisplay();
            }
        }
        private void ChapterNo1_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).GameIntro();
        }

        //questions display
        //question1
        private void ChapterYes1_Click(object sender, EventArgs e)
        {
            Chapter = 1;
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter11();                
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter11();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter11();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions1();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions1();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions1();
            }
        }
        //question2
        private void Q1opt1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter12();                
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter12();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter12();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions2();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions2();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions2();
            }
        }
        private void Q1opt2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter12();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter12();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter12();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions2();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions2();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions2();
            }
        }
        private void Q1opt3_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount();

            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter12();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter12();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter12();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions2();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions2();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions2();
            }
        }
        private void Q1opt4_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter12();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter12();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter12();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions2();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions2();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions2();
            }
        }
        //question3
        private void Q2opt1_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount();

            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter13();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter13();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter13();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions3();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions3();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions3();
            }
        }
        private void Q2opt2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter13();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter13();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter13();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions3();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions3();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions3();
            }
        }
        private void Q2opt3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter13();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter13();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter13();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions3();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions3();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions3();
            }
        }
        private void Q2opt4_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter13();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter13();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter13();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions3();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions3();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions3();
            }
        }
        //question 4
        private void Q3opt1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter14();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter14();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter14();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions4();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions4();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions4();
            }
        }
        private void Q3opt2_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount();

            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter14();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter14();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter14();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions4();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions4();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions4();
            }
        }
        private void Q3opt3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter14();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter14();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter14();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions4();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions4();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions4();
            }
        }
        private void Q3opt4_Click(object sender, EventArgs e)
        {

            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter14();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter14();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter14();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions4();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions4();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions4();
            }
        }
        //question 5
        private void Q4opt1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter15();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter15();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter15();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions5();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions5();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions5();
            }
        }
        private void Q4opt2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter15();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter15();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter15();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions5();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions5();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions5();
            }
        }
        private void Q4opt3_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount();

            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter15();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter15();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter15();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions5();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions5();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions5();
            }
        }
        private void Q4opt4_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter15();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter15();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter15();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap1CodeQuestions5();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap1CodeQuestions5();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap1CodeQuestions5();
            }
        }
        //Chapter 1 score
        private void Q5opt1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter16();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter16();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter16();
            }
        }
        private void Q5opt2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter16();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter16();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter16();
            }
        }
        private void Q5opt3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter16();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter16();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter16();
            }
        }
        private void Q5opt4_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount();
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter16();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter16();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter16();
            }
        }

        private void NextBtn5_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).ScoreDisplayer();
        }


        //chapter 2 starts
        private void NextBtn6_Click_1(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).ChapterCoverDisplay1();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).ChapterCoverDisplay1();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).ChapterCoverDisplay1();
            }

        }
        private void ChapterYes2_Click(object sender, EventArgs e)
        {
            Chapter = 2;

            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter21();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter21();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter21();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions1();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions1();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions1();
            }
        }


        private void Q6opt1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter22();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter22();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter22();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions2();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions2();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions2();
            }
        }

        private void Q6opt2_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount1();
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter22();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter22();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter22();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions2();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions2();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions2();
            }
        }

        private void Q6opt3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter22();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter22();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter22();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions2();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions2();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions2();
            }
        }

        private void Q6opt4_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter22();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter22();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter22();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions2();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions2();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions2();
            }
        }



        private void Q7opt1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter23();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter23();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter23();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions3();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions3();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions3();
            }
        }

        private void Q7opt2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter23();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter23();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter23();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions3();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions3();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions3();
            }
        }

        private void Q7opt3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter23();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter23();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter23();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions3();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions3();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions3();
            }
        }

        private void Q7opt4_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount1();
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter23();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter23();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter23();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions3();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions3();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions3();
            }
        }


        private void Q8opt1_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount1();
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter24();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter24();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter24();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions4();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions4();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions4();
            }
        }

        private void Q8opt2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter24();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter24();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter24();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions4();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions4();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions4();
            }
        }

        private void Q8opt3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter24();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter24();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter24();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions4();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions4();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions4();
            }

        }

        private void Q8opt4_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter24();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter24();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter24();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions4();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions4();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions4();
            }
        }


        private void Q9opt1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter25();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter25();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter25();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions5();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions5();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions5();
            }
        }

        private void Q9opt2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter25();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter25();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter25();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions5();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions5();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions5();
            }
        }

        private void Q9opt3_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount1();
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter25();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter25();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter25();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions5();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions5();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions5();
            }
        }

        private void Q9opt4_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter25();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter25();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter25();
            }


            if (Lang == "Java")
            {
                new JavaLanguage(this).Chap2CodeQuestions5();
            }
            else if (Lang == "Csharp")
            {
                new CsharpLanguage(this).Chap2CodeQuestions5();
            }
            else if (Lang == "Python")
            {
                new PythonLangauge(this).Chap2CodeQuestions5();
            }
        }

        private void Q10opt1_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter26();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter26();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter26();
            }

        }

        private void Q10opt2_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter26();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter26();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter26();
            }
        }

        private void Q10opt3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter26();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter26();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter26();
            }
        }

        private void Q10opt4_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).scoreCount1();
            if (Story == "Crime")
            {
                new CrimeStory(this).Chapter26();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Chapter26();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Chapter26();
            }
        }


        private void NextBtn7_Click(object sender, EventArgs e)
        {
            new IntroSetup(this).ScoreDisplayer1();

        }


        private void NextBtn10_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).EndingDisplay();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).EndingDisplay();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).EndingDisplay();
            }
        }



        private void ChapterYes3_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Ending1();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Ending1();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Ending1();
            }
        }

        private void NextBtn8_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Ending2();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Ending2();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Ending2();
            }
        }

        private void NextBtn9_Click(object sender, EventArgs e)
        {
            if (Story == "Crime")
            {
                new CrimeStory(this).Ending3();
            }
            else if (Story == "Funny")
            {
                new FunnyStory(this).Ending3();
            }
            else if (Story == "Horror")
            {
                new HorrorStory(this).Ending3();
            }
        }

        private void FunnyEnding_Click(object sender, EventArgs e)
        {

        }


        private void ScoreDisplayCover_Click(object sender, EventArgs e)
        {

        }





    }
}

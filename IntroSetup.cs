using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecodeAndDiscovers
{
    internal class IntroSetup
    {
        private readonly Form1 _form;
        public IntroSetup(Form1 form) => _form = form;
        private static int Count = 0;
        private static int Count1= 0;
        public String playerName;

        public void GameIntro()
        {
            Count = 0;
            Count1 = 0;
            //this method is also used for exit button functionality
            _form.PlayBtn.Visible = true;
            _form.dadIntro.Visible = true;
            _form.dadStory.Visible = false;
            _form.MiniCrimeCoverBtn.Visible = false;
            _form.MiniFunnyCoverBtn.Visible = false;
            _form.MiniHorrorCoverBtn.Visible = false;
            _form.GraveyardOfFears.Visible = false;
            _form.FileThatShouldnt.Visible = false;
            _form.BugThatBroke.Visible = false;
            _form.dadLang.Visible = false;
            _form.Csharp.Visible = false;
            _form.JavaBtn.Visible = false;
            _form.Python.Visible = false;
            _form.PythonBtn.Visible = false;
            _form.Java.Visible = false;
            _form.CsharpBtn.Visible = false;
            _form.StoryCover.Visible = false;
            _form.NextBtn.Visible = false;
            _form.StoryBackground.Visible = false;
            _form.Chapter1.Visible = false;
            _form.Chapter2.Visible = false;
            _form.Chapter3.Visible = false;
            _form.Ending.Visible = false;
            _form.CrimeStoryCover.Visible = false;
            _form.NextBtn.Visible = false;
            _form.StartBtn.Visible = false;
            _form.CrimeBack1.Visible = false;
            _form.CrimeBack2.Visible = false;
            _form.CrimeBack3.Visible = false;
            _form.NextBtn1.Visible = false;
            _form.NextBtn2.Visible = false;
            _form.NextBtn3.Visible = false;
            _form.NextBtn4.Visible = false;
            _form.CrimeBack4.Visible = false;
            _form.CrimeBack5.Visible = false;
            _form.ChapterYes1.Visible = false;
            _form.ChapterNo1.Visible = false;
            _form.CrimeChapterCover1.Visible = false;
            _form.CrimeChapter11.Visible = false;
            _form.EndGame.Visible = false;
            _form.CrimeChapter12.Visible = false;
            _form.CrimeChapter13.Visible = false;
            _form.ChapterYes2.Visible = false;
            _form.ChapterYes3.Visible = false;
            _form.Q1opt1.Visible = false;
            _form.Q1opt2.Visible = false;
            _form.Q1opt3.Visible = false;
            _form.Q1opt4.Visible = false;
            _form.Q2opt1.Visible = false;
            _form.Q2opt2.Visible = false;
            _form.Q2opt3.Visible = false;
            _form.Q2opt4.Visible = false;
            _form.Q3opt1.Visible = false;
            _form.Q3opt2.Visible = false;
            _form.Q3opt3.Visible = false;
            _form.Q3opt4.Visible = false;
            _form.Q4opt1.Visible = false;
            _form.Q4opt2.Visible = false;
            _form.Q4opt3.Visible = false;
            _form.Q4opt4.Visible = false;
            _form.Q5opt1.Visible = false;
            _form.Q5opt2.Visible = false;
            _form.Q5opt3.Visible = false;
            _form.Q5opt4.Visible = false;
            _form.Q6opt1.Visible = false;
            _form.Q6opt2.Visible = false;
            _form.Q6opt3.Visible = false;
            _form.Q6opt4.Visible = false;
            _form.Q7opt1.Visible = false;
            _form.Q7opt2.Visible = false;
            _form.Q7opt3.Visible = false;
            _form.Q7opt4.Visible = false;
            _form.Q8opt1.Visible = false;
            _form.Q8opt2.Visible = false;
            _form.Q8opt3.Visible = false;
            _form.Q8opt4.Visible = false;
            _form.Q9opt1.Visible = false;
            _form.Q9opt2.Visible = false;
            _form.Q9opt3.Visible = false;
            _form.Q9opt4.Visible = false;
            _form.Q10opt1.Visible = false;
            _form.Q10opt2.Visible = false;
            _form.Q10opt3.Visible = false;
            _form.Q10opt4.Visible = false;            
            _form.CrimeChapter21.Visible = false;
            _form.CrimeChapter31.Visible = false;
            _form.NextBtn7.Visible = false;
            _form.ScoreDisplayCover.Visible = false;
            _form.ScoreDisplay.Visible = false;
            _form.Score.Visible = false;
            _form.NextBtn5.Visible = false;
            _form.NextBtn6.Visible = false;
            _form.HorrorBack1.Visible = false;
            _form.HorrorBack2.Visible = false;
            _form.HorrorBack3.Visible = false;
            _form.HorrorBack4.Visible = false;
            _form.HorrorBack5.Visible = false;
            _form.HorrorChapter11.Visible = false;
            _form.HorrorChapter12.Visible = false;
            _form.HorrorChapter13.Visible = false;
            _form.HorrorChapter21.Visible = false;
            _form.HorrorStoryCover.Visible = false;
            _form.HorrorChapterCover1.Visible = false;
            _form.HorrorChapter22.Visible = false;
            _form.HorrorChapter23.Visible = false;
            _form.HorrorChapter31.Visible = false;
            _form.HorrorChapter32.Visible = false;
            _form.HorrorEnding1.Visible = false;
            _form.CrimeEnding.Visible = false;
            _form.HorrorEnding2.Visible = false;
            _form.NextBtn8.Visible = false;
            _form.NextBtn9.Visible = false;
            _form.NextBtn10.Visible = false;
            _form.FunnyStoryCover.Visible = false;
            _form.FunnyBack1.Visible = false;
            _form.FunnyBack2.Visible = false;
            _form.FunnyBack3.Visible = false;
            _form.FunnyChapter11.Visible = false;
            _form.FunnyChapter12.Visible = false;
            _form.FunnyChapter21.Visible = false;
            _form.FunnyEnding.Visible = false;
            _form.HarderMeme1.Visible = false;
            _form.AverageMeme1.Visible = false;
            _form.GoodMeme1.Visible = false;
            _form.HarderMeme2.Visible = false;
            _form.AverageMeme2.Visible = false;
            _form.GoodMeme2.Visible = false;
            _form.PlayerNameDisplay.Visible = false;
            _form.SubmitBtn.Visible = false;
            _form.PlayerName.Visible = false;

        }

        public void GetPlayerName()
        {
            _form.PlayerNameDisplay.Visible = true;
            _form.SubmitBtn.Visible = true;
            _form.PlayerName.Visible = true;
            _form.PlayBtn.Visible = false;

            _form.PlayerNameDisplay.Parent = _form.dadIntro;
            _form.PlayerNameDisplay.Text = "Enter your name: ";
            playerName = _form.PlayerName.Text;
            
        }

        public void StorySelection()
        {
            _form.PlayerNameDisplay.Visible = false;
            _form.SubmitBtn.Visible = false;
            _form.PlayerName.Visible = false;
            _form.dadIntro.Visible = false;
            _form.dadStory.Visible = true;
            _form.MiniCrimeCoverBtn.Visible = true;
            _form.MiniFunnyCoverBtn.Visible = true;
            _form.MiniHorrorCoverBtn.Visible = true;
            _form.GraveyardOfFears.Visible = true;
            _form.FileThatShouldnt.Visible = true;
            _form.BugThatBroke.Visible = true;

            _form.MiniCrimeCoverBtn.Parent = _form.dadStory;
            _form.MiniFunnyCoverBtn.Parent = _form.dadStory;
            _form.MiniHorrorCoverBtn.Parent = _form.dadStory;
            _form.GraveyardOfFears.Parent = _form.dadStory;
            _form.FileThatShouldnt.Parent = _form.dadStory;
            _form.BugThatBroke.Parent = _form.dadStory;
            
        }
        public void LanguageSelection()
        {
            _form.MiniCrimeCoverBtn.Visible = false;
            _form.MiniFunnyCoverBtn.Visible = false;
            _form.MiniHorrorCoverBtn.Visible = false;
            _form.GraveyardOfFears.Visible = false;
            _form.FileThatShouldnt.Visible = false;
            _form.BugThatBroke.Visible = false;
            _form.dadLang.Visible = true;
            _form.dadStory.Visible = false;
            _form.CsharpBtn.Visible = true;
            _form.JavaBtn.Visible = true;
            _form.PythonBtn.Visible = true;
            _form.Python.Visible = true;
            _form.Java.Visible = true;
            _form.Csharp.Visible = true;

            _form.Csharp.Parent = _form.dadLang;
            _form.Java.Parent = _form.dadLang;
            _form.Python.Parent = _form.dadLang;
            _form.CsharpBtn.Parent = _form.dadLang;
            _form.JavaBtn.Parent = _form.dadLang;
            _form.PythonBtn.Parent = _form.dadLang;
        }
        public void StartStory()
        {
            _form.dadLang.Visible = false;
            _form.Java.Visible = false;
            _form.JavaBtn.Visible = false;
            _form.Python.Visible = false;
            _form.PythonBtn.Visible = false;
            _form.Csharp.Visible = false;
            _form.CsharpBtn.Visible = false;
        }

        public int scoreCount()
        {
            Count++;
            return Count;
        }
        public int scoreCount1()
        {
            Count1++;
            return Count1;
        }

        public void ScoreDisplayer()
        {

            if (_form.Story == "Crime")
            {
                _form.CrimeChapter13.Visible = false;
            }
            else if (_form.Story == "Horror")
            {
                _form.HorrorChapter13.Visible = false;
            }
            else if (_form.Story == "Funny")
            {
                _form.FunnyChapter12.Visible = false;
                _form.FunnyStoryCover.Visible = false;
            }

            _form.NextBtn6.Visible = true;
            _form.ScoreDisplay.Visible = true;
            _form.ScoreDisplayCover.Visible = true;
            _form.Score.Visible = true;

            _form.NextBtn6.Parent = _form.ScoreDisplayCover;
            _form.Score.Parent = _form.ScoreDisplayCover;
            _form.ScoreDisplay.Parent = _form.ScoreDisplayCover;
            _form.ScoreDisplay.Text = "           Score Display            \n          Your Score is:            ";
            _form.Score.Text = "              " + Count+ "/5              ";

            if (Count >= 0 && Count < 3)
            {
                _form.HarderMeme1.Visible = true;
                _form.HarderMeme1.Parent = _form.ScoreDisplayCover;
            }
            else if ( Count == 3)
            {
                _form.AverageMeme1.Visible = true;
                _form.AverageMeme1.Parent = _form.ScoreDisplayCover;
            }
            else if (Count >= 4)
            {
                _form.GoodMeme1.Visible = true;
                _form.GoodMeme1.Parent = _form.ScoreDisplayCover;
            }

            MySqlHelper db = new MySqlHelper();
            string player = _form.StoredPlayerName;
            int chapterNumber = 1; 

            db.SaveProgress(player, _form.Story, _form.Lang, chapterNumber, Count);
        }
        public void ScoreDisplayer1()
        {
            _form.HarderMeme1.Visible = false;
            _form.AverageMeme1.Visible = false;
            _form.GoodMeme1.Visible = false;
            _form.NextBtn6.Visible = false;
            _form.NextBtn7.Visible = false;

            if (_form.Story == "Crime")
            {
                _form.CrimeChapter31.Visible = false;
            }
            else if(_form.Story == "Horror")
            {
                _form.HorrorChapter23.Visible = false;

            }
            else if(_form.Story == "Funny")
            {
                _form.FunnyChapter12.Visible = false;
                _form.FunnyStoryCover.Visible = false;

            }

            _form.NextBtn10.Visible = true;
            _form.ScoreDisplay.Visible = true;
            _form.ScoreDisplayCover.Visible = true;
            _form.Score.Visible = true;

            _form.NextBtn10.Parent = _form.ScoreDisplayCover;
            _form.Score.Parent = _form.ScoreDisplayCover;
            _form.ScoreDisplay.Parent = _form.ScoreDisplayCover;
            _form.ScoreDisplay.Text = "           Score Display            \n          Your Score is:            ";
            _form.Score.Text = "              " + Count1 + "/5              ";

            if (Count1 >= 0 && Count1 < 3)
            {
                _form.HarderMeme2.Visible = true;
                _form.HarderMeme2.Parent = _form.ScoreDisplayCover;
            }
            else if (Count1 == 3)
            {
                _form.AverageMeme2.Visible = true;
                _form.AverageMeme2.Parent = _form.ScoreDisplayCover;
            }
            else if (Count1 >= 4)
            {
                _form.GoodMeme2.Visible = true;
                _form.GoodMeme2.Parent = _form.ScoreDisplayCover;
            }
            MySqlHelper db = new MySqlHelper();
            string player = _form.StoredPlayerName;
            int chapterNumber = 2;

            db.SaveProgress(player, _form.Story, _form.Lang, chapterNumber, Count1);

        }



    }
}

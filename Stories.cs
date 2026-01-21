using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDiscovers
{
    public class Stories
    {
        private readonly Form1 _form;
        public Stories(Form1 form) => _form = form;


        public virtual void StoryCoverDisplay()
        {
            _form.StoryCover.Visible = true;
            _form.NextBtn.Visible = true;

            _form.NextBtn.Parent = _form.StoryCover;
        }
        public virtual void StoryBackground()
        {
            _form.StoryBackground.Visible = true;
            _form.StoryBackground.Text = "All the background story will be written in this method through polymorphishm overriding";

        }



        public virtual void StoryBackground1()
        {
            _form.StoryBackground.Visible = true;
            _form.StoryBackground.Text = "All the background story will be written in this method through polymorphishm overriding";

        }
        public virtual void StoryBackground2()
        {
            _form.StoryBackground.Visible = true;
            _form.StoryBackground.Text = "All the background story will be written in this method through polymorphishm overriding";

        }
        public virtual void StoryBackground3()
        {
            _form.StoryBackground.Visible = true;
            _form.StoryBackground.Text = "All the background story will be written in this method through polymorphishm overriding";

        }
        public virtual void StoryBackground4()
        {
            _form.StoryBackground.Visible = true;
            _form.StoryBackground.Text = "All the background story will be written in this method through polymorphishm overriding";

        }

        public virtual void StoryBackground5()
        {
            _form.StoryBackground.Visible = true;
            _form.StoryBackground.Text = "All the background story will be written in this method through polymorphishm overriding";

        }



        public virtual void ChapterCoverDisplay()
        {
            _form.StoryCover.Visible = false;
            _form.CrimeStoryCover.Visible = true;
            _form.StartBtn.Visible = true;

            _form.StartBtn.Parent = _form.CrimeStoryCover;
        }

        public virtual void ChapterCoverDisplay1()
        {
            _form.StoryCover.Visible = false;
            _form.CrimeStoryCover.Visible = true;
            _form.StartBtn.Visible = true;

            _form.StartBtn.Parent = _form.CrimeStoryCover;
        }
        public virtual void ChapterCoverDisplay5()
        {
            _form.StoryCover.Visible = false;
            _form.CrimeStoryCover.Visible = true;
            _form.StartBtn.Visible = true;

            _form.StartBtn.Parent = _form.CrimeStoryCover;
        }

        public virtual void EndingDisplay()
        {
            _form.CrimeStoryCover.Visible = true;
            _form.StartBtn.Visible = true;

            _form.StartBtn.Parent = _form.CrimeStoryCover;
        }


        public virtual void Chapter11()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter12()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";

        }
        public virtual void Chapter13()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter14()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter15()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter16()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter21()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter22()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";

        }
        public virtual void Chapter23()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter24()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter25()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Chapter26()
        {
            _form.Chapter1.Visible = true;
            _form.Chapter1.Text = "All the story content of chapter 1";
        }
        public virtual void Ending1()
        {
            _form.Ending.Visible = true;
            _form.Ending.Text = "All the story content of ending";
        }
        public virtual void Ending2()
        {
            _form.Ending.Visible = true;
            _form.Ending.Text = "All the story content of ending";
        }

        public virtual void Ending3()
        {
            _form.Ending.Visible = true;
            _form.Ending.Text = "All the story content of ending";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecodeAndDiscovers
{
    internal class HorrorStory : Stories
    {
        private readonly Form1 _form;
        public HorrorStory(Form1 form) : base(form) => _form = form;

        //Story Background
        public override void StoryCoverDisplay()
        {
            _form.StoryCover.Visible = false;
            _form.EndGame.Visible = true;
            _form.HorrorStoryCover.Visible = true;
            _form.StartBtn.Visible = true;

            _form.StartBtn.Parent = _form.HorrorStoryCover;
        }
        public override void StoryBackground()
        {
            _form.HorrorStoryCover.Visible = false;
            _form.StartBtn.Visible = false;
            _form.NextBtn.Visible = true;
            _form.HorrorBack1.Visible = true;
            _form.StoryBackground.Visible = true;

            _form.NextBtn.Parent = _form.HorrorBack1;
            _form.StoryBackground.Parent = _form.HorrorBack1;
            _form.StoryBackground.Text = "Urooba had just moved to the city and was already making a strong impression. Bright, brave, and a bit quirky, \nshe believed in facing life head-on—with sarcasm, memes, and caffeine. But the city had its own set of legends, and today, \nUrooba accidentally stepped right into one.\r\n";
        }
        public override void StoryBackground1()
        {
            _form.HorrorBack1.Visible = false;
            _form.NextBtn.Visible = false;
            _form.NextBtn1.Visible = true;
            _form.HorrorBack2.Visible = true;

            _form.NextBtn1.Parent = _form.HorrorBack2;
            _form.StoryBackground.Parent = _form.HorrorBack2;
            _form.StoryBackground.Text = "After a casual encounter with the town's infamous bullies at the park, she turned the tables on them with her bold attitude. \nIrritated, the bullies gave her a dare—\"Spend the night at the haunted city graveyard.\" They smirked, expecting her to panic.\r\nBut Urooba, who had never believed in ghost stories and thought horror movies were hilarious, simply shrugged.\r\n\"Cool. Is there Wi-Fi there too?\"\r\nThe bullies froze. She had no idea what she had just agreed to.\r\n";
        }
        public override void StoryBackground2()
        {
            _form.HorrorBack2.Visible = false;
            _form.NextBtn1.Visible = false;
            _form.NextBtn2.Visible = true;
            _form.HorrorBack3.Visible = true;

            _form.NextBtn2.Parent = _form.HorrorBack3;
            _form.StoryBackground.Parent = _form.HorrorBack3;
            _form.StoryBackground.Text = "As night approached, Urooba packed her backpack with essentials: a hoodie, a flashlight, snacks, and of course, her laptop. \nShe was planning to binge watch some Netflix series while she waited for morning. \r\nShe arrived at the graveyard just before midnight.\r\nThe gate creaked open by itself.\r\nNo big deal, she thought. Maybe it’s automatic.";
        }
        public override void StoryBackground3()
        {
            _form.HorrorBack3.Visible = false;
            _form.NextBtn2.Visible = false;
            _form.NextBtn3.Visible = true;
            _form.HorrorBack4.Visible = true;

            _form.NextBtn3.Parent = _form.HorrorBack4;
            _form.StoryBackground.Parent = _form.HorrorBack4;
            _form.StoryBackground.Text = "Urooba wandered deeper into the graveyard, looking for a clean-ish bench to sit. The place was eerily quiet. \nNot even a cricket sound. Suddenly, the flashlight flickered.\r\nShe tapped it. \"Cheap batteries.\"\r\nthe flashlight was gone. there was only moonlight making it possible to see the surrounding. \nSuddenly mist crept across the ground. \nThe headstones seemed older, cracked, and shifted. The trees looked... twisted. \nShe thought things might be looking like this cz of the insufficient light. \r\n";
        }
        public override void StoryBackground4()
        {
            _form.HorrorBack4.Visible = false;
            _form.NextBtn3.Visible = false;
            _form.NextBtn4.Visible = true;
            _form.HorrorBack5.Visible = true;

            _form.NextBtn4.Parent = _form.HorrorBack5;
            _form.StoryBackground.Parent = _form.HorrorBack5;
            _form.StoryBackground.Text = "But then she saw it—a glowing screen floating in midair. It displayed: \"Welcome, Urooba. Ready to Face your Biggest Fear?\"\r\nBeing a Genz she stared in confusion, thinking \"Was this an AR prank by the bullies?\"\r\n\"Ohh come-on guys ik its you, trying to mess with me. im not afraid of these stupid ghosts\".\r\nUrooba still thought it was all just a prank to cause her lose the dare. Suddenly the Flashlight worked again. \nBut this time she felt a little frightened.  the graveyard was a totally different place now. \nBefore she was at a well constructed graveyard but now what she was seeing was a \nold and forgotten graveyard which was seemed extremely old. all the headstones seemed like a hundred years old. \r\nShe looked towards the glowing screen but now there was a computer whose showed a familiar sight—a coding test, \njust like the ones that always made her anxious. She clicked \"Start\".\r\n";
        }

        //Story Chapters 1
        public override void ChapterCoverDisplay()
        {
            _form.EndGame.Visible = false;
            _form.HorrorBack5.Visible = false;
            _form.NextBtn4.Visible = false;
            _form.StoryBackground.Visible = false;
            _form.HorrorChapterCover1.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes1.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes1.Parent = _form.HorrorChapterCover1;
            _form.ChapterNo1.Parent = _form.HorrorChapterCover1;
            _form.ContinueStory.Parent = _form.HorrorChapterCover1;
            _form.ContinueStory.Text = "Do you want to start the new chapter 1 of \"The Graveyard of Fears\" ?";
        }

        public override void Chapter11()
        {
            _form.HorrorChapterCover1.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes1.Visible = false;
            _form.ChapterNo1.Visible = false;
            _form.EndGame.Visible = true;
            _form.HorrorChapter11.Visible = true;
            _form.Chapter1.Visible = true;
            _form.CodeQuestion1.Visible = true;

            _form.CodeQuestion1.Parent = _form.HorrorChapter11;
            _form.Chapter1.Parent = _form.HorrorChapter11;
            _form.Chapter1.Text = "She clicked \"Start,\" and the floating screen blinked to life. Suddenly, lines of code—buggy, broken, and confusing—filled the air like smoke. \nRed error marks flashed like sirens. She leaned forward. The title on the screen read:\r\n\"Midnight Coding Assessment: Pass to Survive\"\r\nHer hands trembled. Her palms were sweaty. The very thing she feared most was now the only way out.\r\nShe muttered under her breath, \"I don't... I can't do this.\"\r\nSuddenly, a deep, bone-chilling voice echoed from all directions: \"Fail the test. Become one of us.\"\r\nGiggling noises echoed through the graveyard as the world started closing in on her. Her breath hitched. Her heartbeat raced. But then…\r\nAmid all the horror, she heard a faint voice.Her own voice—recorded from a reel she once posted:\r\n\"When you fail a coding test but still get the job 😂💻\"\r\nThe screen blinked again. First question appeared.\r\n";
        }

        public override void Chapter12()
        {
            _form.Chapter1.Parent = _form.HorrorChapter11;
            _form.Chapter1.Text = "She read it carefully. Her fingers flew over the ghostly keyboard.\r\nClick. Submit.\r\nHer confidence sparked.\r\n";
        }

        public override void Chapter13()
        {
            _form.HorrorChapter11.Visible = false;
            _form.HorrorChapter12.Visible = true;

            _form.Chapter1.Parent = _form.HorrorChapter12;
            _form.Chapter1.Text = "She closed her eyes, took a deep breath, and answered.\r\nAnother correct answer.\r\nThe fog in the graveyard began to thin.\r\nThe voice returned, angrier this time:\r\n\"You will never be enough. You will never solve this. You will never pass the test.\"\r\nShe grit her teeth.\r\n\"Watch me.\"\r\nShe hesitated—this one was tricky.\r\n";
        }

        public override void Chapter14()
        {
            _form.Chapter1.Parent = _form.HorrorChapter12;
            _form.Chapter1.Text = "A loud screech came from the shadows, retreating.\r\nA glitch in the air formed into a huge screen displaying:\r\n";
        }

        public override void Chapter15()
        {
            _form.HorrorChapter12.Visible = false;
            _form.HorrorChapter13.Visible = true;

            _form.Chapter1.Parent = _form.HorrorChapter13;
            _form.Chapter1.Text = "This one was different. It wasn't multiple choice.\r\nIt asked her to write a function from scratch.\r\nShe took a deep breath, fingers steady now.\r\nLines of clean code danced on the screen.\r\nShe passed.\r\nThe world shimmered again.\r\nA memory surfaced—her first coding fail, where she cried all night.\r\nShe shook it off.\r\n\"I’m not that girl anymore.\"\r\nSuddenly, a warning appeared:\r\n\"Final Question. Face it... or disappear forever.\"\r\nThe screen glowed.\r\n";
        }

        public override void Chapter16()
        {
            _form.Q5opt1.Visible = false;
            _form.Q5opt2.Visible = false;
            _form.Q5opt3.Visible = false;
            _form.Q5opt4.Visible = false;
            _form.CodeQuestion1.Visible = false;
            _form.NextBtn5.Visible = true;

            _form.NextBtn5.Parent = _form.HorrorChapter13;
            _form.Chapter1.Parent = _form.HorrorChapter13;
            _form.Chapter1.Text = "This was it. The toughest one yet.\r\nAnd right as she solved it and hit \"Submit\"—\r\nThe giggling voices vanished.\r\n";
        }
        //Story Chapters 2
        public override void ChapterCoverDisplay1()
        {
            _form.NextBtn6.Visible = false;

            _form.EndGame.Visible = false;
            _form.ScoreDisplayCover.Visible = false;
            _form.Chapter1.Visible = false;
            _form.HorrorChapterCover1.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes2.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes2.Parent = _form.HorrorChapterCover1;
            _form.ChapterNo1.Parent = _form.HorrorChapterCover1;
            _form.ContinueStory.Parent = _form.HorrorChapterCover1;
            _form.ContinueStory.Text = "Do you want to start the new chapter 2 of \"The Graveyard of Fears\" ?";

        }

        public override void Chapter21()
        {
            _form.HorrorChapterCover1.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes2.Visible = false;
            _form.ChapterNo1.Visible = false;
            _form.EndGame.Visible = true;
            _form.HorrorChapter21.Visible = true;
            _form.Chapter2.Visible = true;

            _form.Chapter2.Parent = _form.HorrorChapter21;
            _form.Chapter2.Text = "She passed the first test successfully. The dark screen faded and the whispers quieted. Urooba stood up, her breathing steady, \nher eyes sharp. \"I did it,\" she said to herself. “That wasn’t so bad.” Just when she thought it was over, a strange tremor shook the ground \nbeneath her feet. A cracking sound followed, deep and eerie—like the earth yawning. Suddenly, the ground split wide open. She didn’t even \nhave time to scream. She fell straight in. Down, down into a spinning tunnel of glowing code. Lines of code spiraled around her like a tornado.\r\nShe reached out, trying to grab anything—but it was all digital. Code was all she could see. And hear. A robotic voice echoed from nowhere: \n“You are now trapped in an infinite loop.”\r\nUrooba landed in a circular chamber made entirely of dark screens. The air smelled like burnt circuits. The walls glowed with a \nsingle haunting phrase:\r\n“You forgot to update the condition.” “You forgot to break.” “You forgot to break.”\r\nOver and over again. Urooba walked in circles, then ran in the opposite direction— But no matter what she did, the room stayed the same.\r\n\"I’ve seen horror movies less confusing than this,\" she muttered, breathing heavily. She slammed her laptop open.\r\nSuddenly, a floating question appeared in front of her, glowing in red.\r\n";
        }

        public override void Chapter22()
        {
            _form.Chapter2.Parent = _form.HorrorChapter21;
            _form.Chapter2.Text = "She typed it correctly. The loop glowed blue—and one wall flickered.\r\n“Progress detected,” the robotic voice said.\r\nAnother question appeared.\r\n";
        }

        public override void Chapter23()
        {
            _form.HorrorChapter21.Visible = false;
            _form.HorrorChapter22.Visible = true;

            _form.Chapter2.Parent = _form.HorrorChapter22;
            _form.Chapter2.Text = "The whispers got softer. The ceiling cracked.\r\nSuddenly, from above, a broken for-loop dropped like a monster, growling:\r\n“I will repeat forever!”\r\nUrooba rolled her eyes.\r\n“No, you’ll repeat until I say so.”\r\n";
        }

        public override void Chapter24()
        {
            _form.Chapter2.Parent = _form.HorrorChapter22;
            _form.Chapter2.Text = "The monster loop vanished in a glitch.\r\nMore questions floated toward her now, like spirits circling.\r\nThe room brightened.\r\n";
        }
        public override void Chapter25()
        {
            _form.HorrorChapter22.Visible = false;
            _form.HorrorChapter23.Visible = true;

            _form.Chapter2.Parent = _form.HorrorChapter23;
            _form.Chapter2.Text = "Boom. One of the screens exploded into dust.\r\nThen came the final test:\r\n";
        }
        public override void Chapter26()
        {
            _form.CodeQuestion1.Visible = false;
            _form.Q10opt1.Visible = false;
            _form.Q10opt2.Visible = false; 
            _form.Q10opt3.Visible = false;
            _form.Q10opt4.Visible = false;
            _form.Chapter2.Visible = true;

            _form.NextBtn7.Visible = true;
            _form.NextBtn7.Parent = _form.HorrorChapter23;
            _form.Chapter2.Parent = _form.HorrorChapter23;
            _form.Chapter2.Text = "Suddenly, a booming voice said:\r\n“You have broken the loop.”\r\nThe screens shattered. The ground opened again—this time upward.\r\nA beam of light shot down and lifted her out of the chamber.\r\nShe floated back into the graveyard... breathless, but proud.\r\nShe had faced her first real fear in code—infinite loops—and won.\r\n";
        }


        public override void EndingDisplay()
        {
            _form.EndGame.Visible = false;
            _form.ScoreDisplayCover.Visible = false;
            _form.Chapter2.Visible = false;
            _form.HorrorChapterCover1.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes3.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes3.Parent = _form.HorrorChapterCover1;
            _form.ChapterNo1.Parent = _form.HorrorChapterCover1;
            _form.ContinueStory.Parent = _form.HorrorChapterCover1;
            _form.ContinueStory.Text = "Do you want to start the ending of \"The Graveyard of Fears\" ?";

        }

        public override void Ending1()
        {
            _form.HorrorChapterCover1.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes3.Visible = false;
            _form.ChapterNo1.Visible = false;

            _form.NextBtn8.Visible = true;
            _form.EndGame.Visible = true;
            _form.Ending.Visible = true;
            _form.HorrorEnding1.Visible = true;
            _form.NextBtn8.Parent = _form.HorrorEnding1;
            _form.Ending.Parent = _form.HorrorEnding1;
            _form.Ending.Text = "Urooba dusted herself off, standing in the quiet.\r\n\"Like I said,\" she smirked,\r\n\"This is just code. And I’m not afraid of code anymore.\" \nSuddenly she felt dizzy and fainted.\r\nWhen Urooba opened her eyes, it was morning. Birds chirped. The graveyard looked normal again—silent, peaceful.\r\nShe was lying on the grass, holding her laptop. The coding screen was gone.\r\nShe stood up, stretched, and walked toward the gate. This time, it opened gently.\r\n";
        }

        public override void Ending2()
        {
            _form.NextBtn8.Visible = false;
            _form.NextBtn9.Visible = true;
            _form.NextBtn9.Parent = _form.HorrorEnding1;

            _form.Ending.Parent = _form.HorrorEnding1;
            _form.Ending.Text = "The bullies were waiting outside with smug expressions.\r\n\"Guess you couldn’t do it, huh?\"\r\nShe walked past them and smirked.\r\n\"Oh, I stayed. Took a coding test in the graveyard, debugged my nightmares, screamed at a clown, and made peace with fear. You?\"\r\nThe bullies were speechless.\r\n";
        }
        public override void Ending3()
        {
            _form.NextBtn9.Visible = false;
            _form.HorrorEnding1.Visible = false;
            _form.HorrorEnding2.Visible = true;
            _form.Ending.Parent = _form.HorrorEnding2;
            _form.Ending.Text = "From that day on, no one ever dared to challenge Urooba again.\r\nBut whenever she opened her laptop late at night, she sometimes saw a flicker—a ghostly screen offering a new test.\r\nAnd she’d smile and say:\r\n“Let’s do this.”\r\n";
        }
    }
}

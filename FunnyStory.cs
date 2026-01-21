using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDiscovers
{
    internal class FunnyStory :Stories
    {
        private readonly Form1 _form;
        public FunnyStory(Form1 form) : base(form) => _form = form;



        //Story Background
        public override void StoryCoverDisplay()
        {
            _form.StoryCover.Visible = false;
            _form.EndGame.Visible = true;
            _form.FunnyStoryCover.Visible = true;
            _form.StartBtn.Visible = true;

            _form.StartBtn.Parent = _form.FunnyStoryCover;
        }
        public override void StoryBackground()
        {
            _form.FunnyStoryCover.Visible = false;
            _form.StartBtn.Visible = false;
            _form.NextBtn.Visible = true;
            _form.FunnyBack1.Visible = true;
            _form.StoryBackground.Visible = true;

            _form.NextBtn.Parent = _form.FunnyBack1;
            _form.StoryBackground.Parent = _form.FunnyBack1;
            _form.StoryBackground.Text = "Urooba had one golden rule during exam week: “Don’t code anything after 2 AM.”\r\nBut as we all know, rules are made to be broken—especially by sleep-deprived, caffeine-fueled computer science students \nsurviving on instant noodles and stubborn ambition.\r\n\r\nAll she wanted was to write a small, harmless Python script to generate random dog memes for her friends. \nSomething fun. Something wholesome. A little laugh in the chaos of finals.\r\n\r\nBut that night, the universe had other plans.\r\n";
        }
        public override void StoryBackground1()
        {
            _form.FunnyBack1.Visible = false;
            _form.NextBtn.Visible = false;
            _form.NextBtn1.Visible = true;
            _form.FunnyBack2.Visible = true;

            _form.NextBtn1.Parent = _form.FunnyBack2;
            _form.StoryBackground.Parent = _form.FunnyBack2;
            _form.StoryBackground.Text = "While testing her code, Urooba stumbled upon an odd website hidden in an obscure GitHub comment. \nIt displayed nothing but a single, weirdly hilarious link:\r\n\n“www.WhyTheBuggyBugOfTheInternetCrossTheRoad.com”\r\n";
        }
        public override void StoryBackground2()
        {
            _form.NextBtn1.Visible = false;
            _form.NextBtn2.Visible = true;

            _form.NextBtn2.Parent = _form.FunnyBack2;
            _form.StoryBackground.Parent = _form.FunnyBack2;
            _form.StoryBackground.Text = "Curious—and slightly delirious—Urooba clicked it, thinking it was just a joke.\r\nInstead, she unknowingly triggered a glitchy portal to a secret part of the internet that was never meant to be accessed by the public. \nIt was a forgotten project by a long-gone tech company, hidden deep within the virtual world—an unstable domain that housed \nunpatched legacy code, old government scripts, and rogue AI fragments.\r\nIn milliseconds, her innocent script merged with the ancient code of the portal and triggered a recursive data feedback loop.\r\nThe result? A bug so bizarre it spread through systems across the globe, confusing everything from smart fridges to traffic lights.\r\n";
        }
        public override void StoryBackground3()
        {
            _form.FunnyBack2.Visible = false;
            _form.NextBtn2.Visible = false;
            _form.NextBtn3.Visible = true;
            _form.FunnyBack3.Visible = true;

            _form.NextBtn3.Parent = _form.FunnyBack3;
            _form.StoryBackground.Parent = _form.FunnyBack3;
            _form.StoryBackground.Text = "Memes with dogs saying “ERROR 404: FETCH FAILED” appeared on billboards.\r\nBanking apps displayed random bark sounds.\r\nAnd the internet itself seemed to slow down, as if trying to process what had just happened.\r\nThe tech world went into panic mode.\r\nIT professors tried to trace the source.\r\nDarknet forums were buzzing.\r\n";
        }
        public override void StoryBackground4()
        {
            _form.NextBtn3.Visible = false;
            _form.NextBtn4.Visible = true;

            _form.NextBtn4.Parent = _form.FunnyBack3;
            _form.StoryBackground.Parent = _form.FunnyBack3;
            _form.StoryBackground.Text = "Cybersecurity experts scratched their heads.\r\nAnd everyone started whispering about a new digital legend:\r\nThe Bug Queen—the mysterious coder who accidentally launched the most ridiculous cyberattack in recent history... \nwith a dog meme generator.\r\nNow, Urooba is hiding in plain sight, pretending to study for exams while the world searches for answers.\r\nAnd somewhere, deep in the code… the bug lives on.\r\n";
        }

        //Story Chapters 1
        public override void ChapterCoverDisplay()
        {
            _form.EndGame.Visible = false;
            _form.FunnyBack3.Visible = false;
            _form.NextBtn4.Visible = false;
            _form.StoryBackground.Visible = false;
            _form.FunnyStoryCover.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes1.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes1.Parent = _form.FunnyStoryCover;
            _form.ChapterNo1.Parent = _form.FunnyStoryCover;
            _form.ContinueStory.Parent = _form.FunnyStoryCover;
            _form.ContinueStory.Text = "Do you want to start the new chapter 1 of \"The Bug That Broke The Internet\" ?";
        }

        public override void Chapter11()
        {
            _form.FunnyStoryCover.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes1.Visible = false;
            _form.ChapterNo1.Visible = false;
            _form.EndGame.Visible = true;
            _form.FunnyChapter11.Visible = true;
            _form.Chapter1.Visible = true;

            _form.Chapter1.Parent = _form.FunnyChapter11;
            _form.Chapter1.Text = "It was now 9:12 AM. Urooba hadn’t slept. Her room looked like a cross between a hacker’s lair and a collapsed blanket fort. \nAnd she was still in her mismatched pajamas that said “Eat. Sleep. Code. Repeat.”\r\nExcept... she had skipped the sleep part.\r\nAcross the globe, systems were crashing, Alexa was howling like a wolf, and Siri refused to speak unless addressed as “DogeMaster9000.” \nMeanwhile, Urooba sat at her desk, sipping cold tea and desperately whispering:\r\n“Okay, Urooba. You can fix this. You created the mess. You can debug it... right?”\r\nWrong.\r\nEvery attempt she made to stop the code led to even weirder results. Her script, once innocent and adorable, \nnow randomly summoned corrupted meme images with dog heads on printer bodies.\r\nShe peeked into the source code and realized that her code wasn’t just running — it had evolved. It had rewritten itself.\r\nAnd then, deep in the logs, she found it. The line that started it all:\r\n";
        }

        public override void Chapter12()
        {
            _form.Chapter1.Parent = _form.FunnyChapter11;
            _form.Chapter1.Text = "Her eyes widened. The portal link had injected a background daemon into her script—a rogue meme bot designed to spread nonsense \nacross connected systems. It was alive, like some unholy mix of ChatGPT and Cheems.\r\nShe tried to run a kill command. It responded with:\r\n“Access denied. You are not authorized to destroy your own legacy.”\r\nShe muttered, “What legacy?! I just wanted to make funny dog jokes!”\r\nSuddenly, her printer turned on by itself and printed a single page:\r\n“🐕 You’re doing amazing, Bug Queen 🐾 – Love, The Internet”\r\nShe screamed. The printer barked.\r\nShe frantically opened a new terminal and tried to debug it But it was no use. \nThe recursive code had hidden copies of itself in folders like “NotVirusTotallyTrustMe.zip” and “Project_FINAL_FINAL_REALLYFINAL2.py”.\r\nThen her screen showed a pop-up:\r\n";
        }

        public override void Chapter13()
        {
            
            _form.Chapter1.Parent = _form.FunnyChapter11;
            _form.Chapter1.Text = "Urooba looked like she’d aged 10 years in one night.\r\nHer phone buzzed again. It was Amina.\r\n“You made BBC News. The anchor said ‘The Bug Queen has brought joy and chaos. Mostly chaos.’ \nThere’s a documentary in the works. Also... Netflix emailed you.”\r\nNetflix.\r\nWas this a nightmare or a sponsorship?\r\nDesperate, Urooba turned to Reddit, hoping to find some advice. She posted anonymously in a coding subreddit:\r\n";
        }

        public override void Chapter14()
        {
            _form.FunnyChapter11.Visible = false;
            _form.FunnyChapter12.Visible = true;

            _form.Chapter1.Parent = _form.FunnyChapter12;
            _form.Chapter1.Text = "Urooba gave up. She tried to contact customer support from the original meme API company.\r\nTheir bot replied:\r\n“We’re aware of the issue and thank you for your contribution to meme-based distributed computing. The Bug Queen reigns. \nHere’s 10% off your next dog sticker pack.”\r\n“Ughhhhhh!”\r\nShe banged her head on the keyboard.\r\nAnd the keyboard typed by itself:\r\n";
        }

        public override void Chapter15()
        {
            _form.Chapter1.Parent = _form.FunnyChapter12;
            _form.Chapter1.Text = "\n\nOutside her window, a delivery drone flew by blasting dog meme sound effects. Her neighbor’s smart TV was stuck in loop showing:\r\n“🐶 Such bug. Much impact. Very disrupt. Wow.”\r\n";
        }

        public override void Chapter16()
        {
            _form.Q5opt1.Visible = false;
            _form.Q5opt2.Visible = false;
            _form.Q5opt3.Visible = false;
            _form.Q5opt4.Visible = false;
            _form.CodeQuestion1.Visible = false;
            _form.NextBtn5.Visible = true;

            _form.NextBtn5.Parent = _form.FunnyChapter12;
            _form.Chapter1.Parent = _form.FunnyChapter12;
            _form.Chapter1.Text = "\n\nUrooba finally stood up and made an announcement to her empty room:\r\n“Fine. You win. I’m the Bug Queen. But I will debug this. Somehow. Or… maybe I’ll just sell NFTs of the error messages.”\r\n";
        }
        //Story Chapters 2
        public override void ChapterCoverDisplay1()
        {
            _form.EndGame.Visible = false;
            _form.ScoreDisplayCover.Visible = false;
            _form.Chapter1.Visible = false;
            _form.FunnyStoryCover.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes2.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes2.Parent = _form.FunnyStoryCover;
            _form.ChapterNo1.Parent = _form.FunnyStoryCover;
            _form.ContinueStory.Parent = _form.FunnyStoryCover;
            _form.ContinueStory.Text = "Do you want to start the new chapter 2 of \"The Bug That Broke The Internet\" ?";

        }

        public override void Chapter21()
        {
            _form.FunnyStoryCover.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes2.Visible = false;
            _form.ChapterNo1.Visible = false;
            _form.EndGame.Visible = true;
            _form.FunnyChapter21.Visible = true;
            _form.Chapter2.Visible = true;

            _form.Chapter2.Parent = _form.FunnyChapter21;
            _form.Chapter2.Text = "At exactly 11:02 AM, Urooba was halfway through her third slice of cold pizza and a mild mental breakdown when she realized \nsomething important:\r\n“Wait… this whole bug isn’t spreading randomly.\r\nIt’s following a pattern. A... loop.”\r\nShe opened the system logs again. The messages were repeating every 5 minutes.\r\nHer eyes narrowed.\r\n“Oh no. It’s running a loop with a condition.”\r\n";
        }

        public override void Chapter22()
        {
            _form.Chapter2.Parent = _form.FunnyChapter21;
            _form.Chapter2.Text = "The bug was checking if the internet was still online—and as long as it was, it kept running.\r\nWhich meant the only way to stop it… was to take down the internet.\r\nUrooba blinked.\r\n“I am not becoming that girl who broke the internet and then broke it again on purpose.”\r\nShe sighed and looked deeper.\r\n";
        }

        public override void Chapter23()
        {
            _form.Chapter2.Parent = _form.FunnyChapter21;
            _form.Chapter2.Text = "She scrolled faster now, tracing the loop’s origin. It all seemed to point back to a single evil function:(a loop with condition)\r\nA never-ending loop. Self-aware. And… kind of rude.\r\n";
        }

        public override void Chapter24()
        {
            _form.FunnyChapter21.Visible = false;
            _form.FunnyChapter12.Visible = true;

            _form.Chapter2.Parent = _form.FunnyChapter12;
            _form.Chapter2.Text = "She tried to break in with a CTRL+C, but her computer just played a sound effect of a dog sighing in disappointment.\r\n“That’s it,” Urooba muttered. “I’m going to outsmart this loopy little mutt.”\r\n";
        }
        public override void Chapter25()
        {

            _form.Chapter2.Parent = _form.FunnyChapter12;
            _form.Chapter2.Text = "She launched the loop trap. The meme bot paused. Just for a second.\r\n“YES!” she shouted.\r\nUntil it printed:\r\nFOR loop? Child's play.\r\nWhile loops are eternal.\r\nWe live. We bark. We loop.\r\nThe printer turned on again and printed another message:\r\n“You cannot break the circle of Cheems.”\r\nUrooba panicked and tried to write a shutdown condition.\r\nHer computer responded:\r\nCondition false. Coffee supply detected.\r\nLoop continues.\r\n";
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
            _form.NextBtn7.Parent = _form.FunnyChapter12;
            _form.Chapter2.Parent = _form.FunnyChapter12;
            _form.Chapter2.Text = "She faceplanted her desk.\r\n“I hate loops. I hate dogs. I hate sleep deprivation.”\r\nHer phone buzzed again. Amina again.\r\n“You won an award. ‘Most Unintentional Meme Supervillain of the Year.’”\r\n“Also, the FBI tweeted ‘pls stop \U0001f972.’”\r\nOutside, birds were chirping, but they sounded suspiciously like barking. The sun was shining. Her smart curtain displayed:\r\n“🌞 Good morning, Bug Queen. Loop #193 active.”\r\nShe opened her laptop one last time and stared into the abyss of her code.\r\nAnd the code... barked back.\r\n";
        }
        public override void EndingDisplay()
        {
            _form.ChapterYes2.Visible = false;

            _form.EndGame.Visible = false;
            _form.ScoreDisplayCover.Visible = false;
            _form.Chapter2.Visible = false;
            _form.FunnyStoryCover.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes3.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes2.Parent = _form.FunnyStoryCover;
            _form.ChapterNo1.Parent = _form.FunnyStoryCover;
            _form.ContinueStory.Parent = _form.FunnyStoryCover;
            _form.ContinueStory.Text = "Do you want to start the ending of \"The Bug That Broke The Internet\" ?";

        }

        public override void Ending1()
        {
            _form.FunnyStoryCover.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes3.Visible = false;
            _form.ChapterNo1.Visible = false;

            _form.NextBtn8.Visible = true;
            _form.EndGame.Visible = true;
            _form.Ending.Visible = true;
            _form.FunnyEnding.Visible = true;
            _form.NextBtn8.Parent = _form.FunnyEnding;
            _form.Ending.Parent = _form.FunnyEnding;
            _form.Ending.Text = "At 12:47 PM, Urooba was still in her pajamas — now decorated with three crumbs, two energy drink stains, and one emotional support sticker that read:\r\n“Keep Calm and Blame the Compiler.”\r\n\r\nShe stared at the code again. Not just stared — glared.\r\n“I’m not afraid of you, you spaghetti-scripted nightmare.”\r\n\r\nWith bloodshot eyes and a keyboard covered in snack debris, she took a deep breath and opened up the logs. The loop was still going strong. Still pinging the internet. Still mocking her.\r\n\r\nBut this time, she noticed something else.\r\nIn the thousands of repeating logs, there was a gap.\r\nA flicker. A skipped iteration.\r\n\r\n";

        }
        public override void Ending2()
        {
            _form.NextBtn8.Visible = false;
            _form.NextBtn9.Visible = true;
            _form.NextBtn9.Parent = _form.FunnyEnding;

            _form.Ending.Parent = _form.FunnyEnding;
            _form.Ending.Text = "Her fingers twitched. “There. That’s it.”\r\n\r\nShe realized the loop wasn’t unbreakable — it was timed. The bot had to sleep, just like everything else on the internet. For 0.003 seconds every 10,000 cycles, it blinked.\r\n\r\nThat was her window.\r\n\r\nHeart pounding, she readied her script. A shutdown override, injected through that fleeting vulnerability.\r\n\r\nShe waited. And when the time was right — she launched it.\r\n\r\nThe terminal froze. The meme loop paused.\r\n\r\nThe room went silent.\r\nNo more meme sounds.\r\nNo barking printers.\r\nNo drones blasting “Such wow.”\r\nJust… peace.";
        }
        public override void Ending3()
        {
            _form.NextBtn9.Visible = false;
            _form.Ending.Parent = _form.FunnyEnding;
            _form.Ending.Text = "A message popped up on her screen:\r\nSYSTEM STATUS: Restored\r\n\"All memes returned to their respective corners of the internet.\"\r\n\r\nUrooba collapsed back in her chair, eyes glazed, fingers trembling.\r\n\r\nHer phone buzzed again. Amina:\r\n“You did it?! Netflix says congrats. They wanna name the series: Debugging Disaster: The Rise of the Bug Queen.”\r\n\r\nShe replied with a single emoji:\r\n💀\r\n\r\nFrom outside, a small child pointed at her window.\r\n“Mummy, look! The lady who made the TV say ‘Such Bug!’”\r\n\r\nUrooba smiled faintly and whispered:\r\n“I fixed it. I fixed it all.”\r\n\r\nThe printer printed one last message:\r\n“You win this time, Bug Queen. But memes never die.”\r\n\r\nShe tore it off, held it like a trophy, and finally — finally — went to sleep.\r\n\r\nTHE END ";
        }
    }
}

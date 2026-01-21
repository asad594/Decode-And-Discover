using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDiscovers
{
    internal class CrimeStory :Stories
    {
        private readonly Form1 _form;
        public CrimeStory(Form1 form) : base(form) => _form = form;


        //Story Background
        public override void StoryCoverDisplay()
        {
            _form.StoryCover.Visible = false;
            _form.EndGame.Visible = true;
            _form.CrimeStoryCover.Visible = true;
            _form.StartBtn.Visible = true;

            _form.StartBtn.Parent = _form.CrimeStoryCover;
        }
        public override void StoryBackground()
        {
            _form.CrimeStoryCover.Visible = false;
            _form.StartBtn.Visible = false;
            _form.NextBtn.Visible = true;
            _form.CrimeBack1.Visible = true;
            _form.StoryBackground.Visible = true;

            _form.NextBtn.Parent = _form.CrimeBack1;
            _form.StoryBackground.Parent = _form.CrimeBack1;
            _form.StoryBackground.Text = "Urooba wasn't a detective. She wasn’t a hacker. She wasn’t even a curious person by nature.\r\nShe just fixed old laptops in a dusty second-hand repair shop on the edge of the city.\r\nThe kind of shop no one noticed anymore. No signs. No customers under thirty. \r\nJust forgotten tech and forgotten stories. But one rainy Wednesday afternoon, a man walked in. \r\nNo name. No small talk. Just an old silver laptop with a single request:\r\n\r\n“Can you wipe it clean? No backups. No questions.”\r\n\r\nHe paid in cash. Left no contact. The laptop had a faint scratch on the lid — like someone \r\nhad tried to file down a serial number. That should’ve been the first red flag. But work was work.\r\n";
        }
        public override void StoryBackground1()
        {
            _form.CrimeBack1.Visible = false;
            _form.NextBtn.Visible = false;
            _form.NextBtn1.Visible = true;
            _form.CrimeBack2.Visible = true;

            _form.NextBtn1.Parent = _form.CrimeBack2;
            _form.StoryBackground.Parent = _form.CrimeBack2;
            _form.StoryBackground.Text = "Urooba plugged it in, booted into safe mode, and opened the file explorer. It was almost empty.\r\nNo personal photos. No saved passwords. No apps.\r\nJust one folder buried deep in a chain of system logs:\r\n\r\nSystem>Temp>Cache>Unknown>DO_NOT_OPEN\r\n\r\nShe knew better. She should’ve closed it.   But something about the folder felt... wrong. \r\nLike it was trying to hide.Inside, there was a single file:\r\nrecording_14_lastchance.mp4\r\n\r\nThe icon flickered. Just once.\r\n";
        }
        public override void StoryBackground2()
        {
            _form.CrimeBack2.Visible = false;
            _form.NextBtn1.Visible = false;
            _form.NextBtn2.Visible = true;
            _form.CrimeBack3.Visible = true;

            _form.NextBtn2.Parent = _form.CrimeBack3;
            _form.StoryBackground.Parent = _form.CrimeBack3;
            _form.StoryBackground.Text = "She clicked.\r\n\r\nIt was grainy surveillance footage — timestamped 2:43 AM.\r\nA dark alley. Two figures. Muffled audio.\r\nAnd then—gunshots. A man dropped. The other ran.\r\nA voice off-screen whispered: \r\n\r\n“It’s done. No one will ever trace this.”\r\n\r\nThen the video ended.";
        }
        public override void StoryBackground3()
        {
            _form.CrimeBack3.Visible = false;
            _form.NextBtn2.Visible = false;
            _form.NextBtn3.Visible = true;
            _form.CrimeBack4.Visible = true;

            _form.NextBtn3.Parent = _form.CrimeBack4;
            _form.StoryBackground.Parent = _form.CrimeBack4;
            _form.StoryBackground.Text = "Urooba sat frozen.\r\nThe laptop fan hummed louder. The lights flickered in her shop.\r\n\r\nAnd before she could even close the file, the screen went black.\r\n\r\nSeconds later, the machine rebooted itself.\r\nThe folder was gone. The video? Erased.";
        }
        public override void StoryBackground4()
        {
            _form.CrimeBack4.Visible = false;
            _form.NextBtn3.Visible = false;
            _form.NextBtn4.Visible = true;
            _form.CrimeBack5.Visible = true;

            _form.NextBtn4.Parent = _form.CrimeBack5;
            _form.StoryBackground.Parent = _form.CrimeBack5;
            _form.StoryBackground.Text = "All that remained was a message flashing\r\nin red text:\r\n\r\n“We warned you. Now you’re part of it.”\r\n\r\nUrooba stared at the screen, heart pounding.\r\nShe realized this wasn't just some shady client hiding old files.\r\n\r\nShe had just opened something that wasn’t supposed to exist.\r\nEvidence.\r\nMurder.\r\nAnd now... her name might be next on the list.\r\n\r\nThe question wasn’t how to fix the laptop anymore.\r\nIt was: how to stay alive.";
        }

        //Story Chapters 1
        public override void ChapterCoverDisplay()
        {
            _form.EndGame.Visible = false;
            _form.CrimeBack5.Visible = false;
            _form.NextBtn4.Visible = false;
            _form.StoryBackground.Visible = false;
            _form.CrimeChapterCover1.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes1.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes1.Parent = _form.CrimeChapterCover1;
            _form.ChapterNo1.Parent = _form.CrimeChapterCover1;
            _form.ContinueStory.Parent = _form.CrimeChapterCover1;
            _form.ContinueStory.Text = "Do you want to start the new chapter 1 of \"The File That Shouldnt Exist\" ?";
        }

        public override void Chapter11()
        {
            _form.CrimeChapterCover1.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes1.Visible = false;
            _form.ChapterNo1.Visible = false;
            _form.EndGame.Visible = true;
            _form.CrimeChapter11.Visible = true;
            _form.Chapter1.Visible = true;

            _form.Chapter1.Parent = _form.CrimeChapter11;
            _form.Chapter1.Text = "Urooba didn’t sleep that night.\r\nThe message — “We warned you. Now you’re part of it.” — was still flashing in her mind, long after the screen went black. She’d pulled \r\nthe battery out. Disconnected the power. But her hands still shook.\r\nIt wasn’t just the footage. It was the feeling. Like the file had been alive.\r\nShe knew one thing: if that laptop could erase evidence that cleanly, it wasn’t an accident. It was \r\nprogrammed. Intentionally. Carefully. By someone who knew exactly what they were doing.\r\nThe next morning, Urooba pulled out her old dev tools. Not to fix the machine — but to read its code.\r\nShe wasn’t fluent in any particular language, but she knew enough syntax to spot patterns.\r\nShe created a live USB, booted into a forensic OS, and began digging. The laptop’s wipe wasn’t natural — the boot logs were tampered with. \r\nSomeone had overwritten the kernel hooks. That’s when she saw it: a script left behind in the temp partition.\r\nIt looked like a code — clean, commented, too confident.\r\nUrooba’s jaw clenched. The moment she connected to Wi-Fi, it had uploaded the video, then erased the file. And if there was a loop,\r\n it might still be watching.\r\n";
        }

        public override void Chapter12()
        {
            _form.Chapter1.Parent = _form.CrimeChapter11;
            _form.Chapter1.Text = "She examined the script more closely.\r\nIt had no try/except. No safety net. Just a direct, ruthless flow.\r\nA minimal function — just enough to destroy, not enough to explain.\r\n";
        }

        public override void Chapter13()
        {
            _form.CrimeChapter11.Visible = false;
            _form.CrimeChapter12.Visible = true;

            _form.Chapter1.Parent = _form.CrimeChapter12;
            _form.Chapter1.Text = "She noticed something else strange.\r\nThe script was named: “lambda_shadow.py”\r\nBut inside was a class — hidden inside a lambda.\r\nThat wasn’t normal. It wasn’t even efficient.\r\nIt was... deliberately misleading.\r\nShe decoded part of it:\r\nROT13. A simple cipher. Hiding real code in plain sight.\r\nShe ran a translation.\r\nWhat popped out was a list of folder names — not just hers. Dozens.\r\nEach had timestamps. And IPs.\r\nAnd each line ended with the same word: complete\r\nWere these all people who’d seen the same file?\r\n";
        }

        public override void Chapter14()
        {
            _form.Chapter1.Parent = _form.CrimeChapter12;
            _form.Chapter1.Text = "Urooba now understood:\r\nThis wasn’t a simple data wipe script. It was a chain reaction.\r\nIf you opened the file, your system became part of the process.\r\nYou didn’t just view evidence. You became the evidence.\r\nAnd it was built with terrifying simplicity.\r\nShe traced one of the IP addresses. A closed server in Berlin. The registry had been anonymized. But the server name gave her chills:\r\ninit_murdertrail_core_01\r\n";
        }

        public override void Chapter15()
        {
            _form.CrimeChapter12.Visible = false;
            _form.CrimeChapter13.Visible = true;

            _form.Chapter1.Parent = _form.CrimeChapter13;
            _form.Chapter1.Text = "She shut her laptop, heart racing again. She was too deep already.\r\nThe code wasn’t elegant. It was brutal.\r\nWritten like a weapon — fast, light, and with no room for mercy.\r\nAnd as she stared at her cracked window, she noticed something else:\r\nA black car was parked across the street. No one inside. Just idle. Watching.\r\n";
        }

        public override void Chapter16()
        {
            _form.Q5opt1.Visible = false;
            _form.Q5opt2.Visible = false;
            _form.Q5opt3.Visible = false;
            _form.Q5opt4.Visible = false;
            _form.CodeQuestion1.Visible = false;
            _form.NextBtn5.Visible = true;

            _form.NextBtn5.Parent = _form.CrimeChapter13;
            _form.Chapter1.Parent = _form.CrimeChapter13;
            _form.Chapter1.Text = "Urooba took a slow breath.\r\nThis wasn’t about a file anymore. It was about a system.\r\n\r\nA system that didn’t just cover up crimes. It erased the people who noticed them.\r\n\r\nAnd Urooba had just entered the syntax of something much darker than code.\r\nShe was now part of a program.\r\n\r\nOne that didn’t allow debugging.\r\nOnly termination.";
        }
        //Story Chapters 2
        public override void ChapterCoverDisplay1()
        {
            _form.HarderMeme1.Visible = false;
            _form.GoodMeme1.Visible = false;
            _form.AverageMeme1.Visible = false;
            _form.EndGame.Visible = false;
            _form.ScoreDisplayCover.Visible = false;
            _form.Chapter1.Visible = false;
            _form.CrimeChapterCover1.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes2.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes2.Parent = _form.CrimeChapterCover1;
            _form.ChapterNo1.Parent = _form.CrimeChapterCover1;
            _form.ContinueStory.Parent = _form.CrimeChapterCover1;
            _form.ContinueStory.Text = "Do you want to start the new chapter 2 of \"The File That Shouldnt Exist\" ?";

        }

        public override void Chapter21()
        {
            _form.CrimeChapterCover1.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes2.Visible = false;
            _form.ChapterNo1.Visible = false;
            _form.EndGame.Visible = true;
            _form.CrimeChapter21.Visible = true;
            _form.Chapter2.Visible = true;

            _form.Chapter2.Parent = _form.CrimeChapter21;
            _form.Chapter2.Text = "Urooba stayed away from the windows.\r\nThe car outside hadn’t moved.\r\nShe thought about calling someone. The police? No—what would she say?\r\n\"Hi, I saw a video of a murder, it vanished, and now my laptop talks to me in red text?\"\r\nThey’d laugh. Or worse… they’d believe her. And she wasn’t ready for what came next.\r\nSo instead, she dug deeper.\r\nBack into the code.\r\nIt had no break condition.\r\nNo exit().\r\nNo pause.\r\nJust infinite watching.\r\n";
        }

        public override void Chapter22()
        {
            _form.Chapter2.Parent = _form.CrimeChapter21;
            _form.Chapter2.Text = "It checked the user’s clipboard, downloads, even keystrokes.\r\nA condition.\r\nA digital tripwire.\r\nIf she even searched for the video again… it would know.\r\n";
        }

        public override void Chapter23()
        {
            _form.Chapter2.Parent = _form.CrimeChapter21;
            _form.Chapter2.Text = "Urooba felt her stomach twist. The code wasn’t just tracking file paths. It was watching behavior.\r\nMonitoring for curiosity. And anyone who went too deep?\r\nexecute_next() was the final step.\r\nShe traced that function next. It included system shutdown, screen lock, VPN wipe... and something else.\r\nThis was more than surveillance. It was a trap.\r\nA way to burn everything behind — and then pretend it never existed.";
        }

        public override void Chapter24()
        {
            _form.CrimeChapter21.Visible = false;
            _form.CrimeChapter31.Visible = true;

            _form.Chapter2.Parent = _form.CrimeChapter31;
            _form.Chapter2.Text = "Suddenly, her fan kicked on again. Too loud. Too soon.\r\nA new line appeared on the screen, blinking:\r\nloop_active: TRUE\r\nnext_trigger: pending\r\nUrooba’s heart raced. Was it watching her now? Was she already in the condition?\r\nShe yanked the LAN cable out. Disabled Wi-Fi. Tried to kill the process — but it wouldn’t close.\r\nThe screen flickered.\r\nACCESS DENIED.\r\nThen another line appeared: \"you looped yourself in.\"";
        }
        public override void Chapter25()
        {

            _form.Chapter2.Parent = _form.CrimeChapter31;
            _form.Chapter2.Text = "She slammed the laptop shut. The black car outside?\r\nGone. But something told her she wasn’t alone.\r\nThat this wasn’t just software. It was networked. Distributed.\r\nBuilt to spread through conditions — not just code. And if she was now part of the loop…\r\nShe had two options: Break the cycle. Or become its next output.\r\n";
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
            _form.NextBtn7.Parent = _form.CrimeChapter31;
            _form.Chapter2.Parent = _form.CrimeChapter31;
            _form.Chapter2.Text = "...no single point of failure.\r\n\r\nBut just before she hit upload, a new window popped open in the corner of her screen. No system prompt. No terminal.";
        }
        public override void EndingDisplay()
        {
            _form.ChapterYes2.Visible = false;
            _form.HarderMeme2.Visible = false;
            _form.GoodMeme2.Visible = false;
            _form.AverageMeme2.Visible = false;
            _form.EndGame.Visible = false;
            _form.ScoreDisplayCover.Visible = false;
            _form.Chapter2.Visible = false;
            _form.CrimeChapterCover1.Visible = true;
            _form.ContinueStory.Visible = true;
            _form.ChapterYes3.Visible = true;
            _form.ChapterNo1.Visible = true;

            _form.ChapterYes3.Parent = _form.CrimeChapterCover1;
            _form.ChapterNo1.Parent = _form.CrimeChapterCover1;
            _form.ContinueStory.Parent = _form.CrimeChapterCover1;
            _form.ContinueStory.Text = "Do you want to start the ending of \"The File That Shouldnt Exist\" ?";

        }

        public override void Ending1()
        {
            _form.CrimeChapterCover1.Visible = false;
            _form.ContinueStory.Visible = false;
            _form.ChapterYes3.Visible = false;
            _form.ChapterNo1.Visible = false;

            _form.NextBtn8.Visible = true;
            _form.EndGame.Visible = true;
            _form.Ending.Visible = true;
            _form.CrimeEnding.Visible = true;
            _form.NextBtn8.Parent = _form.CrimeEnding;
            _form.Ending.Parent = _form.CrimeEnding;
            _form.Ending.Text = " Just plain white text on a black background:\r\n“You were warned.”\r\n\r\nHer cursor froze. The screen began flickering—one file vanishing after the next. She scrambled, locking the compressed folder in a hidden, \nread-only partition. Wrote a quick redirect command. Triggered a decoy bootloader.\r\n\r\nToo late.\r\n\r\nThe connection dropped. Her system started shutting down.\r\n\r\nBut Urooba was already on her second machine.\r\nAir-gapped. No Wi-Fi. No ethernet.\r\nShe plugged in the flash drive with the last copy.\r\nAnd hit run on her counter-script — the one she’d been secretly building for days.\r\n\r\nIt mimicked the behavior of the original virus… but inverted it.\r\n\r\nInstead of deleting evidence, it spread it.\r\nInstead of hiding files, it broadcast them — to old BBS boards, encrypted blogs, onion links.";

        }
        public override void Ending2()
        {
            _form.NextBtn8.Visible = false;
            _form.NextBtn9.Visible = true;
            _form.NextBtn9.Parent = _form.CrimeEnding;

            _form.Ending.Parent = _form.CrimeEnding;
            _form.Ending.Text = "Each copy hidden under fake extensions: .docx, .mp3, .svg.\r\nThe footage was out. The murders — untraceable until now — were in the wild.\r\n\r\nThen, her second screen blinked. Another line of text appeared:\r\n\r\n“We see you.”\r\n“You started a loop we can’t close.”\r\n\r\nShe replied into the terminal:\r\n\r\n“Good. Let it run.”\r\n\r\nShe wiped both machines clean.\r\nTossed the drives into the fire barrel behind her shop. 5Watched as the plastic hissed, curled, and turned to ash.\r\n\r\nThe next morning, the car was gone.\r\n\r\nBut so was her name from the flagged users list.\r\nHer script had replaced her with a new alias: observer_404 — untraceable.\r\n\r\nShe’d done it.\r\nNot by hacking. Not by fighting.\r\nBut by out-debugging the darkness.";
        }
        public override void Ending3()
        {
            _form.NextBtn9.Visible = false;
            _form.Ending.Parent = _form.CrimeEnding;
            _form.Ending.Text = "Urooba stepped into the early light of morning.\r\nThe city was waking.\r\nSomewhere, someone would try to hide again.\r\nBut now… the code was broken.\r\nThe cycle wasn’t clean anymore.\r\nAnd Urooba?\r\n\r\nShe wasn't just part of it.\r\nShe was the glitch.\r\nThe one thing they hadn’t debugged.\r\n\r\nAnd she was just getting started.\r\n\r\nEND.";
        }
    }
}

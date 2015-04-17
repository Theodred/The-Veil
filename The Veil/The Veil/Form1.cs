using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace The_Veil
{
    
    public partial class Veil : Form
    {
        PictureBox pb_anno = new PictureBox();
        PictureBox pb_celeb1 = new PictureBox();
        PictureBox pb_celeb2 = new PictureBox();
        PictureBox pb_celeb3 = new PictureBox();
        PictureBox pb_celeb4 = new PictureBox();
        PictureBox pb_celeb5 = new PictureBox();
        PictureBox pb_celeb6 = new PictureBox();
        int x = Screen.PrimaryScreen.Bounds.Width;
        int y = Screen.PrimaryScreen.Bounds.Height;
        TextBox tb_Name = new TextBox();
        Label label_Name = new Label();
        Button button_Identify = new Button();
        
        RichTextBox rtb_ChoiceA = new RichTextBox();
        RichTextBox rtb_ChoiceB = new RichTextBox();
        RichTextBox rtb_ChoiceC = new RichTextBox();
        RichTextBox rtb_SideKick = new RichTextBox();
        RichTextBox rtb_Story = new RichTextBox();
        RichTextBox rtb_Welcome = new RichTextBox();

        string choice;
        string[] text = new string[400000];

        int story_counter = new int();

        Button restart = new Button();
        Button goto_MainMenu = new Button();

        
        public Veil()
        {
            InitializeComponent();
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\Users\Theodred\Desktop\The Veil\Resources\soundtrack.mp3";
            wplayer.controls.play();
            this.BackColor = Color.Black;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            label_Welcome.ForeColor = Color.White;            

            label_Welcome.Location = new Point(x / 2 - label_Welcome.Size.Width / 2, 50);

            button_Start.Location = new Point(1 * x / 3 - 30 - button_Start.Size.Width, y - 100);
            //button_HowTo.Location = new Point(2 * x / 3 - 100 - button_HowTo.Size.Width, y - 100);
            button_AboutTheVeil.Location = new Point(3 * x / 3 - 100 - button_AboutTheVeil.Size.Width, y - 100);

            button_Start.BackColor = Color.Black;
            button_Start.ForeColor = Color.White;

           // button_HowTo.BackColor = Color.Black;
            //button_HowTo.ForeColor = Color.Red;

            button_AboutTheVeil.BackColor = Color.Black;
            button_AboutTheVeil.ForeColor = Color.White;

            panel_Welcome.BackColor = Color.Black;
            panel_Welcome.Location = new Point(label_Welcome.Location.X-50,label_Welcome.Location.Y+200);
            panel_Welcome.Size = new Size(label_Welcome.Location.X+label_Welcome.Size.Width-100, button_AboutTheVeil.Location.Y-label_Welcome.Location.Y-250);

            this.Focus();
        }

        private void Veil_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case (char)Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void Veil_KeyPress(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        
        private void button_AboutTheVeil_Click(object sender, EventArgs e)
        {
            rtb_Welcome.Location = new Point(0,0);
            rtb_Welcome.Size = panel_Welcome.Size;

            rtb_Welcome.BackColor = Color.Black;
            rtb_Welcome.Visible = true;

            rtb_Welcome.KeyPress += Veil_KeyPress;

            panel_Welcome.Controls.Add(rtb_Welcome);
            panel_Welcome.Visible = true;

            rtb_Welcome.BorderStyle = BorderStyle.None;

            rtb_Welcome.ReadOnly = true;

            rtb_Welcome.ForeColor = Color.White;
            rtb_Welcome.Font = new Font("Century Gothic",22);
            rtb_Welcome.Text = "	Time is unpredictable. Every little detail matters. The world is a puzzle in which everything is connected. Therefore, the future is also...upredictable, as it strictly depends on time. You, as an individual, are surrounded by an overwhelming amount of choices every second, hour, day...technically, all your life. Think about all the possibilities! And you know that, no matter what you do, you influence the future one way or another. Even the fact that you breathe has that effect. You consume oxigen in a world that is short on oxigen. Consequently, the same rules apply for a community, a society, nations, humanity.\r	Tomorrow, the world could be changed by a revolutionary scientist or by the revolution of a nation.\r	Therefore, predicting the future is impossible.The likelyhood of your failling is immense. For all we know, there could be thousands of alternative 'futures' happening at the same time.\r	For instance, in one you...well...\r															...you'll see in the game.";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            

            
            
            restart.Visible = false;
            goto_MainMenu.Visible = false;
            rtb_ChoiceA.Visible = false;
            rtb_ChoiceB.Visible = false;
            rtb_ChoiceC.Visible = false;

            choice = "";
            story_counter = 0;

            //text[]="";

            text[1] = "\r\r     As you woke up, the image of the pen you saved haunted your memory. You somehow feel that, perhaps, it could have been a message. You think about what it could have meant, and you reach the conclusion that:";
            text[11] = "\r\r        You realize that the world you live in is full of events. Somehow you could take advantage of this. The media is thought to be corrupted, but what if… you had something to say as well? Therefore, you chose to follow a career in the field of journalism. You find a job at a local newspaper and slowly, in time, you climb the ladder of success, reaching a top position in a well-known daily journal. One day, you manage to find a reliable source of information that tells you about a terrible event.  However, making it public would affect some very influential people and you could lose your job. What do you do?";
            text[13] = "\r\r        How about…being a professor? You like having control. You’re influential. Technically, the future of a generation ( multiple generations, actually) is in your hands! Therefore, you study, you work hard, and you succeed! You are a brilliant professor at a top high school. With time, however, you are no longer impressed by the younger minds and everything seems to follow a pattern. And you are comfortable with that pattern, the familiarity. Monotony keeps you in control.  Yet, one day, you notice one student sitting at the back of the class that was not paying attention to your teaching, but staring through the window. What do you decide to do about it?";
            text[111] = "\r\r       Nuclear bombs. Despite of them being forbidden, a village in North Korea was a soon-to-be victim of a Russian attack. Millions of lives would have been lost, not to speak about a Third World War. The information that you provided the world would saved it from another episode of mass destruction. However,  before the government should take action, you are summoned in order to prove that all that you say is true. You have the proof, but your life is threatened. What do you chose to do?";
            text[113] = "\r\r       The purpose excuse the means, right? All you need is fame and publicity. It doesn’t matter how you achieve that! Therefore, you decide to modify the information so as it would attract attention, but not be of any use whatsoever. Ambiguity and generalisation, that is your weapon. However, as soon as the newspapers reach the stores, one of the people that you fear calls you and makes you an offer. In exchange for a sum of money, they  could use you as a mean to cover their action and keep the media away. What do you do?";
            text[1111] = "\r\r       The government is convinced. The bombs are found and disarmed. No war, no bloodshed. You are protected from the people that threatened your life and considered a national hero. You have saved the world and assured its peace for a little longer.";
            text[1113] = "\r\r       Because you fear for your life, you declare that all you wanted was publicity. You are made to pay a fine, and trust in journalism is lost forever. Russia launches the bombs and attacks North Korea. As a response, North Korea starts WWIII. Another period of mass destruction and bloodshed has fallen over the world.";
            text[1131] = "\r\r       Your dream is coming to life!  Nonetheless, they use you to cover up the fact that they want to start another war. They are business men, this is what they do, find sources of profit. They don’t care about the means, just like you. Because of your articles, dictated by those men, North Korea declares war. As there was already some political tension, alliances are formed almost immediately and battles commence. All because of a story you wrote…";
            text[1133] = "\r\r       You realize that something is wrong. You come to your senses and decide to tell the police everything, as you suspect that the situation could aggravate.  A week after you do this, you find out that they were plotting to prove the existence of nuclear bombs in Russia, which was an allegation. They hoped to start another war in order to obtain profit. And you prevented it all!";
            text[131] = "\r\r       You decide not to intervene. Perhaps it is a personal problem. Why should you care? It is not a part of your job description to control tantrums. You just have to teach them, if they do not want to listen, it is their problem. Nevertheless, the student’s situation seems to aggravate every week, until he skips school for two days. What do you do?";
            text[133] = "\r\r       You care about your students. Therefore, at the end of the class, you decide to ask him if everything was alright with him. As if you lifted an enormous weight  off his shoulders, he tells you that he trusts you and that he was wondering if you could help him. He realized that the internet was a profitable place and that hacking could be a fruitful business, but was not sure if he was up to it or not. As it is your field of expertise, he asks you for advice. What do you tell him?";
            text[1311] = "\r\r       As you call your parents, they tell you that he refuses to go to school and they invite you over to talk to him. Because you are intrigued, you decide to offer your help. You find him in his room, barely wanting to talk. But, eventually, he confesses that some wealthy people made him a proposition; they offered him financial help in return for his services. He was supposed to hack into NASA’s servers and delete some critical information that could help eradicate the world’s financial problems. At the end of your talk, you convince him not to accept the offer and you promise to help him in return.";
            text[1313] = "\r\r       Next week, he returns to school and you ask him what happened. He said he had a personal problem and you carry on with the class. However, later that day, you hear on the news that Gary McKinnon has hacked into NASA’s network and caused massive damage, compromising data regarding nuclear research and free energy,  making the latter no longer possible. Gary McKinnon is your student.";
            text[1331] = "\r\r       Instead of making him quit, he decided to prove you wrong. He admired you and hoped that you would support him. However, you became his greatest motivation. During his remaining time in school, he no longer bothers you. After 2 years, you hear on the news  that a new virus is spreading like wildfire, gathering information and stealing money. It also caused critical data from FBI’s and NASA’s networks to disappear. Someone obtained that information and sold it to anonymous people around the globe. Free energy and space exploration will never be possible again. Also, most wanted criminals are on the loose, as what kept them behind bars no longer exists. And the person who did all this was…your student.";
            text[1333] = "\r\r       You have a long talk with your student about ethics and what is wrong. However, you do not want to disappoint him and you offer a solution: security. You point out its advantages and how profitable it is. He seems convinced, and during his remained time in school he meets you after class for private lessons. After 2 years, you hear on the news that your student has developed a revolutionary anti-virus that is able to protect a computer from any kind of virus. From now on, the internet will be a safe place and all threats shall be forgotten.";
            text[14] = "Perhaps you should start writing;";
            text[15] = "Maybe your future should be academic;";
            text[114] = "You publish it anyway, because it could save lives.";
            text[115] = "You decide that your job matters more.";
            text[1114] = "Put world peace in front of your life;";
            text[1115] = "Consider your life more valuable and decide to call everything off;";
            text[1134] = "Accept the offer gladly;";
            text[1135] = "Tell the police everything;";
            text[134] = "Ignore him; it’s his problem if he doesn’t pay attention.";
            text[135] = "Talk to him and see if there if a problem;";
            text[1314] = "Call his parents – perhaps something is wrong;";
            text[1315] = "Ignore the situation, it’s just a student out of many;";
            text[1334] = "Hacking takes time and great skill; you are barely a junior, you cannot handle that!";
            text[1335] = "Why not consider cyber security as a job in your future? ";
            text[2] = "\r\r       You realize that you have chosen the ruler because it represents something exact. Numbers. Material things. You believe in what you see and feel around you, and you look for ways of improvement or explanation. As a result, one day you decide to:";
            text[24] = "Explore the world and understand it;";
            text[25] = "Accumulate information and use it for a purpose;";
            text[21] = "\r\r       Nature appeals to you. You spend more and more time outside and you notice symmetry everywhere. You begin to wonder how it could be possible, where did it all come from? Where did we come from? One day, you decide to:";
            text[214] = "You search for answers with the help of science;";
            text[215] = "You search for answers with the help of religion;";
            text[211] = "\r\r       You notice that most animals are similar to each other. Common features and instincts, lifestyle and so on. You start wondering why that happens, and you begin studying anatomy and related sciences in the search for an answer. After years of hard work and research, you come to a result with which the people that surround you disagree violently. They tell you that it is completely wrong and that you might lose everything that you have because of it. What do you do?";
            text[2114] = "You publish your theories anyway;";
            text[2115] = "You decide that it is too risky, and look for other explanations;";
            text[2111] = "\r\r       As you are Charles Darwin, you have just revolutionised the way the world looks upon the apparition of human beings forever. You made men question religion and search for further explanations in science. You made possible a crucial turn in human mentality.";
            text[2113] = "\r\r       After a few weeks,  you hear a man giving a speech in the street, trying to convince people that our ancestors were aliens. Your theory would have helped people know the truth, but now nobody would believe you and young minds are being brainwashed.";
            text[213] = "\r\r       After years and years of studying different religions, you decide that none are accurate. You decide that what the people need is a new, revolutionary faith that will help them evolve and develop. Therefore, you:";
            text[2134] = "Put your faith in science;";
            text[2135] = "Become the prophet of your newly born religion;";
            text[2131] = "\r\r       You abandon religion completely and rely on science for explanations. After years of questions, trial and error, an enormous amount of research and incredibly creativity, you discover gravity. This will turn out to be a major catalyst for science, as you have just built the foundations of mechanics, as your name will remain in history as Sir Isaac Newton .";
            text[2133] = "\r\r       You know that religion is the biggest weapon that society has. Thus, you start spreading  new theories and assumptions around, building a web of questions of which only you have the answer. This way, you become the centre of a newly formed religion, as people have the faith that you will solve all their problems. As you preach that your religion is the only true one, your followers try to convince other “non-believers” to trust you. In time, this evolved into a religious war, as a result of which the only remaining faith will be yours.";
            text[23] = "\r\r       You realize the value of your surroundings and history. However, you’re aware of the importance of evolution and, as a result, you’re constantly looking for way of improvement. However, you decide that what you need is:";
            text[234] = "To help your country;";
            text[235] = "To improve the quality of your life;";
            text[231] = "\r\r       As your country is at war, you’re looking for a way to help your nation be victorious. Therefore, you focus your research and work on developing a revolutionary weapon. After a year, you have found what you are looking for, but you realize that it is extremely dangerous. However, you choose to:";
            text[2314] = "Share your discovery with your country;";
            text[2315] = "Keep it to yourself until the war is over;";
            text[2311] = "\r\r       Your patriotic spirit won, and your discovery, the nuclear bomb, has been proved to be crucial in the battle. Because of you, Germany has won the Second World War and a new world order will be put in place.";
            text[2313] = "\r\r       You fear the consequences of Germany using a nuclear bomb in the battle, and you decide to keep it hidden until the war is over. However, you are killed in the war and your house is destroyed. The world will never know about your work and nuclear power  will remain utopian forever.";
            text[233] = "\r\r       You are aware of the fact that your lifestyle could be improved greatly. Therefore, you start looking for deficiencies, for things that are out of place. However, you realize that:";
            text[2334] = "People waste what they have ";
            text[2335] = " Men can be gods.";
            text[2331] = "\r\r       You chose to find a way of reducing the amount of materials that we consume. Thus, you invent methods of recycling, preventing the planet for collapsing earlier and helping humanity understand the importance of our environment.";
            text[2333] = "\r\r       You create the first successful clone and change people’s life forever. Now, people can only focus on research while clones do everything else and soon, humanity will be able to live on other planets, as Earth’s “life” is close to an end.";
            text[3] = "\r\r       You realize that knowledge is power. And there is no better way of obtaining information than books. Therefore, you decide to read. However, you notice 2 books on the shelf. Which one do you chose?";
            text[34] = "'The Importance of art in a society'";
            text[35] = "'Electric Drive Systems and Operation'";
            text[31] = "\r\r       You think that the world could be improved through art and beauty. You already enjoy painting, thus you decide to go to the Academy of Fine Arts. However, you fail. what do you chose to do next?";
            text[314] = "you turn art into a means of making a living";
            text[315] = "decide to do something else with your life";
            text[311] = "\r\r       Even though you have not been accepted into the Accademy, you still decide to use arts to improve your life. However, what you believe in is:";
            text[3114] = "Art requires a revolution";
            text[3115] = "Freedom of expression is worth fighting for.";
            text[3111] = "\r\r       You set the trend of modern art. You create Monochrome Painting, changing the way in which people look at art. Many will find your art futuristic, others will find it pointless. Either way, you revolutionize artistry for ever.";
            text[3113] = "\r\r       You see that nowadays, freedom of expresion is no longer valued and that it is violated by certaing standards created by the society. Hence, you develop a new genre that rejects prior definitions of art and questions in general, Anti-Art.";
            text[313] = "\r\r       You're angry on the society. You feel like you are an outcast, that you no longer have a place in your community. What do you do?";
            text[3134] = "You try to impose your point of view";
            text[3135] = "You try to inspire other people so that they think like you";
            text[3131] = "\r\r       You join the army and gradually climb up the career ladder. As you reach the top, you command everyone to act as you want and the consequences as great, as you become Adolf Hitler.";
            text[3133] = "\r\r       You create your own world through philosophy and knowledge and you become more and more influential. On account of this, you manage to free India from being a British colony.";
            text[33] = "\r\r       You think that through technology, life and people will be improved dramatically. However, if there is to be technology, there has to be power. Thus, you decide to:";
            text[334] = "Improve what you already have";
            text[335] = "Find new improvements";
            text[331] = "\r\r       You believe that people nowadays focus on the wrong things and you may have the power to do that. Thus, you:";
            text[3314] = "Want to lower living costs";
            text[3315] = "Want to prevent Earth's destruction";
            text[3311] = "\r\r       Aftercountless hours of studying and research, lots of mistakes and errors, you defy popular opinions and produce free energy. This way, everyone would have it, no matter of their financial means, as in today's society, electricity is a necessity.";
            text[3313] = "\r\r       The damage that people cause on nature made you rely on nature for answers. This way, you discover the Solar Power and create Solar Pannels. Soon, the Electricity industry will be changed forever.";
            text[333] = "\r\r       What if humanity would go further?	You think that instead of focusing on what we have, we could create something new, starting from it. Thus, you think about:";
            text[3334] = "Making information more available";
            text[3335] = "Find a soluion to a everlasting problem.";
            text[3331] = "\r\r       Information should be free and available to everyone. That is why you created Wikipidia, a ste that changes the world people learn forever.";
            text[3333] = "\r\r       In an attempt to cure malaria, you discover that by synthetizing quinine for the actual cure, you can obtian a purple mixture. On account of that, you create the purple dye ( William Perkin)";

            label_Welcome.Location = new Point(x / 2 - label_Welcome.Size.Width / 2, 50);            

            panel_Welcome.Visible = false;
            button_Start.Visible = false;
            button_HowTo.Visible = false;
            button_AboutTheVeil.Visible = false;
            label_Welcome.Visible = false;
            

            rtb_Story.Location = new Point(200, 50);
            rtb_Story.Size = new Size(1000,500);
            rtb_Story.BackColor = Color.Black;
            rtb_Story.ReadOnly = true;
            rtb_Story.BorderStyle = BorderStyle.None;
            rtb_Story.Text = "      You are in a poorly lit room. As you look around, searching for something familiar, you notice a small table and a chair. As you slowly approach it, you notice that there are four objects on the table. A pen, a ruler, a book and a brush.  \r\r       Somehow, the room gradually lights up and you feel that everything is disappearing. However, right before the room turned into nothing, you managed to grab one object from the table and you squeeze it firmly in your fist. \r\r        As you look down, you realize that what you decided to save was:";
            rtb_Story.ForeColor = Color.White;
            rtb_Story.Font = new Font("Century Gothic", 25);
            rtb_Story.Visible = true;

            this.Controls.Add(rtb_Story);

            rtb_SideKick.Location = new Point(1400, 50);
            rtb_SideKick.Size = new Size(400,950);
            rtb_SideKick.BackColor = Color.Black;
            rtb_SideKick.BorderStyle = BorderStyle.None;
            rtb_SideKick.Visible = true;

            this.Controls.Add(rtb_SideKick);
            

            rtb_ChoiceA.Location = new Point(200, 550);
            rtb_ChoiceB.Location = new Point(600, 550); 
            rtb_ChoiceC.Location = new Point(1000, 550);
            rtb_ChoiceA.Size = new Size(250, 200);
            rtb_ChoiceB.Size = new Size(250, 200);
            rtb_ChoiceC.Size = new Size(250, 200);
            rtb_ChoiceA.BackColor = Color.Black;
            rtb_ChoiceB.BackColor = Color.Black;
            rtb_ChoiceC.BackColor = Color.Black;
            rtb_ChoiceA.ReadOnly = true;
            rtb_ChoiceA.BorderStyle = BorderStyle.None;
            rtb_ChoiceA.Text = "The pen";
            rtb_ChoiceA.ForeColor = Color.White;
            rtb_ChoiceA.Font = new Font("Century Gothic", 20);
            rtb_ChoiceB.ReadOnly = true;
            rtb_ChoiceB.BorderStyle = BorderStyle.None;
            rtb_ChoiceB.Text = "The ruler";
            rtb_ChoiceB.ForeColor = Color.White;
            rtb_ChoiceB.Font = new Font("Century Gothic", 20);
            rtb_ChoiceC.ReadOnly = true;
            rtb_ChoiceC.BorderStyle = BorderStyle.None;
            rtb_ChoiceC.Text = "The book";
            rtb_ChoiceC.ForeColor = Color.White;
            rtb_ChoiceC.Font = new Font("Century Gothic", 25);

            this.Controls.Add(rtb_ChoiceA);
            this.Controls.Add(rtb_ChoiceB);
            this.Controls.Add(rtb_ChoiceC);

            rtb_ChoiceA.Visible = true;
            rtb_ChoiceB.Visible = true;
            rtb_ChoiceC.Visible = true;
            rtb_ChoiceA.Enabled = true;
            rtb_ChoiceB.Enabled = true;
            rtb_ChoiceC.Enabled = true;
           
            rtb_ChoiceA.Click += rtb_ChoiceA_Click;
            rtb_ChoiceB.Click += rtb_ChoiceB_Click;
            rtb_ChoiceC.Click += rtb_ChoiceC_Click;

            rtb_ChoiceA.KeyPress += rtb_ChoiceA_KeyPress;
            rtb_ChoiceB.KeyPress += rtb_ChoiceB_KeyPress;
            rtb_ChoiceC.KeyPress += rtb_ChoiceC_KeyPress;
            rtb_Story.KeyPress += rtb_Story_KeyPress;
            rtb_SideKick.KeyPress += rtb_SideKick_KeyPress;

            
            
        }

        void rtb_SideKick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        void rtb_Story_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        void rtb_ChoiceC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        void rtb_ChoiceB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        void rtb_ChoiceA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
 
       
        void rtb_ChoiceA_Click(object sender, EventArgs e)
        {
            story_counter++;
            choice += "1";

            rtb_Story.Text = text[Convert.ToInt32(choice)];
            rtb_ChoiceA.Text = text[Convert.ToInt32(choice+"4")];
            rtb_ChoiceC.Text = text[Convert.ToInt32(choice+"5")];

            rtb_ChoiceB.Visible = false;
            if(choice.Length>= 4)
            {
                choice = "";
            }
            if (story_counter == 4)
            {
               
                rtb_ChoiceA.Visible = false;
                rtb_ChoiceC.Visible = false;

                restart.Location = rtb_ChoiceA.Location;
                restart.Size = rtb_ChoiceA.Size;
                restart.Text = "Restart";
                restart.ForeColor = Color.White;
                restart.BackColor = Color.Black;
                restart.Font = new Font("Century Gothic", 25);
                restart.Visible = true;



                //this.Controls.Add(restart);
                

                goto_MainMenu.Location = rtb_ChoiceC.Location;
                goto_MainMenu.Size = rtb_ChoiceA.Size;
                goto_MainMenu.Text = "Main Menu";
                goto_MainMenu.ForeColor = Color.White;
                goto_MainMenu.BackColor = Color.Black;
                goto_MainMenu.Font = new Font("Century Gothic", 25);
                goto_MainMenu.Visible = true;

                //this.Controls.Add(goto_MainMenu);


                restart.Click += button_Start_Click;
                
                goto_MainMenu.Click += goto_MainMenu_Click;

            }
        }

     

        void rtb_ChoiceB_Click(object sender, EventArgs e)
        {
            story_counter++;
            choice += "2";

            rtb_Story.Text = text[Convert.ToInt32(choice)];
            rtb_ChoiceA.Text = text[Convert.ToInt32(choice+"4")];
            rtb_ChoiceC.Text = text[Convert.ToInt32(choice+"5")];

            rtb_ChoiceB.Visible = false;
        }

        void rtb_ChoiceC_Click(object sender, EventArgs e)
        {
            story_counter++;
            choice += "3";

            rtb_Story.Text = text[Convert.ToInt32(choice)];
            rtb_ChoiceA.Text = text[Convert.ToInt32(choice+"4")];
            rtb_ChoiceC.Text = text[Convert.ToInt32(choice+"5")];

            rtb_ChoiceB.Visible = false;
            if (choice.Length >= 4)
            {
                choice = "";
            }
            if (story_counter == 4)
            {
                rtb_ChoiceA.Visible = false;
                rtb_ChoiceC.Visible = false;

                restart.Location = rtb_ChoiceA.Location;
                restart.Size = rtb_ChoiceA.Size;
                restart.Text = "Restart";
                restart.ForeColor = Color.White;
                restart.BackColor = Color.Black;
                restart.Font = new Font("Century Gothic", 27);

                //this.Controls.Add(restart);

                rtb_ChoiceA.Enabled = false;
                rtb_ChoiceC.Enabled = false;

                goto_MainMenu.Location = rtb_ChoiceC.Location;
                goto_MainMenu.Size = rtb_ChoiceA.Size;
                goto_MainMenu.Text = "Main Menu";
                goto_MainMenu.ForeColor = Color.White;
                goto_MainMenu.BackColor = Color.Black;
                goto_MainMenu.Font = new Font("Century Gothic", 27);

                //this.Controls.Add(goto_MainMenu);

                 restart.Click += button_Start_Click;
                goto_MainMenu.Click += goto_MainMenu_Click;
            }
        }

        void goto_MainMenu_Click(object sender, EventArgs e)
        {
             
            choice = "";
            story_counter = 0;
            choice = new string('0', 1);
            goto_MainMenu.Visible = false;

            button_Start.Visible = true;
            button_AboutTheVeil.Visible = true;
            button_HowTo.Visible = true;
            label_Welcome.Visible = true;
            panel_Welcome.Visible = true;
            rtb_Welcome.Visible = true;

            rtb_Story.Visible = false;
            rtb_SideKick.Visible = false;
            rtb_ChoiceA.Visible = false;
            rtb_ChoiceB.Visible = false;
            rtb_ChoiceC.Visible = false;
            rtb_ChoiceA.Enabled = false;
            rtb_ChoiceC.Enabled = false;
            restart.Visible = false;
            choice = "";
            story_counter = 0;
        }
       }
    }


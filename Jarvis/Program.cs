using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
namespace Jarvis
{
    class Program
    {
        static void speakAndWait(SpeechSynthesizer synth, String statement, int millisecondsToWait)
        {
            Console.WriteLine(statement);
            synth.Speak(statement);
            Thread.Sleep(millisecondsToWait);
            return;

        }
        static void speakAbuterolCountdown(SpeechSynthesizer synth) 
        {
                speakAndWait(synth,"starting count down for albuterol",2000);///2 seconds
                speakAndWait(synth,"three",800);     
                speakAndWait(synth,"two",800);  
                speakAndWait(synth,"one",800); 
                speakAndWait(synth,"puff",12000);///twelve seconds because it takes time to do the puff and it wount kill you if you hold your breath to long
                return;                    
        }
        static void speakfloweventcountdawn(SpeechSynthesizer synth)
        {
            speakAndWait(synth, "starting count down for flow vent", 2000);///2 seconds
            speakAndWait(synth, "three", 800);
            speakAndWait(synth, "two", 800);
            speakAndWait(synth, "one", 800);
            speakAndWait(synth, "puff", 12000);///twelve seconds because it takes time to do the puff and it wount kill you if you hold your breath to long
            return;                   
        }
#region askquestion
        static ConsoleKeyInfo askQuestion(SpeechSynthesizer synth, String question) 
        {
            Console.WriteLine(question);
            synth.Speak(question);
            ConsoleKeyInfo key =  Console.ReadKey();
            return key;
        }
        
        #endregion

        static void Main(string[] args)
        {
            #region start up script
            //starting my program
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("wellcome to Jacob's personal reminder system");
            Random randomObject = new Random();
            int randnum = randomObject.Next(6) + 1;
            #endregion

            ConsoleKeyInfo k = askQuestion(synth, "Can you enter a letter?");
            Console.WriteLine(k.KeyChar);

            #region array
            //Get a random array of ints including 1,2,3  (e.g. 2,1,3 or 1,3,2, etc.)
            //How do I create a random array of int in C#?
            System.Random rnd = new System.Random();
            var randomNumbers = Enumerable.Range(1, 3).OrderBy(r => rnd.Next()).ToArray();

            //Now loop through the random array of ints.
            //For example if randomNumbers is 2,1,3
            //randomNumbers[0] = 2
            //randomNumbers[1] = 1
            //randomNumbers[2] = 3
            //How do i loop through an array of int i
            for (int i = 0; i < randomNumbers.Count(); i++)
            #endregion
            #region did you get albuterol
            {
                switch (randomNumbers[i])
                {
                    case 1:
                        {
                            ConsoleKeyInfo KI = askQuestion(synth, "Did you get albuterol?");
                            ///finding out if you got albuteol or not this leads into two if else loops
            #endregion
                            #region albuterol timer
                            if (KI.KeyChar == 'Y')//you got albuterol
                            {
                                ConsoleKeyInfo KI2 = askQuestion(synth, "Would you like to start a 10 second timer for albuterol");
                                if (KI2.KeyChar == 'Y')
                                {
                                    speakAbuterolCountdown(synth);
                                    ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                                    speakAndWait(synth, " your ten seconds are up", 3000);

                                    speakAbuterolCountdown(synth);
                                    ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                                    speakAndWait(synth, " your ten seconds are up", 3000);

                                }
                                ///thats all fo this timer (its jsut for albuterol)
                                else
                                ///if you got albuterol but do not want a timer
                                {
                                    Thread.Sleep(600);
                                    speakAndWait(synth, "okay thats fine, you can do your two puffs of albuterol and when your done with that, I will walk you through everything else", 25000);
                                }
                                TextWriter tw = new StreamWriter("SavingAnswers.txt");
                                tw.WriteLine(KI);
                                tw.Close();
                               
                            }
                            #endregion
                            #region albuterol timer (DID NOT GET)
                            else///you did not get albuterol
                            {
                                speakAndWait(synth, "Would you please go get your albuterol", 6000);
                                speakAbuterolCountdown(synth);
                                speakAndWait(synth, "your ten seconds are up", 3000);
                                ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                                Thread.Sleep(3000);
                                speakAbuterolCountdown(synth);
                                speakAndWait(synth, " your ten seconds are up", 0);
                            }
                            break;
                        }// case one ending
                            #endregion
                    #region saline
                    case 2:
                        {
                            speakAndWait(synth, "would you so kindly get saline", 0);
                            speakAndWait(synth, "did you put saline in your nebulizer?", 4000);
                            break;
                        }
                    #endregion
                    #region pulmozyme
                    case 3:
                        {
                            speakAndWait(synth, "please go get your pulmozyme", 4000);
                            speakAndWait(synth, "would you please put said pulmozyme in your pocket or such that it does not get lost", 5000);
                            break;
                    #endregion
                        }
                }
            }

            #region vest and pulymizin
            ///summery
            ///This is just runnign middle of my treatment reminders and cheacks
            ///this is just a small block and does not do much
            speakAndWait(synth, "starting a half hour timer for your vest.", 1800000);
            ConsoleKeyInfo KI3 = askQuestion(synth, "Is your vest done?");
            if (KI3.KeyChar == 'Y')
            {
                speakAndWait(synth, "congratulations you have run your vest perfectly", 0);
            }
            if (KI3.KeyChar == 'S')
            {
                speakAndWait(synth, "Okay so just finish it up, and you will be done in five, or ten minutes", 0);
            }
            if (KI3.KeyChar == 'N')
            {
                speakAndWait(synth, "Then you need to start it again, and activly work and restarting it at check points!", 0);
            }
            else
            {
                speakAndWait(synth, "Then you need to start it again, and activly work and restarting it at check points!", 0);
            }
            Thread.Sleep(180000);

            ConsoleKeyInfo KI4 = askQuestion(synth, "did you put pulmozyme in?");
            if (KI4.KeyChar == 'Y')
            {
                speakAndWait(synth, "Good job remembring to put it in.", 0);
            }
            else
            {
                speakAndWait(synth, "well then can you please put your pulmozyme in?", 0);///if you put in a invalid letter
            }
            //FIXME (dj80hd) What if the user enters a different letter like F ?
            Thread.Sleep(10000);
            #endregion
            #region getting off
            speakAndWait(synth, "please turn of your computer.", 240000);///4 min
            #endregion
            #region water
            switch (randnum)
            {
                case 1:
                    {
                        ///this set of code is for when im do with tharpy 
                        ///it will reminde me to do kayston and to put my nebulizer in water to wash

                        speakAndWait(synth, "please put you nebulizer in water.", 1500);
                        speakAndWait(synth, "please get your kayston and start it", 0);
                        break;
                    }
                case 2:
                    {
                        speakAndWait(synth, "pleease get you Kayston after you put your nebulizer in water", 0);
                        break;
                    }
            #endregion
                    speakAndWait(synth, "now that you have put your nebulizer in water can you please get the saline and powder for kayston", 8000);///kayston is a small fast nebulizer that comes in a small glass vile 
                    ///and a saline tube that you have to mix it takes around three minutes
                    speakAndWait(synth, "would you please mix your kayston", 8000);
                    speakAndWait(synth, "would you please put together you nebulizer", 10000);
                    speakAndWait(synth, "please start your kayston I will run a four minute timer for you", 240000);
                    speakAndWait(synth, "can you please put your nebulizer in water", 12000);
                    #region flowe vent and noise spray
                    ///this will all get replaced with a small function 
                    speakAbuterolCountdown(synth);
                    ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                    speakAndWait(synth, " your ten seconds are up", 3000);

                    speakAbuterolCountdown(synth);
                    ///repeating the code so that it runns the counter tiwse because i have to du two puffs 
                    speakAndWait(synth, " your ten seconds are up", 3000);
                    speakAndWait(synth, "pleae do the nose spray you should have gotten,", 6000);

            }
                    #endregion
            #region ending
            speakAndWait(synth, "congragulations you have now run though a intire set of therapy without missing anything", 4000);///meanse you did not forget anything
            speakAndWait(synth, "Jarvis signing off", 0);
            #endregion

            TextReader tr = new StreamReader("SavingAnswers.txt");
            string aNumberString  = tr.ReadLine();
            int aNumber = Convert.ToInt32(aNumberString);
            tr.Close();
            ///Code sorce http://stackoverflow.com/questions/15278839/how-do-i-save-variables-to-a-new-text-file-so-that-those-variables-are-loaded-th first answer 
            ///what did I do wrong I dont under stand
            //ANSWER - You already used variable KI for something else
                    }

                }
            }


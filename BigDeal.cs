/**************************************************************

***************************************************************

***************************************************************

***                                                         ***

***                 ID INFORMATION                          ***

***                                                         ***

***   Programmer :                      Eduardo Moreno      ***

***   Assignment # :                              P #1      ***

***   Assignment Name :                Deal or No Deal      ***

***   Course # and Title :               CISC 193 – C#      ***

***   Class Meeting Time :           MW 01:15 - 4:10pm      ***

***   Instructor :                    Professor Forman      ***

***   Hours    :                                    15      ***

***   Difficulty :                                   6      ***

***   Completion Date :                     10/08/2013      ***

***   Program Name :                   EduardosBigDeal      ***

***                                                         ***

***************************************************************
***************************************************************

***                                                         ***

***                   PROGRAM DESCRIPTION                   ***

***                                                         ***

***    This program is a game of deal or no deal, where     ***

***    players select suitcases and are offered amounts     ***

***    of money based on how much money remains in unopened ***

***    suitcases.                                           ***

***************************************************************

***************************************************************
***             NON-EVENT METHOD LIST                       ***
 
***                                                         *** 

***             randomGen                                   ***

***             login                                       ***

***             goodBye                                     ***

***             playIntroSound                              ***

***             playSuitSound                               ***

***             currentPlayerUpdate                         ***

***             resetGame                                   *** 

***             dealMethod                                  ***

***************************************************************
***************************************************************

***             EVENT-DEFINED METHOD LIST                   ***

***     instructionButton_Click                             ***

***     pictureBox1_Click                                   ***

***     pictureBox2_Click                                   ***

***     pictureBox4_Click                                   ***

***     pictureBox18_Click                                  ***

***     pictureBox17_Click                                  ***

***     pictureBox12_Click                                  ***

***     pictureBox10_Click                                  ***

***     pictureBox11_Click                                  ***

***     submitbutton_Click                                       ***

***     instructionsButton_Click                            ***

***     exitButton_Click                                    ***

***     newGameToolStripMenuItem_Click                      ***

***     exitToolStripMenuItem_Click                         ***

***************************************************************
***************************************************************

***                       CREDITS                           ***

***     Thanks for assistance and inspiration from:         ***
                                
***             Professor Forman, Raffa, Don                ***
            
***     Thanks for the opportunity to assist and inspire:
                            
***             Don D                                       ***
 
***************************************************************
***************************************************************

***                        MEDIA                            ***

***                    GRAPHICS USED                        ***

***                         "O"                             ***
http://www.dailydropcap.com/tag/o

***                                                         ***

***                      "Suitcase"                         ***
http://commons.uncyclomedia.org/wiki/Image:Little_tan_suitcase_jona_.svg

***                                                         ***

***                                                         ***

***                     AUDIO USED                          ***

***                                                         ***

***     Porky - http://www.wavsource.com/tv/looney2.htm     ***

***  Rawhide - http://www.televisiontunes.com/Rawhide.html‎  ***

***************************************************************
***************************************************************

***                       STARS                             ***

*** 1. Use a list box to display the updated scoreboard     *** 

*** 2. Use 8 picture boxes for the “suitcases”              ***

*** 3. Disable all other necessary controls so game can     ***

***    continue only if user selects “deal” or “no deal”    ***

*** 4. Handle in a nice clean way the final offer           ***

*** 5. Advanced features: array, loops, menuStrip           ***

*** Total: 5 STARS                                          *** 
**************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduardosBigDeal2
{
    public partial class Form1 : Form
    {

        //-----------------------------------------------------------------------------
        //---------------------- GLOBAL CONSTANTS & VARIABLES--------------------------
        //-----------------------------------------------------------------------------

        String userID, pickedSuitcaseAmount;
        int gamesPlayed, turnVar, sum = 0;
        int suitcasesO, deal, winnings;
        int suitcasesR = 8;
        int random, amount;
        int[] amounts = new int[8];

        System.Media.SoundPlayer sndPlayer;

        DialogResult buttonResponseDialogResult;

        Random randomFun1 = new Random();

        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------        
        //>>>>>>>>>>>>>>>>>>>>>> NON-EVENT DRIVEN CUSTOM-DESIGNED METHODS >>>>>>>>>>>>>

        //-----------------------------------------------------------------------------

        //  Form1() constructor

        //            initializes components of form and calls welcomeMethod()

        //-----------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString();
        }

        //-----------------------------------------------------------------------------

        //  randomGen() 

        //            generates random integer between 1 and 1,000,000

        //-----------------------------------------------------------------------------

        public int randomGen()
        {
            random = Math.Abs(randomFun1.Next(1, 1000001));
            return random;
        }

        //-----------------------------------------------------------------------------

        //  loginMethod() 

        //            returns textBox1 text as string variable userID

        //-----------------------------------------------------------------------------

        public String loginMethod()
        {
            userID = textBox1.Text;
            return userID;
        }

        //-----------------------------------------------------------------------------

        //  goodBye() 

        //            displays message boxes which Thank user, diplay id, amount won

        //            for this game, total amount won this session, and ID, CREDITS, etc.

        //-----------------------------------------------------------------------------

        public void goodBye()
        {
            MessageBox.Show("Thanks for playing " + userID + ".  You won: $" + winnings + " in " + gamesPlayed + " games!");
            playIntroSound();
            MessageBox.Show("***************************************************************\n" +

            "***                                                         ***\n" +

            "***                 ID INFORMATION                          ***\n" +

            "***                                                         ***\n" +

            "***   Programmer :                      Eduardo Moreno      ***\n" +

            "***   Assignment # :                              P #1      ***\n" +

            "***   Assignment Name :                Deal or No Deal      ***\n" +

            "***   Course # and Title :               CISC 193 – C#      ***\n" +

            "***   Class Meeting Time :           MW 01:15 - 4:10pm      ***\n" +

            "***   Instructor :                    Professor Forman      ***\n" +

            "***   Hours    :                                    15      ***\n" +

            "***   Difficulty :                                   6      ***\n" +

            "***   Completion Date :                     10/08/2013      ***\n" +

            "***   Program Name :                   EduardosBigDeal      ***\n" +

            "***                                                         ***\n" +

            "***************************************************************");

            MessageBox.Show("***************************************************************\n" +

            "***                       CREDITS                           ***\n" +

            "***     Thanks for assistance and inspiration from:         ***\n" +

            "***             Professor Forman, Raffa, Don                ***\n" +

            "***     Thanks for the opportunity to assist and inspire:\n" +

            "***             Don D                                       ***\n" +

            "***                                                         ***\n" +
            "***                        MEDIA                            ***\n" +

            "***                    GRAPHICS USED                        ***\n" +

            "***                           O                             ***\n" +
            "http://www.dailydropcap.com/tag/o" + "\n" +

            "***                                                         ***\n" +

            "***                       Suitcase                          ***\n" +
            "http://commons.uncyclomedia.org/wiki/Image:Little_tan_suitcase_jona_.svg" + "\n" +

            "***                                                         ***\n" +

            "***                                                         ***\n" +

            "***                     AUDIO USED                          ***\n" +

            "***                                                         ***\n" +

            "***     Porky - http://www.wavsource.com/tv/looney2.htm     ***\n" +

            "***  Rawhide - http://www.televisiontunes.com/Rawhide.html‎  ***\n" +

            "***************************************************************\n" +

            "***************************************************************\n");


            MessageBox.Show("***************************************************************\n" +

            "***                       STARS                             ***\n" +

            "*** 1. Use a list box to display the updated scoreboard     ***\n" +

            "*** 2. Use 8 picture boxes for the “suitcases”              ***\n" +

            "*** 3. Disable all other necessary controls so game can     ***\n" +

            "***    continue only if user selects “deal” or “no deal”    ***\n" +

            "*** 4. Handle in a nice clean way the final offer           ***\n" +

            "*** 5. Advanced features: array, loops, menuStrip           ***\n" +

            "*** Total: 5 STARS                                          ***\n" +
            "**************************************************************\n");
        }

        //-----------------------------------------------------------------------------

        //  playIntroSound() 

        //            creates SoundPlayer object, loads rawhide.wav, plays it

        //-----------------------------------------------------------------------------

        public void playIntroSound()
        {

            sndPlayer = new System.Media.SoundPlayer(Properties.Resources.rawhide);
            sndPlayer.Play();
        }

        //-----------------------------------------------------------------------------

        //  playSuitSound() 

        //            creates SoundPlayer object, loads porky2.wav, plays it

        //-----------------------------------------------------------------------------

        public void playSuitSound()
        {
            sndPlayer = new System.Media.SoundPlayer(Properties.Resources.porky2);
            sndPlayer.Play();
        }

        //-----------------------------------------------------------------------------

        //  resetGame() 

        //            sets sum to 0, clears both listboxes, and resets all picture boxes

        //            and labels. RandomGen once for each picturebox and numbers are stored

        //            in array. Labels are populated with each array value. Suitcase opened

        //            and remaining labels are also reset, along with TurnVar, and Games played

        //            is incremented

        //-----------------------------------------------------------------------------

        private void resetGame()
        {
            sum = 0;
            possibleListBox.Items.Clear();
            openedListBox.Items.Clear();

            pictureBox1.Image = Properties.Resources.suitcase;
            pictureBox2.Image = Properties.Resources.suitcase;
            pictureBox4.Image = Properties.Resources.suitcase;
            pictureBox10.Image = Properties.Resources.suitcase;
            pictureBox11.Image = Properties.Resources.suitcase;
            pictureBox12.Image = Properties.Resources.suitcase;
            pictureBox17.Image = Properties.Resources.suitcase;
            pictureBox18.Image = Properties.Resources.suitcase;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label17.Visible = false;
            label18.Visible = false;


            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox4.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;

            for (int i = 0; i < 8; i++)
            {
                randomGen();
                amounts[i] = random;
                possibleListBox.Items.Add(amounts[i].ToString());


                sum = sum + Math.Abs(random);
            }

            label1.Text = amounts[0].ToString();
            label2.Text = amounts[1].ToString();
            label3.Text = amounts[2].ToString();
            label10.Text = amounts[3].ToString();
            label11.Text = amounts[4].ToString();
            label12.Text = amounts[5].ToString();
            label17.Text = amounts[6].ToString();
            label18.Text = amounts[7].ToString();



            gamesPlayed++;
            suitcasesR = 8;
            suitcasesO = 0;
            turnVar = 0;
            suitcasesRLabel.Text = "Suitcases remaining: " + suitcasesR;
            suitcasesOLabel.Text = "Suitcases opened: " + suitcasesO;
            gamesPlayedLabel.Text = "Games Played: " + gamesPlayed;

        }

        //-----------------------------------------------------------------------------

        //  dealMethod() 

        //            creates deals diplayed via a message box that offer user an amount

        //            of money (i.e., average remaining amount). depending on user's choice,

        //            user adds to winnings and resets game. if there are only two suitcases

        //            remaining, alternative deal (either suitcase) is offered and game resets, etc.

        //-----------------------------------------------------------------------------


        private void dealMethod()
        {
            DialogResult buttonResponseDialogResult;

            deal = (sum / suitcasesR);
            buttonResponseDialogResult = MessageBox.Show("Your deal is: " + deal + ". Would you like to accept this offer?", "Your deal", MessageBoxButtons.YesNo);

            if (buttonResponseDialogResult == DialogResult.Yes)
            {
                winnings += deal;
                MessageBox.Show("Congratulations! You win: $" + deal);
                winningsLabel.Text = "Total winnings: $" + winnings;
                resetGame();
            }

            if (turnVar == 7)
            {
                buttonResponseDialogResult = MessageBox.Show("Your deal is the first suitcase you selected. The " + "O" + " suitcase." + " Would you like to accept this offer?" + "\n\n If you choose not to accept this offer, you will receive the remaining suitcase.", "Your deal", MessageBoxButtons.YesNo);

                if (buttonResponseDialogResult == DialogResult.Yes)
                {
                    winnings += int.Parse(pickedSuitcaseAmount);
                    MessageBox.Show("Congratulations! You win: $" + pickedSuitcaseAmount);
                    winningsLabel.Text = "Total winnings: $" + winnings;
                    resetGame();
                }

                if (buttonResponseDialogResult == DialogResult.No)
                {
                    winnings += (sum - int.Parse(pickedSuitcaseAmount));
                    MessageBox.Show("Congratulations! You win: $" + (sum - int.Parse(pickedSuitcaseAmount)));
                    winningsLabel.Text = "Total winnings: $" + winnings;
                    resetGame();
                }
            }

        }

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //<<<<<<<<<<<<<<<<<<<<<< EVENT-DRIVEN CUSTOM-DESIGNED METHODS <<<<<<<<<

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //-----------------------------------------------------------------------------

        //  submitbutton_Click() 

        //              requires user to enter login information. once entere, login method
        
        //              is called, login textbox, combobox, listbox and button are then invisible

        //              and resetGame method is called.

        //-----------------------------------------------------------------------------


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Modified = true && comboBox1.SelectedIndex != 0 && listBox1.SelectedIndex != 0)
            {
                MessageBox.Show("Please enter login information!");

            }
            else
            {
                loginMethod();
                MessageBox.Show("Thanks for entering your login information, " + userID + ". Your sign is: " + comboBox1.SelectedItem + ".  Your age is: " + listBox1.SelectedItem);
                textBox1.Visible = false;
                comboBox1.Visible = false;
                listBox1.Visible = false;
                submitButton.Visible = false;

                resetGame();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = userID;
        }

        //-----------------------------------------------------------------------------

        //  instructionsButton_Click() 

        //            displays a messagebox that explains rules of game.

        //-----------------------------------------------------------------------------


        private void instructionsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please first enter your login ID as well as select an astrological sign and age range. Then, select a suitcase you would like to keep. Then, you will select a suitcase that has an amount of money in it. The bank will offer you some money and you can take it or continue selecting suitcases.");
        }

        //-----------------------------------------------------------------------------

        //  exitButton_Click() 

        //            calls goodBye and Close methods

        //-----------------------------------------------------------------------------

        private void exitButton_Click(object sender, EventArgs e)
        {

            goodBye();
            Close();
        }

        //-----------------------------------------------------------------------------

        //  pictureBox18_Click() 

        //            if first suitcase selected for this game, that suitcase is changed to

        //            picture 'O' and its amount is assigned to pickedSuitcaseAmount variable.

        //            otherwise, playSuitSound is called, picture is made invisible and label

        //            that contains the amount is revealed behind picture. the sum variable is

        //            decreased by the selected amount, listboxes are updated (i.e., move the selected

        //            amount), suitCaseO and suitCaseR variables and labels are updated, turnVar incremented,

        //            and dealMethod is called

        //-----------------------------------------------------------------------------

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (turnVar == 0)
            {
                playSuitSound();
                pictureBox18.Image = Properties.Resources.o;
                turnVar++;
                pickedSuitcaseAmount = amounts[7].ToString(); 
            }

            else
            {
                playSuitSound();
                pictureBox18.Visible = false;
                label18.Visible = true;
                


                sum = sum - (int.Parse(label18.Text));

                possibleListBox.Items.Remove(amounts[7].ToString());
                openedListBox.Items.Add(amounts[7].ToString());

                suitcasesO++;
                suitcasesR--;

                suitcasesOLabel.Text = "Suitcases Opened: " + suitcasesO;
                suitcasesRLabel.Text = "Suitcases Remaining: " + suitcasesR;

                turnVar++;

                dealMethod();

            }
        }

        //-----------------------------------------------------------------------------

        //  pictureBox1_Click() 

        //            if first suitcase selected for this game, that suitcase is changed to

        //            picture 'O' and its amount is assigned to pickedSuitcaseAmount variable.

        //            otherwise, playSuitSound is called, picture is made invisible and label

        //            that contains the amount is revealed behind picture. the sum variable is

        //            decreased by the selected amount, listboxes are updated (i.e., move the selected

        //            amount), suitCaseO and suitCaseR variables and labels are updated, turnVar incremented,

        //            and dealMethod is called

        //-----------------------------------------------------------------------------

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (turnVar == 0)
            {
                playSuitSound();
                pictureBox1.Image = Properties.Resources.o;
                turnVar++;
                pickedSuitcaseAmount = amounts[0].ToString();
            }

            else
            {
                playSuitSound();
                pictureBox1.Visible = false;
                label1.Visible = true;
                
                sum -= (int.Parse(label1.Text));

                possibleListBox.Items.Remove(amounts[0].ToString());
                openedListBox.Items.Add(amounts[0].ToString());

                suitcasesO++;
                suitcasesR--;

                suitcasesOLabel.Text = "Suitcases Opened: " + suitcasesO;
                suitcasesRLabel.Text = "Suitcases Remaining: " + suitcasesR;

                turnVar++;
                dealMethod();
            }
        }

        //-----------------------------------------------------------------------------

        //  pictureBox2_Click() 

        //            if first suitcase selected for this game, that suitcase is changed to

        //            picture 'O' and its amount is assigned to pickedSuitcaseAmount variable.

        //            otherwise, playSuitSound is called, picture is made invisible and label

        //            that contains the amount is revealed behind picture. the sum variable is

        //            decreased by the selected amount, listboxes are updated (i.e., move the selected

        //            amount), suitCaseO and suitCaseR variables and labels are updated, turnVar incremented,

        //            and dealMethod is called

        //-----------------------------------------------------------------------------


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (turnVar == 0)
            {
                playSuitSound();
                pictureBox2.Image = Properties.Resources.o;
                turnVar++;
                pickedSuitcaseAmount = amounts[1].ToString();
            }

            else
            {
                playSuitSound();
                pictureBox2.Visible = false;
                label2.Visible = true;
                
                sum -= (int.Parse(label2.Text));

                possibleListBox.Items.Remove(amounts[1].ToString());
                openedListBox.Items.Add(amounts[1].ToString());

                suitcasesO++;
                suitcasesR--;

                suitcasesOLabel.Text = "Suitcases Opened: " + suitcasesO;
                suitcasesRLabel.Text = "Suitcases Remaining: " + suitcasesR;

                turnVar++;
                dealMethod();
            }
        }

        //-----------------------------------------------------------------------------

        //  pictureBox4_Click() 

        //            if first suitcase selected for this game, that suitcase is changed to

        //            picture 'O' and its amount is assigned to pickedSuitcaseAmount variable.

        //            otherwise, playSuitSound is called, picture is made invisible and label

        //            that contains the amount is revealed behind picture. the sum variable is

        //            decreased by the selected amount, listboxes are updated (i.e., move the selected

        //            amount), suitCaseO and suitCaseR variables and labels are updated, turnVar incremented,

        //            and dealMethod is called

        //-----------------------------------------------------------------------------


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (turnVar == 0)
            {
                playSuitSound();
                pictureBox4.Image = Properties.Resources.o;
                turnVar++;
                pickedSuitcaseAmount = amounts[2].ToString();
            }

            else
            {
                playSuitSound();
                pictureBox4.Visible = false;
                label3.Visible = true;
                
                sum -= (int.Parse(label3.Text));

                possibleListBox.Items.Remove(amounts[2].ToString());
                openedListBox.Items.Add(amounts[2].ToString());

                suitcasesO++;
                suitcasesR--;

                suitcasesOLabel.Text = "Suitcases Opened: " + suitcasesO;
                suitcasesRLabel.Text = "Suitcases Remaining: " + suitcasesR;

                turnVar++;
                dealMethod();

            }
        }

        //-----------------------------------------------------------------------------

        //  pictureBox17_Click() 

        //            if first suitcase selected for this game, that suitcase is changed to

        //            picture 'O' and its amount is assigned to pickedSuitcaseAmount variable.

        //            otherwise, playSuitSound is called, picture is made invisible and label

        //            that contains the amount is revealed behind picture. the sum variable is

        //            decreased by the selected amount, listboxes are updated (i.e., move the selected

        //            amount), suitCaseO and suitCaseR variables and labels are updated, turnVar incremented,

        //            and dealMethod is called

        //-----------------------------------------------------------------------------


        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (turnVar == 0)
            {
                playSuitSound();
                pictureBox17.Image = Properties.Resources.o;
                turnVar++;
                pickedSuitcaseAmount = amounts[6].ToString();
            }

            else
            {
                playSuitSound();
                pictureBox17.Visible = false;
                label17.Visible = true;
                
                sum -= (int.Parse(label17.Text));

                possibleListBox.Items.Remove(amounts[6].ToString());
                openedListBox.Items.Add(amounts[6].ToString());

                suitcasesO++;
                suitcasesR--;

                suitcasesOLabel.Text = "Suitcases Opened: " + suitcasesO;
                suitcasesRLabel.Text = "Suitcases Remaining: " + suitcasesR;

                turnVar++;
                dealMethod();

            }
        }

        //-----------------------------------------------------------------------------

        //  pictureBox12_Click() 

        //            if first suitcase selected for this game, that suitcase is changed to

        //            picture 'O' and its amount is assigned to pickedSuitcaseAmount variable.

        //            otherwise, playSuitSound is called, picture is made invisible and label

        //            that contains the amount is revealed behind picture. the sum variable is

        //            decreased by the selected amount, listboxes are updated (i.e., move the selected

        //            amount), suitCaseO and suitCaseR variables and labels are updated, turnVar incremented,

        //            and dealMethod is called

        //-----------------------------------------------------------------------------


        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (turnVar == 0)
            {
                playSuitSound();
                pictureBox12.Image = Properties.Resources.o;
                turnVar++;
                pickedSuitcaseAmount = amounts[5].ToString();
            }

            else
            {
                playSuitSound();
                pictureBox12.Visible = false;
                label12.Visible = true;
                
                sum -= (int.Parse(label12.Text));

                possibleListBox.Items.Remove(amounts[5].ToString());
                openedListBox.Items.Add(amounts[5].ToString());

                suitcasesO++;
                suitcasesR--;

                suitcasesOLabel.Text = "Suitcases Opened: " + suitcasesO;
                suitcasesRLabel.Text = "Suitcases Remaining: " + suitcasesR;

                turnVar++;
                dealMethod();
            }
        }

        //-----------------------------------------------------------------------------

        //  pictureBox11_Click() 

        //            if first suitcase selected for this game, that suitcase is changed to

        //            picture 'O' and its amount is assigned to pickedSuitcaseAmount variable.

        //            otherwise, playSuitSound is called, picture is made invisible and label

        //            that contains the amount is revealed behind picture. the sum variable is

        //            decreased by the selected amount, listboxes are updated (i.e., move the selected

        //            amount), suitCaseO and suitCaseR variables and labels are updated, turnVar incremented,

        //            and dealMethod is called

        //-----------------------------------------------------------------------------

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (turnVar == 0)
            {
                playSuitSound();
                pictureBox11.Image = Properties.Resources.o;
                turnVar++;
                pickedSuitcaseAmount = amounts[4].ToString();
            }

            else
            {
                playSuitSound();
                pictureBox11.Visible = false;
                label11.Visible = true;
                
                sum -= (int.Parse(label11.Text));

                possibleListBox.Items.Remove(amounts[4].ToString());
                openedListBox.Items.Add(amounts[4].ToString());

                suitcasesO++;
                suitcasesR--;

                suitcasesOLabel.Text = "Suitcases Opened: " + suitcasesO;
                suitcasesRLabel.Text = "Suitcases Remaining: " + suitcasesR;

                turnVar++;
                dealMethod();

            }
        }

        //-----------------------------------------------------------------------------

        //  pictureBox10_Click() 

        //            if first suitcase selected for this game, that suitcase is changed to

        //            picture 'O' and its amount is assigned to pickedSuitcaseAmount variable.

        //            otherwise, playSuitSound is called, picture is made invisible and label

        //            that contains the amount is revealed behind picture. the sum variable is

        //            decreased by the selected amount, listboxes are updated (i.e., move the selected

        //            amount), suitCaseO and suitCaseR variables and labels are updated, turnVar incremented,

        //            and dealMethod is called

        //-----------------------------------------------------------------------------

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (turnVar == 0)
            {
                playSuitSound();
                pictureBox10.Image = Properties.Resources.o;
                turnVar++;
                pickedSuitcaseAmount = amounts[3].ToString();
            }

            else
            {
                playSuitSound();
                pictureBox10.Visible = false;
                label10.Visible = true;
                
                sum -= (int.Parse(label10.Text));

                possibleListBox.Items.Remove(amounts[3].ToString());
                openedListBox.Items.Add(amounts[3].ToString());

                suitcasesO++;
                suitcasesR--;

                suitcasesOLabel.Text = "Suitcases Opened: " + suitcasesO;
                suitcasesRLabel.Text = "Suitcases Remaining: " + suitcasesR;

                turnVar++;
                dealMethod();

            }
        }

        //-----------------------------------------------------------------------------

        //  newGameToolStripMenuItem_Click() 

        //            calls resetGame method

        //-----------------------------------------------------------------------------

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        //-----------------------------------------------------------------------------

        //  exitToolStripMenuItem_Click() 

        //            calls resetGame method

        //-----------------------------------------------------------------------------

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goodBye();
            Close();
        }
    }
}

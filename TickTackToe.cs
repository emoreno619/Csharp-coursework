/**************************************************************

***************************************************************

***************************************************************

***                                                         ***

***                 ID INFORMATION                          ***

***                                                         ***

***   Programmer :                      Eduardo Moreno      ***

***   Assignment # :                           TA #1.3      ***

***   Assignment Name :              Tickee Tackee Toe      ***

***   Course # and Title :               CISC 193 – C#      ***

***   Class Meeting Time :           MW 01:15 - 4:10pm      ***

***   Instructor :                    Professor Forman      ***

***   Hours    :                                     8      ***

***   Difficulty :                                   4      ***

***   Completion Date :                     09/18/2013      ***

***   Program Name :           EduardosTickeeTackeeToe      ***

***                                                         ***

***************************************************************
***************************************************************

***                                                         ***

***                   PROGRAM DESCRIPTION                   ***

***                                                         ***

***    This program is a game of tick tack toe that         ***

***    also displays links and photos of myself and         ***

***    heroes.                                              ***

***************************************************************

***************************************************************
***             NON-EVENT METHOD LIST                       ***
 
***                                                         *** 

***             welcomeMethod                               ***

***             closeMethod                                 ***

***             displayDate                                 ***

***             playerxSound                                ***

***             playeroSound                                ***

***             currentPlayerUpdate                         ***

***             welcomeMethod                               *** 

***                                                         ***

***             EVENT-DEFINED METHOD LIST                   ***

***     instructionButton_Click                             ***

***     pictureBox1_Click                                   ***

***     pictureBox2_Click                                   ***

***     pictureBox3_Click                                   ***

***     pictureBox4_Click                                   ***

***     pictureBox5_Click                                   ***

***     pictureBox6_Click                                   ***

***     pictureBox7_Click                                   ***

***     pictureBox8_Click                                   ***

***     pictureBox9_Click                                   ***

***     player1Turn_CheckChanged                            ***

***     player2Turn_CheckChanged                            ***

***     date_checkBox_CheckedChanged                        ***

***     currentPlayer_checkBox_CheckedChanged               ***

***     exitButton_Click                                    ***

***     link_checkBox_CheckedChanged                        ***

***     linkLabel1_LinkClicked                              ***

***     photoCheckBox_CheckedChanged                        ***

***************************************************************
***************************************************************

***                       CREDITS                           ***

***     Thanks for assistance and inspiration from:         ***
                                
***             Professor Forman and Don                    ***
            
***     Thanks for the opportunity to assist and inspire:
                            
***             Stefano and Ahmed                           ***
 
***                                                         *** 
***                        MEDIA                            ***

***         Learned about the stopwatch class from:         ***
http://msdn.microsoft.com/en-us/library/system.diagnostics.stopwatch.aspx 

***                    GRAPHICS USED                        ***

***                         "O"                             ***
http://www.dailydropcap.com/tag/o

***                                                         ***

***                         "X"                             ***
http://www.freepik.com/free-vector/x-wrong-cross-no-clip-art_383990.htm

***                                                         ***

***                       Batman                            ***
http://dcjosh.deviantart.com/art/Jim-Lee-Batman-quicky-78684970

***                                                         ***

***                       Socrates                          ***
http://www.philotampa.org/socware.htm

***                                                         ***

***           Eduardo photo supplied by Eduardo             ***

***                                                         ***

***                     AUDIO USED                          ***

***                                                         ***

***     Porky - http://www.wavsource.com/tv/looney2.htm     ***

***  Rawhide - http://www.televisiontunes.com/Rawhide.html‎  ***

***************************************************************

***************************************************************

***                       STARS                             ***

*** 1. Add extra pizazz, colors, fonts, etc.                *** 

*** 2. Add another checkbox with photos of myself & heroes  ***

*** 3. Expand the link checkbox to include 3 links          ***

*** 4. The game automatically alternates between players    ***
 
*** 5. Expand the link checkbox to include 3 links          ***

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

namespace EduardosTickeeTackeeToe
{
    public partial class Form1 : Form
    {
//-----------------------------------------------------------------------------
//---------------------- GLOBAL CONSTANTS -------------------------------------
//-----------------------------------------------------------------------------


        const string EDUARDO = "Eduardo";
        int playerTurnVar = 1;
        int totalPoints = 0;
        System.Media.SoundPlayer sndPlayer;
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------        
//>>>>>>>>>>>>>>>>>>>>>> NON-EVENT DRIVEN CUSTOM-DESIGNED METHODS >>>>>>>>>>>>>

//---------------------------------------------------------------------

//  Form1() constructor

//            initializes components of form and calls welcomeMethod()

//---------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();

            welcomeMethod();
                
        }

//---------------------------------------------------------------------

//  welcomeMethod()

//       Welcomes the user with a message box that contains a string 
       
//       constant

//---------------------------------------------------------------------

        public void welcomeMethod()
            {
             MessageBox.Show("Welcome to " + EDUARDO + "'s TickeeTackeeToe!");   
            }

//---------------------------------------------------------------------

//  closeMethod()

//       Thanks the user with a message box that contains a string 

//       constant, and displays credits and id info

//---------------------------------------------------------------------

        public void closeMethod()
        {
            MessageBox.Show("Thanks for coming to " + EDUARDO + "'s TickeeTackeeToe!");
            MessageBox.Show("ID \n" +"/**************************************************************\n" +

"***************************************************************\n" +

"***************************************************************\n" +

"***                                                         ***\n" +

"***                 ID INFORMATION                          ***\n" +

"***                                                         ***\n" +

"***   Programmer :                      Eduardo Moreno      ***\n" +

"***   Assignment # :                           TA #1.3      ***\n" +

"***   Assignment Name :              Tickee Tackee Toe      ***\n" +

"***   Course # and Title :               CISC 193 – C#      ***\n" +

"***   Class Meeting Time :           MW 01:15 - 4:10pm      ***\n" +

"***   Instructor :                    Professor Forman      ***\n" +

"***   Hours    :                                     8      ***\n" +

"***   Difficulty :                                   4      ***\n" +

"***   Completion Date :                     09/18/2013      ***\n" +

"***   Program Name :           EduardosTickeeTackeeToe      ***\n" +

"***                                                         ***\n" +

"***************************************************************\n" +
"***************************************************************\n" +

"***                                                         ***\n" +

"***                   PROGRAM DESCRIPTION                   ***\n" +

"***                                                         ***\n" +

"***    This program is a game of tick tack toe that         ***\n" +

"***    also displays links and photos of myself and         ***\n" +

"***    heroes.                                              ***\n" +

"***************************************************************\n" +

"***************************************************************");
            MessageBox.Show("CREDITS \n" +
                "***************************************************************\n" +
"***************************************************************\n" +

"***                       CREDITS                           ***\n" +

"***     Thanks for assistance and inspiration from:         ***\n" +

"***             Professor Forman and Don                    ***\n" +

"***     Thanks for the opportunity to assist and inspire:\n" +

"***             Stefano and Ahmed                           ***\n" +

"***                                                         *** \n" +
"***                        MEDIA                            ***\n" +

"***         Learned about the stopwatch class from:         ***\n" +
"http://msdn.microsoft.com/en-us/library/system.diagnostics.stopwatch.aspx" + "\n" +

"***                    GRAPHICS USED                        ***\n" +

"***                         'O'                             ***\n" +
"http://www.dailydropcap.com/tag/o" + "\n" +

"***                                                         ***\n" +

"***                         'X'                             ***\n" +
"http://www.freepik.com/free-vector/x-wrong-cross-no-clip-art_383990.htm" + "\n" +

"***                                                         ***\n" +

"***                       Batman                            ***\n" +
"http://dcjosh.deviantart.com/art/Jim-Lee-Batman-quicky-78684970" + "\n" +

"***                                                         ***\n" +

"***                       Socrates                          ***\n" +
"http://www.philotampa.org/socware.htm" + "\n" +

"***                                                         ***\n" +

"***           Eduardo photo supplied by Eduardo             ***\n" +

"***                                                         ***\n" +

"***                     AUDIO USED                          ***\n" +

"***                                                         ***\n" +

"***     Porky - http://www.wavsource.com/tv/looney2.htm     ***\n" +

"***  Rawhide - http://www.televisiontunes.com/Rawhide.html‎  ***\n" +

"***************************************************************\n" +

"***************************************************************\n");
            MessageBox.Show("***************************************************************\n" +

"***                       STARS                             ***\n" +

"*** 1. Add extra pizazz, colors, fonts, etc.                ***\n" + 

"*** 2. Add another checkbox with photos of myself & heroes  ***\n" +

"*** 3. Expand the link checkbox to include 3 links          ***\n" +

"*** 4. The game automatically alternates between players    ***\n" +
 
"*** 5. Expand the link checkbox to include 3 links          ***\n" +

"*** Total: 5 STARS                                          *** \n" +
"**************************************************************");
            Close();
        }

//---------------------------------------------------------------------

//  displayDate()

//       Creates a DateTime object and displays it in a textbox that is

//       made visible

//---------------------------------------------------------------------

        private void displayDate()
        {
            DateTime date = new DateTime();
            textBox1.Text = "" + DateTime.Now;
            textBox1.Visible = true;
        }

//---------------------------------------------------------------------

//  playerxSound()

//       Creates a SoundPlayer object, loads the porky sound file and plays 

//       the file.

//---------------------------------------------------------------------

        private void playerxSound()
        {
            sndPlayer = new System.Media.SoundPlayer(Properties.Resources.porky2);
            sndPlayer.Play();
        }

//---------------------------------------------------------------------

//  playeroSound()

//       Creates a SoundPlayer object, loads the rawhide sound file and plays 

//       the file.

//---------------------------------------------------------------------

        private void playeroSound()
        {
            sndPlayer = new System.Media.SoundPlayer(Properties.Resources.rawhide);
            sndPlayer.Play();
        }

//---------------------------------------------------------------------

//  currentPlayerUpdate()

//       Checks current player turn by evaluating the playerTurnVar, 

//       changing the currentPlayer_PicBox to the symbol of the current player.

//       Also checks to see whether either player has won.

//---------------------------------------------------------------------
        private void currentPlayerUpdate()
        {
            if (playerTurnVar == 1)
            {
                currentPlayer_PicBox.Image = Properties.Resources.x;
                player1Turn.Select();
            }

            if (playerTurnVar == 2)
            {
                currentPlayer_PicBox.Image = Properties.Resources.o;
                player2Turn.Select();
            }

            //if (pictureBox1.Image != null && pictureBox4.Image != null && pictureBox6.Image != null)
            //{
                if (pictureBox1.Image == Properties.Resources.x && pictureBox4.Image == Properties.Resources.x && pictureBox6.Image == Properties.Resources.x)
                {
                    MessageBox.Show("You win!");
                }
            //}

            if (pictureBox4.Image != null && pictureBox9.Image != null && pictureBox5.Image != null)
            {
                if (pictureBox4.Image == pictureBox9.Image && pictureBox9.Image == pictureBox5.Image)
                {
                    MessageBox.Show("You win!");
                }
            }

            if (pictureBox4.Image != null && pictureBox3.Image != null && pictureBox2.Image != null)
            {
                if (pictureBox4.Image == pictureBox3.Image && pictureBox2.Image == pictureBox4.Image)
                {
                    MessageBox.Show("You win!");
                }
            }

            if (pictureBox9.Image != null && pictureBox3.Image != null && pictureBox8.Image != null)
            {
                if (pictureBox9.Image == pictureBox3.Image && pictureBox8.Image == pictureBox9.Image)
                {
                    MessageBox.Show("You win!");
                }
            }

            if (pictureBox2.Image != null && pictureBox7.Image != null && pictureBox5.Image != null)
            {
                if (pictureBox2.Image == pictureBox7.Image && pictureBox5.Image == pictureBox7.Image)
                {
                    MessageBox.Show("You win!");
                }
            }

            if (pictureBox1.Image != null && pictureBox9.Image != null && pictureBox7.Image != null)
            {
                if (pictureBox1.Image == pictureBox9.Image && pictureBox7.Image == pictureBox1.Image)
                {
                    MessageBox.Show("You win!");
                }
            }

            if (pictureBox6.Image != null && pictureBox8.Image != null && pictureBox5.Image != null)
            {
                if (pictureBox6.Image == pictureBox8.Image && pictureBox6.Image == pictureBox5.Image)
                {
                    MessageBox.Show("You win!");
                }
            }

            if (pictureBox6.Image != null && pictureBox9.Image != null && pictureBox2.Image != null)
            {
                if (pictureBox6.Image == pictureBox9.Image && pictureBox6.Image == pictureBox2.Image)
                {
                    MessageBox.Show("You win!");
                }
            }
        }
//---------------------------------------------------------------------
//---------------------------------------------------------------------
//---------------------------------------------------------------------

//<<<<<<<<<<<<<<<<<<<<<< EVENT-DRIVEN CUSTOM-DESIGNED METHODS <<<<<<<<<<<<<<<<<

//---------------------------------------------------------------------
//---------------------------------------------------------------------
//---------------------------------------------------------------------

//  instructionButton_Click

//              When button labeled "Instructions" is clicked, a messagebox  

//              appears that instructs the user how to play the game.

//---------------------------------------------------------------------

        private void instructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INSTRUCTIONS \n" +"Choose which player goes first. First player chooses a square and his/her symbol is placed in the square. The other player then takes his/her turn. The first player with three symbols in a straight line wins.");
        }

//---------------------------------------------------------------------

//  pictureBox4_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == null)
            {

                if (playerTurnVar == 1)
                {
                    pictureBox4.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox4.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                pictureBox4.Visible = true;
                currentPlayerUpdate();
            }

         
        }

//---------------------------------------------------------------------

//  pictureBox1_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                if (playerTurnVar == 1)
                {
                    pictureBox1.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox1.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                currentPlayerUpdate();
            }
        }

//---------------------------------------------------------------------

//  pictureBox6_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == null)
            {
                if (playerTurnVar == 1)
                {
                    pictureBox6.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox6.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                currentPlayerUpdate();
            }
        }

//---------------------------------------------------------------------

//  pictureBox3_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == null)
            {
                if (playerTurnVar == 1)
                {
                    pictureBox3.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox3.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                currentPlayerUpdate();
            }
        }

//---------------------------------------------------------------------

//  pictureBox9_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == null)
            {
                if (playerTurnVar == 1)
                {
                    pictureBox9.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox9.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                currentPlayerUpdate();
            }
        }

//---------------------------------------------------------------------

//  pictureBox8_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image == null)
            {
                if (playerTurnVar == 1)
                {
                    pictureBox8.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox8.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                currentPlayerUpdate();
            }
        }

//---------------------------------------------------------------------

//  pictureBox5_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == null)
            {
                if (playerTurnVar == 1)
                {
                    pictureBox5.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox5.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                currentPlayerUpdate();
            }
        }

//---------------------------------------------------------------------

//  pictureBox7_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image == null)
            {
                if (playerTurnVar == 1)
                {
                    pictureBox7.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox7.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                currentPlayerUpdate();
            }
        }

//---------------------------------------------------------------------

//  pictureBox2_Click

//              When pictureBox is clicked, if it is player 1's turn  

//              the pictureBox will display his picture; if it is player

//              2's turn, the pictureBox will display her picture. It also

//              calls the relevant player's sound method and the currentPlayerUpdate()

//              method.

//---------------------------------------------------------------------

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                if (playerTurnVar == 1)
                {
                    pictureBox2.Image = Properties.Resources.x;
                    playerTurnVar = 2;
                    playerxSound();

                }

                else
                {
                    pictureBox2.Image = Properties.Resources.o;
                    playerTurnVar = 1;
                    playeroSound();

                }

                currentPlayerUpdate();
            }
        }

//---------------------------------------------------------------------

//  player1Turn_CheckedChanged()

//              When player1 radio button is clicked, the playerTurnVar is  

//              set to 1.

//---------------------------------------------------------------------

        private void player1Turn_CheckedChanged(object sender, EventArgs e)
        {
            playerTurnVar = 1; 
        }

//---------------------------------------------------------------------

//  player2Turn_CheckedChanged()

//              When player2 radio button is clicked, the playerTurnVar is  

//              set to 2.

//---------------------------------------------------------------------

        private void player2Turn_CheckedChanged(object sender, EventArgs e)
        {
            playerTurnVar = 2; 
        }

//---------------------------------------------------------------------

//  date_checkBox_CheckedChanged()

//              When date checkbox is clicked, the displayDate() method   

//              is called, displaying a date.

//---------------------------------------------------------------------

        private void date_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            displayDate();
        }

//---------------------------------------------------------------------

//  currentPlayer_checkBox_CheckedChanged()

//              When current player checkbox is clicked, the current player's   

//              symbol is displayed in the currentPlayer_PicBox. Photo boxes

//              are made invisible.

//---------------------------------------------------------------------

        private void currentPlayer_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (playerTurnVar == 1)
            {
                currentPlayer_PicBox.Image = Properties.Resources.x;
            }

            if (playerTurnVar == 2)
            {
                currentPlayer_PicBox.Image = Properties.Resources.o;
            }

            photoBox1.Visible = false;
            photoBox2.Visible = false;
            photoBox3.Visible = false;
            currentPlayer_PicBox.Visible = true;
        }

//---------------------------------------------------------------------

//  exitButton_Click()

//              When exit button is clicked, the closeMethod() method is  

//              called, closing the program.

//---------------------------------------------------------------------

        private void exitButton_Click(object sender, EventArgs e)
        {
            closeMethod();
        }

//---------------------------------------------------------------------

//  link_checkBox_CheckedChanged()

//              When link checkbox is clicked, a linklabel that displays  

//              a favorite link with a string constant

//---------------------------------------------------------------------

        private void link_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            linkLabel1.Text = EDUARDO + "'s first favorite link";
            linkLabel4.Text = EDUARDO + "'s second favorite link";
            linkLabel3.Text = EDUARDO + "'s third favorite link";
            linkLabel1.Visible = true;
            linkLabel4.Visible = true;
            linkLabel3.Visible = true;
        }

//---------------------------------------------------------------------

//  linkLabel1_LinkClicked()

//              When linkLabel1 is clicked, Internet Explorer is opened  

//              and www.google.com is opened.

//---------------------------------------------------------------------

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start
                ("C:/Program Files/Internet Explorer/iexplore",
                "http://www.google.com/");
        }

//---------------------------------------------------------------------

//  photoCheckBox_CheckedChanged()

//              When photo checkbox is clicked, three photos are displayed.   

//              CurrentPlayer_PicBox is also made invisible.

//---------------------------------------------------------------------

        private void photoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currentPlayer_PicBox.Visible = false;
            photoBox1.Image = Properties.Resources.socrates;
            photoBox2.Image = Properties.Resources.smile;
            photoBox3.Image = Properties.Resources.batman;

            photoBox1.Visible = true;
            photoBox2.Visible = true;
            photoBox3.Visible = true;
        }

//---------------------------------------------------------------------

//  linkLabel4_LinkClicked()

//              When linkLabel4 is clicked, Internet Explorer is opened  

//              and www.tomshardware.com is opened.

//---------------------------------------------------------------------

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start
                ("C:/Program Files/Internet Explorer/iexplore",
                "http://www.tomshardware.com/");
        }

//---------------------------------------------------------------------

//  linkLabel3_LinkClicked()

//              When linkLabel3 is clicked, Internet Explorer is opened  

//              and www.espn.com is opened.

//---------------------------------------------------------------------

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start
                ("C:/Program Files/Internet Explorer/iexplore",
                "http://www.espn.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult buttonResponseDialogResult;

            buttonResponseDialogResult =
            MessageBox.Show("Would Player 1 like to go first?", "Which player goes first?" , MessageBoxButtons.YesNo);

            if (buttonResponseDialogResult == DialogResult.Yes)
            {
                playerTurnVar = 1;
                currentPlayerUpdate();
            }

            if (buttonResponseDialogResult == DialogResult.No)
            {
                playerTurnVar = 2;
                currentPlayerUpdate();
            }

            button1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            currentPlayer_checkBox.Visible = true;
            photoCheckBox.Visible = true;
            link_checkBox.Visible = true;
            date_checkBox.Visible = true;

        }
//-----------------------------------------------------------------------------

//                      END CUSTOM-DESIGNED METHODS

//-----------------------------------------------------------------------------

    }
}

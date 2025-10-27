using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
            DisplayScene();
        }

        private void choice1Button_Click(object sender, EventArgs e)
        {
            HandleChoice(1);
        }

        private void choice2Button_Click(object sender, EventArgs e)
        {
            HandleChoice(2);
        }

        private void choice3Button_Click(object sender, EventArgs e)
        {
            HandleChoice(3);
        }

        private void HandleChoice(int choice)
        {
            switch (scene)
            {
                case 0: //check damage or oxygen
                    if (choice == 1) scene = 1; //check damage
                    else scene = 2; //check oxygen
                    break;

                case 1: //repair or seal the breach
                    if (choice == 1) scene = 3; //repair 
                    else scene = 4; //seal 
                    break;

                case 2: //control room or escape pod
                    if (choice == 1) scene = 5; //control room
                    else scene = 99;
                    break;

                case 3: //power choice
                    if (choice == 1) scene = 5;
                    else scene = 5;
                    break;

                case 4: //after sealing the breach
                    scene = 5;
                    break;

                case 5: //cross coridor(random event)
                    int chance = randGen.Next(1, 101);
                    if (chance <= 70) scene = 6; //safe
                    else scene = 7; //injured
                    break;

                case 6: //send signal to earth or colonies
                    if (choice == 1) scene = 8; //earth
                    else scene = 9; //colonies
                    break;

                case 7: //injured path
                    if (choice == 1) scene = 8;
                    else scene = 9;
                    break;

                case 8: //planet detected (land or orbit)
                    if (choice == 1) scene = 10; //land
                    else scene = 98; //rescued ending
                    break;

                case 9: // Planet detected from colony scan
                    if (choice == 1) scene = 10;
                    else scene = 98;
                    break;

                case 10: // Suit integrity before landing
                    if (choice == 1) scene = 11; // fix suit
                    else scene = 11; // risk it
                    break;

                case 11: //alien encounter (3 choices)
                    if (choice == 1) scene = 91; // peaceful
                    else if (choice == 2) scene = 92; // hide
                    else scene = 93; // attack
                    break;

                default:
                    Application.Exit();
                    break;
            }

            DisplayScene();
        }

        private void DisplayScene()
        {
            choice3Button.Visible = false;

            switch (scene)
            {
                case 0:
                    BackgroundImage = Properties.Resources.cockpit;
                    outputLabel.Text = "You wake up to flashing red lights." + "\n";
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "“Warning: oxygen levels critical.”";
                    choice1Button.Text = "Check damage";
                    choice2Button.Text = "Check oxygen";
                    break;

                case 1:
                    BackgroundImage = Properties.Resources.
                    outputLabel.Text = "A hull breach alarm blares. Try to repair it or seal the door?";
                    choice1Button.Text = "Repair breach";
                    choice2Button.Text = "Seal the door";
                    break;

                case 2:
                    BackgroundImage = Properties.Resources.
                   outputLabel.Text = "Oxygen at 25%. Head for the control room or the escape pod?";
                    choice1Button.Text = "Control room";
                    choice2Button.Text = "Escape pod";
                    break;

                case 3:
                    BackgroundImage = Properties.Resources.
                   outputLabel.Text = "You repair the hull. You find the emergency generator sparking. Divert power?";
                    choice1Button.Text = "Oxygen systems";
                    choice2Button.Text = "Communications";
                    break;

                case 4:
                    outputLabel.Text = "You seal off the breach and move toward the control room.";
                    choice1Button.Text = "Continue";
                    choice2Button.Text = "";
                    break;

                case 5:
                    BackgroundImage = Properties.Resources.corridor;
                   outputLabel.Text = "You must cross a damaged corridor to reach the control room...";
                    choice1Button.Text = "Proceed";
                    choice2Button.Text = "";
                    break;

                case 6:
                    BackgroundImage = Properties.Resources.controlPanel;
                    outputLabel.Text = "You make it safely. Send a signal to Earth or nearby colonies?";
                    choice1Button.Text = "Earth";
                    choice2Button.Text = "Colonies";
                    break;

                case 7:
                    BackgroundImage = Properties.Resources.controlPanel;
                   outputLabel.Text = "You’re injured crossing the corridor. Oxygen leaks faster. Send a signal?";
                    choice1Button.Text = "Earth";
                    choice2Button.Text = "Colonies";
                    break;

                case 8:
                    BackgroundImage = Properties.Resources.window;
                   outputLabel.Text = "Sensors detect a small livable planet nearby. Land or stay in orbit?";
                    choice1Button.Text = "Land";
                    choice2Button.Text = "Stay in orbit";
                    break;

                case 9:
                    BackgroundImage = Properties.Resources.window;
                   outputLabel.Text = "A livable planet shows up on your scan. Land or stay in orbit?";
                    choice1Button.Text = "Land";
                    choice2Button.Text = "Stay in orbit";
                    break;

                case 10:
                   outputLabel.Text = "Your suit valve is loose. Fix it now or risk it during descent?";
                    choice1Button.Text = "Fix it";
                    choice2Button.Text = "Hope it holds";
                    break;

                case 11:
                    BackgroundImage = Properties.Resources.
                   outputLabel.Text = "You encounter alien lifeforms! What do you do?";
                    choice1Button.Text = "Approach peacefully";
                    choice2Button.Text = "Hide";
                    choice3Button.Text = "Attack";
                    choice3Button.Visible = true;
                    break;

                case 91:
                    BackgroundImage = Properties.Resources.
                   outputLabel.Text = "The aliens accept your peaceful approach. You form an alliance.";
                    choice1Button.Text = "End Game";
                    choice2Button.Text = "";
                    break;

                case 92:
                    BackgroundImage = Properties.Resources.
                   outputLabel.Text = "You try to hide, but the aliens find you. You’re captured.";
                    choice1Button.Text = "End Game";
                    choice2Button.Text = "";
                    break;

                case 93:
                    BackgroundImage = Properties.Resources.
                   outputLabel.Text = "You attack the aliens. They retaliate. You’re destroyed.";
                    choice1Button.Text = "End Game";
                    choice2Button.Text = "";
                    break;

                case 98:
                    BackgroundImage = Properties.Resources.
                   outputLabel.Text = "You stay in orbit. A rescue ship arrives. You’re saved!";
                    choice1Button.Text = "End Game";
                    choice2Button.Text = "";
                    break;

                case 99:
                    BackgroundImage = Properties.Resources.
                   outputLabel.Text = "You launch the escape pod but drift endlessly into space...";
                    choice1Button.Text = "End Game";
                    choice2Button.Text = "";
                    break;
            }

        }
    }
}

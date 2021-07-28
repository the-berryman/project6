using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project6
{
    public partial class project6 : Form
    {
        string selectedTeam;
        

        public project6()
        {
            InitializeComponent();

            
            string seriesWinners;
            string teamList;

           StreamReader inputFile;

            inputFile = File.OpenText("Teams.txt");

            while (!inputFile.EndOfStream)
            {
                teamList = inputFile.ReadLine();
                teamsList.Items.Add(teamList);
                
            }
            inputFile.Close();



                    
            inputFile = File.OpenText("WorldSeries.txt");

            while (!inputFile.EndOfStream)
            {
                seriesWinners = inputFile.ReadLine();
                winnersList.Items.Add(seriesWinners);


            }

            inputFile.Close();




        }
            

       

        private void teamsList_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                selectedTeam = teamsList.Items[teamsList.SelectedIndex].ToString();
        }

        private void calculatePush_Click(object sender, EventArgs e)
        {
            try
            {
              

                string[] winnerList = File.ReadAllLines("WorldSeries.txt");

                int listsize = winnerList.Length;
                int index = 0;
                int wincount = 0;
                int realwins;
                


                foreach (string name in winnerList)
                {
                    if(selectedTeam == winnerList[index])
                    {
                        wincount++;

                    }

                    else
                    {
                        
                        index++;
                    }
                }


                realwins = wincount / 7;


                totalwins.Text = "The " + selectedTeam + " have won the world series " + realwins.ToString() + " times.";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitPush_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
                



        }

       
    
    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();       //instantiates new random generator

        int D_mod_selected = 0;          //public variable instantiation
        int D_num_selected = 0;

        public Form1()
        {
            InitializeComponent();       //On application start....
            D_Num.Items.Add(1);
            D_Num.Items.Add(2);
            D_Num.Items.Add(3);
            D_Num.Items.Add(4);
            D_Num.Items.Add(5);
                                         //...instantiates all combo box values to make available
            D_Mod.Items.Add(-5);
            D_Mod.Items.Add(-4);
            D_Mod.Items.Add(-3);
            D_Mod.Items.Add(-2);
            D_Mod.Items.Add(-1);
            D_Mod.Items.Add(0);
            D_Mod.Items.Add(1);
            D_Mod.Items.Add(2);
            D_Mod.Items.Add(3);
            D_Mod.Items.Add(4);
            D_Mod.Items.Add(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            D_Mod.SelectedIndex = 5;                      // default values for combo boxes
            D_Num.SelectedIndex = 0;

            ToolTip D_Num_Info = new ToolTip();
            D_Num_Info.SetToolTip(this.D_Num, "Number of Dice to be rolled");    //tooltips when hover (D_Num Combo Box)

            ToolTip D_Mod_Info = new ToolTip();
            D_Mod_Info.SetToolTip(this.D_Mod, "Stat modifiers to be applied");   //tooltips when hover (D_Mod Combo Box)
        }

        private void D20_Roll_Click(object sender, EventArgs e)                                              //D20 Roller and display
        {
            int sides = 20;                                                                                  //passes side of the dice
            D20_Result.Text = Dice_Roller(sides);                                                            //pass amount of sides on desired dice
            Res_Log_Box.AppendText("D20: " + D20_Result.Text + "      " + DateTime.Now.ToString("h:mm:ss")); //log result in log box
            Res_Log_Box.AppendText(Environment.NewLine);                                                     //make new line for following result
        }
           
        private void D12_Roll_Click(object sender, EventArgs e)                                              //D12 Roller and display
        {
            int sides = 12;
            D12_Result.Text = Dice_Roller(sides);
            Res_Log_Box.AppendText("D12: " + D12_Result.Text + "      " + DateTime.Now.ToString("h:mm:ss"));
            Res_Log_Box.AppendText(Environment.NewLine);
        }

        private void D10_Roll_Click(object sender, EventArgs e)                                              //D10 Roller and display
        {
            int sides = 10;
            D10_Result.Text = Dice_Roller(sides);
            Res_Log_Box.AppendText("D10: " + D10_Result.Text + "      " + DateTime.Now.ToString("h:mm:ss"));
            Res_Log_Box.AppendText(Environment.NewLine);
        }

        private void D8_Roll_Click(object sender, EventArgs e)                                               //D8 Roller and display
        {
            int sides = 8;
            D8_Result.Text = Dice_Roller(sides);
            Res_Log_Box.AppendText("D8: " + D8_Result.Text + "       " + DateTime.Now.ToString("h:mm:ss"));
            Res_Log_Box.AppendText(Environment.NewLine);
        }

        private void D6_Roll_Click(object sender, EventArgs e)                                               //D6 Roller and display
        {
            int sides = 6;
            D6_Result.Text = Dice_Roller(sides);
            Res_Log_Box.AppendText("D6: " + D6_Result.Text + "       " + DateTime.Now.ToString("h:mm:ss"));
            Res_Log_Box.AppendText(Environment.NewLine);
        }

        private void D4_Roll_Click(object sender, EventArgs e)                                               //D4 Roller and display
        {
            int sides = 4;
            D4_Result.Text = Dice_Roller(sides);
            Res_Log_Box.AppendText("D4: " + D4_Result.Text + "       " + DateTime.Now.ToString("h:mm:ss"));
            Res_Log_Box.AppendText(Environment.NewLine);
        }

        public String Dice_Roller(int sides)                                                                 //Method for actual rolling of the dice
        {
            int d_res = 0;
            int d_res_w_mods = 0;
            int d_final_res = 0;
                conversion();                                  //converts combo box to String, then int (see method)

                for (int x = 0; x < (D_num_selected); x++)     //Rolls dependant on the number of dice selected
                {
                    d_res = rnd.Next(1, sides + 1);            //1 <= d_res < sides + 1
                    d_final_res = d_final_res + d_res;         //recursive overwriting
                }
                d_res_w_mods = d_final_res + D_mod_selected;
                string d_res_fill = d_res_w_mods.ToString();   //Convert Reult of roll and D_Num and D_Mod to String from Int
                return d_res_fill;                             //Value returned to be displayed
        }

        private void clear_Click(object sender, EventArgs e)   //When Clear Button is clicked...
        {
            D20_Result.Text = null;
            D12_Result.Text = null;
            D10_Result.Text = null;                            //Clear all Text boxes next to the Dice Buttons 
            D8_Result.Text = null;
            D6_Result.Text = null;
            D4_Result.Text = null;
        }

        private void Clear_Log_Click(object sender, EventArgs e)  //When Clear Log Button is clicked...
        {
            Res_Log_Box.Text = null;                              //...Clear Log Box
        }

        public void conversion()
        {
            D_mod_selected = Int32.Parse(this.D_Mod.SelectedItem.ToString());
            D_num_selected = Int32.Parse(this.D_Num.SelectedItem.ToString());
        }

    }
}
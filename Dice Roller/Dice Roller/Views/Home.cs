using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class Home : Form
    {
        Random rnd = new Random();

        int D_mod_selected = 0;
        int D_num_selected = 0;

        public Home()
        {
            InitializeComponent();
            LoadDropDowns();
        }

        private void LoadDropDowns()
        {
            var quantityOptions = new List<int> { 1, 2, 3, 4, 5 };
            var modifierOptions = new List<int> { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

            foreach (int item in quantityOptions)
            {
                D_Num.Items.Add(item);
            }

            foreach (int item in modifierOptions)
            {
                D_Mod.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            D_Mod.SelectedIndex = 5;
            D_Num.SelectedIndex = 0;

            var D_Num_Info = new ToolTip();
            D_Num_Info.SetToolTip(D_Num, "Number of Dice to be rolled");

            var D_Mod_Info = new ToolTip();
            D_Mod_Info.SetToolTip(D_Mod, "Stat modifiers to be applied");
        }

        private void D20_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D20_Result, $"D20: {D20_Result.Text} ({DateTime.Now:h:mm:ss})", 20);
        }
           
        private void D12_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D12_Result, $"D12: {D12_Result.Text} ({DateTime.Now:h:mm:ss})", 12);
        }

        private void D10_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D10_Result, $"D10: {D10_Result.Text} ({DateTime.Now:h:mm:ss})", 10);
        }

        private void D8_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D8_Result, $"D8: {D8_Result.Text} ({DateTime.Now:h:mm:ss})", 8);
        }

        private void D6_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D8_Result, $"D6: {D6_Result.Text} ({DateTime.Now:h:mm:ss})", 6);
        }

        private void D4_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D4_Result, $"D4: {D4_Result.Text} ({DateTime.Now:h:mm:ss})", 4);
        }

        public string Dice_Roller(int sides)
        {
            int d_res = 0;
            int d_res_w_mods = 0;
            int d_final_res = 0;
                conversion();

                for (int x = 0; x < (D_num_selected); x++)
                {
                    d_res = rnd.Next(1, sides + 1);
                    d_final_res = d_final_res + d_res;
                }
                d_res_w_mods = d_final_res + D_mod_selected;
                string d_res_fill = d_res_w_mods.ToString();
                return d_res_fill;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            D20_Result.Text = null;
            D12_Result.Text = null;
            D10_Result.Text = null;
            D8_Result.Text = null;
            D6_Result.Text = null;
            D4_Result.Text = null;
        }

        private void Clear_Log_Click(object sender, EventArgs e)
        {
            Res_Log_Box.Text = null;
        }

        public void conversion()
        {
            D_mod_selected = Int32.Parse(this.D_Mod.SelectedItem.ToString());
            D_num_selected = Int32.Parse(this.D_Num.SelectedItem.ToString());
        }

        private void AppendLogEntry(TextBox target, string text, int sides)
        {
            target.Text = Dice_Roller(sides);
            Res_Log_Box.AppendText(text);
            Res_Log_Box.AppendText(Environment.NewLine);
        }
    }
}
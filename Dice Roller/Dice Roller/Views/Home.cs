﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class Home : Form
    {
        Random random = new Random();

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

        private void Home_Load(object sender, EventArgs e)
        {
            D_Mod.SelectedIndex = 5;
            D_Num.SelectedIndex = 0;

            var quantityToolTip = new ToolTip();
            quantityToolTip.SetToolTip(D_Num, "Number of Dice to be rolled");

            var modifierToolTip = new ToolTip();
            modifierToolTip.SetToolTip(D_Mod, "Stat modifiers to be applied");
        }

        public string Dice_Roller(int sides)
        {
            int result = 0;
            ParseSelectedValues();

            for (int x = 0; x < D_num_selected; x++)
            {
                result += random.Next(1, sides + 1);
            }
            return (result + D_mod_selected).ToString();
        }

        private void Clear_LastResult_Click(object sender, EventArgs e)
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

        private void AppendLogEntry(TextBox target, string text, int sides)
        {
            target.Text = Dice_Roller(sides);
            Res_Log_Box.AppendText(text);
            Res_Log_Box.AppendText(Environment.NewLine);
        }

        private void D20_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D20_Result, $"D20: {D20_Result.Text} ({DateTime.Now:h:mm:ss tt})", 20);
        }

        private void D12_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D12_Result, $"D12: {D12_Result.Text} ({DateTime.Now:h:mm:ss tt})", 12);
        }

        private void D10_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D10_Result, $"D10: {D10_Result.Text} ({DateTime.Now:h:mm:ss tt})", 10);
        }

        private void D8_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D8_Result, $"D8: {D8_Result.Text} ({DateTime.Now:h:mm:ss tt})", 8);
        }

        private void D6_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D6_Result, $"D6: {D6_Result.Text} ({DateTime.Now:h:mm:ss tt})", 6);
        }

        private void D4_Roll_Click(object sender, EventArgs e)
        {
            AppendLogEntry(D4_Result, $"D4: {D4_Result.Text} ({DateTime.Now:h:mm:ss tt})", 4);
        }

        public void ParseSelectedValues()
        {
            D_mod_selected = int.Parse(D_Mod.SelectedItem.ToString());
            D_num_selected = int.Parse(D_Num.SelectedItem.ToString());
        }
    }
}
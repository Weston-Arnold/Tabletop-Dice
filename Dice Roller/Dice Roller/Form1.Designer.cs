namespace Dice_Roller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.D20_Roll = new System.Windows.Forms.Button();
            this.D20_Result = new System.Windows.Forms.TextBox();
            this.D12_Roll = new System.Windows.Forms.Button();
            this.D12_Result = new System.Windows.Forms.TextBox();
            this.D10_Roll = new System.Windows.Forms.Button();
            this.D8_Roll = new System.Windows.Forms.Button();
            this.D6_Roll = new System.Windows.Forms.Button();
            this.D4_Roll = new System.Windows.Forms.Button();
            this.D10_Result = new System.Windows.Forms.TextBox();
            this.D8_Result = new System.Windows.Forms.TextBox();
            this.D6_Result = new System.Windows.Forms.TextBox();
            this.D4_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.D_Mod = new System.Windows.Forms.ComboBox();
            this.Dice_Num = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.D_Num = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Button();
            this.Res_Log_Box = new System.Windows.Forms.TextBox();
            this.Clear_Log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // D20_Roll
            // 
            this.D20_Roll.Location = new System.Drawing.Point(302, 39);
            this.D20_Roll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D20_Roll.Name = "D20_Roll";
            this.D20_Roll.Size = new System.Drawing.Size(120, 37);
            this.D20_Roll.TabIndex = 0;
            this.D20_Roll.Text = "D20";
            this.D20_Roll.UseVisualStyleBackColor = true;
            this.D20_Roll.Click += new System.EventHandler(this.D20_Roll_Click);
            // 
            // D20_Result
            // 
            this.D20_Result.Location = new System.Drawing.Point(457, 45);
            this.D20_Result.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D20_Result.Name = "D20_Result";
            this.D20_Result.ReadOnly = true;
            this.D20_Result.Size = new System.Drawing.Size(106, 21);
            this.D20_Result.TabIndex = 1;
            // 
            // D12_Roll
            // 
            this.D12_Roll.Location = new System.Drawing.Point(302, 98);
            this.D12_Roll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D12_Roll.Name = "D12_Roll";
            this.D12_Roll.Size = new System.Drawing.Size(120, 37);
            this.D12_Roll.TabIndex = 2;
            this.D12_Roll.Text = "D12";
            this.D12_Roll.UseVisualStyleBackColor = true;
            this.D12_Roll.Click += new System.EventHandler(this.D12_Roll_Click);
            // 
            // D12_Result
            // 
            this.D12_Result.Location = new System.Drawing.Point(457, 104);
            this.D12_Result.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D12_Result.Name = "D12_Result";
            this.D12_Result.ReadOnly = true;
            this.D12_Result.Size = new System.Drawing.Size(106, 21);
            this.D12_Result.TabIndex = 3;
            // 
            // D10_Roll
            // 
            this.D10_Roll.Location = new System.Drawing.Point(302, 158);
            this.D10_Roll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D10_Roll.Name = "D10_Roll";
            this.D10_Roll.Size = new System.Drawing.Size(120, 37);
            this.D10_Roll.TabIndex = 4;
            this.D10_Roll.Text = "D10";
            this.D10_Roll.UseVisualStyleBackColor = true;
            this.D10_Roll.Click += new System.EventHandler(this.D10_Roll_Click);
            // 
            // D8_Roll
            // 
            this.D8_Roll.Location = new System.Drawing.Point(302, 215);
            this.D8_Roll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D8_Roll.Name = "D8_Roll";
            this.D8_Roll.Size = new System.Drawing.Size(120, 37);
            this.D8_Roll.TabIndex = 5;
            this.D8_Roll.Text = "D8";
            this.D8_Roll.UseVisualStyleBackColor = true;
            this.D8_Roll.Click += new System.EventHandler(this.D8_Roll_Click);
            // 
            // D6_Roll
            // 
            this.D6_Roll.Location = new System.Drawing.Point(302, 274);
            this.D6_Roll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D6_Roll.Name = "D6_Roll";
            this.D6_Roll.Size = new System.Drawing.Size(120, 37);
            this.D6_Roll.TabIndex = 6;
            this.D6_Roll.Text = "D6";
            this.D6_Roll.UseVisualStyleBackColor = true;
            this.D6_Roll.Click += new System.EventHandler(this.D6_Roll_Click);
            // 
            // D4_Roll
            // 
            this.D4_Roll.Location = new System.Drawing.Point(302, 334);
            this.D4_Roll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D4_Roll.Name = "D4_Roll";
            this.D4_Roll.Size = new System.Drawing.Size(120, 37);
            this.D4_Roll.TabIndex = 7;
            this.D4_Roll.Text = "D4";
            this.D4_Roll.UseVisualStyleBackColor = true;
            this.D4_Roll.Click += new System.EventHandler(this.D4_Roll_Click);
            // 
            // D10_Result
            // 
            this.D10_Result.Location = new System.Drawing.Point(457, 164);
            this.D10_Result.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D10_Result.Name = "D10_Result";
            this.D10_Result.ReadOnly = true;
            this.D10_Result.Size = new System.Drawing.Size(106, 21);
            this.D10_Result.TabIndex = 8;
            // 
            // D8_Result
            // 
            this.D8_Result.Location = new System.Drawing.Point(457, 220);
            this.D8_Result.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D8_Result.Name = "D8_Result";
            this.D8_Result.ReadOnly = true;
            this.D8_Result.Size = new System.Drawing.Size(106, 21);
            this.D8_Result.TabIndex = 9;
            // 
            // D6_Result
            // 
            this.D6_Result.Location = new System.Drawing.Point(457, 280);
            this.D6_Result.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D6_Result.Name = "D6_Result";
            this.D6_Result.ReadOnly = true;
            this.D6_Result.Size = new System.Drawing.Size(106, 21);
            this.D6_Result.TabIndex = 10;
            // 
            // D4_Result
            // 
            this.D4_Result.Location = new System.Drawing.Point(457, 341);
            this.D4_Result.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D4_Result.Name = "D4_Result";
            this.D4_Result.ReadOnly = true;
            this.D4_Result.Size = new System.Drawing.Size(106, 21);
            this.D4_Result.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dice Selector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Result";
            // 
            // D_Mod
            // 
            this.D_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.D_Mod.FormattingEnabled = true;
            this.D_Mod.Location = new System.Drawing.Point(175, 45);
            this.D_Mod.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D_Mod.Name = "D_Mod";
            this.D_Mod.Size = new System.Drawing.Size(86, 23);
            this.D_Mod.TabIndex = 25;
            // 
            // Dice_Num
            // 
            this.Dice_Num.AutoSize = true;
            this.Dice_Num.Location = new System.Drawing.Point(26, 9);
            this.Dice_Num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dice_Num.Name = "Dice_Num";
            this.Dice_Num.Size = new System.Drawing.Size(71, 15);
            this.Dice_Num.TabIndex = 24;
            this.Dice_Num.Text = "Dice Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Modifier";
            // 
            // D_Num
            // 
            this.D_Num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.D_Num.FormattingEnabled = true;
            this.D_Num.Location = new System.Drawing.Point(30, 45);
            this.D_Num.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.D_Num.Name = "D_Num";
            this.D_Num.Size = new System.Drawing.Size(86, 23);
            this.D_Num.TabIndex = 26;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(457, 396);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(105, 34);
            this.clear.TabIndex = 27;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Res_Log_Box
            // 
            this.Res_Log_Box.Location = new System.Drawing.Point(30, 98);
            this.Res_Log_Box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Res_Log_Box.Multiline = true;
            this.Res_Log_Box.Name = "Res_Log_Box";
            this.Res_Log_Box.ReadOnly = true;
            this.Res_Log_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Res_Log_Box.Size = new System.Drawing.Size(234, 273);
            this.Res_Log_Box.TabIndex = 28;
            // 
            // Clear_Log
            // 
            this.Clear_Log.Location = new System.Drawing.Point(89, 396);
            this.Clear_Log.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Clear_Log.Name = "Clear_Log";
            this.Clear_Log.Size = new System.Drawing.Size(105, 34);
            this.Clear_Log.TabIndex = 29;
            this.Clear_Log.Text = "Clear Log";
            this.Clear_Log.UseVisualStyleBackColor = true;
            this.Clear_Log.Click += new System.EventHandler(this.Clear_Log_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 447);
            this.Controls.Add(this.Clear_Log);
            this.Controls.Add(this.Res_Log_Box);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.D_Num);
            this.Controls.Add(this.D_Mod);
            this.Controls.Add(this.Dice_Num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D4_Result);
            this.Controls.Add(this.D6_Result);
            this.Controls.Add(this.D8_Result);
            this.Controls.Add(this.D10_Result);
            this.Controls.Add(this.D4_Roll);
            this.Controls.Add(this.D6_Roll);
            this.Controls.Add(this.D8_Roll);
            this.Controls.Add(this.D10_Roll);
            this.Controls.Add(this.D12_Result);
            this.Controls.Add(this.D12_Roll);
            this.Controls.Add(this.D20_Result);
            this.Controls.Add(this.D20_Roll);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button D20_Roll;
        private System.Windows.Forms.TextBox D20_Result;
        private System.Windows.Forms.Button D12_Roll;
        private System.Windows.Forms.TextBox D12_Result;
        private System.Windows.Forms.Button D10_Roll;
        private System.Windows.Forms.Button D8_Roll;
        private System.Windows.Forms.Button D6_Roll;
        private System.Windows.Forms.Button D4_Roll;
        private System.Windows.Forms.TextBox D10_Result;
        private System.Windows.Forms.TextBox D8_Result;
        private System.Windows.Forms.TextBox D6_Result;
        private System.Windows.Forms.TextBox D4_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox D_Mod;
        private System.Windows.Forms.Label Dice_Num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox D_Num;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox Res_Log_Box;
        private System.Windows.Forms.Button Clear_Log;
    }
}


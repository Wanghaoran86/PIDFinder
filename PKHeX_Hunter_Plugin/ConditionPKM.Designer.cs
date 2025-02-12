﻿namespace PKHeX_Hunter_Plugin
{
    partial class ConditionPKM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeMin = new System.Windows.Forms.TextBox();
            this.SpDMin = new System.Windows.Forms.TextBox();
            this.SpAMin = new System.Windows.Forms.TextBox();
            this.DefMin = new System.Windows.Forms.TextBox();
            this.AtkMin = new System.Windows.Forms.TextBox();
            this.HPMin = new System.Windows.Forms.TextBox();
            this.SpeMax = new System.Windows.Forms.TextBox();
            this.SpDMax = new System.Windows.Forms.TextBox();
            this.SpAMax = new System.Windows.Forms.TextBox();
            this.DefMax = new System.Windows.Forms.TextBox();
            this.AtkMax = new System.Windows.Forms.TextBox();
            this.HPMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Shiny = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Natures = new PKHeX_Hunter_Plugin.CheckedComboBox();
            this.CB_Ability = new System.Windows.Forms.ComboBox();
            this.CB_Gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "Speed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 46;
            this.label10.Text = "SpD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 45;
            this.label7.Text = "SpA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 44;
            this.label8.Text = "Def";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 43;
            this.label6.Text = "Atk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "HP";
            // 
            // SpeMin
            // 
            this.SpeMin.Location = new System.Drawing.Point(58, 129);
            this.SpeMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpeMin.MaxLength = 2;
            this.SpeMin.Name = "SpeMin";
            this.SpeMin.Size = new System.Drawing.Size(21, 21);
            this.SpeMin.TabIndex = 41;
            this.SpeMin.Text = "0";
            this.SpeMin.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // SpDMin
            // 
            this.SpDMin.Location = new System.Drawing.Point(58, 104);
            this.SpDMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpDMin.MaxLength = 2;
            this.SpDMin.Name = "SpDMin";
            this.SpDMin.Size = new System.Drawing.Size(21, 21);
            this.SpDMin.TabIndex = 40;
            this.SpDMin.Text = "0";
            this.SpDMin.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // SpAMin
            // 
            this.SpAMin.Location = new System.Drawing.Point(58, 79);
            this.SpAMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpAMin.MaxLength = 2;
            this.SpAMin.Name = "SpAMin";
            this.SpAMin.Size = new System.Drawing.Size(21, 21);
            this.SpAMin.TabIndex = 39;
            this.SpAMin.Text = "0";
            this.SpAMin.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // DefMin
            // 
            this.DefMin.Location = new System.Drawing.Point(58, 53);
            this.DefMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DefMin.MaxLength = 2;
            this.DefMin.Name = "DefMin";
            this.DefMin.Size = new System.Drawing.Size(21, 21);
            this.DefMin.TabIndex = 38;
            this.DefMin.Text = "0";
            this.DefMin.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // AtkMin
            // 
            this.AtkMin.Location = new System.Drawing.Point(58, 28);
            this.AtkMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtkMin.MaxLength = 2;
            this.AtkMin.Name = "AtkMin";
            this.AtkMin.Size = new System.Drawing.Size(21, 21);
            this.AtkMin.TabIndex = 37;
            this.AtkMin.Text = "0";
            this.AtkMin.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // HPMin
            // 
            this.HPMin.Location = new System.Drawing.Point(58, 2);
            this.HPMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HPMin.MaxLength = 2;
            this.HPMin.Name = "HPMin";
            this.HPMin.Size = new System.Drawing.Size(21, 21);
            this.HPMin.TabIndex = 36;
            this.HPMin.Text = "0";
            this.HPMin.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // SpeMax
            // 
            this.SpeMax.Location = new System.Drawing.Point(97, 129);
            this.SpeMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpeMax.MaxLength = 2;
            this.SpeMax.Name = "SpeMax";
            this.SpeMax.Size = new System.Drawing.Size(21, 21);
            this.SpeMax.TabIndex = 35;
            this.SpeMax.Text = "31";
            this.SpeMax.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // SpDMax
            // 
            this.SpDMax.Location = new System.Drawing.Point(97, 104);
            this.SpDMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpDMax.MaxLength = 2;
            this.SpDMax.Name = "SpDMax";
            this.SpDMax.Size = new System.Drawing.Size(21, 21);
            this.SpDMax.TabIndex = 34;
            this.SpDMax.Text = "31";
            this.SpDMax.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // SpAMax
            // 
            this.SpAMax.Location = new System.Drawing.Point(97, 79);
            this.SpAMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpAMax.MaxLength = 2;
            this.SpAMax.Name = "SpAMax";
            this.SpAMax.Size = new System.Drawing.Size(21, 21);
            this.SpAMax.TabIndex = 33;
            this.SpAMax.Text = "31";
            this.SpAMax.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // DefMax
            // 
            this.DefMax.Location = new System.Drawing.Point(97, 53);
            this.DefMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DefMax.MaxLength = 2;
            this.DefMax.Name = "DefMax";
            this.DefMax.Size = new System.Drawing.Size(21, 21);
            this.DefMax.TabIndex = 32;
            this.DefMax.Text = "31";
            this.DefMax.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // AtkMax
            // 
            this.AtkMax.Location = new System.Drawing.Point(97, 28);
            this.AtkMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AtkMax.MaxLength = 2;
            this.AtkMax.Name = "AtkMax";
            this.AtkMax.Size = new System.Drawing.Size(21, 21);
            this.AtkMax.TabIndex = 31;
            this.AtkMax.Text = "31";
            this.AtkMax.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // HPMax
            // 
            this.HPMax.Location = new System.Drawing.Point(97, 2);
            this.HPMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HPMax.MaxLength = 2;
            this.HPMax.Name = "HPMax";
            this.HPMax.Size = new System.Drawing.Size(21, 21);
            this.HPMax.TabIndex = 30;
            this.HPMax.Text = "31";
            this.HPMax.TextChanged += new System.EventHandler(this.IVS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "Shiny";
            // 
            // CB_Shiny
            // 
            this.CB_Shiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Shiny.FormattingEnabled = true;
            this.CB_Shiny.Location = new System.Drawing.Point(215, 119);
            this.CB_Shiny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Shiny.Name = "CB_Shiny";
            this.CB_Shiny.Size = new System.Drawing.Size(92, 20);
            this.CB_Shiny.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 51;
            this.label4.Text = "Ability";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "Gender";
            // 
            // CB_Natures
            // 
            this.CB_Natures.CheckOnClick = true;
            this.CB_Natures.DefaultValue = null;
            this.CB_Natures.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CB_Natures.DropDownHeight = 1;
            this.CB_Natures.FormattingEnabled = true;
            this.CB_Natures.IntegralHeight = false;
            this.CB_Natures.Location = new System.Drawing.Point(215, 34);
            this.CB_Natures.Name = "CB_Natures";
            this.CB_Natures.Size = new System.Drawing.Size(92, 22);
            this.CB_Natures.TabIndex = 53;
            this.CB_Natures.ValueSeparator = ", ";
            // 
            // CB_Ability
            // 
            this.CB_Ability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Ability.FormattingEnabled = true;
            this.CB_Ability.Location = new System.Drawing.Point(215, 64);
            this.CB_Ability.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Ability.Name = "CB_Ability";
            this.CB_Ability.Size = new System.Drawing.Size(92, 20);
            this.CB_Ability.TabIndex = 54;
            // 
            // CB_Gender
            // 
            this.CB_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Gender.FormattingEnabled = true;
            this.CB_Gender.Location = new System.Drawing.Point(215, 91);
            this.CB_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Gender.Name = "CB_Gender";
            this.CB_Gender.Size = new System.Drawing.Size(92, 20);
            this.CB_Gender.TabIndex = 55;
            // 
            // ConditionPKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CB_Gender);
            this.Controls.Add(this.CB_Ability);
            this.Controls.Add(this.CB_Natures);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Shiny);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeMin);
            this.Controls.Add(this.SpDMin);
            this.Controls.Add(this.SpAMin);
            this.Controls.Add(this.DefMin);
            this.Controls.Add(this.AtkMin);
            this.Controls.Add(this.HPMin);
            this.Controls.Add(this.SpeMax);
            this.Controls.Add(this.SpDMax);
            this.Controls.Add(this.SpAMax);
            this.Controls.Add(this.DefMax);
            this.Controls.Add(this.AtkMax);
            this.Controls.Add(this.HPMax);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConditionPKM";
            this.Size = new System.Drawing.Size(329, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SpeMin;
        private System.Windows.Forms.TextBox SpDMin;
        private System.Windows.Forms.TextBox SpAMin;
        private System.Windows.Forms.TextBox DefMin;
        private System.Windows.Forms.TextBox AtkMin;
        private System.Windows.Forms.TextBox HPMin;
        private System.Windows.Forms.TextBox SpeMax;
        private System.Windows.Forms.TextBox SpDMax;
        private System.Windows.Forms.TextBox SpAMax;
        private System.Windows.Forms.TextBox DefMax;
        private System.Windows.Forms.TextBox AtkMax;
        private System.Windows.Forms.TextBox HPMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Shiny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private PKHeX_Hunter_Plugin.CheckedComboBox CB_Natures;
        private System.Windows.Forms.ComboBox CB_Ability;
        private System.Windows.Forms.ComboBox CB_Gender;
    }
}

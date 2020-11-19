namespace WindowsFormsApp1
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
            this.EnvironmentListBox = new System.Windows.Forms.ListBox();
            this.CageButton = new System.Windows.Forms.RadioButton();
            this.AquariumButton = new System.Windows.Forms.RadioButton();
            this.TerrariumButton = new System.Windows.Forms.RadioButton();
            this.InhabitantType = new System.Windows.Forms.TextBox();
            this.AquariumPH = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WaterPHLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CleanTimeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FeedTimeTextBox = new System.Windows.Forms.TextBox();
            this.WPHLabel = new System.Windows.Forms.Label();
            this.WaterPHTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InhabitantCountTextBox = new System.Windows.Forms.TextBox();
            this.AddInhabitantButton = new System.Windows.Forms.Button();
            this.RemoveInhabitantButton = new System.Windows.Forms.Button();
            this.FeedButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.InhabitantTypeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RemoveEnvironmentButton = new System.Windows.Forms.Button();
            this.InhabitantCounter = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AquariumPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InhabitantCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // EnvironmentListBox
            // 
            this.EnvironmentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnvironmentListBox.FormattingEnabled = true;
            this.EnvironmentListBox.ItemHeight = 24;
            this.EnvironmentListBox.Location = new System.Drawing.Point(24, 125);
            this.EnvironmentListBox.Name = "EnvironmentListBox";
            this.EnvironmentListBox.Size = new System.Drawing.Size(321, 316);
            this.EnvironmentListBox.TabIndex = 0;
            this.EnvironmentListBox.SelectedIndexChanged += new System.EventHandler(this.EnvironmentListBox_SelectedIndexChanged);
            // 
            // CageButton
            // 
            this.CageButton.AutoSize = true;
            this.CageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CageButton.Location = new System.Drawing.Point(33, 635);
            this.CageButton.Name = "CageButton";
            this.CageButton.Size = new System.Drawing.Size(61, 22);
            this.CageButton.TabIndex = 1;
            this.CageButton.TabStop = true;
            this.CageButton.Text = "Cage";
            this.CageButton.UseVisualStyleBackColor = true;
            this.CageButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // AquariumButton
            // 
            this.AquariumButton.AutoSize = true;
            this.AquariumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AquariumButton.Location = new System.Drawing.Point(33, 612);
            this.AquariumButton.Name = "AquariumButton";
            this.AquariumButton.Size = new System.Drawing.Size(88, 22);
            this.AquariumButton.TabIndex = 2;
            this.AquariumButton.TabStop = true;
            this.AquariumButton.Text = "Aquarium";
            this.AquariumButton.UseVisualStyleBackColor = true;
            this.AquariumButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // TerrariumButton
            // 
            this.TerrariumButton.AutoSize = true;
            this.TerrariumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerrariumButton.Location = new System.Drawing.Point(33, 658);
            this.TerrariumButton.Name = "TerrariumButton";
            this.TerrariumButton.Size = new System.Drawing.Size(90, 22);
            this.TerrariumButton.TabIndex = 3;
            this.TerrariumButton.TabStop = true;
            this.TerrariumButton.Text = "Terrarium";
            this.TerrariumButton.UseVisualStyleBackColor = true;
            this.TerrariumButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // InhabitantType
            // 
            this.InhabitantType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InhabitantType.Location = new System.Drawing.Point(190, 628);
            this.InhabitantType.Name = "InhabitantType";
            this.InhabitantType.Size = new System.Drawing.Size(215, 26);
            this.InhabitantType.TabIndex = 4;
            // 
            // AquariumPH
            // 
            this.AquariumPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AquariumPH.Location = new System.Drawing.Point(448, 628);
            this.AquariumPH.Name = "AquariumPH";
            this.AquariumPH.Size = new System.Drawing.Size(73, 26);
            this.AquariumPH.TabIndex = 5;
            this.AquariumPH.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(563, 627);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(146, 28);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add Environment";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inhabitant";
            // 
            // WaterPHLabel
            // 
            this.WaterPHLabel.AutoSize = true;
            this.WaterPHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterPHLabel.Location = new System.Drawing.Point(443, 577);
            this.WaterPHLabel.Name = "WaterPHLabel";
            this.WaterPHLabel.Size = new System.Drawing.Size(77, 20);
            this.WaterPHLabel.TabIndex = 9;
            this.WaterPHLabel.Text = "Water pH";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(542, 125);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(234, 29);
            this.IDTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Time Fed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Time Cleaned:";
            // 
            // CleanTimeTextBox
            // 
            this.CleanTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanTimeTextBox.Location = new System.Drawing.Point(542, 179);
            this.CleanTimeTextBox.Name = "CleanTimeTextBox";
            this.CleanTimeTextBox.Size = new System.Drawing.Size(234, 29);
            this.CleanTimeTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // FeedTimeTextBox
            // 
            this.FeedTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedTimeTextBox.Location = new System.Drawing.Point(542, 235);
            this.FeedTimeTextBox.Name = "FeedTimeTextBox";
            this.FeedTimeTextBox.Size = new System.Drawing.Size(234, 29);
            this.FeedTimeTextBox.TabIndex = 15;
            // 
            // WPHLabel
            // 
            this.WPHLabel.AutoSize = true;
            this.WPHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WPHLabel.Location = new System.Drawing.Point(402, 408);
            this.WPHLabel.Name = "WPHLabel";
            this.WPHLabel.Size = new System.Drawing.Size(122, 20);
            this.WPHLabel.TabIndex = 16;
            this.WPHLabel.Text = "Water pH Level:";
            // 
            // WaterPHTextBox
            // 
            this.WaterPHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterPHTextBox.Location = new System.Drawing.Point(542, 399);
            this.WaterPHTextBox.Name = "WaterPHTextBox";
            this.WaterPHTextBox.Size = new System.Drawing.Size(234, 29);
            this.WaterPHTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Inhabitant Count:";
            // 
            // InhabitantCountTextBox
            // 
            this.InhabitantCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InhabitantCountTextBox.Location = new System.Drawing.Point(542, 344);
            this.InhabitantCountTextBox.Name = "InhabitantCountTextBox";
            this.InhabitantCountTextBox.Size = new System.Drawing.Size(234, 29);
            this.InhabitantCountTextBox.TabIndex = 19;
            // 
            // AddInhabitantButton
            // 
            this.AddInhabitantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInhabitantButton.Location = new System.Drawing.Point(24, 487);
            this.AddInhabitantButton.Name = "AddInhabitantButton";
            this.AddInhabitantButton.Size = new System.Drawing.Size(110, 51);
            this.AddInhabitantButton.TabIndex = 20;
            this.AddInhabitantButton.Text = "Add Inhabitants";
            this.AddInhabitantButton.UseVisualStyleBackColor = true;
            this.AddInhabitantButton.Click += new System.EventHandler(this.AddInhabitantButton_Click);
            // 
            // RemoveInhabitantButton
            // 
            this.RemoveInhabitantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveInhabitantButton.Location = new System.Drawing.Point(235, 487);
            this.RemoveInhabitantButton.Name = "RemoveInhabitantButton";
            this.RemoveInhabitantButton.Size = new System.Drawing.Size(110, 51);
            this.RemoveInhabitantButton.TabIndex = 21;
            this.RemoveInhabitantButton.Text = "Remove Inhabitants";
            this.RemoveInhabitantButton.UseVisualStyleBackColor = true;
            this.RemoveInhabitantButton.Click += new System.EventHandler(this.RemoveInhabitantButton_Click);
            // 
            // FeedButton
            // 
            this.FeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedButton.Location = new System.Drawing.Point(414, 487);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(108, 51);
            this.FeedButton.TabIndex = 22;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanButton.Location = new System.Drawing.Point(542, 487);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(108, 51);
            this.CleanButton.TabIndex = 23;
            this.CleanButton.Text = "Clean";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // InhabitantTypeTextBox
            // 
            this.InhabitantTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InhabitantTypeTextBox.Location = new System.Drawing.Point(542, 289);
            this.InhabitantTypeTextBox.Name = "InhabitantTypeTextBox";
            this.InhabitantTypeTextBox.Size = new System.Drawing.Size(234, 29);
            this.InhabitantTypeTextBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Inhabitant Type:";
            // 
            // RemoveEnvironmentButton
            // 
            this.RemoveEnvironmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEnvironmentButton.Location = new System.Drawing.Point(668, 487);
            this.RemoveEnvironmentButton.Name = "RemoveEnvironmentButton";
            this.RemoveEnvironmentButton.Size = new System.Drawing.Size(108, 49);
            this.RemoveEnvironmentButton.TabIndex = 26;
            this.RemoveEnvironmentButton.Text = "Remove Environment";
            this.RemoveEnvironmentButton.UseVisualStyleBackColor = true;
            this.RemoveEnvironmentButton.Click += new System.EventHandler(this.RemoveEnvironmentButton_Click);
            // 
            // InhabitantCounter
            // 
            this.InhabitantCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InhabitantCounter.Location = new System.Drawing.Point(155, 500);
            this.InhabitantCounter.Name = "InhabitantCounter";
            this.InhabitantCounter.Size = new System.Drawing.Size(58, 26);
            this.InhabitantCounter.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Environments:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(379, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Environment Information:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label10.Location = new System.Drawing.Point(17, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(384, 37);
            this.label10.TabIndex = 30;
            this.label10.Text = "Adoption Center Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 716);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InhabitantCounter);
            this.Controls.Add(this.RemoveEnvironmentButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InhabitantTypeTextBox);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.RemoveInhabitantButton);
            this.Controls.Add(this.AddInhabitantButton);
            this.Controls.Add(this.InhabitantCountTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WaterPHTextBox);
            this.Controls.Add(this.WPHLabel);
            this.Controls.Add(this.FeedTimeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CleanTimeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.WaterPHLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AquariumPH);
            this.Controls.Add(this.InhabitantType);
            this.Controls.Add(this.TerrariumButton);
            this.Controls.Add(this.AquariumButton);
            this.Controls.Add(this.CageButton);
            this.Controls.Add(this.EnvironmentListBox);
            this.Name = "Form1";
            this.Text = "Adoption Center Manager";
            ((System.ComponentModel.ISupportInitialize)(this.AquariumPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InhabitantCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EnvironmentListBox;
        private System.Windows.Forms.RadioButton CageButton;
        private System.Windows.Forms.RadioButton AquariumButton;
        private System.Windows.Forms.RadioButton TerrariumButton;
        private System.Windows.Forms.TextBox InhabitantType;
        private System.Windows.Forms.NumericUpDown AquariumPH;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WaterPHLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CleanTimeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FeedTimeTextBox;
        private System.Windows.Forms.Label WPHLabel;
        private System.Windows.Forms.TextBox WaterPHTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InhabitantCountTextBox;
        private System.Windows.Forms.Button AddInhabitantButton;
        private System.Windows.Forms.Button RemoveInhabitantButton;
        private System.Windows.Forms.Button FeedButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.TextBox InhabitantTypeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RemoveEnvironmentButton;
        private System.Windows.Forms.NumericUpDown InhabitantCounter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


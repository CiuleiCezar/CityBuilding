namespace CityProject
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
            this.ComboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxFacebook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxBuildingType = new System.Windows.Forms.ComboBox();
            this.PictureBoxMap = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.Information = new System.Windows.Forms.TextBox();
            this.RulesButton = new System.Windows.Forms.Button();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.DistrictTextBox = new System.Windows.Forms.TextBox();
            this.AddDistrict = new System.Windows.Forms.Button();
            this.ShowDistrictRatings = new System.Windows.Forms.Button();
            this.GetWeather = new System.Windows.Forms.Button();
            this.PlaceAddress = new System.Windows.Forms.TextBox();
            this.searchPlaceButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PlaceInformation = new System.Windows.Forms.TextBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.ruleToAdd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxDistrict
            // 
            this.ComboBoxDistrict.FormattingEnabled = true;
            this.ComboBoxDistrict.Items.AddRange(new object[] {
            "Ciungi",
            "Marceni"});
            this.ComboBoxDistrict.Location = new System.Drawing.Point(779, 35);
            this.ComboBoxDistrict.Name = "ComboBoxDistrict";
            this.ComboBoxDistrict.Size = new System.Drawing.Size(187, 24);
            this.ComboBoxDistrict.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(779, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Place";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddPlaceButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(674, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "District";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "PlaceType";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(779, 124);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(187, 22);
            this.TextBoxAddress.TabIndex = 6;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(779, 163);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(187, 22);
            this.TextBoxEmail.TabIndex = 7;
            // 
            // TextBoxFacebook
            // 
            this.TextBoxFacebook.Location = new System.Drawing.Point(779, 201);
            this.TextBoxFacebook.Name = "TextBoxFacebook";
            this.TextBoxFacebook.Size = new System.Drawing.Size(187, 22);
            this.TextBoxFacebook.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Facebook";
            // 
            // TextBoxCapacity
            // 
            this.TextBoxCapacity.Location = new System.Drawing.Point(779, 281);
            this.TextBoxCapacity.Name = "TextBoxCapacity";
            this.TextBoxCapacity.Size = new System.Drawing.Size(187, 22);
            this.TextBoxCapacity.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capacity";
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.Location = new System.Drawing.Point(779, 318);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(187, 22);
            this.TextBoxScore.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Score";
            // 
            // ComboBoxBuildingType
            // 
            this.ComboBoxBuildingType.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.ComboBoxBuildingType.FormattingEnabled = true;
            this.ComboBoxBuildingType.Items.AddRange(new object[] {
            "Factory",
            "HouseBuilding",
            "Park",
            "Hydro",
            "Forest"});
            this.ComboBoxBuildingType.Location = new System.Drawing.Point(779, 79);
            this.ComboBoxBuildingType.Name = "ComboBoxBuildingType";
            this.ComboBoxBuildingType.Size = new System.Drawing.Size(187, 24);
            this.ComboBoxBuildingType.TabIndex = 16;
            // 
            // PictureBoxMap
            // 
            this.PictureBoxMap.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxMap.Name = "PictureBoxMap";
            this.PictureBoxMap.Size = new System.Drawing.Size(650, 650);
            this.PictureBoxMap.TabIndex = 0;
            this.PictureBoxMap.TabStop = false;
            this.PictureBoxMap.MouseHover += new System.EventHandler(this.PictureBoxMap_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "PhoneNumber";
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(779, 238);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(187, 22);
            this.TextBoxPhoneNumber.TabIndex = 18;
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(779, 539);
            this.Information.Multiline = true;
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(191, 46);
            this.Information.TabIndex = 19;
            // 
            // RulesButton
            // 
            this.RulesButton.AutoEllipsis = true;
            this.RulesButton.BackColor = System.Drawing.Color.Black;
            this.RulesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesButton.ForeColor = System.Drawing.Color.Red;
            this.RulesButton.Location = new System.Drawing.Point(3, 675);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(215, 36);
            this.RulesButton.TabIndex = 21;
            this.RulesButton.Text = "Rules of building a place";
            this.RulesButton.UseVisualStyleBackColor = false;
            this.RulesButton.Click += new System.EventHandler(this.RulesButton_Click);
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Location = new System.Drawing.Point(674, 439);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(88, 17);
            this.DistrictLabel.TabIndex = 22;
            this.DistrictLabel.Text = "DistrictName";
            // 
            // DistrictTextBox
            // 
            this.DistrictTextBox.Location = new System.Drawing.Point(779, 439);
            this.DistrictTextBox.Name = "DistrictTextBox";
            this.DistrictTextBox.Size = new System.Drawing.Size(187, 22);
            this.DistrictTextBox.TabIndex = 23;
            // 
            // AddDistrict
            // 
            this.AddDistrict.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDistrict.ForeColor = System.Drawing.Color.Red;
            this.AddDistrict.Location = new System.Drawing.Point(779, 476);
            this.AddDistrict.Name = "AddDistrict";
            this.AddDistrict.Size = new System.Drawing.Size(187, 33);
            this.AddDistrict.TabIndex = 24;
            this.AddDistrict.Text = "Add District";
            this.AddDistrict.UseVisualStyleBackColor = false;
            this.AddDistrict.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // ShowDistrictRatings
            // 
            this.ShowDistrictRatings.BackColor = System.Drawing.Color.Black;
            this.ShowDistrictRatings.ForeColor = System.Drawing.Color.Red;
            this.ShowDistrictRatings.Location = new System.Drawing.Point(224, 675);
            this.ShowDistrictRatings.Name = "ShowDistrictRatings";
            this.ShowDistrictRatings.Size = new System.Drawing.Size(224, 36);
            this.ShowDistrictRatings.TabIndex = 26;
            this.ShowDistrictRatings.Text = "Districts Rating";
            this.ShowDistrictRatings.UseVisualStyleBackColor = false;
            this.ShowDistrictRatings.Click += new System.EventHandler(this.ShowDistrictRatings_Click);
            // 
            // GetWeather
            // 
            this.GetWeather.BackColor = System.Drawing.Color.Black;
            this.GetWeather.ForeColor = System.Drawing.Color.Red;
            this.GetWeather.Location = new System.Drawing.Point(779, 591);
            this.GetWeather.Name = "GetWeather";
            this.GetWeather.Size = new System.Drawing.Size(191, 36);
            this.GetWeather.TabIndex = 28;
            this.GetWeather.Text = "Get Weather";
            this.GetWeather.UseVisualStyleBackColor = false;
            this.GetWeather.Click += new System.EventHandler(this.GetWeather_Click);
            // 
            // PlaceAddress
            // 
            this.PlaceAddress.Location = new System.Drawing.Point(779, 655);
            this.PlaceAddress.Multiline = true;
            this.PlaceAddress.Name = "PlaceAddress";
            this.PlaceAddress.Size = new System.Drawing.Size(191, 36);
            this.PlaceAddress.TabIndex = 29;
            // 
            // searchPlaceButton
            // 
            this.searchPlaceButton.BackColor = System.Drawing.Color.Black;
            this.searchPlaceButton.ForeColor = System.Drawing.Color.Red;
            this.searchPlaceButton.Location = new System.Drawing.Point(666, 655);
            this.searchPlaceButton.Name = "searchPlaceButton";
            this.searchPlaceButton.Size = new System.Drawing.Size(107, 36);
            this.searchPlaceButton.TabIndex = 30;
            this.searchPlaceButton.Text = "Search Place";
            this.searchPlaceButton.UseVisualStyleBackColor = false;
            this.searchPlaceButton.Click += new System.EventHandler(this.searchPlaceButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(674, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Weather\'s info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(682, 719);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Place\'s info";
            // 
            // PlaceInformation
            // 
            this.PlaceInformation.Location = new System.Drawing.Point(779, 719);
            this.PlaceInformation.Multiline = true;
            this.PlaceInformation.Name = "PlaceInformation";
            this.PlaceInformation.Size = new System.Drawing.Size(191, 36);
            this.PlaceInformation.TabIndex = 33;
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.Black;
            this.btnAddRule.ForeColor = System.Drawing.Color.Red;
            this.btnAddRule.Location = new System.Drawing.Point(3, 744);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(215, 36);
            this.btnAddRule.TabIndex = 34;
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // ruleToAdd
            // 
            this.ruleToAdd.Location = new System.Drawing.Point(224, 744);
            this.ruleToAdd.Multiline = true;
            this.ruleToAdd.Name = "ruleToAdd";
            this.ruleToAdd.Size = new System.Drawing.Size(224, 36);
            this.ruleToAdd.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.ruleToAdd);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.PlaceInformation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchPlaceButton);
            this.Controls.Add(this.PlaceAddress);
            this.Controls.Add(this.GetWeather);
            this.Controls.Add(this.ShowDistrictRatings);
            this.Controls.Add(this.AddDistrict);
            this.Controls.Add(this.DistrictTextBox);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.RulesButton);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComboBoxBuildingType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxCapacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxFacebook);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboBoxDistrict);
            this.Controls.Add(this.PictureBoxMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxMap;
        private System.Windows.Forms.ComboBox ComboBoxDistrict;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxFacebook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxBuildingType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox Information;
        private System.Windows.Forms.Button RulesButton;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.TextBox DistrictTextBox;
        private System.Windows.Forms.Button AddDistrict;
        private System.Windows.Forms.Button ShowDistrictRatings;
        private System.Windows.Forms.Button GetWeather;
        private System.Windows.Forms.TextBox PlaceAddress;
        private System.Windows.Forms.Button searchPlaceButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PlaceInformation;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.TextBox ruleToAdd;
    }
}


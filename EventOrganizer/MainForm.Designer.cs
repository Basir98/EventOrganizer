
namespace EventOrganizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSurplus = new System.Windows.Forms.Label();
            this.lblNumberOfParticipants = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCountryList = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.tbFeePerParticipant = new System.Windows.Forms.TextBox();
            this.tbCostPerParticipant = new System.Windows.Forms.TextBox();
            this.tbEventTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSurplus);
            this.groupBox3.Controls.Add(this.lblNumberOfParticipants);
            this.groupBox3.Controls.Add(this.lblTotalFees);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblTotalCost);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(419, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 167);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event economy";
            // 
            // lblSurplus
            // 
            this.lblSurplus.AutoSize = true;
            this.lblSurplus.Location = new System.Drawing.Point(187, 131);
            this.lblSurplus.Name = "lblSurplus";
            this.lblSurplus.Size = new System.Drawing.Size(17, 20);
            this.lblSurplus.TabIndex = 10;
            this.lblSurplus.Text = "0";
            // 
            // lblNumberOfParticipants
            // 
            this.lblNumberOfParticipants.AutoSize = true;
            this.lblNumberOfParticipants.Location = new System.Drawing.Point(187, 28);
            this.lblNumberOfParticipants.Name = "lblNumberOfParticipants";
            this.lblNumberOfParticipants.Size = new System.Drawing.Size(17, 20);
            this.lblNumberOfParticipants.TabIndex = 8;
            this.lblNumberOfParticipants.Text = "0";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(187, 100);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(17, 20);
            this.lblTotalFees.TabIndex = 9;
            this.lblTotalFees.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Surplus";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(187, 64);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(17, 20);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Total fees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Total cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Number of participants";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(623, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(438, 269);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(94, 29);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.ItemHeight = 20;
            this.listBoxParticipants.Location = new System.Drawing.Point(345, 49);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(480, 204);
            this.listBoxParticipants.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCountryList);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbZipCode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbCity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbStreet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbLastName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbFirstName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(36, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 273);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add participants";
            // 
            // cbCountryList
            // 
            this.cbCountryList.FormattingEnabled = true;
            this.cbCountryList.Location = new System.Drawing.Point(101, 197);
            this.cbCountryList.Name = "cbCountryList";
            this.cbCountryList.Size = new System.Drawing.Size(149, 28);
            this.cbCountryList.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Country";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(101, 158);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(149, 27);
            this.tbZipCode.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Zip code";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(101, 125);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(149, 27);
            this.tbCity.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "City";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(101, 92);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(149, 27);
            this.tbStreet.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Street";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(101, 59);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(149, 27);
            this.tbLastName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lastname";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(101, 26);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(149, 27);
            this.tbFirstName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Firstname";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateEvent);
            this.groupBox1.Controls.Add(this.tbFeePerParticipant);
            this.groupBox1.Controls.Add(this.tbCostPerParticipant);
            this.groupBox1.Controls.Add(this.tbEventTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Event";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(72, 145);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(105, 29);
            this.btnCreateEvent.TabIndex = 1;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // tbFeePerParticipant
            // 
            this.tbFeePerParticipant.Location = new System.Drawing.Point(165, 100);
            this.tbFeePerParticipant.Name = "tbFeePerParticipant";
            this.tbFeePerParticipant.Size = new System.Drawing.Size(86, 27);
            this.tbFeePerParticipant.TabIndex = 1;
            // 
            // tbCostPerParticipant
            // 
            this.tbCostPerParticipant.Location = new System.Drawing.Point(165, 62);
            this.tbCostPerParticipant.Name = "tbCostPerParticipant";
            this.tbCostPerParticipant.Size = new System.Drawing.Size(86, 27);
            this.tbCostPerParticipant.TabIndex = 1;
            // 
            // tbEventTitle
            // 
            this.tbEventTitle.Location = new System.Drawing.Point(102, 23);
            this.tbEventTitle.Name = "tbEventTitle";
            this.tbEventTitle.Size = new System.Drawing.Size(149, 27);
            this.tbEventTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fee per participant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per participant";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSurplus;
        private System.Windows.Forms.Label lblNumberOfParticipants;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbCountryList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.TextBox tbFeePerParticipant;
        private System.Windows.Forms.TextBox tbCostPerParticipant;
        private System.Windows.Forms.TextBox tbEventTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


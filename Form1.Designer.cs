﻿
namespace Restaurant_Menu
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
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.textBoxNewItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewItemPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddItemPicture = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSelectItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonSaveMenu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCurrentItemPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCurrentItemName = new System.Windows.Forms.TextBox();
            this.buttonOpenJSON = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRestaurantName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRestaurantIcon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRestaurantDescription = new System.Windows.Forms.TextBox();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.BackColor = System.Drawing.Color.Lime;
            this.buttonAddNewItem.Location = new System.Drawing.Point(615, 84);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(107, 76);
            this.buttonAddNewItem.TabIndex = 0;
            this.buttonAddNewItem.Text = "Add New Item To Menu";
            this.buttonAddNewItem.UseVisualStyleBackColor = false;
            // 
            // textBoxNewItemName
            // 
            this.textBoxNewItemName.Location = new System.Drawing.Point(74, 81);
            this.textBoxNewItemName.Name = "textBoxNewItemName";
            this.textBoxNewItemName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewItemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Price:";
            // 
            // textBoxNewItemPrice
            // 
            this.textBoxNewItemPrice.Location = new System.Drawing.Point(74, 137);
            this.textBoxNewItemPrice.Name = "textBoxNewItemPrice";
            this.textBoxNewItemPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewItemPrice.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Menu.Properties.Resources.Smash;
            this.pictureBox1.Location = new System.Drawing.Point(278, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddItemPicture
            // 
            this.buttonAddItemPicture.Location = new System.Drawing.Point(197, 92);
            this.buttonAddItemPicture.Name = "buttonAddItemPicture";
            this.buttonAddItemPicture.Size = new System.Drawing.Size(75, 52);
            this.buttonAddItemPicture.TabIndex = 6;
            this.buttonAddItemPicture.Text = "Add Item Picture";
            this.buttonAddItemPicture.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Open Menu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "New Menu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(715, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edit Item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add New Item:";
            // 
            // comboBoxSelectItem
            // 
            this.comboBoxSelectItem.FormattingEnabled = true;
            this.comboBoxSelectItem.Items.AddRange(new object[] {
            "Burger",
            "Taco",
            "Steak",
            "Large Soda"});
            this.comboBoxSelectItem.Location = new System.Drawing.Point(386, 235);
            this.comboBoxSelectItem.Name = "comboBoxSelectItem";
            this.comboBoxSelectItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectItem.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select Existing Item:";
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteItem.Location = new System.Drawing.Point(654, 237);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(68, 50);
            this.buttonDeleteItem.TabIndex = 14;
            this.buttonDeleteItem.Text = "Delete Item From Menu";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            // 
            // buttonSaveMenu
            // 
            this.buttonSaveMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSaveMenu.Location = new System.Drawing.Point(958, 362);
            this.buttonSaveMenu.Name = "buttonSaveMenu";
            this.buttonSaveMenu.Size = new System.Drawing.Size(107, 76);
            this.buttonSaveMenu.TabIndex = 15;
            this.buttonSaveMenu.Text = "Save Menu";
            this.buttonSaveMenu.UseVisualStyleBackColor = false;
            this.buttonSaveMenu.Click += new System.EventHandler(this.buttonSaveMenu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Item Price:";
            // 
            // textBoxCurrentItemPrice
            // 
            this.textBoxCurrentItemPrice.Location = new System.Drawing.Point(386, 298);
            this.textBoxCurrentItemPrice.Name = "textBoxCurrentItemPrice";
            this.textBoxCurrentItemPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentItemPrice.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Item Name:";
            // 
            // textBoxCurrentItemName
            // 
            this.textBoxCurrentItemName.Location = new System.Drawing.Point(386, 266);
            this.textBoxCurrentItemName.Name = "textBoxCurrentItemName";
            this.textBoxCurrentItemName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentItemName.TabIndex = 16;
            // 
            // buttonOpenJSON
            // 
            this.buttonOpenJSON.Location = new System.Drawing.Point(610, 390);
            this.buttonOpenJSON.Name = "buttonOpenJSON";
            this.buttonOpenJSON.Size = new System.Drawing.Size(112, 48);
            this.buttonOpenJSON.TabIndex = 20;
            this.buttonOpenJSON.Text = "Open .Json";
            this.buttonOpenJSON.UseVisualStyleBackColor = true;
            this.buttonOpenJSON.Click += new System.EventHandler(this.buttonOpenJSON_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(786, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Restaurant Name:";
            // 
            // textBoxRestaurantName
            // 
            this.textBoxRestaurantName.Location = new System.Drawing.Point(880, 43);
            this.textBoxRestaurantName.Name = "textBoxRestaurantName";
            this.textBoxRestaurantName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRestaurantName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(793, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Restaurant Icon:";
            // 
            // textBoxRestaurantIcon
            // 
            this.textBoxRestaurantIcon.Location = new System.Drawing.Point(880, 73);
            this.textBoxRestaurantIcon.Name = "textBoxRestaurantIcon";
            this.textBoxRestaurantIcon.Size = new System.Drawing.Size(100, 20);
            this.textBoxRestaurantIcon.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(761, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Restaurant Description:";
            // 
            // textBoxRestaurantDescription
            // 
            this.textBoxRestaurantDescription.Location = new System.Drawing.Point(880, 109);
            this.textBoxRestaurantDescription.Multiline = true;
            this.textBoxRestaurantDescription.Name = "textBoxRestaurantDescription";
            this.textBoxRestaurantDescription.Size = new System.Drawing.Size(185, 82);
            this.textBoxRestaurantDescription.TabIndex = 25;
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSaveItem.Location = new System.Drawing.Point(541, 223);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(107, 76);
            this.buttonSaveItem.TabIndex = 27;
            this.buttonSaveItem.Text = "Save Changes To Item ";
            this.buttonSaveItem.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Select Existing Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Burger",
            "Taco",
            "Steak",
            "Large Soda"});
            this.comboBoxCategory.Location = new System.Drawing.Point(142, 270);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 28;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(492, 390);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(112, 48);
            this.buttonClearAll.TabIndex = 30;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Webserver URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(328, 417);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(158, 20);
            this.textBoxURL.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonSaveItem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRestaurantDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRestaurantIcon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxRestaurantName);
            this.Controls.Add(this.buttonOpenJSON);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCurrentItemPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCurrentItemName);
            this.Controls.Add(this.buttonSaveMenu);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSelectItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAddItemPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewItemPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewItemName);
            this.Controls.Add(this.buttonAddNewItem);
            this.Name = "Form1";
            this.Text = "Editting TacoBellMenu.json";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.TextBox textBoxNewItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewItemPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddItemPicture;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSelectItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonSaveMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCurrentItemPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCurrentItemName;
        private System.Windows.Forms.Button buttonOpenJSON;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRestaurantName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRestaurantIcon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRestaurantDescription;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxURL;
    }
}


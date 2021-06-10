﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Restaurant_Menu
{
    public partial class Form1 : Form
    {
        private dynamic jsonMenu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void open_json_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Public\\tacoshop.json";
            openJson(filePath);
        }

        private void openJson(string filePath)
        {
            this.jsonMenu = JsonConvert.DeserializeObject(File.ReadAllText(filePath));
            fillInData();
        }

        private void fillInData()
        {
            Console.WriteLine(jsonMenu.categories[0]);
            //Populate basic menu data.
            this.Text = "Editing " + (string)jsonMenu.restaurantName;
            textBoxRestaurantName.Text = (string)jsonMenu.restaurantName;
            textBoxRestaurantIcon.Text = (string)jsonMenu.restaurantIcon;
            textBoxRestaurantDescription.Text = (string)jsonMenu.restaurantDescription;


            //Populate existing items combobox
            foreach(dynamic category in jsonMenu.categories) {
                comboBoxCategory.Items.Add((string)category.categoryName);
            }
        }
        private void clearData()
        {

        }

        private void ClearAllButt_Click(object sender, EventArgs e)
        {
            textBoxNewItemName.Clear();
            textBoxNewItemPrice.Clear();
            textBoxCurrentItemName.Clear();
            textBoxCurrentItemPrice.Clear();
            textBoxRestaurantName.Clear();
            textBoxRestaurantIcon.Clear();
            textBoxRestaurantDescription.Clear();
            comboBoxSelectItem.Text = string.Empty;
        }
    }
}

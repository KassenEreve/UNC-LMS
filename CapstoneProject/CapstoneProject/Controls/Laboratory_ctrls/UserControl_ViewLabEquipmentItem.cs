﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProject.Class;

namespace CapstoneProject.Controls.Laboratory_ctrls
{
    public partial class UserControl_ViewLabEquipmentItem : UserControl
    {
        Computer computer;
        public bool isSelected = false;
        public UserControl_ViewLabEquipmentItem(Computer computer)
        {
            InitializeComponent();
            this.computer = computer;
        }

        private void UserControl_ViewLabEquipmentItem_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            xuiButton1.ButtonText = computer.pc_num;
        }
        public void SelectItem(bool forceSelect=false)
        {
            if (isSelected&&!forceSelect)
            {
                isSelected = false;
                xuiButton1.BackgroundColor = Color.White;
            }
            else
            {
                isSelected = true;
                xuiButton1.BackgroundColor = Color.Gray;
            }
        }
        private void xuiButton1_Click(object sender, EventArgs e)
        {
            SelectItem();
            if (ModifierKeys.HasFlag(Keys.Control))
            {
               int from= this.Parent.Controls.OfType<UserControl_ViewLabEquipmentItem>().ToList().FindIndex(o => o.isSelected);
                int to = this.Parent.Controls.IndexOf(this);
              
                for(int i =from;i<=to;i++)
                {
                    this.Parent.Controls.OfType<UserControl_ViewLabEquipmentItem>().ToList()[i].SelectItem(true);
                }

            }
        }
    }
}
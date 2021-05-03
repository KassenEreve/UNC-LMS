using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProject.Class;
using XanderUI;

namespace CapstoneProject.Controls
{
    public partial class UserControl_mainWindow : UserControl
    {
        public UserControl_mainWindow()
        {
            InitializeComponent();
            
        }

        private void LoadPanel()
        {
            var instance = UserInterface.GetInstance();
            panel_main.Controls.Add(instance.userControl_LabList);
            panel_main.Controls.Add(instance.userControl_AddLab);
            panel_main.Controls.Add(instance.userControl_EquipmentType);
            panel_main.Controls.Add(instance.userControl_AddEquipmentType);
            panel_main.Controls.Add(instance.userControl_PcSpecsList);
            panel_main.Controls.Add(instance.userControl_AddPCSpecs);
            panel_main.Controls.Add(instance.userControl_ViewLab);
            panel_main.Controls.Add(instance.userControl_AddLabEquipment);
        }

        private void UserControl_mainWindow_Load(object sender, EventArgs e)
        {
            LoadPanel();

            btn_lab.Tag = 1;
            btn_labList.Tag = 2;
            btn_equipmentType.Tag =3;
            btn_specsList.Tag = 4;


            //click event handler
            btn_lab.Click += Button_Click;
            btn_labList.Click += Button_Click;
            btn_equipmentType.Click += Button_Click;
            btn_specsList.Click += Button_Click; 

        }

        private void Button_Click(object sender, EventArgs e)
        {
            int tag=0;
            var ui = UserInterface.GetInstance();


            if (sender is XUIButton)
            {
                var b = sender as XUIButton;
                tag = (int)b.Tag;
            }
           
           
            switch (tag)
            {
                case 1:
                    expandCollapseMenu(sender as XUIButton);



                    break;
                case 2: ui.userControl_LabList.BringToFront();
                    ui.userControl_LabList.LoadList();
                    break;
                case 3:ui.userControl_EquipmentType.BringToFront();
                    ui.userControl_EquipmentType.LoadList();
                    break;
                case 4: ui.userControl_PcSpecsList.BringToFront();
                    ui.userControl_PcSpecsList.LoadList();
                    break;

              
              
            }
        }
        private void expandCollapseMenu(XUIButton btn)
        {
            UserInterface.button = btn;
            UserInterface.timer.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLLUG_TEST
{
    public partial class Form_PLLUGTEST : Form
    {
        public Form_PLLUGTEST()
        {
            InitializeComponent();
        }

        double DoorHeight, DoorWidth, CircleRadius, WardrobeHeight, WardrobeWidth,
            WardrobeLenght, CylinderHeight, CylinderRadius, BallRadius;
        bool flag = false;
        int FlagExit = 0, FlagObject=0;


        private void rbDoor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDoor.Checked == true)
            {
                
                LDoorHeight.Text = "Door Height";
                tbExitHeight.Visible = true;
                LDoorWidth.Text = "Door Width";
                tbExitWidth.Visible = true;
                FlagExit = 1;
               
            }
        }

        private void rbCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCircle.Checked == true)
            {
                LDoorHeight.Text = "Circle Radius";
                tbExitHeight.Visible = true;
                LDoorWidth.Text = "";
                tbExitWidth.Visible = false;
                FlagExit = 2;
            }
        }

        private void rbWardrobe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWardrobe.Checked == true)
            {
                LObjectHeight.Text = "Wardrobe Height";
                tbObjectHeight.Visible = true;
                LObjectWidth.Text = "Wardrobe Width";
                tbObjectWidth.Visible = true;
                LObjectLength.Text = "Wardrobe Length";
                tbObjectLength.Visible = true;
                FlagObject = 1;
            }
        }

        private void rbCylinder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCylinder.Checked == true)
            {
                LObjectHeight.Text = "Cylinder Height";
                tbObjectHeight.Visible = true;
                LObjectWidth.Text = "Cylinder Radius";
                tbObjectWidth.Visible = true;
                LObjectLength.Text = "";
                tbObjectLength.Visible = false;
                FlagObject = 2;

            }
        }

        private void rbBall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBall.Checked == true)
            {
                LObjectHeight.Text = "Ball Radius";
                tbObjectHeight.Visible = true;
                LObjectWidth.Text = "";
                tbObjectWidth.Visible = false;
                LObjectLength.Text = "";
                tbObjectLength.Visible = false;
                FlagObject = 3;

            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.IndexOf(',') != -1 || (string.IsNullOrEmpty((sender as TextBox).Text)))
                {
                    e.Handled = true;
                }
                else
                    e.Handled = false;
            }
            else
                if (Char.IsDigit(ch))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            if (FlagExit == 1)
            {

                switch (FlagObject)
                {
                    case 1: DoorWardrobe();
                        break;
                    case 2: DoorCylinder();
                        break;
                    case 3: DoorBall();
                        break;
                }
               
            }
            if (FlagExit == 2)
            {
                switch(FlagObject)
                {
                    case 1: CircleWardrobe();
                        break;
                    case 2: CircleCylinder();
                        break;
                    case 3: CircleBall();
                        break;
                }
            }
        }

        public void DoorWardrobe()
        {
            if (string.IsNullOrEmpty(tbExitHeight.Text) || string.IsNullOrEmpty(tbExitWidth.Text))
            {
                MessageBox.Show("Data about the DOOR is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoorHeight = Convert.ToDouble(tbExitHeight.Text);
                DoorWidth = Convert.ToDouble(tbExitWidth.Text);
            }

            if (string.IsNullOrEmpty(tbObjectHeight.Text) || string.IsNullOrEmpty(tbObjectWidth.Text) || string.IsNullOrEmpty(tbObjectLength.Text))
            {
                MessageBox.Show("Data about the OBJECT is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WardrobeHeight = Convert.ToDouble(tbObjectHeight.Text);
                WardrobeWidth = Convert.ToDouble(tbObjectWidth.Text);
                WardrobeLenght = Convert.ToDouble(tbObjectLength.Text);
                flag = true;
            }

            if (flag)
            {
                if (WardrobeHeight < DoorHeight && WardrobeWidth < DoorWidth ||
                    WardrobeWidth < DoorHeight && WardrobeHeight < DoorWidth ||
                    WardrobeHeight < DoorHeight && WardrobeLenght < DoorWidth ||
                    WardrobeLenght < DoorHeight && WardrobeHeight < DoorWidth ||
                    WardrobeLenght < DoorHeight && WardrobeWidth < DoorWidth ||
                    WardrobeWidth < DoorHeight && WardrobeLenght < DoorWidth)
                {
                    MessageBox.Show("Object passes through the door", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _TextBoxClear();
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Object not pass through the door", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _TextBoxClear();
                    flag = false;
                }
            }
        }

        public void DoorCylinder()
        {
            if (string.IsNullOrEmpty(tbExitHeight.Text) || string.IsNullOrEmpty(tbExitWidth.Text))
            {
                MessageBox.Show("Data about the DOOR is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoorHeight = Convert.ToDouble(tbExitHeight.Text);
                DoorWidth = Convert.ToDouble(tbExitWidth.Text);
            }

            if (string.IsNullOrEmpty(tbObjectHeight.Text) || string.IsNullOrEmpty(tbObjectWidth.Text))
            {
                MessageBox.Show("Data about the OBJECT is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CylinderHeight = Convert.ToDouble(tbObjectHeight.Text);
                CylinderRadius = Convert.ToDouble(tbObjectWidth.Text);

                flag = true;
            }

            if (flag)
            {
                if (CylinderHeight < DoorHeight && 2 * CylinderRadius < DoorWidth ||
                    2 * CylinderRadius < DoorHeight && CylinderHeight < DoorWidth ||
                    2 * CylinderRadius < DoorHeight && 2 * CylinderRadius < DoorWidth)
                {
                    MessageBox.Show("Cylinder passes through the door", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _TextBoxClear();
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Cylinder not pass through the door", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _TextBoxClear();
                    flag = false;
                }
            }

        }

        public void DoorBall()
        {
            if (string.IsNullOrEmpty(tbExitHeight.Text) || string.IsNullOrEmpty(tbExitWidth.Text))
            {
                MessageBox.Show("Data about the DOOR is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoorHeight = Convert.ToDouble(tbExitHeight.Text);
                DoorWidth = Convert.ToDouble(tbExitWidth.Text);
            }

            if (string.IsNullOrEmpty(tbObjectHeight.Text))
            {
                MessageBox.Show("Data about the OBJECT is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BallRadius = Convert.ToDouble(tbObjectHeight.Text);

                flag = true;
            }

            if (flag)
            {
                if (DoorHeight > 2 * BallRadius && DoorWidth > 2 * BallRadius)
                {
                    MessageBox.Show("Ball passes through the door", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _TextBoxClear();
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Ball not pass through the door", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _TextBoxClear();
                    flag = false;
                }
            }
        }

        public void CircleWardrobe()
        {
            if (string.IsNullOrEmpty(tbExitHeight.Text))
            {
                MessageBox.Show("Data about the CIRCLE is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CircleRadius = Convert.ToDouble(tbExitHeight.Text);

            }

            if (string.IsNullOrEmpty(tbObjectHeight.Text) || string.IsNullOrEmpty(tbObjectWidth.Text) || string.IsNullOrEmpty(tbObjectLength.Text))
            {
                MessageBox.Show("Data about the OBJECT is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WardrobeHeight = Convert.ToDouble(tbObjectHeight.Text);
                WardrobeWidth = Convert.ToDouble(tbObjectWidth.Text);
                WardrobeLenght = Convert.ToDouble(tbObjectLength.Text);
                flag = true;
            }

            if (flag)
            {
                if (2 * CircleRadius > Math.Sqrt(Math.Pow(WardrobeHeight, 2) + Math.Pow(WardrobeWidth, 2)) ||
                    2 * CircleRadius > Math.Sqrt(Math.Pow(WardrobeHeight, 2) + Math.Pow(WardrobeLenght, 2)) ||
                    2 * CircleRadius > Math.Sqrt(Math.Pow(WardrobeWidth, 2) + Math.Pow(WardrobeLenght, 2)))
                {
                    MessageBox.Show("Object passes through the door", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _TextBoxClear();
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Object not pass through the door", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _TextBoxClear();
                    flag = false;
                }
            }
        }

        public void CircleCylinder()
        {
            if (string.IsNullOrEmpty(tbExitHeight.Text))
            {
                MessageBox.Show("Data about the CIRCLE is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CircleRadius = Convert.ToDouble(tbExitHeight.Text);

            }

            if (string.IsNullOrEmpty(tbObjectHeight.Text) || string.IsNullOrEmpty(tbObjectWidth.Text))
            {
                MessageBox.Show("Data about the OBJECT is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CylinderHeight = Convert.ToDouble(tbObjectHeight.Text);
                CylinderRadius = Convert.ToDouble(tbObjectWidth.Text);

                flag = true;
            }

            if (flag)
            {
                if (2 * CircleRadius > 2 * CylinderRadius ||
                    2 * CircleRadius > Math.Sqrt(Math.Pow(CylinderHeight, 2) + Math.Pow(2 * CylinderRadius, 2)))
                {
                    MessageBox.Show("Object passes through the door", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _TextBoxClear();
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Object not pass through the door", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _TextBoxClear();
                    flag = false;
                }
            }
        }

        public void CircleBall()
        {
            if (string.IsNullOrEmpty(tbExitHeight.Text))
            {
                MessageBox.Show("Data about the CIRCLE is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CircleRadius = Convert.ToDouble(tbExitHeight.Text);

            }

            if (string.IsNullOrEmpty(tbObjectHeight.Text))
            {
                MessageBox.Show("Data about the OBJECT is not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BallRadius = Convert.ToDouble(tbObjectHeight.Text);

                flag = true;
            }

            if (flag)
            {
                if (2 * CircleRadius > 2 * BallRadius)

                {
                    MessageBox.Show("Object passes through the door", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _TextBoxClear();
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Object not pass through the door", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _TextBoxClear();
                    flag = false;
                }
            }
        }

        public void _TextBoxClear()
        {
            tbExitHeight.Clear();
            tbExitWidth.Clear();
            tbObjectHeight.Clear();
            tbObjectWidth.Clear();
            tbObjectLength.Clear();
        }


    }
}

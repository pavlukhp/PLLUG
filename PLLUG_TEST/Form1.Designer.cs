namespace PLLUG_TEST
{
    partial class Form_PLLUGTEST
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
            this.panel_Door = new System.Windows.Forms.Panel();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbDoor = new System.Windows.Forms.RadioButton();
            this.LDoorWidth = new System.Windows.Forms.Label();
            this.LDoorHeight = new System.Windows.Forms.Label();
            this.tbExitWidth = new System.Windows.Forms.TextBox();
            this.tbExitHeight = new System.Windows.Forms.TextBox();
            this.panel_Object = new System.Windows.Forms.Panel();
            this.rbBall = new System.Windows.Forms.RadioButton();
            this.rbCylinder = new System.Windows.Forms.RadioButton();
            this.rbWardrobe = new System.Windows.Forms.RadioButton();
            this.LObjectLength = new System.Windows.Forms.Label();
            this.tbObjectLength = new System.Windows.Forms.TextBox();
            this.LObjectWidth = new System.Windows.Forms.Label();
            this.LObjectHeight = new System.Windows.Forms.Label();
            this.tbObjectWidth = new System.Windows.Forms.TextBox();
            this.tbObjectHeight = new System.Windows.Forms.TextBox();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.panel_Door.SuspendLayout();
            this.panel_Object.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Door
            // 
            this.panel_Door.Controls.Add(this.rbCircle);
            this.panel_Door.Controls.Add(this.rbDoor);
            this.panel_Door.Controls.Add(this.LDoorWidth);
            this.panel_Door.Controls.Add(this.LDoorHeight);
            this.panel_Door.Controls.Add(this.tbExitWidth);
            this.panel_Door.Controls.Add(this.tbExitHeight);
            this.panel_Door.Location = new System.Drawing.Point(12, 12);
            this.panel_Door.Name = "panel_Door";
            this.panel_Door.Size = new System.Drawing.Size(229, 235);
            this.panel_Door.TabIndex = 0;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(99, 17);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 5;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbDoor
            // 
            this.rbDoor.AutoSize = true;
            this.rbDoor.Location = new System.Drawing.Point(17, 17);
            this.rbDoor.Name = "rbDoor";
            this.rbDoor.Size = new System.Drawing.Size(48, 17);
            this.rbDoor.TabIndex = 4;
            this.rbDoor.TabStop = true;
            this.rbDoor.Text = "Door";
            this.rbDoor.UseVisualStyleBackColor = true;
            this.rbDoor.CheckedChanged += new System.EventHandler(this.rbDoor_CheckedChanged);
            // 
            // LDoorWidth
            // 
            this.LDoorWidth.AutoSize = true;
            this.LDoorWidth.Location = new System.Drawing.Point(14, 148);
            this.LDoorWidth.Name = "LDoorWidth";
            this.LDoorWidth.Size = new System.Drawing.Size(0, 13);
            this.LDoorWidth.TabIndex = 3;
            // 
            // LDoorHeight
            // 
            this.LDoorHeight.AutoSize = true;
            this.LDoorHeight.Location = new System.Drawing.Point(14, 87);
            this.LDoorHeight.Name = "LDoorHeight";
            this.LDoorHeight.Size = new System.Drawing.Size(0, 13);
            this.LDoorHeight.TabIndex = 2;
            // 
            // tbExitWidth
            // 
            this.tbExitWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbExitWidth.Location = new System.Drawing.Point(99, 135);
            this.tbExitWidth.Multiline = true;
            this.tbExitWidth.Name = "tbExitWidth";
            this.tbExitWidth.Size = new System.Drawing.Size(119, 37);
            this.tbExitWidth.TabIndex = 1;
            this.tbExitWidth.Visible = false;
            this.tbExitWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tbExitHeight
            // 
            this.tbExitHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbExitHeight.Location = new System.Drawing.Point(99, 75);
            this.tbExitHeight.Multiline = true;
            this.tbExitHeight.Name = "tbExitHeight";
            this.tbExitHeight.Size = new System.Drawing.Size(119, 37);
            this.tbExitHeight.TabIndex = 0;
            this.tbExitHeight.Visible = false;
            this.tbExitHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // panel_Object
            // 
            this.panel_Object.Controls.Add(this.rbBall);
            this.panel_Object.Controls.Add(this.rbCylinder);
            this.panel_Object.Controls.Add(this.rbWardrobe);
            this.panel_Object.Controls.Add(this.LObjectLength);
            this.panel_Object.Controls.Add(this.tbObjectLength);
            this.panel_Object.Controls.Add(this.LObjectWidth);
            this.panel_Object.Controls.Add(this.LObjectHeight);
            this.panel_Object.Controls.Add(this.tbObjectWidth);
            this.panel_Object.Controls.Add(this.tbObjectHeight);
            this.panel_Object.Location = new System.Drawing.Point(270, 12);
            this.panel_Object.Name = "panel_Object";
            this.panel_Object.Size = new System.Drawing.Size(229, 235);
            this.panel_Object.TabIndex = 1;
            // 
            // rbBall
            // 
            this.rbBall.AutoSize = true;
            this.rbBall.Location = new System.Drawing.Point(178, 17);
            this.rbBall.Name = "rbBall";
            this.rbBall.Size = new System.Drawing.Size(42, 17);
            this.rbBall.TabIndex = 8;
            this.rbBall.TabStop = true;
            this.rbBall.Text = "Ball";
            this.rbBall.UseVisualStyleBackColor = true;
            this.rbBall.CheckedChanged += new System.EventHandler(this.rbBall_CheckedChanged);
            // 
            // rbCylinder
            // 
            this.rbCylinder.AutoSize = true;
            this.rbCylinder.Location = new System.Drawing.Point(101, 17);
            this.rbCylinder.Name = "rbCylinder";
            this.rbCylinder.Size = new System.Drawing.Size(62, 17);
            this.rbCylinder.TabIndex = 7;
            this.rbCylinder.TabStop = true;
            this.rbCylinder.Text = "Cylinder";
            this.rbCylinder.UseVisualStyleBackColor = true;
            this.rbCylinder.CheckedChanged += new System.EventHandler(this.rbCylinder_CheckedChanged);
            // 
            // rbWardrobe
            // 
            this.rbWardrobe.AutoSize = true;
            this.rbWardrobe.Location = new System.Drawing.Point(19, 17);
            this.rbWardrobe.Name = "rbWardrobe";
            this.rbWardrobe.Size = new System.Drawing.Size(72, 17);
            this.rbWardrobe.TabIndex = 6;
            this.rbWardrobe.TabStop = true;
            this.rbWardrobe.Text = "Wardrobe";
            this.rbWardrobe.UseVisualStyleBackColor = true;
            this.rbWardrobe.CheckedChanged += new System.EventHandler(this.rbWardrobe_CheckedChanged);
            // 
            // LObjectLength
            // 
            this.LObjectLength.AutoSize = true;
            this.LObjectLength.Location = new System.Drawing.Point(16, 208);
            this.LObjectLength.Name = "LObjectLength";
            this.LObjectLength.Size = new System.Drawing.Size(0, 13);
            this.LObjectLength.TabIndex = 5;
            // 
            // tbObjectLength
            // 
            this.tbObjectLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbObjectLength.Location = new System.Drawing.Point(107, 195);
            this.tbObjectLength.Multiline = true;
            this.tbObjectLength.Name = "tbObjectLength";
            this.tbObjectLength.Size = new System.Drawing.Size(119, 37);
            this.tbObjectLength.TabIndex = 4;
            this.tbObjectLength.Visible = false;
            this.tbObjectLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // LObjectWidth
            // 
            this.LObjectWidth.AutoSize = true;
            this.LObjectWidth.Location = new System.Drawing.Point(16, 148);
            this.LObjectWidth.Name = "LObjectWidth";
            this.LObjectWidth.Size = new System.Drawing.Size(0, 13);
            this.LObjectWidth.TabIndex = 3;
            // 
            // LObjectHeight
            // 
            this.LObjectHeight.AutoSize = true;
            this.LObjectHeight.Location = new System.Drawing.Point(16, 87);
            this.LObjectHeight.Name = "LObjectHeight";
            this.LObjectHeight.Size = new System.Drawing.Size(0, 13);
            this.LObjectHeight.TabIndex = 2;
            // 
            // tbObjectWidth
            // 
            this.tbObjectWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbObjectWidth.Location = new System.Drawing.Point(107, 135);
            this.tbObjectWidth.Multiline = true;
            this.tbObjectWidth.Name = "tbObjectWidth";
            this.tbObjectWidth.Size = new System.Drawing.Size(119, 37);
            this.tbObjectWidth.TabIndex = 1;
            this.tbObjectWidth.Visible = false;
            this.tbObjectWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // tbObjectHeight
            // 
            this.tbObjectHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbObjectHeight.Location = new System.Drawing.Point(107, 75);
            this.tbObjectHeight.Multiline = true;
            this.tbObjectHeight.Name = "tbObjectHeight";
            this.tbObjectHeight.Size = new System.Drawing.Size(119, 37);
            this.tbObjectHeight.TabIndex = 0;
            this.tbObjectHeight.Visible = false;
            this.tbObjectHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(153, 278);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(214, 56);
            this.button_Calculate.TabIndex = 2;
            this.button_Calculate.Text = "CALCULATE";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // Form_PLLUGTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 358);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.panel_Object);
            this.Controls.Add(this.panel_Door);
            this.Name = "Form_PLLUGTEST";
            this.Text = "PLLUG TEST";
            this.panel_Door.ResumeLayout(false);
            this.panel_Door.PerformLayout();
            this.panel_Object.ResumeLayout(false);
            this.panel_Object.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Door;
        private System.Windows.Forms.Label LDoorWidth;
        private System.Windows.Forms.Label LDoorHeight;
        private System.Windows.Forms.TextBox tbExitWidth;
        private System.Windows.Forms.TextBox tbExitHeight;
        private System.Windows.Forms.Panel panel_Object;
        private System.Windows.Forms.Label LObjectWidth;
        private System.Windows.Forms.Label LObjectHeight;
        private System.Windows.Forms.TextBox tbObjectWidth;
        private System.Windows.Forms.TextBox tbObjectHeight;
        private System.Windows.Forms.Label LObjectLength;
        private System.Windows.Forms.TextBox tbObjectLength;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbDoor;
        private System.Windows.Forms.RadioButton rbBall;
        private System.Windows.Forms.RadioButton rbCylinder;
        private System.Windows.Forms.RadioButton rbWardrobe;
    }
}


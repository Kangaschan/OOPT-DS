namespace WinFormsApp1
{
    partial class Form1
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
            picBox = new PictureBox();
            cmbBox = new ComboBox();
            btnLVLUP = new Button();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // picBox
            // 
            picBox.Location = new Point(20, 41);
            picBox.Name = "picBox";
            picBox.Size = new Size(950, 500);
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            picBox.MouseClick += picBox_MouseClick;
            // 
            // cmbBox
            // 
            cmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox.ImeMode = ImeMode.Disable;
            cmbBox.Items.AddRange(new object[] { "Human", "Elf", "Dwarf", "FlyingCreature", "Dragon ", "Treant" });
            cmbBox.Location = new Point(47, 7);
            cmbBox.Name = "cmbBox";
            cmbBox.Size = new Size(419, 28);
            cmbBox.TabIndex = 1;
            cmbBox.SelectedIndexChanged += cmbBox_SelectedIndexChanged;
            // 
            // btnLVLUP
            // 
            btnLVLUP.Location = new Point(809, 6);
            btnLVLUP.Name = "btnLVLUP";
            btnLVLUP.Size = new Size(94, 29);
            btnLVLUP.TabIndex = 2;
            btnLVLUP.Text = "btnLVLUP";
            btnLVLUP.UseVisualStyleBackColor = true;
            btnLVLUP.Click += button1_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(665, 6);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnCreate);
            Controls.Add(btnLVLUP);
            Controls.Add(cmbBox);
            Controls.Add(picBox);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "недо днд";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBox;
        private ComboBox cmbBox;
        private Button btnLVLUP;
        private Button btnCreate;
    }
}

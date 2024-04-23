namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            picBox = new PictureBox();
            cmbBox = new ComboBox();
            btnLVLUP = new Button();
            btnCreate = new Button();
            btnDessurerealize = new Button();
            btnSurerealize = new Button();
            cmbBoxSerr = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // picBox
            // 
            picBox.Location = new Point(20, 71);
            picBox.Name = "picBox";
            picBox.Size = new Size(950, 470);
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            picBox.MouseClick += picBox_MouseClick;
            picBox.MouseDoubleClick += picBox_MouseDoubleClick;
            // 
            // cmbBox
            // 
            cmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBox.ImeMode = ImeMode.Disable;
            cmbBox.Items.AddRange(new object[] { "Human", "Elf", "Dwarf", "FlyingCreature", "Dragon ", "Treant" });
            cmbBox.Location = new Point(20, 7);
            cmbBox.Name = "cmbBox";
            cmbBox.Size = new Size(326, 28);
            cmbBox.TabIndex = 1;
            cmbBox.SelectedIndexChanged += cmbBox_SelectedIndexChanged;
            // 
            // btnLVLUP
            // 
            btnLVLUP.Location = new Point(508, 6);
            btnLVLUP.Name = "btnLVLUP";
            btnLVLUP.Size = new Size(150, 29);
            btnLVLUP.TabIndex = 2;
            btnLVLUP.Text = "поднять уровень";
            btnLVLUP.UseVisualStyleBackColor = true;
            btnLVLUP.Click += button1_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(352, 6);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDessurerealize
            // 
            btnDessurerealize.Location = new Point(820, 6);
            btnDessurerealize.Name = "btnDessurerealize";
            btnDessurerealize.Size = new Size(150, 29);
            btnDessurerealize.TabIndex = 4;
            btnDessurerealize.Text = "Десериализовать";
            btnDessurerealize.UseVisualStyleBackColor = true;
            btnDessurerealize.Click += button1_Click_1;
            // 
            // btnSurerealize
            // 
            btnSurerealize.Location = new Point(664, 6);
            btnSurerealize.Name = "btnSurerealize";
            btnSurerealize.Size = new Size(150, 29);
            btnSurerealize.TabIndex = 5;
            btnSurerealize.Text = "Сериализовать";
            btnSurerealize.UseVisualStyleBackColor = true;
            btnSurerealize.Click += btnSurerealize_Click;
            // 
            // cmbBoxSerr
            // 
            cmbBoxSerr.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSerr.ImeMode = ImeMode.Disable;
            cmbBoxSerr.Items.AddRange(new object[] { "XML", "бинарный" });
            cmbBoxSerr.Location = new Point(664, 37);
            cmbBoxSerr.Name = "cmbBoxSerr";
            cmbBoxSerr.Size = new Size(306, 28);
            cmbBoxSerr.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(cmbBoxSerr);
            Controls.Add(btnSurerealize);
            Controls.Add(btnDessurerealize);
            Controls.Add(btnCreate);
            Controls.Add(btnLVLUP);
            Controls.Add(cmbBox);
            Controls.Add(picBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
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
        private Button btnDessurerealize;
        private Button btnSurerealize;
        private ComboBox cmbBoxSerr;
    }
}

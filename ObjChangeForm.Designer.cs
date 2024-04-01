namespace WinFormsApp1
{
    partial class ObjChangeForm : Form
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
            tableLayoutPanel = new TableLayoutPanel();
            btn_save = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Location = new Point(24, 12);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(631, 387);
            tableLayoutPanel.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(671, 37);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 1;
            btn_save.Text = "button1";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(671, 344);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "button1";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // ObjChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(tableLayoutPanel);
            Name = "ObjChangeForm";
            Text = "ObjChangeForm";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Dictionary<string, object> parameters;
        public ObjChangeForm(Dictionary<string, object> parameters)
        {
            InitializeComponent();
            this.parameters = parameters;
            GenerateControls();
        }

        private void GenerateControls()
        {
            // Создание элементов управления на основе параметров
            foreach (var param in parameters)
            {
                // Создание метки для параметра
                Label label = new Label();
                label.Text = param.Key;

                // Создание текстового поля для ввода значения параметра
                TextBox textBox = new TextBox();
                textBox.Text = param.Value.ToString(); // Предполагаем, что значения параметров - строки

                // Размещение метки и текстового поля на форме
                tableLayoutPanel.Controls.Add(label);
                tableLayoutPanel.Controls.Add(textBox);
            }
        }

        private Button btn_save;
        private Button btn_cancel;
    }
}
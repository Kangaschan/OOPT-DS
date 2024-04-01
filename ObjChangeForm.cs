using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ObjChangeForm : Form
    {
        public ObjChangeForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    string paramName = tableLayoutPanel.GetRow(textBox).ToString(); // Получаем имя параметра из номера строки
                    // Применение нового значения к параметру объекта
                    // Например: object[paramName] = textBox.Text;
                }
            }

            DialogResult = DialogResult.OK; // Закрываем окно с результатом OK
            Close(); // Закрываем окно
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Закрываем окно с результатом Cancel
            Close(); // Закрываем окно
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTP
{
    public struct TFormBuildInfo
    {
        public string info;
        public Type type;
        public object value;
    }
    public partial class FormObjChange : Form
    {
        public List<TFormBuildInfo> UpdatedList { get; private set; }
        protected List<TFormBuildInfo> classFields; 
        private const int controlHeight = 50;
        TextBox[] textBoxesValue;
        Label[] labelsInfo;
        Button btnSubmit;
        Label[] labelsType;
    //    private Dictionary<object,Type> parameters;
        public FormObjChange(List<TFormBuildInfo> inp)
        {
            InitializeComponent();
            this.classFields = inp;
         //   this.parameters = parameters;
            UpdatedList = new List<TFormBuildInfo>();
            btnSubmit = new Button();
            btnSubmit.Click += btnSaveInfo;
            textBoxesValue = new TextBox[classFields.Count];
            labelsInfo = new Label[classFields.Count];
            labelsType = new Label[classFields.Count];   
            this.Height = (classFields.Count + 1) * controlHeight + 50;
            GenereateControls();
        }
        private void GenereateControls()
        {
          
            for (int i = 0; i < classFields.Count; i++)
            {

                labelsInfo[i] = new Label();
                labelsInfo[i].Text = classFields[i].info;
                labelsInfo[i].Location = new System.Drawing.Point(10, 5 + i * controlHeight);
                labelsInfo[i].Height = controlHeight - 10;
                labelsInfo[i].Width = this.Width / 3 - 40;
                this.Controls.Add(labelsInfo[i]);


                textBoxesValue[i] = new TextBox();
                textBoxesValue[i].Text = classFields[i].value.ToString();
                textBoxesValue[i].Location = new System.Drawing.Point((this.Width / 3) * 2 + 20, 5 + i * controlHeight);
                textBoxesValue[i].Height = controlHeight - 10;
                textBoxesValue[i].Width = this.Width / 3 - 40;
                this.Controls.Add(textBoxesValue[i]);

                labelsType[i] = new Label();
                labelsType[i].Text = classFields[i].type.ToString();
                labelsType[i].Location =  new System.Drawing.Point((this.Width / 3) + 10, 5 + i * controlHeight);
                labelsType[i].Height = controlHeight - 10;
                labelsType[i].Width = this.Width / 3 - 40;
                this.Controls.Add(labelsType[i]);
            }

            btnSubmit.Text = "Сохранить изменения";
            btnSubmit.Location =new System.Drawing.Point((this.Width / 3) + 10, 5 + (classFields.Count ) * controlHeight);
            btnSubmit.Height = controlHeight - 10;
            btnSubmit.Width = this.Width / 3 - 40;
            btnSubmit.Enabled = true;
            btnSubmit.Visible = true;
            this.Controls.Add(btnSubmit);
        }

        private void btnSaveInfo(object sender, EventArgs e)
        {
            for (int i = 0; i< classFields.Count; i++)
            {
                Type typetmp = classFields[i].type;
                TFormBuildInfo temp;
                temp.info = "";
                try
                {
                    temp.value = Convert.ChangeType(textBoxesValue[i].Text, typetmp);
                }
                catch
                {
                    temp.value = classFields[i].value;
                }
                temp.type = typetmp;
                UpdatedList.Add(temp);
            }
            this.Close();
        }
        private void FormObjChange_Load(object sender, EventArgs e)
        {

        }
    }
}

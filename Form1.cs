using OOTP;
using System.Collections;
using System.Drawing.Text;
using System.Net.Http.Headers;
using System.Xml.Linq;
using System.Xml.Serialization;
using WinFormsApp1;


namespace WinFormsApp1
{

    public partial class MainForm : Form
    {
        private bool click = false;
        private void DrawArr()
        {
            GFX.FillRectangle(Brushes.White, new RectangleF(0, 0, picBox.Width, picBox.Height));
            for (int i = 0; i < arr.Count; i++)
            {
                GFX.DrawImage(image: arr[i].self.DrawitSelf(), point: new Point(arr[i].X, arr[i].Y));
            }
        }
        private string filenameXML = "creatures.xml";
        private string filenameBIN = "creatures.bin";
        private Factory fact;
        public List<Coord> arr;
        private int ind, clickind;
        private Point clickPoint;
        private Graphics GFX;
        public MainForm()
        {
            HookManager.SetHook();
            arr = new List<Coord>();
            ind = 0;
            InitializeComponent();
            GFX = picBox.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 00; i < arr.Count; i++)
            {
                if (arr[i] != null)
                    arr[i].self.incLevel(10);
            }
            DrawArr();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (fact != null)
            {
                // arr[ind++] = new Coord(fact.Create(1, 1), 0, 0);
                arr.Add(new Coord(fact.Create(1, 1), 0, 0));
                DrawArr();
            }
            else
                MessageBox.Show("не выбран тип обьекта");
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBox.SelectedIndex)
            {
                case 0:
                    fact = new HumanFactory();
                    break;
                case 1:
                    fact = new ElfFactory();
                    break;
                case 2:
                    fact = new DwarfFactory();
                    break;
                case 3:
                    fact = new FlyingCreatureFactory();
                    break;
                case 4:
                    fact = new DragonFactory();
                    break;
                case 5:
                    fact = new TreantFactory();
                    break;
            }
        }

        private void picBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (click == false)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (e.X >= arr[i].X && e.X <= (arr[i].X + Coord.width))
                    {
                        if (e.Y >= arr[i].Y && e.Y <= (arr[i].Y + Coord.height))
                        {
                            clickind = i;
                            click = true;
                            clickPoint = new Point(e.X, e.Y);
                        }
                    }
                }
            }
            else
            {
                arr[clickind].X = e.X - Coord.width / 2;
                arr[clickind].Y = e.Y - Coord.height / 2;
                click = false;
                DrawArr();
            }
        }

    
        private void picBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int clickind = -1;
            for (int i = 0; i < arr.Count; i++)
            {
                if (e.X >= arr[i].X && e.X <= (arr[i].X + Coord.width))
                {
                    if (e.Y >= arr[i].Y && e.Y <= (arr[i].Y + Coord.height))
                    {
                        clickind = i;
                    }
                }
            }
            if (clickind != -1)
            {
                List<TFormBuildInfo> Ltest = new List<TFormBuildInfo>();
                Ltest = arr[clickind].self.GetParams();

                FormObjChange Ftest = new FormObjChange(Ltest);
                Ftest.ShowDialog();
                Ltest = Ftest.UpdatedList;

                arr[clickind].self.SetParams(Ltest);
                DrawArr();
            }
            else
            {
                MessageBox.Show("Вы не выбрали обьект");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LivingCreature[] creatures = new LivingCreature[0];
            if (cmbBoxSerr.SelectedIndex != -1)
            {
                if (cmbBoxSerr.SelectedIndex == 0)
                {
                    creatures = MySerializer.DeserializeXml(filenameXML);
                }
                if (cmbBoxSerr.SelectedIndex == 1)
                {
                    creatures = MySerializer.DeserializeObject<LivingCreature[]>(filenameBIN);
                }
                for (int i = 0; i < creatures.Length;i++)
                {
                    arr.Add(new Coord(creatures[i], 0, 0));
                }
                DrawArr();
            }
            else
            {
                MessageBox.Show("Вы не вырбали способ");
            }
        }

        private void btnSurerealize_Click(object sender, EventArgs e)
        {
            if (cmbBoxSerr.SelectedIndex != -1)
            {
                LivingCreature[] serrArr = new LivingCreature[arr.Count];
                for (int i = 0; i < arr.Count; i++)
                {
                    serrArr[i] = new Human();
                    serrArr[i] = arr[i].self;
                }

                if (cmbBoxSerr.SelectedIndex == 0)
                {
                    MySerializer.SerializeXml(filenameXML, serrArr);
                }
                if (cmbBoxSerr.SelectedIndex == 1)
                {
                    MySerializer.SerializeObject(obj: serrArr, filenameBIN);
                }
                
                }
            else
            {
                MessageBox.Show("Вы не вырбали способ");
            }
        }
    }
}



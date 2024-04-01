using System.Collections;
using System.Drawing.Text;
using System.Xml.Linq;
using WinFormsApp1;


namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private bool click = false;
        private void DrawArr()
        {
            GFX.FillRectangle(Brushes.White, new RectangleF(0, 0, picBox.Width, picBox.Height));
            for (int i = 0; i < ind; i++)
            {
                GFX.DrawImage(image: arr[i].self.DrawitSelf(), point: new Point(arr[i].X, arr[i].Y));
            }
        }
        private Factory fact;
        private Coord[] arr;
        private int ind, clickind;
        private Point clickPoint;
        private Graphics GFX;
        public Form1()
        {

            arr = new Coord[10];
            ind = 0;
            InitializeComponent();
            GFX = picBox.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 00; i < arr.Length; i++)
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
                arr[ind++] = new Coord(fact.Create(1, 1), 0, 0);
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
                for (int i = 0; i < ind; i++)
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
                arr[clickind].X = e.X - Coord.width/2;
                arr[clickind].Y = e.Y - Coord.height/2;
                click = false;
                DrawArr();
            }
        }
    }
}



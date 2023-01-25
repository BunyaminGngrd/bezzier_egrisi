namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point orijin = new Point(800, 500);
            kordinat(orijin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daire();

        }

        private void button3_Click(object sender, EventArgs e)
        {
                bezzier();
        }
        public void kordinat(Point orijin)  //Kordinat sistemi çizildi.
        {
            Point p1 = new Point(0, 250);
            Point p2 = new Point(800, 250);
            Point p3 = new Point(400, 0);
            Point p4 = new Point(400, 500);
            Graphics gg = CreateGraphics();
            Pen p = new Pen(Color.Green);
            gg.DrawLine(p, p1, p2);
            gg.DrawLine(p, p3, p4);

        }


        private void daire()                         //Daireler çizildi.
        {                                            //(0,0) noktasý (397.5,247.5) noktasý alýndý.
            Graphics l = CreateGraphics();          //Daha net gözükmesi için birimler 100 ile çarpýldý.
            Pen p = new Pen(Color.Red, 5);
            l.DrawEllipse(p, 397.5f, 247.5f, 5, 5);
            l.DrawEllipse(p, 497.5f, 22.5f, 5, 5);
            l.DrawEllipse(p, 747.5f, 172.5f, 5, 5);
            l.DrawEllipse(p, 672.5f, 247.5f, 5, 5);

        }
        public void bezzier()   //Bezzier eðrisi çizildi.
        {
            PointF[] p = {
            new PointF(397.5f, 247.5f),
            new PointF(497.5f, 22.5f),
            new PointF(747.5f, 172.5f),
            new PointF(672.5f, 247.5f)};
            Graphics dd = CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            dd.DrawBeziers(pen, p);
        }


    }
}
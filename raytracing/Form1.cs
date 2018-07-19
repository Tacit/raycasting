using System;
using System.Drawing;
using System.Windows.Forms;

namespace raytracing
{
    public partial class Form1 : Form
    {
        const int width = 40;
        const int height = 30;
        const int size = 8;

        private Scene scene;

        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            scene.CreateSceneFromFile("map.map");
            Render2d();
            Render3d();
        }

        private void Render2d()
        {
            Bitmap bm = new Bitmap(320, 240);
            Graphics g = Graphics.FromImage(bm);
            scene.Render2D(g);
            pb2d.Image = bm;
        }

        private void Render3d()
        {
            Bitmap bm = new Bitmap(320, 240);
            Graphics g = Graphics.FromImage(bm);
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 320, 240));
            g.FillRectangle(Brushes.AliceBlue,0, 0, 320, 240 / 2);
            g.FillRectangle(Brushes.SandyBrown, 0, 240 / 2, 320, 240);
            scene.Render3D(g);
            pb3d.Image = bm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scene.camera.viewangle -= 10f;

            Render2d();
            Render3d();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            scene.camera.viewangle += 10f;

            Render2d();
            Render3d();
        }
    }

    
}

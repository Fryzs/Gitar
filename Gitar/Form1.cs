using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Security.Cryptography.Xml;
using NAudio.Wave;
using WMPLib;


namespace Gitar
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int lineDrawCount = 0;  // Лічильник кількості ліній
        private Button animateButton;
        Pen pen = new Pen(Color.Black, 2);
        Pen Strun = new Pen(Color.Black, 1);
        Graphics g;
        int x = 10, y = 40, w = 200, h = 200, S = 0;
        float dx, dy;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            GraphicsPath ThreeD = new GraphicsPath();



        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GitarFull()
        {

            Gitar();

            float dx = w / 33.0f;
            float dy = h / 69.0f;
            g.DrawLine(Strun, x + dx * 25.3f, y + dy * 9.8f, x + dx * 13.2f, y + dy * 53);
            g.DrawLine(Strun, x + dx * 25.7f, y + dy * 9.8f, x + dx * 14f, y + dy * 53);
            g.DrawLine(Strun, x + dx * 26.1f, y + dy * 9.8f, x + dx * 14.7f, y + dy * 53);

            g.DrawLine(Strun, x + dx * 26.5f, y + dy * 9.9f, x + dx * 15.4f, y + dy * 53);
            g.DrawLine(Strun, x + dx * 26.9f, y + dy * 9.95f, x + dx * 16.2f, y + dy * 53);
            g.DrawLine(Strun, x + dx * 27.3f, y + dy * 10.2f, x + dx * 17f, y + dy * 53);

        }
        private void Gitar()
        {
            // g.DrawBezier(pen,  x+dx*,y+dy*,  x+dx*, y+dy* ,   x+dx*, y+dy*,  x+dx*,y+dy*);
            g.Clear(Color.White);


            Pen Someone = new Pen(Color.White, 3);
            float dx = w / 33.0f;
            float dy = h / 69.0f;

            g.DrawLine(pen, x + dx * 19, y + dy * 69, x + dx * 18, y + dy * 69);
            //1Side
            g.DrawBezier(pen, x + dx * 18, y + dy * 69, x + dx * 12, y + dy * 68, x + dx * 9.2f, y + dy * 67, x + dx * 7, y + dy * 66);
            g.DrawBezier(pen, x + dx * 7, y + dy * 66, x + dx * 5, y + dy * 65, x + dx * 3.6f, y + dy * 64, x + dx * 2.9f, y + dy * 63);
            g.DrawBezier(pen, x + dx * 2.9f, y + dy * 63, x + dx * 2.2f, y + dy * 62, x + dx * 1.9f, y + dy * 61, x + dx * 1.6f, y + dy * 60);
            g.DrawBezier(pen, x + dx * 1.6f, y + dy * 60, x + dx * 1.3f, y + dy * 59, x + dx * 1.3f, y + dy * 58, x + dx * 1.2f, y + dy * 57);
            g.DrawBezier(pen, x + dx * 1.2f, y + dy * 57, x + dx * 1.5f, y + dy * 56, x + dx * 1.8f, y + dy * 55, x + dx * 2, y + dy * 54);
            g.DrawBezier(pen, x + dx * 2, y + dy * 54, x + dx * 2.3f, y + dy * 53, x + dx * 2.9f, y + dy * 52, x + dx * 3.3f, y + dy * 51);
            g.DrawBezier(pen, x + dx * 3.3f, y + dy * 51, x + dx * 4.1f, y + dy * 50, x + dx * 4.9f, y + dy * 49, x + dx * 5.7f, y + dy * 48);
            g.DrawBezier(pen, x + dx * 5.7f, y + dy * 48, x + dx * 6.2f, y + dy * 47, x + dx * 7, y + dy * 46, x + dx * 7.3f, y + dy * 45);
            g.DrawBezier(pen, x + dx * 7.3f, y + dy * 45, x + dx * 8, y + dy * 44, x + dx * 8.2f, y + dy * 43, x + dx * 8.5f, y + dy * 42);
            g.DrawBezier(pen, x + dx * 8.5f, y + dy * 42, x + dx * 8.7f, y + dy * 41, x + dx * 8.8f, y + dy * 40, x + dx * 8.9f, y + dy * 39);
            g.DrawBezier(pen, x + dx * 8.9f, y + dy * 39, x + dx * 9, y + dy * 38, x + dx * 9.3f, y + dy * 37, x + dx * 9.7f, y + dy * 36);
            g.DrawBezier(pen, x + dx * 9.7f, y + dy * 36, x + dx * 10, y + dy * 35, x + dx * 11, y + dy * 34, x + dx * 13, y + dy * 33);

            g.DrawBezier(pen, x + dx * 13, y + dy * 33, x + dx * 14, y + dy * 32.9f, x + dx * 15, y + dy * 32.8f, x + dx * 16, y + dy * 32.7f);
            g.DrawBezier(pen, x + dx * 16, y + dy * 32.7f, x + dx * 17, y + dy * 32.8f, x + dx * 17, y + dy * 32.8f, x + dx * 18, y + dy * 33);
            //2Side

            g.DrawBezier(pen, x + dx * 19, y + dy * 69, x + dx * 23, y + dy * 68, x + dx * 24.1f, y + dy * 67, x + dx * 25.2f, y + dy * 66);
            g.DrawBezier(pen, x + dx * 25.2f, y + dy * 66, x + dx * 26, y + dy * 65, x + dx * 26.3f, y + dy * 64, x + dx * 26.8f, y + dy * 63);
            g.DrawBezier(pen, x + dx * 26.8f, y + dy * 63, x + dx * 27, y + dy * 62, x + dx * 27.2f, y + dy * 61, x + dx * 27.3f, y + dy * 60);
            g.DrawBezier(pen, x + dx * 27.3f, y + dy * 60, x + dx * 27.2f, y + dy * 59, x + dx * 27.2f, y + dy * 58, x + dx * 27.1f, y + dy * 57);
            g.DrawBezier(pen, x + dx * 27.1f, y + dy * 57, x + dx * 27, y + dy * 56, x + dx * 26.7f, y + dy * 55, x + dx * 26.5f, y + dy * 54);
            g.DrawBezier(pen, x + dx * 26.5f, y + dy * 54, x + dx * 26.4f, y + dy * 53, x + dx * 26.3f, y + dy * 52, x + dx * 26.2f, y + dy * 51);
            g.DrawBezier(pen, x + dx * 26.2f, y + dy * 51, x + dx * 26.1f, y + dy * 50, x + dx * 26, y + dy * 49, x + dx * 26, y + dy * 48);
            g.DrawBezier(pen, x + dx * 26, y + dy * 48, x + dx * 25.9f, y + dy * 47, x + dx * 26.3f, y + dy * 46, x + dx * 26.7f, y + dy * 45);
            g.DrawBezier(pen, x + dx * 26.7f, y + dy * 45, x + dx * 27.1f, y + dy * 44, x + dx * 27.6f, y + dy * 43, x + dx * 28, y + dy * 42);
            g.DrawBezier(pen, x + dx * 28, y + dy * 42, x + dx * 28.2f, y + dy * 41, x + dx * 28.5f, y + dy * 40, x + dx * 28.6f, y + dy * 39);
            g.DrawBezier(pen, x + dx * 28.6f, y + dy * 39, x + dx * 28.3f, y + dy * 38, x + dx * 27.9f, y + dy * 37, x + dx * 27, y + dy * 36);
            g.DrawBezier(pen, x + dx * 27, y + dy * 36, x + dx * 25, y + dy * 35, x + dx * 23, y + dy * 34, x + dx * 18, y + dy * 33);
            //3D
            g.DrawBezier(pen, x + dx * (19), y + dy * 69, x + dx * (23 + 1.5f), y + dy * 68, x + dx * (24.1f + 1.5f), y + dy * 67, x + dx * (25.2f + 1.5f), y + dy * 66);
            g.DrawBezier(pen, x + dx * (25.2f + 1.5f), y + dy * 66, x + dx * (26 + 1.5f), y + dy * 65, x + dx * (26.3f + 1.5f), y + dy * 64, x + dx * (26.8f + 1.5f), y + dy * 63);
            g.DrawBezier(pen, x + dx * (26.8f + 1.5f), y + dy * 63, x + dx * (27 + 1.5f), y + dy * 62, x + dx * (27.2f + 1.5f), y + dy * 61, x + dx * (27.3f + 1.5f), y + dy * 60);
            g.DrawBezier(pen, x + dx * (27.3f + 1.5f), y + dy * 60, x + dx * (27.2f + 1.5f), y + dy * 59, x + dx * (27.2f + 1.5f), y + dy * 58, x + dx * (27.1f + 1.5f), y + dy * 57);
            g.DrawBezier(pen, x + dx * (27.1f + 1.5f), y + dy * 57, x + dx * (27 + 1.5f), y + dy * 56, x + dx * (26.7f + 1.5f), y + dy * 55, x + dx * (26.5f + 1.5f), y + dy * 54);
            g.DrawBezier(pen, x + dx * (26.5f + 1.5f), y + dy * 54, x + dx * (26.4f + 1.5f), y + dy * 53, x + dx * (26.3f + 1.5f), y + dy * 52, x + dx * (26.2f + 1.5f), y + dy * 51);
            g.DrawBezier(pen, x + dx * (26.2f + 1.5f), y + dy * 51, x + dx * (26.1f + 1.5f), y + dy * 50, x + dx * (26 + 1.5f), y + dy * 49, x + dx * (26 + 1.5f), y + dy * 48);
            g.DrawBezier(pen, x + dx * (26 + 1.5f), y + dy * 48, x + dx * (25.9f + 1.5f), y + dy * 47, x + dx * (26.3f + 1.5f), y + dy * 46, x + dx * (26.7f + 1.5f), y + dy * 45);
            g.DrawBezier(pen, x + dx * (26.7f + 1.5f), y + dy * 45, x + dx * (27.1f + 1.5f), y + dy * 44, x + dx * (27.6f + 1.5f), y + dy * 43, x + dx * (28 + 1.5f), y + dy * 42);
            g.DrawBezier(pen, x + dx * (28 + 1.5f), y + dy * 42, x + dx * (28.2f + 1.3f), y + dy * 41, x + dx * (28.5f + 1.2f), y + dy * 40, x + dx * (28.6f + 0.8f), y + dy * 39);
            g.DrawBezier(pen, x + dx * (28.6f + 0.8f), y + dy * 39, x + dx * (28.3f + 0.5f), y + dy * 38, x + dx * (27.9f + 0.3f), y + dy * 37, x + dx * (27), y + dy * 36);
            //Grif
            g.DrawLine(pen, x + dx * 16.5f, y + dy * 39.4f, x + dx * 25, y + dy * 10);
            g.DrawLine(pen, x + dx * 20.7f, y + dy * 40.2f, x + dx * 27.7f, y + dy * 10.4f);
            g.DrawBezier(pen, x + dx * 16.5f, y + dy * 39.4f, x + dx * 18, y + dy * 40.1f, x + dx * 19.5f, y + dy * 40.3f, x + dx * 20.7f, y + dy * 40.2f);
            g.DrawBezier(pen, x + dx * 25, y + dy * 10, x + dx * 26, y + dy * 9.6f, x + dx * 27, y + dy * 10, x + dx * 27.7f, y + dy * 10.4f);
            //Head
            g.DrawBezier(pen, x + dx * 25, y + dy * 10, x + dx * 25, y + dy * 8.8f, x + dx * 24.5f, y + dy * 7.5f, x + dx * 25.2f, y + dy * 6);
            g.DrawBezier(pen, x + dx * 25.2f, y + dy * 6, x + dx * 25.8f, y + dy * 5, x + dx * 26.1f, y + dy * 4, x + dx * 26.4f, y + dy * 3);
            g.DrawBezier(pen, x + dx * 26.4f, y + dy * 3, x + dx * 26.8f, y + dy * 2, x + dx * 27, y + dy * 1, x + dx * 27.5f, y + dy * 0.3f);
            g.DrawBezier(pen, x + dx * 27.5f, y + dy * 0.3f, x + dx * 28, y + dy * 0.1f, x + dx * 29, y + dy * 0.1f, x + dx * 30, y + dy * 0.3f);
            g.DrawBezier(pen, x + dx * 30, y + dy * 0.3f, x + dx * 31, y + dy * 0.5f, x + dx * 32, y + dy * 1, x + dx * 32.6f, y + dy * 1.6f);
            g.DrawBezier(pen, x + dx * 32.6f, y + dy * 1.6f, x + dx * 32.6f, y + dy * 2, x + dx * 32, y + dy * 3, x + dx * 31.4f, y + dy * 4);
            g.DrawBezier(pen, x + dx * 31.4f, y + dy * 4, x + dx * 31, y + dy * 5, x + dx * 30.7f, y + dy * 6, x + dx * 30.3f, y + dy * 7);
            g.DrawBezier(pen, x + dx * 30.3f, y + dy * 7, x + dx * 30.2f, y + dy * 7.5f, x + dx * 30, y + dy * 8, x + dx * 29, y + dy * 9);
            g.DrawBezier(pen, x + dx * 29, y + dy * 9, x + dx * 28.5f, y + dy * 9.5f, x + dx * 28, y + dy * 10.4f, x + dx * 27.7f, y + dy * 10.4f);

            g.DrawBezier(pen, x + dx * 27.5f, y + dy * 10.3f, x + dx * 27.7f, y + dy * 9.8f, x + dx * 28, y + dy * 9, x + dx * 29, y + dy * 8);
            g.DrawBezier(pen, x + dx * 29, y + dy * 8, x + dx * 29.8f, y + dy * 6, x + dx * 31.1f, y + dy * 3, x + dx * 32, y + dy * 1.2f);

            g.DrawBezier(pen, x + dx * 25.7f, y + dy * 9.9f, x + dx * 26.2f, y + dy * 8, x + dx * 27, y + dy * 6, x + dx * 27.8f, y + dy * 2);
            g.DrawLine(pen, x + dx * 26.25f, y + dy * 8, x + dx * 26.2f, y + dy * 7);
            g.DrawLine(pen, x + dx * 26.85f, y + dy * 6, x + dx * 26.7f, y + dy * 4.8f);

            g.DrawBezier(pen, x + dx * 26.9f, y + dy * 10f, x + dx * 27.3f, y + dy * 8.5f, x + dx * 28.7f, y + dy * 6.3f, x + dx * 30.6f, y + dy * 2.4f);
            g.DrawLine(pen, x + dx * 27.5f, y + dy * 8.5f, x + dx * 28.5f, y + dy * 7.2f);
            g.DrawLine(pen, x + dx * 28.6f, y + dy * 6.3f, x + dx * 29.7f, y + dy * 5.1f);

            g.DrawBezier(pen, x + dx * 27.05f, y + dy * 1.3f, x + dx * 26.4f, y + dy * 0.7f, x + dx * 26, y + dy * 1.9f, x + dx * 26.8f, y + dy * 1.8f);

            Brush brush = new SolidBrush(Color.Black);
            GraphicsPath Left = new GraphicsPath();
            GraphicsPath Right = new GraphicsPath();
            GraphicsPath Right1 = new GraphicsPath();
            GraphicsPath Right2 = new GraphicsPath();

            // Додаємо криву Без'є до шляху
            Left.AddBezier(x + dx * 27.05f, y + dy * 1.3f,
                           x + dx * 26.4f, y + dy * 0.7f,
                           x + dx * 26, y + dy * 1.9f,
                           x + dx * 26.8f, y + dy * 1.8f);
            Left.AddBezier(x + dx * 26.1f, y + dy * 3.9f, x + dx * 25.6f, y + dy * 3.4f, x + dx * 25, y + dy * 4.6f, x + dx * 25.9f, y + dy * 4.5f);
            Left.AddBezier(x + dx * 25.18f, y + dy * 6.2f, x + dx * 24.4f, y + dy * 5.6f, x + dx * 24.1f, y + dy * 6.9f, x + dx * 24.9f, y + dy * 7.1f);
            Right.AddBezier(x + dx * 32.38f, y + dy * 2.3f, x + dx * 32.8f, y + dy * 2.4f, x + dx * 32.3f, y + dy * 3.6f, x + dx * 32f, y + dy * 3f);
            Right1.AddBezier(x + dx * 31f, y + dy * 5f, x + dx * 31.8f, y + dy * 4.9f, x + dx * 31.3f, y + dy * 6.2f, x + dx * 30.7f, y + dy * 5.9f);
            Right2.AddBezier(x + dx * 30.2f, y + dy * 7.3f, x + dx * 30.8f, y + dy * 7.4f, x + dx * 30.3f, y + dy * 8.7f, x + dx * 29.9f, y + dy * 8f);
            // Заповнюємо криву
            g.FillPath(brush, Left);
            g.FillPath(brush, Right);
            g.FillPath(brush, Right1);
            g.FillPath(brush, Right2);



            //Body
            GraphicsPath Body = new GraphicsPath();

            // Додаємо елементи до шляху
            Body.AddBezier(x + dx * 10, y + dy * 51,
                           x + dx * 14, y + dy * 52.3f,
                           x + dx * 17, y + dy * 53,
                           x + dx * 19.4f, y + dy * 53.6f);

            Body.AddLine(x + dx * 19.4f, y + dy * 53.6f,
                         x + dx * 19.3f, y + dy * 54.9f);

            Body.AddBezier(x + dx * 19.3f, y + dy * 54.9f,
                           x + dx * 17, y + dy * 56f,
                           x + dx * 13, y + dy * 55,
                           x + dx * 10f, y + dy * 52f);

            Body.AddLine(x + dx * 10f, y + dy * 52f,
                         x + dx * 10, y + dy * 51);

            // Заповнюємо фігуру
            g.FillPath(brush, Body);
            g.DrawBezier(Someone, x + dx * 12.5f, y + dy * 52.4f, x + dx * 14f, y + dy * 53.2f, x + dx * 16, y + dy * 53.6f, x + dx * 17.5f, y + dy * 53.9f);

            g.FillEllipse(new SolidBrush(Color.Black), x + dx * 13.7f, y + dy * 42f, dx * 7, dy * 7);
            g.DrawEllipse(pen, x + dx * 12.7f, y + dy * 41f, dx * 9, dy * 9);
            //Line
            g.DrawLine(pen, x + dx * 16.8f, y + dy * 38.2f, x + dx * 21f, y + dy * 39f);
            g.DrawLine(pen, x + dx * 17.3f, y + dy * 36.2f, x + dx * 21.5f, y + dy * 37f);
            g.DrawLine(pen, x + dx * 17.95f, y + dy * 34.2f, x + dx * 22f, y + dy * 35f);
            g.DrawLine(pen, x + dx * 18.55f, y + dy * 32.2f, x + dx * 22.4f, y + dy * 33f);
            g.DrawLine(pen, x + dx * 19.15f, y + dy * 30.2f, x + dx * 22.8f, y + dy * 31f);
            g.DrawLine(pen, x + dx * 19.75f, y + dy * 28.2f, x + dx * 23.3f, y + dy * 29f);
            g.DrawLine(pen, x + dx * 20.35f, y + dy * 26.2f, x + dx * 23.8f, y + dy * 27f);
            g.DrawLine(pen, x + dx * 20.95f, y + dy * 24.2f, x + dx * 24.3f, y + dy * 25f);
            g.DrawLine(pen, x + dx * 21.50f, y + dy * 22.2f, x + dx * 24.8f, y + dy * 23f);
            g.DrawLine(pen, x + dx * 22.10f, y + dy * 20.2f, x + dx * 25.3f, y + dy * 21f);
            g.DrawLine(pen, x + dx * 22.6f, y + dy * 18.2f, x + dx * 25.75f, y + dy * 19f);
            g.DrawLine(pen, x + dx * 23.25f, y + dy * 16.2f, x + dx * 26.2f, y + dy * 17f);
            g.DrawLine(pen, x + dx * 23.80f, y + dy * 14.2f, x + dx * 26.7f, y + dy * 15f);
            g.DrawLine(pen, x + dx * 24.35f, y + dy * 12.2f, x + dx * 27.10f, y + dy * 13f);

        }
        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y -= 10;
            GitarFull();
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y += 10;
            GitarFull();

        }

        private void leftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            x -= 10;
            GitarFull();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x += 10;
            GitarFull();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            w *= 2;
            h *= 2;
            GitarFull();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            w /= 2;
            h /= 2;
            GitarFull();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Інтервал 500 мс
            timer.Tick += new EventHandler(F);
            timer.Start();


        }
        public void F(object sender, EventArgs e)
        {
            float dx = w / 33.0f;
            float dy = h / 69.0f;
            switch (S)
            {
                case 1:
                    Gitar();
                    g.DrawBezier(Strun, x + dx * 25.3f, y + dy * 9.8f, x + dx * 21f, y + dy * 24, x + dx * 17f, y + dy * 34, x + dx * 13.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 25.7f, y + dy * 9.8f, x + dx * 14f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.1f, y + dy * 9.8f, x + dx * 14.7f, y + dy * 53);

                    g.DrawLine(Strun, x + dx * 26.5f, y + dy * 9.9f, x + dx * 15.4f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.9f, y + dy * 9.95f, x + dx * 16.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 27.3f, y + dy * 10.2f, x + dx * 17f, y + dy * 53);

                    break;
                case 2:
                    GitarFull();

                    break;
                case 3:
                    S = 0;
                    timer.Stop();
                    break;

            }
            S++;

        }

        private void siToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Інтервал 500 мс
            timer.Tick += new EventHandler(Si);
            timer.Start();
        }
        public void Si(object sender, EventArgs e)
        {
            float dx = w / 33.0f;
            float dy = h / 69.0f;
            switch (S)
            {
                case 1:
                    Gitar();
                    g.DrawLine(Strun, x + dx * 25.3f, y + dy * 9.8f, x + dx * 13.2f, y + dy * 53);
                    g.DrawBezier(Strun, x + dx * 25.7f, y + dy * 9.8f, x + dx * 21.4f, y + dy * 24, x + dx * 17.4f, y + dy * 34, x + dx * 14f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.1f, y + dy * 9.8f, x + dx * 14.7f, y + dy * 53);

                    g.DrawLine(Strun, x + dx * 26.5f, y + dy * 9.9f, x + dx * 15.4f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.9f, y + dy * 9.95f, x + dx * 16.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 27.3f, y + dy * 10.2f, x + dx * 17f, y + dy * 53);


                    break;
                case 2:
                    GitarFull();

                    break;
                case 3:
                    S = 0;
                    timer.Stop();
                    break;

            }
            S++;

        }
        public void Sol(object sender, EventArgs e)
        {
            float dx = w / 33.0f;
            float dy = h / 69.0f;
            switch (S)
            {
                case 1:
                    Gitar();
                    g.DrawLine(Strun, x + dx * 25.3f, y + dy * 9.8f, x + dx * 13.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 25.7f, y + dy * 9.8f, x + dx * 14f, y + dy * 53);
                    g.DrawBezier(Strun, x + dx * 26.1f, y + dy * 9.8f, x + dx * 21.8f, y + dy * 24, x + dx * 17.8f, y + dy * 34, x + dx * 14.7f, y + dy * 53);

                    g.DrawLine(Strun, x + dx * 26.5f, y + dy * 9.9f, x + dx * 15.4f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.9f, y + dy * 9.95f, x + dx * 16.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 27.3f, y + dy * 10.2f, x + dx * 17f, y + dy * 53);


                    break;
                case 2:
                    GitarFull();

                    break;
                case 3:
                    S = 0;
                    timer.Stop();
                    break;

            }
            S++;

        }

        private void solToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Інтервал 500 мс
            timer.Tick += new EventHandler(Sol);
            timer.Start();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Інтервал 500 мс
            timer.Tick += new EventHandler(Re);
            timer.Start();
        }
        public void Re(object sender, EventArgs e)
        {
            float dx = w / 33.0f;
            float dy = h / 69.0f;
            switch (S)
            {
                case 1:
                    Gitar();
                    g.DrawLine(Strun, x + dx * 25.3f, y + dy * 9.8f, x + dx * 13.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 25.7f, y + dy * 9.8f, x + dx * 14f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.1f, y + dy * 9.8f, x + dx * 14.7f, y + dy * 53);

                    g.DrawBezier(Strun, x + dx * 26.5f, y + dy * 9.9f, x + dx * 22.2f, y + dy * 24, x + dx * 18.2f, y + dy * 34, x + dx * 15.4f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.9f, y + dy * 9.95f, x + dx * 16.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 27.3f, y + dy * 10.2f, x + dx * 17f, y + dy * 53);


                    break;
                case 2:
                    GitarFull();

                    break;
                case 3:
                    S = 0;
                    timer.Stop();
                    break;

            }
            S++;

        }

        private void laToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Інтервал 500 мс
            timer.Tick += new EventHandler(La);
            timer.Start();
        }
        public void La(object sender, EventArgs e)
        {
            float dx = w / 33.0f;
            float dy = h / 69.0f;
            switch (S)
            {
                case 1:
                    Gitar();
                    g.DrawLine(Strun, x + dx * 25.3f, y + dy * 9.8f, x + dx * 13.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 25.7f, y + dy * 9.8f, x + dx * 14f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.1f, y + dy * 9.8f, x + dx * 14.7f, y + dy * 53);

                    g.DrawLine(Strun, x + dx * 26.5f, y + dy * 9.9f, x + dx * 15.4f, y + dy * 53);
                    g.DrawBezier(Strun, x + dx * 26.9f, y + dy * 9.95f, x + dx * 22.6f, y + dy * 24, x + dx * 18.6f, y + dy * 34, x + dx * 16.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 27.3f, y + dy * 10.2f, x + dx * 17f, y + dy * 53);


                    break;
                case 2:
                    GitarFull();

                    break;
                case 3:
                    S = 0;
                    timer.Stop();
                    break;

            }
            S++;

        }

        private void miToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Інтервал 500 мс
            timer.Tick += new EventHandler(Mi);
            timer.Start();
        }
        public void Mi(object sender, EventArgs e)
        {
            float dx = w / 33.0f;
            float dy = h / 69.0f;
            switch (S)
            {
                case 1:
                    Gitar();
                    g.DrawLine(Strun, x + dx * 25.3f, y + dy * 9.8f, x + dx * 13.2f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 25.7f, y + dy * 9.8f, x + dx * 14f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.1f, y + dy * 9.8f, x + dx * 14.7f, y + dy * 53);

                    g.DrawLine(Strun, x + dx * 26.5f, y + dy * 9.9f, x + dx * 15.4f, y + dy * 53);
                    g.DrawLine(Strun, x + dx * 26.9f, y + dy * 9.95f, x + dx * 16.2f, y + dy * 53);
                    g.DrawBezier(Strun, x + dx * 27.3f, y + dy * 10.2f, x + dx * 23f, y + dy * 24, x + dx * 19f, y + dy * 34, x + dx * 17f, y + dy * 53);


                    break;
                case 2:
                    GitarFull();

                    break;
                case 3:
                    S = 0;
                    timer.Stop();
                    break;

            }
            S++;

        }
    }

}


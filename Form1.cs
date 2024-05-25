using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsForms_GDI3
{
    public partial class Game : Form
    {
        private bool isJumping = false;
        private int jumpHeight = 120; // Висота стрибка
        private int jumpSpeed = 40;   // Швидкість стрибка
        private int gravity = 30;     // Гравітація

        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap background = new Bitmap("E:\\Programs\\Microsoft Visual Studio\\Проекты\\WindowsForms_GDI3\\Images\\background.png");
            e.Graphics.DrawImage(background, new Rectangle(0, 0, 1100, 600));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap knight = new Bitmap("E:\\Programs\\Microsoft Visual Studio\\Проекты\\WindowsForms_GDI3\\Images\\Knight sprites.png");
            e.Graphics.DrawImage(knight, new Rectangle(0, 0, 2500, 1400));
        }

        private void pictureBoxSkeleton_Paint(object sender, PaintEventArgs e)
        {
            Bitmap knight = new Bitmap("E:\\Programs\\Microsoft Visual Studio\\Проекты\\WindowsForms_GDI3\\Images\\Skeleton sprites.png");
            e.Graphics.DrawImage(knight, new Rectangle(-2300, 0, 2500, 1400));
        }



        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            int step = 10;
            if (e.KeyCode == Keys.Right)
            {
                pictureBoxKnight.Invoke(new Action(() => pictureBoxKnight.Left += step));
            }
            if (e.KeyCode == Keys.Left)
            {
                pictureBoxKnight.Invoke(new Action(() => pictureBoxKnight.Left -= step));
            }
            if (e.KeyCode == Keys.Up && !isJumping)
            {
                isJumping = true;
                new Thread(Jump).Start();
            }
        }

        private void Jump()
        {
            int originalY = pictureBoxKnight.Bottom;

            while (pictureBoxKnight.Bottom > originalY - jumpHeight)
            {
                pictureBoxKnight.Invoke(new Action(() => pictureBoxKnight.Top -= jumpSpeed));
                Thread.Sleep(50);
            }

            while (pictureBoxKnight.Bottom < originalY)
            {
                pictureBoxKnight.Invoke(new Action(() => pictureBoxKnight.Top += gravity));
                Thread.Sleep(50);
            }

            isJumping = false;
        }
    }
}
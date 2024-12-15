using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace IceRink
{
    public partial class Form1 : Form
    {
        private List<Tree> trees = new List<Tree>();
        private List<Snowflake> snowflakes = new List<Snowflake>();
        private List<Cloud> clouds = new List<Cloud>();
        private List<House> houses = new List<House>();
        private Timer timer;
        private Random rand = new Random();
        private Rink rink;
        private List<Character> snowman = new List<Character>();
        private List<Character> character = new List<Character>();
        private Image imgCh1 = Properties.Resources.CharacterI;
        private Image imgCh2 = Properties.Resources.CharacterII;
        private Image imgCh3 = Properties.Resources.CharacterIII;
        private Image imgSnowman = Properties.Resources.snowman;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.Size = new Size(700, 700);
            BackColor = Color.LightSlateGray;
            this.Paint += new PaintEventHandler(this.OnPaint);
            CreateObjects();

            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void CreateSnowflakes()
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                snowflakes.Add(new Snowflake(
                    random.Next(ClientSize.Width),
                    random.Next(ClientSize.Height),
                    Color.White,
                    random.Next(5, 20),
                    random.Next(1, 5)
                ));
            }
        }
        private void AddCharacter()
        {
            character.Add(new Character(100, 400, 100, 3, imgCh1));
            character.Add(new Character(400, 500, 120, 3, imgCh2));
            character.Add(new Character(200, 600, 150, 3, imgCh3));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Snowflake snowflake in snowflakes)
            {
                snowflake.Y += snowflake.Step;

                if (snowflake.Y > ClientSize.Height)
                {
                    snowflake.Y = -snowflake.Size;
                    snowflake.X = rand.Next(ClientSize.Width);
                }
            }
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DrawScene(e.Graphics);
        }

        private void DrawScene(Graphics g)
        {

            foreach (House house in houses)
            {
                house.Draw(g);
            }

            foreach (Tree tree in trees)
            {
                tree.Draw(g);
            }

            rink.Draw(g);

            foreach (var item in character)
            {
                item.Draw(g);
                item.Move(Width);
            }

            foreach (Character snowman in snowman)
            {
                snowman.Draw(g);
            }

            foreach (Snowflake snowflake in snowflakes)
            {
                snowflake.Draw(g);
            }

            foreach (Cloud cloud in clouds)
            {
                cloud.Draw(g);
            }
        }

        private void CreateObjects()
        {
            AddCharacter();
            CreateSnowflakes();
            CreateHouses();
            CreateClouds();
            rink = new Rink(0, 300, Color.CadetBlue, ClientSize.Width, 0);
            CreateSnowman();
            CreateTrees();
        }

        private void CreateTrees()
        {
            int x = 50;
            for (int i = 0; i < 8; i++)
            {
                trees.Add(new Tree(
                   x,
                   350,
                   Color.White,
                   rand.Next(70, 105),
                   rand.Next(1, 5)
               ));
                x += 80;
            }
        }

        private void CreateSnowman()
        {
            snowman.Add(new Character(100, 100, 100, 0, imgSnowman));
            snowman.Add(new Character(500, 100, 100, 0, imgSnowman));
            snowman.Add(new Character(290, 100, 100, 0, imgSnowman));
        }

        private void CreateClouds()
        {
            clouds.Add(new Cloud(50, 50, Color.LightGray, 100, 5));
            clouds.Add(new Cloud(250, 50, Color.LightGray, 80, 5));
            clouds.Add(new Cloud(450, 50, Color.LightGray, 100, 5));
        }

        private void CreateHouses()
        {
            houses.Add(new House(500, 300, Color.Red, 150, 4, 4));
            houses.Add(new House(350, 300, Color.Red, 150, 2, 4));
            houses.Add(new House(200, 300, Color.Red, 150, 3, 4));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                string extension = Path.GetExtension(saveFileDialog.FileName).ToLowerInvariant();

                Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
                Graphics g = Graphics.FromImage(bmp);

                g.FillRectangle(Brushes.White, 0, 0, Width, Height);

                DrawScene(g);

                switch (extension)
                {
                    case ".jpg":
                        bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;

                    case ".bmp":
                        bmp.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                        break;

                    default:
                        bmp.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                }
            }
        }
    }
}

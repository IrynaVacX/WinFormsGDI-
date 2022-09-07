﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace HW_02_Maze
{
    class Labirint
    {
        public int smileX = 0;
        public int smileY = 2;

        public int height;
        public int width;

        public MazeObject[,] maze;
        public PictureBox[,] images;

        public static Random r = new Random();
        public Form parent;

        public Labirint(Form parent, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.parent = parent;

            maze = new MazeObject[height, width];
            images = new PictureBox[height, width];

            // наш персонажик
            int x = 0, y = 2;
            maze[y, x] = new MazeObject(MazeObject.MazeObjectType.CHAR);
            images[y, x] = new PictureBox();
            images[y, x].Location = new Point(x * maze[y, x].width, y * maze[y, x].height);
            images[y, x].Parent = parent;
            images[y, x].Width = maze[y, x].width;
            images[y, x].Height = maze[y, x].height;
            images[y, x].BackgroundImage = maze[y, x].texture;
            images[y, x].Visible = false;

            Generate();
        }

        private void Generate()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    MazeObject.MazeObjectType current = MazeObject.MazeObjectType.HALL;

                    // в 1 случае из 5 - ставим стену
                    if (r.Next(5) == 0)
                        current = MazeObject.MazeObjectType.WALL;

                    // в 1 случае из 250 - кладём денежку
                    if (r.Next(250) == 0)
                        current = MazeObject.MazeObjectType.MEDAL;

                    // в 1 случае из 250 - размещаем врага
                    if (r.Next(250) == 0)
                        current = MazeObject.MazeObjectType.ENEMY;

                    // стены по периметру обязательны
                    if (y == 0 || x == 0 || y == height - 1 | x == width - 1)
                        current = MazeObject.MazeObjectType.WALL;

                    // наш персонажик
                    if (x == smileX && y == smileY)
                        continue;

                    // есть выход, и соседняя ячейка справа всегда свободна
                    if (x == smileX + 1 && y == smileY || x == width - 1 && y == height - 3)
                        current = MazeObject.MazeObjectType.HALL;

                    maze[y, x] = new MazeObject(current);
                    images[y, x] = new PictureBox();
                    images[y, x].Location = new Point(x * maze[y, x].width, y * maze[y, x].height);
                    images[y, x].Parent = parent;
                    images[y, x].Width = maze[y, x].width;
                    images[y, x].Height = maze[y, x].height;
                    images[y, x].BackgroundImage = maze[y, x].texture;
                    images[y, x].Visible = false;
                }
            }
        }

        public void Show()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    images[y, x].Visible = true;
        }
    }
}

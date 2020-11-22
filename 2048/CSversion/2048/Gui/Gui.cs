using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class Gui : Form
    {
        private Map map;

        public Gui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Map();
            // 将map类数据显示到图形化界面上
            DisplayMap(map.GetMap(), map.TopPoints(), map.Points());
        }

        private void DisplayMap(int[,] map, int topPoints, int points)
        {
            // 在best label上显示topPoints
            best.Text = topPoints.ToString();
            // 在score上显示points
            score.Text = points.ToString();
            // 循环将不为0的tile设置为可见并显示数字
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    string str = $"tile{row}{col}";
                    if (map[row, col] != 0)
                    {
                        foreach (Control ctol in panel3.Controls)
                        {
                            if (ctol is Label && ctol.Name == str)
                            {
                                int num = map[row, col];
                                ctol.Visible = true;
                                ctol.Text = num.ToString();
                                if (num == 2 || num == 8 || num == 32)
                                {
                                    ctol.ForeColor = Color.Beige;
                                }
                                else if (num == 4 || num == 16 || num == 64)
                                {
                                    ctol.ForeColor = Color.Bisque;
                                }
                                else if (num == 128 || num == 512)
                                {
                                    ctol.ForeColor = Color.BlanchedAlmond;
                                }
                                else if (num == 256 || num == 1028)
                                {
                                    ctol.ForeColor = Color.BlueViolet;
                                }
                                else
                                {
                                    ctol.ForeColor = Color.Chocolate;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (Control ctol in panel3.Controls)
                        {
                            if (ctol is Label && ctol.Name == str)
                            {
                                ctol.Visible = false;
                                ctol.Text = "0";
                            }
                        }
                    }
                }
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "HOW TO PLAY: Use your arrow keys to move the tiles. When two tiles with the same number touch, they merge into one!\n" +
                "使用键盘方向键移动方块，当两个有着同样数字的方块碰到一起时，合并为一块。",
                "Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Gui_KeyDown(object sender, KeyEventArgs e)
        {
            // 获取键盘输入并更新数据
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                map.UpMap();
                UpdateMap(ref map);
                DisplayMap(map.GetMap(), map.TopPoints(), map.Points());
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                map.DownMap();
	            UpdateMap(ref map);
                DisplayMap(map.GetMap(), map.TopPoints(), map.Points());
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                map.RightMap();
                UpdateMap(ref map);
                DisplayMap(map.GetMap(), map.TopPoints(), map.Points());
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                map.LeftMap();
                UpdateMap(ref map);
                DisplayMap(map.GetMap(), map.TopPoints(), map.Points());
            }
        }

        private void UpdateMap(ref Map map)
        {
            // 在任意随机位置添加随机数字，如果没有空位置，失败退出
            if (!map.ShuffleMap())
            {
                MessageBox.Show("End", "Sorry, you failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NewGame();
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            // 将记录重写
            map.SetTopPoints();
            map = new Map();
            DisplayMap(map.GetMap(), map.TopPoints(), map.Points());
        }

        private void label_2048_Click(object sender, EventArgs e)
        {

        }
    }
}

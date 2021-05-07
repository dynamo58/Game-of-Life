using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.IO;

namespace gameOfLife
{
    public partial class main : MaterialForm
    {
        Vars vars = new Vars()
        {
            cellNum = 20,
            cellState = new bool[20, 20],
            surviveConds = new int[] { 2, 3 },
            bornConds = new int[] { 3 }
        };

        public main()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Grey900, Primary.Grey500, Accent.Orange400, TextShade.WHITE);

            this.Load += new EventHandler(updateSizeTrackerLabel);
            this.Load += new EventHandler(updateEnvironment);

            changeEnvBtn.Click += new EventHandler(updateEnvironment);
            sizeTracker.ValueChanged += new EventHandler(updateSizeTrackerLabel);
            panel1.Click += new EventHandler(changeCellStateHandler);
        }

        private void sendConfig()
        {
            string parsedJSON = JsonConvert.SerializeObject(vars);
            File.WriteAllText(@"config.json", parsedJSON);
        }

        int getNeighborCount(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (x + i >= 0 && x + i < vars.cellNum && y + j >= 0 && y + j < vars.cellNum)
                    {
                        if (vars.cellState[x + i, y + j] == true)
                        {
                            count++;
                        }
                    }
                }
            }

            if (vars.cellState[x, y] == true)
            {
                count--;
            }

            //Console.WriteLine(x.ToString() + "," + y.ToString() + " -- " + count);

            return count;
        }

        private void newGeneration()
        {
            bool[,] newCellState = new bool[vars.cellNum, vars.cellNum];

            for (int i = 0; i < vars.cellNum; i++)
            {
                for (int j = 0; j < vars.cellNum; j++)
                {
                    int nCount = getNeighborCount(i, j);

                    if (vars.cellState[i, j] == true)
                    {
                        newCellState[i, j] = (nCount == 2 || nCount == 3) ? true : false;
                    }
                    else
                    {
                        newCellState[i, j] = (nCount == 3) ? true : false;
                    }
                }
            }

            vars.cellState = newCellState;

            panel1.Refresh();
        }

        private void changeCellStateHandler(object sender, EventArgs e)
        {
            var coords = panel1.PointToClient(Cursor.Position);

            int[] cellCoords = {
                (int)Math.Floor(((coords.X) / (double)((panel1.Width - 2) / vars.cellNum))),
                (int)Math.Floor(((coords.Y) / (double)((panel1.Width - 2) / vars.cellNum)))
            };

            vars.cellState[cellCoords[0], cellCoords[1]] = (vars.cellState[cellCoords[0], cellCoords[1]]) ? false : true;
            panel1.Refresh();
        }

        private void updateEnvironment(object sender, EventArgs e)
        {
            vars.cellNum = sizeTracker.Value * 5;

            if (panel1.Width % vars.cellNum != 0)
            {
                panel1.Width = 500;

                while (panel1.Width % vars.cellNum != 0)
                {
                    panel1.Width++;
                }
            }

            panel1.Width += 2;
            panel1.Height = panel1.Width;

            bool[,] tempState = vars.cellState;
            vars.cellState = new bool[vars.cellNum, vars.cellNum];

            for (int i = 0; i < vars.cellNum; i++)
            {
                for (int j = 0; j < vars.cellNum; j++)
                {
                    try
                    {
                        if (tempState[i, j] == true)
                        {
                            vars.cellState[i, j] = true;
                        }
                    }
                    catch
                    {
                        vars.cellState[i, j] = false;
                    }
                }
            }

            if (autoGenerationTimer.Enabled == true)
            {
                autoGenerationButton_Click(autoGenerationButton, e);
            }


            // fetch survive :: be born conditions
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //

            panel1.Refresh();
        }

        private void updateSizeTrackerLabel(object sender, EventArgs e)
        {
            sizeTrackerLabel.Text = (sizeTracker.Value * 5).ToString();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            int width = (panel1.Width - 2) / vars.cellNum;


            for (int i = 0; i < vars.cellNum; i++)
            {
                for (int j = 0; j < vars.cellNum; j++)
                {
                    if (vars.cellState[i, j])
                    {
                        canvas.FillRectangle(Brushes.Orange, width * i, width * j, width, width);
                    }
                }
            }
        }

        private void newGenButton_Click(object sender, EventArgs e)
        {
            newGeneration();
        }

        private void autoGenerationTimer_Tick(object sender, EventArgs e)
        {
            newGeneration();
        }

        private void autoGenerationButton_Click(object sender, EventArgs e)
        {
            autoGenerationTimer.Enabled = (autoGenerationTimer.Enabled) ? false : true;
            autoGenerationButton.Text = (autoGenerationButton.Text == "Auto generation [OFF]") ?
                autoGenerationButton.Text = "Auto generation [ON]" :
                autoGenerationButton.Text = "Auto generation [OFF]";
        }


        Random rd = new Random();
        private void randomizeCellsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vars.cellNum; i++)
            {
                for (int j = 0; j < vars.cellNum; j++)
                {
                    int rand = rd.Next(3);
                    if (rand == 0) vars.cellState[i, j] = true;
                    else vars.cellState[i, j] = false;
                }
            }
            panel1.Refresh();
        }

        private void fastModeButton_CheckedChanged(object sender, EventArgs e)
        {
            autoGenerationTimer.Interval = (fastModeButton.Checked) ? 10 : 50;
        }
    }
}

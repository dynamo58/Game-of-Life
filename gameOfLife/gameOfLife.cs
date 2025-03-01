﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.IO;
using AnimatedGif;


//
//           Autor:  Marek Smolík
//           Popis:  implementace Hry života (Game of Life)
//           Datum:  9.5.2021
//  Použité balíky:  MateralSkin        (https://www.nuget.org/packages/MaterialSkin.2/2.1.3)
//                   Newtonsoft.Json    (https://www.nuget.org/packages/Newtonsoft.Json/)
//                   AnimatedGIF        (https://www.nuget.org/packages/AnimatedGif/)
//


namespace gameOfLife
{
    public partial class main : MaterialForm
    {
        readonly string configFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\gameOfLife";
        readonly string tempFilePath = Path.GetTempPath() + "\\gameOfLife_tempfiles";
        bool recording = false;
        int tempImgs = 0;

        // vytvoří instanci třídy Vars s výchozím nastavením
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
            getConfig();

            CheckForIllegalCrossThreadCalls = false;
            sizeTracker.Value = vars.cellNum / 5;
            customRulesSTextBox.Text = string.Join("", vars.surviveConds);
            customRulesBTextBox.Text = string.Join("", vars.bornConds);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Grey900, Primary.Grey500, Accent.Orange400, TextShade.WHITE);

            this.Load += new EventHandler(updateSizeTrackerLabel);
            this.Load += new EventHandler(updateEnvironment);

            sizeTracker.ValueChanged += new EventHandler(updateSizeTrackerLabel);
            changeEnvBtn.Click += new EventHandler(updateEnvironment);
            panel1.Click += new EventHandler(changeCellState);
        }

        // uloží současnou var instanci do config souboru
        private void sendConfig()
        {
            string currentConfig = JsonConvert.SerializeObject(vars);
            File.WriteAllText(configFilePath + "\\config.json", currentConfig);

            Console.WriteLine("Sent current config to config file.");
        }

        // získá config z config souboru
        private void getConfig()
        {
            if (!File.Exists(configFilePath))
                Directory.CreateDirectory(configFilePath);

            if (File.Exists(configFilePath + "\\config.json"))
            {
                string savedConfig = File.ReadAllText(configFilePath + "\\config.json");
                vars = JsonConvert.DeserializeObject<Vars>(savedConfig);
            }
        }

        // sečte počet sousedních buněk kolem spec. buňky
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

            return count;
        }

        // vytvoří novou generaci buňek
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
                        newCellState[i, j] = vars.surviveConds.Contains(nCount);
                    }
                    else
                    {
                        newCellState[i, j] = vars.bornConds.Contains(nCount);
                    }
                }
            }

            vars.cellState = newCellState;

            panel1.Refresh();

            if (recording)
            {
                savePanelAsPNG();
            }
        }

        // změní stav buňky, když je na buňku kliknuto
        private void changeCellState(object sender, EventArgs e)
        {
            var coords = panel1.PointToClient(Cursor.Position);

            int[] cellCoords = {
                (int)Math.Floor(((coords.X) / (double)((panel1.Width - 2) / vars.cellNum))),
                (int)Math.Floor(((coords.Y) / (double)((panel1.Width - 2) / vars.cellNum)))
            };

            vars.cellState[cellCoords[0], cellCoords[1]] = !vars.cellState[cellCoords[0], cellCoords[1]];
            panel1.Refresh();
        }

        // aktualizuje konfiguraci prostředí
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

            int[] currentSurvConds = vars.surviveConds;
            int[] currentBornConds = vars.bornConds;

            char[] surv = customRulesSTextBox.Text.ToCharArray();
            char[] born = customRulesBTextBox.Text.ToCharArray();

            vars.surviveConds = Array.ConvertAll(surv, num => (int)Char.GetNumericValue(num));
            vars.bornConds = Array.ConvertAll(born, num => (int)Char.GetNumericValue(num));

            if (vars.surviveConds.Contains(-1) || vars.bornConds.Contains(-1))
            {
                vars.surviveConds = currentSurvConds;
                vars.bornConds = currentBornConds;

                customRulesSTextBox.Text = string.Join("", vars.surviveConds);
                customRulesBTextBox.Text = string.Join("", vars.bornConds);

                MessageBox.Show("Zadejte numerické podmínky; předešlé nastavení bylo obnoveno.");
            }

            sendConfig();

            panel1.Refresh();
        }

        // aktualizuje identifikátor nastavené velikosti
        private void updateSizeTrackerLabel(object sender, EventArgs e)
        {
            sizeTrackerLabel.Text = (sizeTracker.Value * 5).ToString();
        }

        // ---
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

        // ---
        private void newGenButton_Click(object sender, EventArgs e)
        {
            newGeneration();
        }


        // ---
        private void autoGenerationTimer_Tick(object sender, EventArgs e)
        {
            newGeneration();
        }


        // bude automaticky vytvářet nové generace
        private void autoGenerationButton_Click(object sender, EventArgs e)
        {
            autoGenerationTimer.Enabled = !autoGenerationTimer.Enabled;
            autoGenerationButton.Text = (autoGenerationButton.Text == "Automatická generace [OFF]") ?
                autoGenerationButton.Text = "Automatická generace [ON]" :
                autoGenerationButton.Text = "Automatická generace [OFF]";
        }

        // náhodně oživotní / zabije buňky
        readonly Random rd = new Random();
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

        // zrychlí (popř. zpomalí) rychlost automatické generace
        private void fastModeButton_CheckedChanged(object sender, EventArgs e)
        {
            autoGenerationTimer.Interval = (fastModeButton.Checked) ? 10 : 50;
        }


        // uloží konfiguraci do configu
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            sendConfig();
            if (recording)
            {
                deleteTempFiles();
            }
        }


        // smaže všechny buňky
        private void killCellsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vars.cellNum; i++)
            {
                for (int j = 0; j < vars.cellNum; j++)
                {
                    vars.cellState[i, j] = false;
                }
            }

            panel1.Refresh();
        }


        // uloží panel jako *.png temp. soubor
        private void savePanelAsPNG()
        {
            Thread thread = new Thread(t =>
            {
                tempImgs++;

                if (!Directory.Exists(tempFilePath))
                {
                    Directory.CreateDirectory(tempFilePath);
                }

                int width = panel1.Size.Width;
                int height = panel1.Size.Height;

                Bitmap bm = new Bitmap(width, height);
                panel1.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
                bm.Save(tempFilePath + "\\temp" + tempImgs.ToString() + ".png", ImageFormat.Png);
            })
            { IsBackground = true };
            thread.Start();
        }

        // vytvoří z temp obrázku *.gif (a následně je smaže)
        private void compileTempImages()
        {
            var img = Image.FromFile(tempFilePath +"\\temp1.png");
            using (var gif = AnimatedGif.AnimatedGif.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\gameOfLife" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".gif", 100))
            {
                for (int i = 1; i <= tempImgs; i++)
                {
                    img = Image.FromFile(tempFilePath + "\\temp" + i.ToString() + ".png");
                    gif.AddFrame(img, delay: -1, quality: GifQuality.Bit8);
                }
            }

            tempImgs = 0;
            deleteTempFiles();
        }


        // smaže temp. obrázky
        private void deleteTempFiles()
        {
            string[] tempImages = Directory.GetFiles(tempFilePath + "\\", "temp*");

            foreach (string image in tempImages)
            {
                File.Delete(image);
            }
        }


        // ---
        private void recordingButton_Click(object sender, EventArgs e)
        {
            recording = !recording;
            recordingButton.Text = recording ? "Nahrávání [ON]" : "Nahrávání [OFF]"; 

            if (recording)
            {
                savePanelAsPNG();
            }
            else
            {
                if (autoGenerationTimer.Enabled == true)
                {
                    autoGenerationButton_Click(autoGenerationButton, e);
                }

                compileTempImages();
            }
        }
    }
}
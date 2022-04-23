namespace Vizualizacija_algoritama_za_sortiranje
{
    public partial class Form1 : Form
    {
        Label[] array;
        int[] niz = { 4, 2, 20, 4, 10, 6 };
        int i1=0, i2=5, x1=100, x2=100+50*5;
        int ib, jb;
        int g;
        int trenutni;
        int smjerOtvaranjaPanela = 1;
        int indexMin = 0, smjer = 0;
        bool pauzirano = true;
        System.Windows.Forms.Timer trenutniTimer;
        System.Windows.Forms.Timer proba;
        Button ButtonTrenutni;


        private void ButtonBubbleSort_Click(object sender, EventArgs e)
        {
            ib = 0;
            jb = 0;

            pauzirano = true;
            trenutniTimer.Stop();
            buttonKontrola.Text = "Pokreni";

            //timerBubbleSort.Enabled = true;
            ButtonTrenutni.Enabled = true;
            ButtonTrenutni = ButtonBubbleSort;
            ButtonTrenutni.Enabled = false;
            trenutniTimer = timerBubbleSort;
            //MessageBox.Show("ukljucen timer");
        }

        private void ButtonSelectionSort_Click(object sender, EventArgs e)
        {
            ib = 0;
            jb = 1;

            pauzirano = true;
            trenutniTimer.Stop();
            buttonKontrola.Text = "Pokreni";

            //timerSelectionSort.Enabled = true;
            ButtonTrenutni.Enabled = true;
            ButtonTrenutni = ButtonSelectionSort;
            ButtonTrenutni.Enabled = false;
            trenutniTimer = timerSelectionSort;
        }

        private void ButtonInsertionSort_Click(object sender, EventArgs e)
        {
            ib = 0;
            jb = 1;

            pauzirano = true;
            trenutniTimer.Stop();
            buttonKontrola.Text = "Pokreni";

            //timerInsertionSort.Enabled = true;
            ButtonTrenutni.Enabled = true;
            ButtonTrenutni = ButtonInsertionSort;
            ButtonTrenutni.Enabled = false;
            trenutniTimer = timerInsertionSort;
        }
        private void ButtonShellSort_Click(object sender, EventArgs e)
        {
            g = array.Length / 2;
            ib = g;
            jb = ib;

            pauzirano = true;
            trenutniTimer.Stop();
            buttonKontrola.Text = "Pokreni";

            //timerShellSort.Enabled = true;
            ButtonTrenutni.Enabled = true;
            ButtonTrenutni = ButtonShellSort;
            ButtonTrenutni.Enabled = false;
            trenutniTimer = timerShellSort;
        }

        private void timerBubbleSort_Tick(object sender, EventArgs e)
        {
            if (ib < array.Length - 1)
            {
                label1.Text = "usao u ib= " + ib + ", jb= " + jb;
                /*if (array[ib].BackColor != Color.Yellow)
                {
                    array[ib].BackColor = Color.Yellow;

                    label1.Text = "spavanje";
                    label1.Text = "usao u ib= " + ib + ", jb= " + jb;
                    //System.Windows.Forms.Timer proba = new System.Windows.Forms.Timer();
                    proba.Interval = 1000;
                    proba.Start();
                    return;
                }*/

                //MessageBox.Show("ja jedem govna");

                if (jb < array.Length - 1 - ib)
                {
                    label1.Text = "usao u jb";
                    label2.Text = jb.ToString();
                    if (array[jb].BackColor != Color.YellowGreen)
                    {
                        array[jb].BackColor = Color.YellowGreen;
                        array[jb + 1].BackColor = Color.YellowGreen;
                        return;

                    }
                    //if(jb%2==1) MessageBox.Show("poredjenje "+jb.ToString()+" i "+(jb+1));
                    if (Convert.ToInt32(array[jb].Text) > Convert.ToInt32(array[jb + 1].Text))
                    {
                        array[jb].BackColor = Color.Green;
                        array[jb + 1].BackColor = Color.Green;

                        label1.Text = "iskljucen timer";
                        i1 = jb + 1;
                        i2 = jb;
                        x1 = array[jb + 1].Left;
                        x2 = array[jb].Left;
                        jb++;

                        timerSwap.Start();

                        timerBubbleSort.Stop();
                        return;
                    }
                    array[jb].BackColor = Color.Blue;
                    array[jb + 1].BackColor = Color.Blue;
                    jb++;

                    //MessageBox.Show(jb.ToString());

                }
                else
                {
                    array[ib].BackColor = Color.Blue;
                    ib++;
                    jb = 0;
                }

            }
            else
            {
                timerBubbleSort.Stop();
                ButtonTrenutni.Enabled = true;
                ButtonTrenutni.PerformClick();

            }
        }

        private void buttonUnesiNiz_Click(object sender, EventArgs e)
        {
            smjerOtvaranjaPanela *= -1;
            timerUnosNiza.Start();

        }

        private void timerUnosNiza_Tick(object sender, EventArgs e)
        {
            panelUnosNiza.Height += (smjerOtvaranjaPanela * 5);
            panelUnosNiza.Top += (-1 * smjerOtvaranjaPanela * 5);
            if (panelUnosNiza.Height == 100 || panelUnosNiza.Height == 0)  
            {
                timerUnosNiza.Stop();
            }
        }

        private void buttonUnesiNiz2_Click(object sender, EventArgs e)
        {
            string n = textBoxUnosNiza.Text;
            int duzinaNiza = 0;
            for (int i = 1; i < n.Length-1; i++)
            {
                if (n[i] == ',' && n[i + 1] == ',')
                {
                    n = n.Remove(i, 1);
                    i--;
                }
            }
            for (int i = 1; i < n.Length - 1; i++)
            {
                if (n[i] == ',' && n[i - 1] != ',') duzinaNiza++;
                //else while (i < n.Length - 1 && n[i] == ',' && n[i + 1] == ',') i++;
            }
            string tmp = "";
            if (duzinaNiza > 9) 
            {
                MessageBox.Show("Niz je predug!!!\nMolim Vas unesite niz sa maksimalno 10 elemenata");
                return;
            }
            int[] tmpNiz=new int[duzinaNiza+1];
            duzinaNiza=0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= '0' && n[i] <= '9' && tmp.Length<3)
                {
                    tmp += n[i];
                }
                else if (n[i] == ',' && tmp != "") 
                {
                    tmpNiz[duzinaNiza]=Convert.ToInt32(tmp);
                    duzinaNiza++;
                    tmp = "";
                }
            }
            if (tmp != "") tmpNiz[duzinaNiza] = Convert.ToInt32(tmp);
            
            niz = tmpNiz;
            
            kreirajNiz();
            buttonUnesiNiz.PerformClick();
        }

        private void timerSelectionSort_Tick(object sender, EventArgs e)
        {
            if (ib < array.Length - 1)
            {
                label1.Text = "usao u ib= " + ib + ", jb= " + jb;
                if (array[ib].BackColor != Color.Yellow)
                {
                    indexMin = ib;
                    array[ib].BackColor = Color.Yellow;

                    label1.Text = "spavanje";
                    label1.Text = "usao u ib= " + ib + ", jb= " + jb;
                    //System.Windows.Forms.Timer proba = new System.Windows.Forms.Timer();
                    return;
                }

                //MessageBox.Show("ja jedem govna");

                if (jb < array.Length)
                {
                    label1.Text = "usao u jb";
                    label2.Text = jb.ToString();
                    if (array[jb].BackColor != Color.YellowGreen)
                    {
                        array[jb].BackColor = Color.YellowGreen;
                        return;

                    }
                    //if(jb%2==1) MessageBox.Show("poredjenje "+jb.ToString()+" i "+(jb+1));
                    if (Convert.ToInt32(array[indexMin].Text) > Convert.ToInt32(array[jb].Text))
                    {
                        array[indexMin].BackColor = Color.Blue;
                        array[ib].BackColor = Color.Yellow;
                        indexMin = jb;
                        //array[ib].BackColor = Color.Green;
                        array[jb].BackColor = Color.Green;

                        /*label1.Text = "iskljucen timer";
                        i1 = jb;
                        i2 = ib;
                        x1 = array[jb].Left;
                        x2 = array[ib].Left;

                        timerSwap.Start();

                        timerSelectionSort.Stop();
                        return;*/
                    }
                    if (indexMin != jb) array[jb].BackColor = Color.Blue;
                    jb++;

                    //MessageBox.Show(jb.ToString());

                }
                else
                {
                    array[ib].BackColor = Color.Blue;
                    i1 = indexMin;
                    i2 = ib;
                    x1 = array[indexMin].Left;
                    x2 = array[ib].Left;

                    timerSwap.Start();

                    timerSelectionSort.Stop();

                    ib++;
                    jb = ib + 1;
                    return;
                }

            }
            else
            {
                timerSelectionSort.Stop();
                ButtonTrenutni.Enabled = true;
                ButtonTrenutni.PerformClick();
            }
        }

        private void buttonKreirajNasumicanNiz_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();
            string nasumicniNiz = "";
            for(int i = rnd.Next(2,7); i >= 0; i--)
            {
                nasumicniNiz += rnd.Next(250) + ",";
            }
            nasumicniNiz += rnd.Next(250);
            textBoxUnosNiza.Text = nasumicniNiz;
        }

        private void timerShellSort_Tick(object sender, EventArgs e)
        {
            if (g > 0)
            {
                if (ib < array.Length)
                {
                    label1.Text = "usao u ib= " + ib + ", jb= " + jb;

                    if (jb >= g && jb < array.Length)
                    {
                        label1.Text = "usao u jb";
                        label2.Text = jb.ToString();
                        if (array[jb].BackColor != Color.YellowGreen)
                        {
                            trenutni = jb;
                            array[jb].BackColor = Color.YellowGreen;
                            array[jb - g].BackColor = Color.YellowGreen;
                            smjer = 0;
                            proba.Interval = 100 / trackBar1.Value;
                            proba.Start();
                            timerShellSort.Stop();
                            //MessageBox.Show("POKRENUTOOOOOO");
                            return;

                        }
                        //if(jb%2==1) MessageBox.Show("poredjenje "+jb.ToString()+" i "+(jb+1));
                        if (Convert.ToInt32(array[jb].Text) < Convert.ToInt32(array[jb - g].Text))
                        {
                            array[jb].BackColor = Color.Green;
                            array[jb - g].BackColor = Color.Green;

                            label1.Text = "iskljucen timer";
                            i1 = jb;
                            i2 = jb - g;
                            x1 = array[jb].Left;
                            x2 = array[jb - g].Left;
                            jb -= g;

                            timerSwap.Start();

                            timerShellSort.Stop();
                            return;
                        }
                        else
                        {
                            trenutni = jb;
                            smjer = 1;
                            proba.Start();
                            timerShellSort.Stop();

                            array[jb].BackColor = Color.Blue;
                            array[jb - g].BackColor = Color.Blue;
                            array[ib].BackColor = Color.Blue;
                            ib++;
                            jb = ib;
                            return;
                        }
                        //array[jb].BackColor = Color.Blue;
                        //array[jb - 1].BackColor = Color.Blue;

                        //MessageBox.Show(jb.ToString());

                    }
                    else
                    {
                        trenutni = jb;
                        smjer = 1;
                        proba.Start();
                        timerShellSort.Stop();

                        array[ib].BackColor = Color.Blue;
                        ib++;
                        jb = ib;
                        return;
                    }

                }
                else
                {
                    g /= 2;
                    ib = g;
                    jb = ib;
                }
            }
            else
            {
                timerShellSort.Stop();
                ButtonTrenutni.Enabled = true;
                ButtonTrenutni.PerformClick();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int k = trackBar1.Value;
            timerBubbleSort.Interval = 1000 / k;
            timerInsertionSort.Interval = 1000 / k;
            timerSelectionSort.Interval = 1000 / k;
            timerShellSort.Interval = 1000 / k;
            timerSwap.Interval = 150 / k;
            proba.Interval = 100 / k;
        }

        private void buttonKontrola_Click(object sender, EventArgs e)
        {
            if (pauzirano)
            {
                pauzirano = false;
                trenutniTimer.Start();
                buttonKontrola.Text = "Pauziraj";
            }
            else
            {
                pauzirano = true;
                trenutniTimer.Stop();
                buttonKontrola.Text = "Pokreni";
            }

        }


        private void timerInsertionSort_Tick(object sender, EventArgs e)
        {
            if (ib < array.Length - 1)
            {
                label1.Text = "usao u ib= " + ib + ", jb= " + jb;

                if (jb > 0 && jb < array.Length)
                {
                    label1.Text = "usao u jb";
                    label2.Text = jb.ToString();
                    if (array[jb].BackColor != Color.YellowGreen)
                    {
                        trenutni = jb;
                        array[jb].BackColor = Color.YellowGreen;
                        array[jb - 1].BackColor = Color.YellowGreen;
                        smjer = 0;
                        proba.Interval = 100 / trackBar1.Value;
                        proba.Start();
                        timerInsertionSort.Stop();
                        //MessageBox.Show("POKRENUTOOOOOO");
                        return;

                    }
                    //if(jb%2==1) MessageBox.Show("poredjenje "+jb.ToString()+" i "+(jb+1));
                    if (Convert.ToInt32(array[jb].Text) < Convert.ToInt32(array[jb - 1].Text))
                    {
                        array[jb].BackColor = Color.Green;
                        array[jb - 1].BackColor = Color.Green;

                        label1.Text = "iskljucen timer";
                        i1 = jb;
                        i2 = jb - 1;
                        x1 = array[jb].Left;
                        x2 = array[jb - 1].Left;
                        jb--;

                        timerSwap.Start();

                        timerInsertionSort.Stop();
                        return;
                    }
                    else
                    {
                        trenutni = jb;
                        smjer = 1;
                        proba.Start();
                        timerInsertionSort.Stop();

                        array[jb].BackColor = Color.Blue;
                        array[jb - 1].BackColor = Color.Blue;
                        array[ib].BackColor = Color.Blue;
                        ib++;
                        jb = ib + 1;
                        return;
                    }
                    //array[jb].BackColor = Color.Blue;
                    //array[jb - 1].BackColor = Color.Blue;

                    //MessageBox.Show(jb.ToString());

                }
                else
                {
                    trenutni = jb;
                    smjer = 1;
                    proba.Start();
                    timerInsertionSort.Stop();

                    array[ib].BackColor = Color.Blue;
                    ib++;
                    jb = ib + 1;
                    return;
                }

            }
            else
            {
                timerInsertionSort.Stop();
                ButtonTrenutni.Enabled = true;
                ButtonTrenutni.PerformClick();
            }
        }

        private void proba_Tick(object sender, EventArgs e)
        {
            if (smjer == 0 && array[trenutni].Top<270)
            {
                array[trenutni].Top += 5;
            }else if(smjer == 1 && array[trenutni].Top > 180)
            {
                array[trenutni].Top -= 5;
            }
            else
            {
                if (!pauzirano) trenutniTimer.Start();
                proba.Stop();
                //MessageBox.Show(array[trenutni].Top.ToString());
            }
            
            //MessageBox.Show("PROBAAAAA");
        }
        

        public Form1()
        {
            InitializeComponent();
            kreirajNiz();

            //niz a=new niz(niz,this);
            
            this.proba = new System.Windows.Forms.Timer(this.components);
            this.proba.Tick += new System.EventHandler(this.proba_Tick);

            trenutniTimer = timerBubbleSort;
            ButtonTrenutni = ButtonBubbleSort;
        }

        private void kreirajNiz()
        {
            if (!(array is null))
            {
                for(int i=0;i<array.Length;i++)
                Controls.Remove(array[i]);
            }
            array = new Label[niz.Length];
            for (int i = 0; i < niz.Length; i++)
            {
                array[i] = new Label();
                //array[i].AutoSize = true;
                array[i].Text = niz[i].ToString();
                int d = (850-(60 * niz.Length + 20 * (niz.Length - 1)))/2;
                array[i].Location = new Point(d + 80 * i, 180);
                array[i].ForeColor = Color.White;
                array[i].BackColor = Color.Blue;
                array[i].Size = new Size(60, 60);
                array[i].TextAlign = ContentAlignment.MiddleCenter;
                array[i].Font = new Font("Arial", 20, FontStyle.Bold);

            }
            Controls.AddRange(array);
        }

        private void timerSwap_Tick(object sender, EventArgs e)
        {
            label1.Text = "ukljucen swap za " + i1 + " " + i2;
            if (array[i1].Left != x2)
            {
                array[i1].Left -= 5;
                array[i2].Left += 5;
            }
            else
            {
                Label tmp = array[i1];
                array[i1] = array[i2];
                array[i2] = tmp;
                array[i1].BackColor = Color.Blue;
                array[i2].BackColor = Color.Blue;
                if(!pauzirano) trenutniTimer.Start();
                
                timerSwap.Stop();
                
            }

        }
    }
}
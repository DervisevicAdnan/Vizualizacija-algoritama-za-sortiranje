namespace Vizualizacija_algoritama_za_sortiranje
{
    public partial class Form1 : Form
    {
        Label[] array;
        int i1=0, i2=5, x1=100, x2=100+50*5;
        int ib, jb;
        System.Windows.Forms.Timer trenutniTimer;
        System.Windows.Forms.Timer proba = new System.Windows.Forms.Timer();


        private void ButtonBubbleSort_Click(object sender, EventArgs e)
        {
            ib = 0;
            jb = 0;
            timerBubbleSort.Enabled = true;
            trenutniTimer = timerBubbleSort;
            //MessageBox.Show("ukljucen timer");
        }

        private void ButtonSelectionSort_Click(object sender, EventArgs e)
        {
            ib = 0;
            jb = 1;
            timerSelectionSort.Enabled = true;
            trenutniTimer = timerSelectionSort;
        }

        private void timerSelectionSort_Tick(object sender, EventArgs e)
        {
            if (ib < array.Length - 1)
            {
                label1.Text = "usao u ib= " + ib + ", jb= " + jb;
                if (array[ib].BackColor != Color.Yellow)
                {
                    array[ib].BackColor = Color.Yellow;

                    label1.Text = "spavanje";
                    label1.Text = "usao u ib= " + ib + ", jb= " + jb;
                    //System.Windows.Forms.Timer proba = new System.Windows.Forms.Timer();
                    proba.Interval = 1000;
                    proba.Start();
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
                        proba.Interval = 1000;
                        proba.Start();
                        return;

                    }
                    //if(jb%2==1) MessageBox.Show("poredjenje "+jb.ToString()+" i "+(jb+1));
                    if (Convert.ToInt32(array[ib].Text) > Convert.ToInt32(array[jb].Text))
                    {
                        array[ib].BackColor = Color.Green;
                        array[jb].BackColor = Color.Green;

                        label1.Text = "iskljucen timer";
                        i1 = jb;
                        i2 = ib;
                        x1 = array[jb].Left;
                        x2 = array[ib].Left;

                        timerSwap.Start();

                        timerSelectionSort.Stop();
                        return;
                    }
                    array[jb].BackColor = Color.Blue;
                    jb++;

                    //MessageBox.Show(jb.ToString());

                }
                else
                {
                    array[ib].BackColor = Color.Blue;
                    ib++;
                    jb = ib + 1;
                }

            }
            else timerSelectionSort.Stop();
        }

        private void proba_Tick(object sender, EventArgs e)
        {
            timerBubbleSort.Start();
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

                if (jb < array.Length-1-ib)
                {
                    label1.Text = "usao u jb";
                    label2.Text = jb.ToString();
                    if(array[jb].BackColor != Color.YellowGreen){
                        array[jb].BackColor = Color.YellowGreen;
                        array[jb + 1].BackColor = Color.YellowGreen;
                        proba.Interval = 1000;
                        proba.Start();
                        return;

                    }
                    //if(jb%2==1) MessageBox.Show("poredjenje "+jb.ToString()+" i "+(jb+1));
                    if (Convert.ToInt32(array[jb].Text) > Convert.ToInt32(array[jb+1].Text))
                    {
                        array[jb].BackColor = Color.Green;
                        array[jb+1].BackColor = Color.Green;

                        label1.Text = "iskljucen timer";
                        i1 = jb+1;
                        i2 = jb;
                        x1 = array[jb+1].Left;
                        x2 = array[jb].Left;
                        jb++;

                        timerSwap.Start();

                        timerBubbleSort.Stop();
                        return;
                    }
                    array[jb].BackColor = Color.Blue;
                    array[jb+1].BackColor = Color.Blue;
                    jb++;

                    //MessageBox.Show(jb.ToString());

                }
                else
                {
                    array[ib].BackColor = Color.Blue;
                    ib++;
                    jb = ib;
                }

            }
            else timerBubbleSort.Stop();
        }

        public Form1()
        {
            InitializeComponent();
            int[] aa = { 4, 2, 20, 4, 10, 6 };
            //niz a=new niz(aa,this);
            array = new Label[aa.Length];
            for (int i = 0; i < aa.Length; i++)
            {
                array[i] = new Label();
                //array[i].AutoSize = true;
                array[i].Text = aa[i].ToString();
                array[i].Location = new Point(100 + 80 * i, 200);
                array[i].ForeColor = Color.White;
                array[i].BackColor = Color.Blue;
                array[i].Size = new Size(60,60);
                array[i].TextAlign = ContentAlignment.MiddleCenter;
                array[i].Font = new Font("Arial", 20, FontStyle.Bold);

            }
            //timerSwap.Start();
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
                trenutniTimer.Start();
                
                timerSwap.Stop();
                
            }

        }
    }
}
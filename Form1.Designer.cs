namespace Vizualizacija_algoritama_za_sortiranje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonBubbleSort = new System.Windows.Forms.Button();
            this.timerSwap = new System.Windows.Forms.Timer(this.components);
            this.timerBubbleSort = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSelectionSort = new System.Windows.Forms.Button();
            this.timerSelectionSort = new System.Windows.Forms.Timer(this.components);
            this.ButtonInsertionSort = new System.Windows.Forms.Button();
            this.timerInsertionSort = new System.Windows.Forms.Timer(this.components);
            this.ButtonShellSort = new System.Windows.Forms.Button();
            this.buttonUnesiNiz = new System.Windows.Forms.Button();
            this.panelUnosNiza = new System.Windows.Forms.Panel();
            this.buttonKontrola = new System.Windows.Forms.Button();
            this.buttonKreirajNasumicanNiz = new System.Windows.Forms.Button();
            this.buttonKreirajNiz = new System.Windows.Forms.Button();
            this.textBoxUnosNiza = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timerUnosNiza = new System.Windows.Forms.Timer(this.components);
            this.timerShellSort = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelUnosNiza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Enabled = false;
            this.ButtonBubbleSort.Location = new System.Drawing.Point(97, 61);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(102, 23);
            this.ButtonBubbleSort.TabIndex = 0;
            this.ButtonBubbleSort.Text = "Bubble sort";
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            this.ButtonBubbleSort.Click += new System.EventHandler(this.ButtonBubbleSort_Click);
            // 
            // timerSwap
            // 
            this.timerSwap.Interval = 150;
            this.timerSwap.Tick += new System.EventHandler(this.timerSwap_Tick);
            // 
            // timerBubbleSort
            // 
            this.timerBubbleSort.Interval = 500;
            this.timerBubbleSort.Tick += new System.EventHandler(this.timerBubbleSort_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(614, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // ButtonSelectionSort
            // 
            this.ButtonSelectionSort.Location = new System.Drawing.Point(217, 61);
            this.ButtonSelectionSort.Name = "ButtonSelectionSort";
            this.ButtonSelectionSort.Size = new System.Drawing.Size(105, 23);
            this.ButtonSelectionSort.TabIndex = 3;
            this.ButtonSelectionSort.Text = "Selection sort";
            this.ButtonSelectionSort.UseVisualStyleBackColor = true;
            this.ButtonSelectionSort.Click += new System.EventHandler(this.ButtonSelectionSort_Click);
            // 
            // timerSelectionSort
            // 
            this.timerSelectionSort.Interval = 500;
            this.timerSelectionSort.Tick += new System.EventHandler(this.timerSelectionSort_Tick);
            // 
            // ButtonInsertionSort
            // 
            this.ButtonInsertionSort.Location = new System.Drawing.Point(337, 61);
            this.ButtonInsertionSort.Name = "ButtonInsertionSort";
            this.ButtonInsertionSort.Size = new System.Drawing.Size(101, 23);
            this.ButtonInsertionSort.TabIndex = 4;
            this.ButtonInsertionSort.Text = "Insertion Sort";
            this.ButtonInsertionSort.UseVisualStyleBackColor = true;
            this.ButtonInsertionSort.Click += new System.EventHandler(this.ButtonInsertionSort_Click);
            // 
            // timerInsertionSort
            // 
            this.timerInsertionSort.Interval = 500;
            this.timerInsertionSort.Tick += new System.EventHandler(this.timerInsertionSort_Tick);
            // 
            // ButtonShellSort
            // 
            this.ButtonShellSort.Location = new System.Drawing.Point(459, 61);
            this.ButtonShellSort.Name = "ButtonShellSort";
            this.ButtonShellSort.Size = new System.Drawing.Size(75, 23);
            this.ButtonShellSort.TabIndex = 5;
            this.ButtonShellSort.Text = "Shell sort";
            this.ButtonShellSort.UseVisualStyleBackColor = true;
            this.ButtonShellSort.Click += new System.EventHandler(this.ButtonShellSort_Click);
            // 
            // buttonUnesiNiz
            // 
            this.buttonUnesiNiz.Enabled = false;
            this.buttonUnesiNiz.Location = new System.Drawing.Point(386, 21);
            this.buttonUnesiNiz.Name = "buttonUnesiNiz";
            this.buttonUnesiNiz.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesiNiz.TabIndex = 6;
            this.buttonUnesiNiz.Text = "Unesi niz";
            this.buttonUnesiNiz.UseVisualStyleBackColor = true;
            this.buttonUnesiNiz.Click += new System.EventHandler(this.buttonUnesiNiz_Click);
            // 
            // panelUnosNiza
            // 
            this.panelUnosNiza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUnosNiza.Controls.Add(this.buttonKontrola);
            this.panelUnosNiza.Controls.Add(this.buttonKreirajNasumicanNiz);
            this.panelUnosNiza.Controls.Add(this.buttonKreirajNiz);
            this.panelUnosNiza.Controls.Add(this.textBoxUnosNiza);
            this.panelUnosNiza.Controls.Add(this.trackBar1);
            this.panelUnosNiza.Location = new System.Drawing.Point(97, 341);
            this.panelUnosNiza.Name = "panelUnosNiza";
            this.panelUnosNiza.Size = new System.Drawing.Size(592, 100);
            this.panelUnosNiza.TabIndex = 7;
            // 
            // buttonKontrola
            // 
            this.buttonKontrola.Location = new System.Drawing.Point(479, 38);
            this.buttonKontrola.Name = "buttonKontrola";
            this.buttonKontrola.Size = new System.Drawing.Size(75, 23);
            this.buttonKontrola.TabIndex = 9;
            this.buttonKontrola.Text = "Pokreni";
            this.buttonKontrola.UseVisualStyleBackColor = true;
            this.buttonKontrola.Click += new System.EventHandler(this.buttonKontrola_Click);
            // 
            // buttonKreirajNasumicanNiz
            // 
            this.buttonKreirajNasumicanNiz.Location = new System.Drawing.Point(49, 60);
            this.buttonKreirajNasumicanNiz.Name = "buttonKreirajNasumicanNiz";
            this.buttonKreirajNasumicanNiz.Size = new System.Drawing.Size(127, 23);
            this.buttonKreirajNasumicanNiz.TabIndex = 2;
            this.buttonKreirajNasumicanNiz.Text = "Kreiraj nasumičan niz";
            this.buttonKreirajNasumicanNiz.UseVisualStyleBackColor = true;
            this.buttonKreirajNasumicanNiz.Click += new System.EventHandler(this.buttonKreirajNasumicanNiz_Click);
            // 
            // buttonKreirajNiz
            // 
            this.buttonKreirajNiz.Location = new System.Drawing.Point(210, 22);
            this.buttonKreirajNiz.Name = "buttonKreirajNiz";
            this.buttonKreirajNiz.Size = new System.Drawing.Size(75, 23);
            this.buttonKreirajNiz.TabIndex = 1;
            this.buttonKreirajNiz.Text = "Kreiraj niz";
            this.buttonKreirajNiz.UseVisualStyleBackColor = true;
            this.buttonKreirajNiz.Click += new System.EventHandler(this.buttonUnesiNiz2_Click);
            // 
            // textBoxUnosNiza
            // 
            this.textBoxUnosNiza.Location = new System.Drawing.Point(25, 22);
            this.textBoxUnosNiza.Name = "textBoxUnosNiza";
            this.textBoxUnosNiza.Size = new System.Drawing.Size(164, 23);
            this.textBoxUnosNiza.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(332, 38);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timerUnosNiza
            // 
            this.timerUnosNiza.Tick += new System.EventHandler(this.timerUnosNiza_Tick);
            // 
            // timerShellSort
            // 
            this.timerShellSort.Interval = 500;
            this.timerShellSort.Tick += new System.EventHandler(this.timerShellSort_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(863, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(281, 179);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(863, 247);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(281, 191);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelUnosNiza);
            this.Controls.Add(this.buttonUnesiNiz);
            this.Controls.Add(this.ButtonShellSort);
            this.Controls.Add(this.ButtonInsertionSort);
            this.Controls.Add(this.ButtonSelectionSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonBubbleSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelUnosNiza.ResumeLayout(false);
            this.panelUnosNiza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonBubbleSort;
        private System.Windows.Forms.Timer timerSwap;
        private System.Windows.Forms.Timer timerBubbleSort;
        private Label label1;
        private Label label2;
        private Button ButtonSelectionSort;
        private System.Windows.Forms.Timer timerSelectionSort;
        private Button ButtonInsertionSort;
        private System.Windows.Forms.Timer timerInsertionSort;
        private Button ButtonShellSort;
        private Button buttonUnesiNiz;
        private Panel panelUnosNiza;
        private Button buttonKreirajNiz;
        private TextBox textBoxUnosNiza;
        private System.Windows.Forms.Timer timerUnosNiza;
        private Button buttonKreirajNasumicanNiz;
        private System.Windows.Forms.Timer timerShellSort;
        private TrackBar trackBar1;
        private Button buttonKontrola;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
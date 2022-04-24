namespace Vizualizacija_algoritama_za_sortiranje
{
    partial class FormVizualizacijaAlgoritama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVizualizacijaAlgoritama));
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
            this.buttonKreirajNasumicanNiz = new System.Windows.Forms.Button();
            this.buttonKreirajNiz = new System.Windows.Forms.Button();
            this.textBoxUnosNiza = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonKontrola = new System.Windows.Forms.Button();
            this.timerShellSort = new System.Windows.Forms.Timer(this.components);
            this.textBoxOpisAlgoritma = new System.Windows.Forms.TextBox();
            this.textBoxPseudokod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNaslov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Enabled = false;
            this.ButtonBubbleSort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBubbleSort.Location = new System.Drawing.Point(134, 28);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(105, 33);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(946, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opis algoritma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(955, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pseudokod";
            // 
            // ButtonSelectionSort
            // 
            this.ButtonSelectionSort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSelectionSort.Location = new System.Drawing.Point(291, 28);
            this.ButtonSelectionSort.Name = "ButtonSelectionSort";
            this.ButtonSelectionSort.Size = new System.Drawing.Size(105, 33);
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
            this.ButtonInsertionSort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonInsertionSort.Location = new System.Drawing.Point(444, 28);
            this.ButtonInsertionSort.Name = "ButtonInsertionSort";
            this.ButtonInsertionSort.Size = new System.Drawing.Size(109, 33);
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
            this.ButtonShellSort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonShellSort.Location = new System.Drawing.Point(608, 28);
            this.ButtonShellSort.Name = "ButtonShellSort";
            this.ButtonShellSort.Size = new System.Drawing.Size(100, 33);
            this.ButtonShellSort.TabIndex = 5;
            this.ButtonShellSort.Text = "Shell sort";
            this.ButtonShellSort.UseVisualStyleBackColor = true;
            this.ButtonShellSort.Click += new System.EventHandler(this.ButtonShellSort_Click);
            // 
            // buttonKreirajNasumicanNiz
            // 
            this.buttonKreirajNasumicanNiz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKreirajNasumicanNiz.Location = new System.Drawing.Point(103, 397);
            this.buttonKreirajNasumicanNiz.Name = "buttonKreirajNasumicanNiz";
            this.buttonKreirajNasumicanNiz.Size = new System.Drawing.Size(183, 44);
            this.buttonKreirajNasumicanNiz.TabIndex = 2;
            this.buttonKreirajNasumicanNiz.Text = "Kreiraj nasumičan niz";
            this.buttonKreirajNasumicanNiz.UseVisualStyleBackColor = true;
            this.buttonKreirajNasumicanNiz.Click += new System.EventHandler(this.buttonKreirajNasumicanNiz_Click);
            // 
            // buttonKreirajNiz
            // 
            this.buttonKreirajNiz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKreirajNiz.Location = new System.Drawing.Point(265, 340);
            this.buttonKreirajNiz.Name = "buttonKreirajNiz";
            this.buttonKreirajNiz.Size = new System.Drawing.Size(105, 41);
            this.buttonKreirajNiz.TabIndex = 1;
            this.buttonKreirajNiz.Text = "Kreiraj niz";
            this.buttonKreirajNiz.UseVisualStyleBackColor = true;
            this.buttonKreirajNiz.Click += new System.EventHandler(this.buttonUnesiNiz2_Click);
            // 
            // textBoxUnosNiza
            // 
            this.textBoxUnosNiza.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUnosNiza.Location = new System.Drawing.Point(67, 349);
            this.textBoxUnosNiza.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBoxUnosNiza.MaximumSize = new System.Drawing.Size(192, 43);
            this.textBoxUnosNiza.Name = "textBoxUnosNiza";
            this.textBoxUnosNiza.Size = new System.Drawing.Size(192, 25);
            this.textBoxUnosNiza.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(482, 376);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(125, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonKontrola
            // 
            this.buttonKontrola.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKontrola.Location = new System.Drawing.Point(712, 365);
            this.buttonKontrola.Name = "buttonKontrola";
            this.buttonKontrola.Size = new System.Drawing.Size(99, 40);
            this.buttonKontrola.TabIndex = 9;
            this.buttonKontrola.Text = "Pokreni";
            this.buttonKontrola.UseVisualStyleBackColor = true;
            this.buttonKontrola.Click += new System.EventHandler(this.buttonKontrola_Click);
            // 
            // timerShellSort
            // 
            this.timerShellSort.Interval = 500;
            this.timerShellSort.Tick += new System.EventHandler(this.timerShellSort_Tick);
            // 
            // textBoxOpisAlgoritma
            // 
            this.textBoxOpisAlgoritma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOpisAlgoritma.Location = new System.Drawing.Point(863, 39);
            this.textBoxOpisAlgoritma.Multiline = true;
            this.textBoxOpisAlgoritma.Name = "textBoxOpisAlgoritma";
            this.textBoxOpisAlgoritma.ReadOnly = true;
            this.textBoxOpisAlgoritma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOpisAlgoritma.Size = new System.Drawing.Size(281, 179);
            this.textBoxOpisAlgoritma.TabIndex = 9;
            this.textBoxOpisAlgoritma.Text = resources.GetString("textBoxOpisAlgoritma.Text");
            // 
            // textBoxPseudokod
            // 
            this.textBoxPseudokod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPseudokod.Location = new System.Drawing.Point(863, 250);
            this.textBoxPseudokod.Multiline = true;
            this.textBoxPseudokod.Name = "textBoxPseudokod";
            this.textBoxPseudokod.ReadOnly = true;
            this.textBoxPseudokod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPseudokod.Size = new System.Drawing.Size(281, 191);
            this.textBoxPseudokod.TabIndex = 10;
            this.textBoxPseudokod.Text = resources.GetString("textBoxPseudokod.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sporo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Brzo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(482, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Podešavanje brzine";
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNaslov.Location = new System.Drawing.Point(368, 93);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(116, 25);
            this.labelNaslov.TabIndex = 14;
            this.labelNaslov.Text = "Bubble sort";
            // 
            // FormVizualizacijaAlgoritama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonKreirajNasumicanNiz);
            this.Controls.Add(this.buttonKontrola);
            this.Controls.Add(this.textBoxUnosNiza);
            this.Controls.Add(this.buttonKreirajNiz);
            this.Controls.Add(this.textBoxPseudokod);
            this.Controls.Add(this.textBoxOpisAlgoritma);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ButtonShellSort);
            this.Controls.Add(this.ButtonInsertionSort);
            this.Controls.Add(this.ButtonSelectionSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonBubbleSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormVizualizacijaAlgoritama";
            this.Text = "Vizualizacija algoritama za sortiranje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVizualizacijaAlgoritama_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Button buttonKreirajNiz;
        private TextBox textBoxUnosNiza;
        private Button buttonKreirajNasumicanNiz;
        private System.Windows.Forms.Timer timerShellSort;
        private TrackBar trackBar1;
        private Button buttonKontrola;
        private Label label3;
        private TextBox textBoxOpisAlgoritma;
        private TextBox textBoxPseudokod;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelNaslov;
    }
}
﻿namespace Vizualizacija_algoritama_za_sortiranje
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
            this.buttonUnesiNiz2 = new System.Windows.Forms.Button();
            this.textBoxUnosNiza = new System.Windows.Forms.TextBox();
            this.timerUnosNiza = new System.Windows.Forms.Timer(this.components);
            this.panelUnosNiza.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBubbleSort
            // 
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
            this.panelUnosNiza.Controls.Add(this.buttonUnesiNiz2);
            this.panelUnosNiza.Controls.Add(this.textBoxUnosNiza);
            this.panelUnosNiza.Location = new System.Drawing.Point(248, 341);
            this.panelUnosNiza.Name = "panelUnosNiza";
            this.panelUnosNiza.Size = new System.Drawing.Size(304, 100);
            this.panelUnosNiza.TabIndex = 7;
            // 
            // buttonUnesiNiz2
            // 
            this.buttonUnesiNiz2.Location = new System.Drawing.Point(207, 14);
            this.buttonUnesiNiz2.Name = "buttonUnesiNiz2";
            this.buttonUnesiNiz2.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesiNiz2.TabIndex = 1;
            this.buttonUnesiNiz2.Text = "Unesi";
            this.buttonUnesiNiz2.UseVisualStyleBackColor = true;
            this.buttonUnesiNiz2.Click += new System.EventHandler(this.buttonUnesiNiz2_Click);
            // 
            // textBoxUnosNiza
            // 
            this.textBoxUnosNiza.Location = new System.Drawing.Point(17, 35);
            this.textBoxUnosNiza.Name = "textBoxUnosNiza";
            this.textBoxUnosNiza.Size = new System.Drawing.Size(149, 23);
            this.textBoxUnosNiza.TabIndex = 0;
            // 
            // timerUnosNiza
            // 
            this.timerUnosNiza.Tick += new System.EventHandler(this.timerUnosNiza_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private Button buttonUnesiNiz2;
        private TextBox textBoxUnosNiza;
        private System.Windows.Forms.Timer timerUnosNiza;
    }
}
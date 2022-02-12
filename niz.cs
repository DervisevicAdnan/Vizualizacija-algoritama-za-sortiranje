using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizualizacija_algoritama_za_sortiranje
{
    public class niz
    {
        private Label[] array;
        public niz() { }
        public niz(int[] sortingArray, Form form)
        {
            array = new Label[sortingArray.Length];
            for(int i= 0; i < sortingArray.Length; i++)
            {
                array[i] = new Label();
                array[i].AutoSize = true;
                array[i].Text = sortingArray[i].ToString();
                array[i].Location = new Point(100 + 50 * i, 200);
                array[i].ForeColor = Color.White;
                array[i].BackColor = Color.Blue;
            }
            form.Controls.AddRange(array);
            MessageBox.Show(sortingArray.Length.ToString());
        }

        public void swap(int i, int j)
        {
            string tmp = array[i].Text;
            array[i].Text = array[j].Text;
            array[j].Text=tmp;
        }
    }
}

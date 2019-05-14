using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trenter_a7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numberList = Enumerable.Range(1, 10).ToList();

        private void Button1_Click(object sender, EventArgs e)
        {
            int x = indexOf(numberList, 7);
            MessageBox.Show("the index of 7 = " + x.ToString()+"(including zero)");
        }
        int indexOf(List<int> numberList,int num)
        {
            return numberList.IndexOf(num);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("the reverse List is: " + string.Join(",",reverse(numberList)));
        }
        List<int> reverse(List<int> numberList)
        {
            numberList.Reverse();
            return numberList;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("inserting zero as the 0th element in the list\n\r" + string.Join(",", insertFunc(numberList, 0, 0)));
        }
        List<int> insertFunc(List<int> numberList,int num,int index)
        {
            numberList.Insert(index,num);
            return numberList;

        }
    }
}

using Lab_4_window.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_window
{
    public partial class Lab_4_window : Form
    {
        public Lab_4_window()
        {
            InitializeComponent();
        }

        Book myBook = new Book("Книга");

        private void Add_Click(object sender, EventArgs e)
        {
            //el = new Item(tb_inf.Text);

            //if (rb_left.Checked == true)
            //{
            //    myTree.AddLeft(el);
            //}
            //if (rb_right.Checked == true)
            //{
            //    myTree.AddRight(el);
            //}

            if (rb_left.Checked == true)
            {
                myBook.AddChapter(tb_inf.Text);
            }
            if (rb_right.Checked == true)
            {
                
            }

            Print();

            rb_right.Visible = true;
        }

        private void Print()
        {
            //tb_output.Text = myTree.ToString();
        }
    }
}

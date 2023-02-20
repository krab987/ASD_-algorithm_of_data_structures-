using Lab_3.Module;
namespace Lab_3
{
    public partial class Form1 : Form
    {
        void Print()
        {
            lb_res.Items.Clear();

            foreach (object Mylist in list.MyArrayList)
            {
                lb_res.Items.Add(Mylist);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        int indexList = -1;
        EasyArrayList list = new EasyArrayList(); //list of lists
        EasyLinkedList subList;

        private void bn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                subList = new EasyLinkedList(++indexList); // create sublist

                int pushEl = int.Parse(tb_countEl.Text);
                if (pushEl < 0)
                    throw new Exception("countEl must be > 0");

                Random rand = new Random();
                for (int i = 0; i < pushEl; i++)
                {
                    Item el = new Item(rand.Next(10), indexList.ToString() + rand.Next(10).ToString());
                    subList.AddLastEl(el);
                } // add el to aublist
                if (tb_index.Text != "")
                {
                    int index = int.Parse(tb_index.Text);
                    list.AddEl(index, subList);
                }
                else
                    list.AddEl(subList); //add sublist to list

                Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bn_delByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                int index;
                if (tb_index.Text != "" && tb_elSublist.Text == "")
                {
                    index = int.Parse(tb_index.Text);
                    list.RemoveEl(index);
                }
                if (tb_elSublist.Text != "" && tb_index.Text != "")
                {
                    index = int.Parse(tb_index.Text);
                    string str = tb_elSublist.Text;
                    list.RemoveEl(index, str);
                }

                Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void bn_AddSublist_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                Item el = new Item(rand.Next(10), indexList.ToString() + rand.Next(10).ToString());

                int index = int.Parse(tb_index.Text);
                string str = tb_elSublist.Text;

                if (rb_AddFirst.Checked == true)
                {
                    list.AddFirstElem(index, el);
                }
                if (rb_AddLast.Checked == true)
                {
                    list.AddLastElem(index, el);
                }

                Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
    }
}




//if (rb_AddAfter.Checked == true)
//{
//    list.AddElAfter(index, str, el);
//}
//if (rb_AddBefore.Checked == true)
//{
//    list.AddElBefore(index, str, el);
//}
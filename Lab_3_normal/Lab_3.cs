using Lab_3_normal.Module;

namespace Lab_3_normal
{
    public partial class Lab_3 : Form
    {
        public Lab_3()
        {
            InitializeComponent();
        }
        void Print()
        {
            lb_res.Items.Clear();

            foreach (object Mylist in list.MyArrayList)
            {
                lb_res.Items.Add(Mylist);
            }
        }

        int indexList = -1;
        EasyArrayList list = new EasyArrayList(); //list of lists
        EasyLinkedList subList;

        private void bn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int indKey = list.GetIndex(int.Parse(tb_key.Text));
                Random rand = new Random();
                Item el = new Item(int.Parse(tb_key.Text), indexList.ToString() + rand.Next(10).ToString());

                if (indKey == -1) //null results
                {
                    subList = new EasyLinkedList(int.Parse(tb_key.Text)); // create sublist
                    subList.AddLastEl(el);

                    list.AddEl(++indexList, subList);
                }
                else
                {
                    list.AddLastElem(indKey, el);
                }

                Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int indKey = list.GetIndex(int.Parse(tb_key.Text));
                list.RemoveEl(indKey, tb_elToDel.Text);

                //int elDel = int.Parse(tb_elToDel.Text);
                //list.RemoveEl(indKey, elDel);

                Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void FirstEl_Click(object sender, EventArgs e)
        {
            try
            {
                int indKey = list.GetIndex(int.Parse(tb_key.Text));
                MessageBox.Show(list.FirstEl(indKey));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
    }
}
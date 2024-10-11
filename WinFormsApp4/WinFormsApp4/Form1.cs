using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sehirler = { "Ankara", "Istanbul", "Bursa", "Adana", "Kars", "Bolu" };


        private void btnClick_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            foreach (string s in sehirler)
            {
                lst1.Items.Add(s);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedItem != null)
            {
                string selectedItem = lst1.SelectedItem.ToString();

                lst2.Items.Add(selectedItem);

                lst1.Items.Remove(selectedItem);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lst2.SelectedItem != null)
            {
                string selectedItem = lst2.SelectedItem.ToString();

                lst1.Items.Add(selectedItem);

                lst2.Items.Remove(selectedItem);
            }
        }
    }
}

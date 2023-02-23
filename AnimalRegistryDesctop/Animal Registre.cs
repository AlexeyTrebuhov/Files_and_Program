using AnimalRegistrenamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalRegistryDesctop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Method();
        }

        public void Method()

        {

        }

        private void button_loadAnimal_Click(object sender, EventArgs e)
        {
            AnimalRegistreClient animalRegistreClient = new AnimalRegistreClient("http://localhost:5215/", new System.Net.Http.HttpClient());
            ICollection<Animals> animals = animalRegistreClient.GetAllAsync().Result;

            listView1.Items.Clear();
            foreach (Animals animal in animals)
            {
                ListViewItem item = new ListViewItem();
                item.Text = animal.AnimalId.ToString();

                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = animal.AnimalName
                });

                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = animal.DateOfBirth.ToString()
                });

                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = animal.ExecutableCommands
                });

                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = animal.AdditionalCommands
                });

                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = animal.AdditionalCommandsToo
                });

                listView1.Items.Add(item);
            }
        }



        private void button_UpdateAnimal_Click(object sender, EventArgs e)
        {
        }



        private void button_GetAnimal_Click(object sender, EventArgs e)
        {

        }

        private void button_DeletAnimal_Click(object sender, EventArgs e)
        {

        }
    }
}

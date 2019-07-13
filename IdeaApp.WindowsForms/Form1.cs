using IdeaApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaApp.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var repository = new IdeaRepositoryEfCore();

            this.dataGridView1.DataSource = repository.GetAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Idea idea = new Idea();
            idea.Note = textBox1.Text;

            var repository = new IdeaRepositoryEfCore();
            repository.Add(idea);

            textBox1.Clear();

            Form1_Load(null, null);
        }
    }
}

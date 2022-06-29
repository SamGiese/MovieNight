using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Movie> movies = new List<Movie>();



        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBinding()
        {

            //Fill out PeopleFoundListBox with the data pulled into the people list. This will populate the large text box
            PeopleFoundListBox.DataSource = movies;
            PeopleFoundListBox.DisplayMember = "FullInfo";

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            //pull value from text box on the form
            movies =  db.GetMovie(LastNameText.Text);


            UpdateBinding();

        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(FirstNameInsertText.Text);

            FirstNameInsertText.Text = "";
            
            

        }

        private void BusinessEntityIDInsertText_TextChanged(object sender, EventArgs e)
        {
            /*
            int value;
            if (int.TryParse(PersonTypeInsertText.Text, out value))
            {
                //parsing successful
            }
            else
            {
                //parsing failed
            }
            */
        }

       
    }
}

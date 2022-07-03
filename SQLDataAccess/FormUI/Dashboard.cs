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
        //movies is the movie it pulls from the MovieNight DB. Keeping as a list for now.
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


        //Fill out RandomMovieListBox with the data pulled into the movies list. This will populate the text box with a random movie.
        private void UpdateBinding()
        {
            RandomMovieListBox.DataSource = movies;
            RandomMovieListBox.DisplayMember = "FullInfo";
        }



        //On click, creates an item of DataAcess type & then uses the GetMovie method to fill it
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            movies =  db.GetMovie();
            UpdateBinding();
        }

        

        private void InsertLabelClick(object sender, EventArgs e)
        {

        }


        //On click, creates an item of DataAcess type & uses the InsertMovie method to insert a record into the MovieNight DB
        //with the string/nvarchar inside MovieNameInsertText.Text
        private void InsertMovieButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertMovie(MovieNameInsertText.Text);

            MovieNameInsertText.Text = "";
            
        }

        

        private void MovieNameInsertText_TextChanged(object sender, EventArgs e)
        {

        }

        //On click, creates an item of DataAcess type & uses the RemoveMovie method to remove any instances
        //of the movie that is currently occupying RandomMovieListBox
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.RemoveMovie(RandomMovieListBox.Text);

        }
    }
}

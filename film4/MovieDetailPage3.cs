using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace film4
{
    public partial class MovieDetailPage3 : ContentPage
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public MovieDetailPage3(string title, string description)
        {
            InitializeComponent();

            Title = title;
            Description = description;

            TitleLabel.Text = Title;
            DescriptionLabel.Text = Description;
        }

      
    }
}
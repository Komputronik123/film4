
namespace film4
{
    public partial class MovieDetailPage2 : ContentPage
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public MovieDetailPage2(string title, string description)
        {
            InitializeComponent();

            Title = title;
            Description = description;

            TitleLabel.Text = Title;
            DescriptionLabel.Text = Description;
        }

     
    }
}
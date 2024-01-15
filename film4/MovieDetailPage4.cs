
namespace film4
{
    public partial class MovieDetailPage4 : ContentPage
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public MovieDetailPage4(string title, string description)
        {
            InitializeComponent();

            Title = title;
            Description = description;

            TitleLabel.Text = Title;
            DescriptionLabel.Text = Description;
        }

       
    }
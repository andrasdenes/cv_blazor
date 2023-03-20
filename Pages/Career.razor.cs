#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace CV.Pages
{
    public partial class Career
    {
        [Inject]
        public IJobService JobService { get; set; }
        public JobCollection JobCollection { get; set; }
        public string CompanyName { get; set; }
        public bool ShowMessage { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            JobCollection = await JobService.GetAllJobs();
        }

        private string Markdown(string md)
        {
            return null; 
        }

        private void ToggleClickMessage()
        {
            if (!ShowMessage)
            {
                ShowMessage = true;
            }
            else 
            {
                ShowMessage= false;
            }
        }
    }
}

namespace CV.Pages
{
    public partial class NewCareer
    {
        [Inject]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IJobService JobService { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string JobList { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string CompanyName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public bool ShowMessage { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            JobList = await JobService.GetAllJobs();
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
                ShowMessage = false;
            }
        }
    }
}

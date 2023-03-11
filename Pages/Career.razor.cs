namespace CV.Pages
{
    public partial class Career
    {
        [Inject]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IJobService JobService { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public List<Job> Jobs { get; set; } = new List<Job>();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string CompanyName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public bool ShowMessage { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            List<string> jobList = await JobService.GetAllJobs();
            foreach (var item in jobList)
            {
                Job jobDetails = await JobService.GetJobDetails(item);
                Jobs?.Add(jobDetails);
            }
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

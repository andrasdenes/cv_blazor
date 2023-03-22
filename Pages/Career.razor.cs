#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CV.Pages
{
    public partial class Career
    {
        [Inject]
        public IJobService JobService { get; set; }
        public JobCollection JobCollection { get; set; }
        public string GeneratedPdf { get; set; }
        public string CompanyName { get; set; }
        public bool ShowMessage { get; set; } = false;
        protected override async Task OnInitializedAsync()
        {
            JobCollection = await JobService.GetAllJobs();
            GeneratedPdf = await TransformPdfData(await JobService.GetGeneratedPdf());
        }

        private async Task<string> TransformPdfData(string rawPdf)
        {
            var pdf = rawPdf.Trim('"');
            return pdf;
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

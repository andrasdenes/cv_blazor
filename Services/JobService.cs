namespace CV.Services
{
    public class JobService : IJobService
    {
        private readonly ICvClient CvClient;

        public JobService(ICvClient cvClient)
        {
            CvClient = cvClient ?? throw new ArgumentNullException(nameof(cvClient));
        }

        public async Task<JobCollection> GetAllJobs()
        {
            var allJobs = await CvClient.GetAllJobs();

            return allJobs;
        }

        public async Task<string> GetGeneratedPdf()
        {
            string pdf = await CvClient.GetGeneratedPdf();
            return pdf;
        }

        public void GetJobDetails(string companyName)
        {

        }
    }
}

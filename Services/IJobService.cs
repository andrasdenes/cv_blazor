namespace CV.Services
{
    public interface IJobService
    {
        Task<JobCollection> GetAllJobs();
        void GetJobDetails(string companyName);
        Task<string> GetGeneratedPdf();
    }
}
namespace CV.Services
{
    public interface IJobService
    {
        Task<string> GetAllJobs();
        void GetJobDetails(string companyName);
    }
}
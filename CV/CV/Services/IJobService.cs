namespace CV.Services
{
    public interface IJobService
    {
        Task<List<string>> GetAllJobs();
        Task<Job> GetJobDetails(string companyName);
    }
}
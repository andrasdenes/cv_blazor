namespace CV.Communication
{
    public interface ICvClient
    {
        Task<string> GetAllJobs();

        Task<string> GetJobDetails(string companyName);
    }
}

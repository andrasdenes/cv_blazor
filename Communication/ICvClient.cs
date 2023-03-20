namespace CV.Communication
{
    public interface ICvClient
    {
        Task<string> GetAllJobs();
    }
}

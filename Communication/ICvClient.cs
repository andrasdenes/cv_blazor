namespace CV.Communication
{
    public interface ICvClient
    {
        Task<JobCollection> GetAllJobs();
        Task<string> GetGeneratedPdf();
    }
}

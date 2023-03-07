using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CV.Communication
{
    public class CvClient : ICvClient
    {
        public string JobListUrl = "jobs/jobs.toml";
        public string JobUrl = "jobs/{0}.toml";
        private HttpClient Client;
        public CvClient(HttpClient httpClient)
        {
            Client = httpClient;
        }

        public async Task<string> GetAllJobs()
        { 
            string jobList = await Client.GetStringAsync(JobListUrl);
            return jobList;
        }

        public async Task<string> GetJobDetails(string companyName)
        { 
            string jobDetails = await Client.GetStringAsync(string.Format(JobUrl,companyName));
            return jobDetails;
        }
    }
}

namespace CV.Communication
{
    public class CvClient : ICvClient
    {
        public string JobListUrl = "api/jobs";
        private HttpClient Client;
        public CvClient(HttpClient httpClient)
        {
            Client = httpClient;
        }

        public async Task<string> GetAllJobs()
        { 
            HttpResponseMessage response = await Client.GetAsync(JobListUrl);
            if (response != null)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            { 
                return string.Empty;
            }
        }
    }
}

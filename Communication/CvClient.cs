using Newtonsoft.Json;

namespace CV.Communication
{
    public class CvClient : ICvClient
    {
        public string JobListUrl = "api/jobs";
        public string JobPdfUrl = "api/jobs/pdf";
        private HttpClient Client;
        public CvClient(HttpClient httpClient)
        {
            Client = httpClient;
        }

        public async Task<JobCollection> GetAllJobs()
        { 
            HttpResponseMessage response = await Client.GetAsync(JobListUrl);
            if (response != null)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<JobCollection>(responseJson);
            }
            else
            { 
                return new JobCollection();
            }
        }

        public async Task<string> GetGeneratedPdf()
        {
            HttpResponseMessage response = await Client.GetAsync(JobPdfUrl);
            if (response != null)
            {
                var responseJson = await response.Content.ReadAsStringAsync();
                return responseJson;
            }
            else
            {
                return null;
            }
        }
    }
}

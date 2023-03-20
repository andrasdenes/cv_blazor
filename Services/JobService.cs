using Tomlyn.Model;

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

        public void GetJobDetails(string companyName)
        {

        }

        private List<string> TomlTableToStringList(object tomlArray) 
        {
            List<string> list = new List<string>();

            if (tomlArray == null)
            {
                return list;
            }

            var e = (tomlArray as TomlArray).GetEnumerator();

            while (e.MoveNext())
            {
                list.Add(e.Current.ToString());
            }
            return list;
        }
    }
}

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

        public async Task<List<string>> GetAllJobs()
        {
            string allJobs = await CvClient.GetAllJobs();
            var toml = Tomlyn.Toml.ToModel(allJobs);
            var found = toml["jobs"];
            return TomlTableToStringList(found);
        }

        public async Task<Job> GetJobDetails(string companyName)
        {
            string jobDetails = await CvClient.GetJobDetails(companyName);
            var job = Tomlyn.Toml.ToModel<Job>(jobDetails);
            return job;
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

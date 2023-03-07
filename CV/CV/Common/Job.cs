namespace CV.Common
{
    public class Job
    {
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string CompanyUrl { get; set; }
        public string Image { get; set; }
        public string ImageAlt { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public List<string> Tags { get; set; }
    }
}

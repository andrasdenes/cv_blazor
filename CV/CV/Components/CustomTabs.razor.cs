namespace CV.Components
{
    public partial class CustomTabs
    {
        public string SelectedTab { get; set; } = "techstack";
        [Parameter]
        public Job Job { get; set; }
        [Parameter]
        public string Class { get; set; }
        private Task OnSelectedTabChanged(string name)
        {
            SelectedTab = name;
            return Task.CompletedTask;
        }
        private bool IsUri(string toCheck)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(toCheck, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }
    }
}

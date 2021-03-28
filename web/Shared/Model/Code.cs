namespace web.Shared.Model
{
    public class Code
    {
        public string FileName { get;}
        public string HRef { get; }

        public string Name { get; }
        public Code(string name, string href)
        {
            this.FileName = name;
            this.Name = name.TrimEnd('.','M','D');
            this.HRef = href;
        }
    }
}
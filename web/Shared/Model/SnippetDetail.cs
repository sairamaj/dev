using Markdig;

public class Detail{
        public string Data {get;set;}
    }
    public class SnippetDetail{
        public string Name {get; set;}
        public Detail Details {get;set;}

        public string DetailData
        {
            get
            {
                if(Details == null){
                    return string.Empty;
                }

                if (string.IsNullOrWhiteSpace(this.Details.Data))
                {
                    return string.Empty;
                }
                return Markdown.ToHtml(this.Details.Data);
            }
        }
    }
namespace Reddit
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public List<int> listIds { get; set; } = new List<int>();

        public Post(string title, string content, string author)
        {
            Id = listIds.Count + 1;
            Title = title;
            Content = content;
            Author = author;
            listIds.Add(Id);
        }
    }
}

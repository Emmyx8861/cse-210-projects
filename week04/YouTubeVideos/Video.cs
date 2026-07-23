using System.Transactions;

public class Video
{
    public string title="";

    public string author="";

    public int lengthinseconds=0;

    public Video(string title, string author, int lengthinseconds)
    {
        this.title = title;
        this.author = author;
        this.lengthinseconds = lengthinseconds;
    }

    public List <Comment> comments = new List<Comment>();

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
}
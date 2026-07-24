using System.Transactions;

public class Video
{
    public string _title="";

    public string _author="";

    public int _lengthinseconds=0;

    public Video(string title, string author, int lengthinseconds)
    {
        _title = title;
        _author = author;
        _lengthinseconds = lengthinseconds;
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
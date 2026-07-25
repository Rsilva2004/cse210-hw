using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

   public int GetNumberOfComments()
    {
        return _comments.Count;
    }

}
using System;

public class BlogWriter : Writer, IVlogger
{
    public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public void Vlog()
    {
        Console.WriteLine(String.Format("{0} vlogs his/her videos on every Friday!", this.AuthorBio));
    }

    public override void Write()
    {
        Console.WriteLine(String.Format("Hi, there. I'm {0}. Hope, you had seen my vlogs!", this.AuthorBio));
    }
}
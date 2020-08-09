using System;

public class BookWriter : Writer, IVlogger
{
    public BookWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public void Vlog()
    {
        Console.WriteLine(String.Format("Vlog from {0}", this.AuthorBio));
    }

    public override void Write()
    {
        Console.WriteLine(String.Format("Hi, there. I'm {0}. Hope, you have read my books!", this.AuthorBio));
    }
}
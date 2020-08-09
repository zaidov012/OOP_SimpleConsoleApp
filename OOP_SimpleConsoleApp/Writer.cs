public abstract class Writer
{
    private string _firstName;
    private string _lastName;
    public string AuthorBio
    {
        get
        {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }

    public Writer(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public abstract void Write();
}
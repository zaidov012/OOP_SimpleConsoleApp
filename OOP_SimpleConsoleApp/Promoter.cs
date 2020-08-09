public abstract class Promoter
{
    private string _firstName;
    private string _lastName;
    private string _phoneNumber;
    public string MyBusinessCard
    {
        get
        {
            return string.Format("{0} {1} - {2}.", this._firstName, this._lastName, this._phoneNumber);
        }
    }

    public Promoter(string firstName, string lastName, string phoneNumber)
    {
        _firstName = firstName;
        _lastName = lastName;
        _phoneNumber = phoneNumber;
    }

    public void Promote()
    {
        Introduce();
        PromotePlan();
    }

    protected abstract void Introduce();
    protected abstract void PromotePlan();
}
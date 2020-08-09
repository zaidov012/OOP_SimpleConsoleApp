using System;

public class XSClubPromoter : Promoter, IVlogger, IBodyBuilder
{
    public XSClubPromoter(string firstName, string lastName, string phoneNumber) : base(firstName, lastName, phoneNumber)
    {
    }
    
    public void Vlog()
    {
        Introduce();
        Console.WriteLine("I vlog my business videos on my GoPro cam!");
    }

    public void Workout()
    {
        Introduce();
        Console.WriteLine("I do workout three times per week. That's great!");
    }

    protected override void Introduce()
    {
        Console.WriteLine(String.Format("Hello, there! I'm a promoter of XSClub. This is my business card: {0}", this.MyBusinessCard));
    }

    protected override void PromotePlan()
    {
        Console.WriteLine("Some promote plan from XS Club Promoter...");
    }
}
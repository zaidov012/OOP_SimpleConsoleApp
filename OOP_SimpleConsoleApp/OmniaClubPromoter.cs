using System;

public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, string phoneNumber) : base(firstName, lastName, phoneNumber)
    {
    }

    protected override void Introduce()
    {
        Console.WriteLine(String.Format("Hello, there! I'm a promoter of Omnia Club. This is my business card: {0}", this.MyBusinessCard));
    }

    protected override void PromotePlan()
    {
        Console.WriteLine("Some promote plan from Omnia Club Promoter...");
    }
}
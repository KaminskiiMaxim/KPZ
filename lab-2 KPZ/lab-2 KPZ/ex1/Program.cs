using lab_2_KPZ;

class Program
{
    static void Main()
    {
        ISubscriptionCreator creator = new WebSiteCreator();
        ISubscription subscription = creator.CreateSubscription();

        Console.WriteLine($"Monthly Fee: {subscription.MonthlyFee}");
        Console.WriteLine($"Min Period: {subscription.MinPeriodMonths}");
        Console.WriteLine("Channels:" + string.Join(",", subscription.Channels));
    }
}

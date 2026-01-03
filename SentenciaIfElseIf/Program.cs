internal class Program
{
    private static void Main(string[] args)
    {
        bool areYouHungry = true;
        bool youHaveMoney = true;


        if(areYouHungry && youHaveMoney && isOpenRestaurant("La konga", 11))
        {
            Console.WriteLine("Come");
        }
        else
        {
            Console.WriteLine("No comas entonces");
        }    
    }

    static bool isOpenRestaurant(string name, int hour = 0)
    {
        if (name == "La konga" && hour > 8 && hour < 23)
        {
            return true;
        }
        else if (name == "Restaurant 24 hs")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
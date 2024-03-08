using System.Collections;
using Fabric.Fabric;

class Program
{
    static void Main()
    {
        ItemGenerator f1 = new GoldGenerator();
        f1.OpenReward();
        ItemGenerator f2 = new GemGenerator();
        f2.OpenReward();

        List<ItemGenerator> generatorList = new List<ItemGenerator>();
        generatorList.Add(f1);
        generatorList.Add(f2);
        generatorList.Add(new GoldGenerator());
        generatorList.Add(new GoldGenerator());

        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            int index = rnd.Next(4);
            generatorList[index].OpenReward();
        }

    }
}
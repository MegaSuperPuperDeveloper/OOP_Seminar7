using Fabric.Interface;

namespace Fabric.Fabric;

public abstract class ItemGenerator
{
    public void OpenReward()
    {
        iGameItem gameItem = CreateItem();
        gameItem.Open();
    }

    public abstract iGameItem CreateItem();

}
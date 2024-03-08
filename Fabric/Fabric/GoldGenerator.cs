using Fabric.Interface;
using Fabric.Product;

namespace Fabric.Fabric;

public class GoldGenerator : ItemGenerator
{
    public override iGameItem CreateItem()
    {
        return new Gold();
    }
}
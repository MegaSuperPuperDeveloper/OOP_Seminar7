using Fabric.Interface;
using Fabric.Product;

namespace Fabric.Fabric;

public class GemGenerator : ItemGenerator
{
    public override iGameItem CreateItem()
    {
        return new Gem();
    }
}
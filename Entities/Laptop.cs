namespace MyFirstApi.Entities;

public sealed class Laptop : Device
{
    public override string GetBrand()
    {
        return "Brand 1";
    }

    public string GetModel()
    {
        var isConnected = IsConnected();
        if (isConnected)
            return "Model 1";

        return "Unknown";
    }

    public override string Hello()
    {
        return "Hello from Laptop";
    }
}
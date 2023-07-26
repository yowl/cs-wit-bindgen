// See https://aka.ms/new-console-template for more information
using wit_the_world;

internal class ExportsImpl : IExports
{
    public void Float32Param(float p0)
    {
        ImportsInterop.float32Param(p0);
    }

    public float Float32Result()
    {
        throw new NotImplementedException();
    }

    public void Float64Param(double p0)
    {
        throw new NotImplementedException();
    }

    public double Float64Result()
    {
        throw new NotImplementedException();
    }
}
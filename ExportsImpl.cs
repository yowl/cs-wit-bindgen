// See https://aka.ms/new-console-template for more information

using wit_the_world.Wit.imports.foo.foo.Floats;

namespace wit_the_world.Wit.exports.foo.foo.Floats;

public partial class FloatsImpl
{
    public static void Float32Param(float p0)
    {
        imports.foo.foo.Floats.FloatsInterop.Float32Param(p0);
    }

    public static float Float32Result()
    {
        throw new NotImplementedException();
    }

    public static void Float64Param(double p0)
    {
        throw new NotImplementedException();
    }

    public static double Float64Result()
    {
        throw new NotImplementedException();
    }
}
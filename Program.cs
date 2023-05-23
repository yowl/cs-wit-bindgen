// See https://aka.ms/new-console-template for more information
using wit_the_world;

Console.WriteLine("Hello, World!");

ExportsInterop.Exports = new ExportsImpl();

Imports.float32Param(1.23f);

Imports.float64Param(3.45d);

Console.WriteLine(Imports.float32Result());

Console.WriteLine(Imports.float64Result());

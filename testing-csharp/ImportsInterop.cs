// Generated by `wit-bindgen` 0.1.0. DO NOT EDIT!
namespace wit_the_world;

using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.InteropServices;

public static class ImportsInterop {
    
    [DllImport("*", EntryPoint = "float32-param")]
    internal static extern void float32Param(float p0);
    
    [DllImport("$root")]
    internal static extern void wasmImportFloat64Param(double p0);
    
    [DllImport("$root")]
    internal static extern float wasmImportFloat32Result();
    
    [DllImport("$root")]
    internal static extern double wasmImportFloat64Result();
    
}


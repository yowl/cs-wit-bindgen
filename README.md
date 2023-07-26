# cs-wit-bindgen
Testing wit-bindgen for c# and NativeAOT-LLVM

Building the c# bindings
`cargo run c-sharp  --string-encoding utf8 --out-dir testing-csharp tests/codegen/floats.wit`

Also generates the component meta data in an object file, e.g. `Generating "testing-csharp\\the_world_component_type.o"`  THis will be linked to the 
generated `.wasm` file to allow the component to be created below by `wasm-tools`

Copy the generated code to this repo

Build the entry point to call the ctors
```
%WASI_SDK_PATH%\bin\clang -c init.c
```

Build the c# Wasm 
```
dotnet publish -r wasi-wasm -c Release /p:PlatformTarget=AnyCPU /p:MSBuildEnableWorkloadResolver=false --self-contained /p:UseAppHost=false
```

This should produce a `component-type:the-world` custom section in the wasm which can be checked with `wasm-objdump.exe -j component-type:the-world -s cswasi.wasm`

Generate the C# module,currently fails as it includes exports

 ```
 wasm-tools component new .\bin\Release\net7.0\wasi-wasm\native\cswasi.wasm -o my-component-cs.wasm  --adapt wasi_snapshot_preview1=C:\github\cs-runtime-example-wasmtime\wasi_snapshot_preview1.reactor.wasm
 ```

View the WAT before creating the component
```
\wabt\bin\wasm2wat bin\Debug\net7.0\wasi-wasm\native\cswasi.wasm > \tmp\component.wat
```

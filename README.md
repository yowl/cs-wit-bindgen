# cs-wit-bindgen
Testing wit-bindgen for c# and NativeAOT-LLVM

Building the c# bindings
`cargo run c-sharp --out-dir testing-csharp tests/codegen/floats.wit`

Copy the generated code to this repo


Build the c# Wasm 
```
dotnet publish -r wasi-wasm -c Debug /p:PlatformTarget=AnyCPU /p:MSBuildEnableWorkloadResolver=false --self-contained /p:UseAppHost=false
```

Generate the C# module,currently fails as it includes exports

 ```
 wasm-tools component new .\bin\Debug\net8.0\wasi-wasm\native\cswasi.wasm -o my-component-cs.wasm  --adapt wasi_snapshot_preview1=c:\github\rustimpl\rustimpl\wasi_preview1_component_adapter.reactor.wasm
 ```


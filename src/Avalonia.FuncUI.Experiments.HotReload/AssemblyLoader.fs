module FuncUI.Experiments.AssemblyLoader

open System.Reflection
open System.Runtime.Loader
open System.Linq

type HotReloadAssemblyLoadContext() =
    inherit AssemblyLoadContext(nameof HotReloadAssemblyLoadContext, true)

    override _.Load (assemblyName: AssemblyName) =
        if assemblyName.Name = "FuncUI.Experiments" then null
        else AssemblyLoadContext.Default.Assemblies
                .FirstOrDefault(fun x -> x.FullName = assemblyName.FullName)
              

let create() = HotReloadAssemblyLoadContext()
                
let load path (loader: HotReloadAssemblyLoadContext) =
    let stream = System.IO.File.OpenRead path
    loader.LoadFromStream stream
    loader.LoadFromAssemblyPath path
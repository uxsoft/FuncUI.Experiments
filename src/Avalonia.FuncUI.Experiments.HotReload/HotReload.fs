module FuncUI.Experiments.HotReload

open FSharp.Control.Tasks
open FuncUI.Experiments
open System.IO
let projectDir = "/Users/dryk/RiderProjects/FuncUI.Experiments"
let liveOutputDir = Path.Combine(projectDir, "bin/HotReload")
let liveAssemblyPath =  Path.Combine(liveOutputDir, "FuncUI.Experiments.dll")

type IHotReloadable =
    abstract View : unit -> obj
    abstract SetModel : string -> unit
    abstract GetModel : unit -> string

let onSourceChanged e =
    task {
        do! DotNet.build projectDir liveOutputDir
        
        let loader = AssemblyLoader.create()
        let assembly = AssemblyLoader.load liveAssemblyPath loader
        ()
    } |> ignore

let watcher =
    FileWatcher.start projectDir
    |> FileWatcher.subscribe onSourceChanged

let test() = onSourceChanged null
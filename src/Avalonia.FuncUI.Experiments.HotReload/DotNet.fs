module FuncUI.Experiments.DotNet

open System.Diagnostics
open FSharp.Control.Tasks

let runCommand program (args: string) =
    task {
        let cmd = Process.Start(program, args)
        do! cmd.WaitForExitAsync()
        // TODO capture standard output?
    }
    
let build project output =
    runCommand "dotnet" $"build \"{project}\" -o \"{output}\""
    
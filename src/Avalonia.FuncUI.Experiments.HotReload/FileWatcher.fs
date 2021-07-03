module FuncUI.Experiments.FileWatcher

open System.IO

let start dir =
    let watcher = new FileSystemWatcher()
    watcher.Path <- dir
    watcher.EnableRaisingEvents <- true
    watcher.IncludeSubdirectories <- true
    watcher.Filter <- "*.fs"
    watcher

let stop (watcher: FileSystemWatcher) =
    watcher.EnableRaisingEvents <- false
    watcher.Dispose()
    
let subscribe (onChanged: FileSystemEventArgs -> unit) (watcher: FileSystemWatcher) =
    watcher.Changed.Add onChanged
    watcher.Created.Add onChanged
    watcher.Deleted.Add onChanged
    watcher.Renamed.Add onChanged
    watcher
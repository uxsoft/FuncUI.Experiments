module Avalonia.FuncUI.Experiments.DSL.Canvas

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Panel
   
type CanvasBuilder<'t when 't :> Canvas>() =
    inherit PanelBuilder<'t>()     
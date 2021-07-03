module Avalonia.FuncUI.Experiments.DSL.GridSplitter

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Thumb
 
type GridSplitterBuilder<'t when 't :> GridSplitter>() =
    inherit ThumbBuilder<'t>()
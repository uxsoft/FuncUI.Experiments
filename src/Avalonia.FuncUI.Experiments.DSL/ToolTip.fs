module Avalonia.FuncUI.Experiments.DSL.ToolTip 

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.ContentControl

type ToolTipBuilder<'t when 't :> ToolTip>() =
    inherit ContentControlBuilder<'t>()
module Avalonia.FuncUI.Experiments.DSL.ContextMenu

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.MenuBase
 
type ContextMenuBuilder<'t when 't :> ContextMenu>() =
    inherit MenuBaseBuilder<'t>()
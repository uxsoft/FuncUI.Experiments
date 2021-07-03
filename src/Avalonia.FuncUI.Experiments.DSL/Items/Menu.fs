module Avalonia.FuncUI.Experiments.DSL.Menu

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.MenuBase
 
type MenuBuilder<'t when 't :> Menu>() =
    inherit MenuBaseBuilder<'t>()
    
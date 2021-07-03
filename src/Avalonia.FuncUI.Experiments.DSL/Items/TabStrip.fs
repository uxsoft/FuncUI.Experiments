module Avalonia.FuncUI.Experiments.DSL.TabStrip

open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Experiments.DSL.SelectingItemsControl

type TabStripBuilder<'t when 't :> TabStrip>() =
    inherit SelectingItemsControlBuilder<'t>()
    
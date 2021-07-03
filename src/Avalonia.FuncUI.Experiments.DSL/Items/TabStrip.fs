module Avalonia.FuncUI.Experiments.DSL.TabStrip

open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Experiments.DSL.SelectingItemsControl
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type TabStripBuilder<'t when 't :> TabStrip>() =
    inherit SelectingItemsControlBuilder<'t>()
    
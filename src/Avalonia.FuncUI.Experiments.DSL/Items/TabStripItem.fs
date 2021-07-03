module Avalonia.FuncUI.Experiments.DSL.TabStripItem

open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Experiments.DSL.ListBoxItem
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type TabStripItemBuilder<'t when 't :> TabStripItem>() =
    inherit ListBoxItemBuilder<'t>()
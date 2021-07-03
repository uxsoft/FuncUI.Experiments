module Avalonia.FuncUI.Experiments.DSL.TabStripItem

open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Experiments.DSL.ListBoxItem

type TabStripItemBuilder<'t when 't :> TabStripItem>() =
    inherit ListBoxItemBuilder<'t>()
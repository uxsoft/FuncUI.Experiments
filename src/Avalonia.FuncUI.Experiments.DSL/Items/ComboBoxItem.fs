module Avalonia.FuncUI.Experiments.DSL.ComboBoxItem

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.ListBoxItem

type ComboBoxItemBuilder<'t when 't :> ComboBoxItem>() =
    inherit ListBoxItemBuilder<'t>()
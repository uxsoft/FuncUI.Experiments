module Avalonia.FuncUI.Experiments.DSL.ComboBoxItem

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.ListBoxItem
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type ComboBoxItemBuilder<'t when 't :> ComboBoxItem>() =
    inherit ListBoxItemBuilder<'t>()
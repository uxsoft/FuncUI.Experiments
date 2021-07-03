module Avalonia.FuncUI.Experiments.DSL.RadioButton

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.ToggleButton
open Avalonia.FuncUI.Builder

type RadioButtonBuilder<'t when 't :> RadioButton>() =
    inherit ToggleButtonBuilder<'t>()

    member _.groupName<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(RadioButton.GroupNameProperty, value, ValueNone) ]
    
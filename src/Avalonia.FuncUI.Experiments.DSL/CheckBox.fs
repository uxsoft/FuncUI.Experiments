module Avalonia.FuncUI.Experiments.DSL.CheckBox

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.Controls
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type CheckBoxBuilder() = 
    inherit DSLBuilder<CheckBox>()

    member _.Run(x: DSLElement<CheckBox>) = 
        ViewBuilder.Create<CheckBox>(x.Attributes)


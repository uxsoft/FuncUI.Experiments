module Avalonia.FuncUI.Experiments.DSL.CheckBox

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.ToggleButton

type CheckBoxBuilder<'t when 't :> CheckBox>() = 
    inherit ToggleButtonBuilder<'t>()

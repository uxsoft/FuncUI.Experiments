module Avalonia.FuncUI.Experiments.DSL.CheckBox

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.ToggleButton
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type CheckBoxBuilder<'t when 't :> CheckBox>() = 
    inherit ToggleButtonBuilder<'t>()

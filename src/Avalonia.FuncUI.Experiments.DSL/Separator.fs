module Avalonia.FuncUI.Experiments.DSL.Separator

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl

type SeparatorBuilder<'t when 't :> Separator>() =
    inherit TemplatedControlBuilder<'t>()
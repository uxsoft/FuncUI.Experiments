module Avalonia.FuncUI.Experiments.DSL.Primitives.ItemsControl

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl

type ItemsControlBuilder<'t when 't :> ItemsControl>() =
    inherit TemplatedControlBuilder<'t>()
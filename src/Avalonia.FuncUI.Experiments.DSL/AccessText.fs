module Avalonia.FuncUI.Experiments.DSL.AccessText

open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Experiments.DSL.TextBlock

type AccessTextBuilder<'t when 't :> AccessText>() =
    inherit TextBlockBuilder<'t>()


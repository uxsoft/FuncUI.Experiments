module Avalonia.FuncUI.Experiments.DSL.Rectangle

open Avalonia.Controls.Shapes
open Avalonia.FuncUI.Experiments.DSL.Shape

type RectangleBuilder<'t when 't :> Rectangle>() =
    inherit ShapeBuilder<'t>()
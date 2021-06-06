module Avalonia.FuncUI.Experiments.DSL.Ellipse

open Avalonia.Controls.Shapes
open Avalonia.FuncUI.Experiments.DSL.Shape

type EllipseBuilder<'t when 't :> Ellipse>() =
    inherit ShapeBuilder<'t>()
   
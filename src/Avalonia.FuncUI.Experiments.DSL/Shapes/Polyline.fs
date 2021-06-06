module Avalonia.FuncUI.Experiments.DSL.Polyline

open System.Collections.Generic
open Avalonia
open Avalonia.Controls.Shapes
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Shape
open Avalonia.FuncUI.Types

 
type PolylineBuilder<'t when 't :> Polyline>() =
    inherit ShapeBuilder<'t>()

    [<CustomOperation("points")>]
    member _.points<'t>(x: DSLElement<'t>, points: IList<Point>) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IList<Point>>(Polyline.PointsProperty, points, ValueNone) ]
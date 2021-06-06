module Avalonia.FuncUI.Experiments.DSL.Path

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Shape
open Avalonia.Media
open Avalonia.Controls.Shapes
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Types
 
type PathBuilder<'t when 't :> Path>() =
    inherit ShapeBuilder<'t>()
    
    [<CustomOperation("data")>]
    member _.data<'t>(x: DSLElement<'t>, geometry: Geometry) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Geometry>(Path.DataProperty, geometry, ValueNone) ]
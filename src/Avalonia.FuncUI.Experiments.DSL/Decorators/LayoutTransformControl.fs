module Avalonia.FuncUI.Experiments.DSL.LayoutTransformControl

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Decorator
open Avalonia.Media
open Avalonia.Controls
open Avalonia.FuncUI.Builder

type LayoutTransformControlBuilder<'t when 't :> LayoutTransformControl>() =
    inherit DecoratorBuilder<'t>()
    
    [<CustomOperation("layoutTransform")>]
    member _.layoutTransform<'t>(x: DSLElement<'t>, value: Transform) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Transform>(LayoutTransformControl.LayoutTransformProperty, value, ValueNone) ]
        
    [<CustomOperation("useRenderTransform")>]
    member _.useRenderTransform<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(LayoutTransformControl.UseRenderTransformProperty, value, ValueNone) ]
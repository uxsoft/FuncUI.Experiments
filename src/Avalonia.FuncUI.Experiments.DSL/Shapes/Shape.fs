namespace Avalonia.FuncUI.Experiments.DSL
open Avalonia.Collections
open Avalonia.Media.Immutable

[<AutoOpen>]
module Shape =
    open Avalonia.Controls.Shapes
    open Avalonia.Media
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder

    type Shape with

        static member fill<'t when 't :> Shape>(brush: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(Shape.FillProperty, brush, ValueNone)
            
        static member fill<'t when 't :> Shape>(color: string) =
            color |> Color.Parse |> ImmutableSolidColorBrush |> Shape.fill
        
        static member stretch<'t when 't :> Shape>(value: Stretch) =
            AttrBuilder<'t>.CreateProperty<Stretch>(Shape.StretchProperty, value, ValueNone)
            
        static member stroke<'t when 't :> Shape>(brush: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(Shape.StrokeProperty, brush, ValueNone)
            
        static member stroke<'t when 't :> Shape>(color: string) =
            color |> Color.Parse |> ImmutableSolidColorBrush |> Shape.stroke
            
        static member strokeThickness<'t when 't :> Shape>(value: double) =
            AttrBuilder<'t>.CreateProperty<double>(Shape.StrokeThicknessProperty, value, ValueNone)
            
        static member strokeDashArray<'t when 't :> Shape>(value: AvaloniaList<double>) =
            AttrBuilder<'t>.CreateProperty<AvaloniaList<double>>(Shape.StrokeDashArrayProperty, value, ValueNone)
            
        static member strokeDashArray<'t when 't :> Shape>(value: double list) =
            value |> AvaloniaList |> Shape.strokeDashArray
            
        static member strokeDashOffset<'t when 't :> Shape>(value: double) =
            AttrBuilder<'t>.CreateProperty<double>(Shape.StrokeDashOffsetProperty, value, ValueNone)
            
        static member strokeLineCap<'t when 't :> Shape>(value: PenLineCap) =
            AttrBuilder<'t>.CreateProperty<PenLineCap>(Shape.StrokeLineCapProperty, value, ValueNone)

        static member strokeJoinCap<'t when 't :> Shape>(value: PenLineJoin) =
            AttrBuilder<'t>.CreateProperty<PenLineJoin>(Shape.StrokeJoinProperty, value, ValueNone)
module Avalonia.FuncUI.Experiments.DSL.Border

open Avalonia
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Decorator
open Avalonia.FuncUI.Builder
open Avalonia.Media

type BorderBuilder<'t when 't :> Border>() =
    inherit DecoratorBuilder<'t>()
    
    [<CustomOperation("background")>] 
    member _.background<'t>(x: DSLElement<'t>, brush: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(Border.BackgroundProperty, brush, ValueNone) ]
        
    [<CustomOperation("borderBrush")>] 
    member _.borderBrush<'t>(x: DSLElement<'t>, brush: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(Border.BorderBrushProperty, brush, ValueNone) ]
        
    [<CustomOperation("borderThickness")>] 
    member _.borderThickness<'t>(x: DSLElement<'t>, value: Thickness) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Thickness>(Border.BorderThicknessProperty, value, ValueNone) ]
        
    [<CustomOperation("cornerRadius")>] 
    member _.cornerRadius<'t>(x: DSLElement<'t>, value: CornerRadius) =
        x @@ [ AttrBuilder<'t>.CreateProperty<CornerRadius>(Border.CornerRadiusProperty, value, ValueNone) ]
        
    [<CustomOperation("boxShadows")>] 
    member _.boxShadows<'t>(x: DSLElement<'t>, value: BoxShadows) =
        x @@ [ AttrBuilder<'t>.CreateProperty(Border.BoxShadowProperty, value, ValueNone) ]
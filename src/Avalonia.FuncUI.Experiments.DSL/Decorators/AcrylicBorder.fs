module Avalonia.FuncUI.Experiments.DSL.AcrylicBorder

open Avalonia
open Avalonia.Controls
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Decorator
open Avalonia.Media

type AcrylicBorderBuilder<'t when 't :> ExperimentalAcrylicBorder>() =
    inherit DecoratorBuilder<'t>()
    
    [<CustomOperation("cornerRadius")>] 
    member _.cornerRadius<'t>(x: DSLElement<'t>, value: CornerRadius) =
        x @@ [ AttrBuilder<'t>.CreateProperty<CornerRadius>(ExperimentalAcrylicBorder.CornerRadiusProperty, value, ValueNone) ]
        
    [<CustomOperation("material")>] 
    member _.material<'t>(x: DSLElement<'t>, value: ExperimentalAcrylicMaterial) =
        x @@ [ AttrBuilder<'t>.CreateProperty<ExperimentalAcrylicMaterial>(ExperimentalAcrylicBorder.MaterialProperty, value, ValueNone) ]
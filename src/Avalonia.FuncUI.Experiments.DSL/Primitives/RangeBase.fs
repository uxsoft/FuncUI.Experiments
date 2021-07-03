module Avalonia.FuncUI.Experiments.DSL.RangeBase

open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
 
type RangeBaseBuilder<'t when 't :> RangeBase>() =
    inherit TemplatedControlBuilder<'t>()

    [<CustomOperation("minimum")>] 
    member _.minimum<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(RangeBase.MinimumProperty, value, ValueNone) ]
            
    [<CustomOperation("maximum")>] 
    member _.maximum<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(RangeBase.MaximumProperty, value, ValueNone) ]
        
    [<CustomOperation("value")>] 
    member _.value<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(RangeBase.ValueProperty, value, ValueNone) ]

    [<CustomOperation("onValueChanged")>] 
    member _.onValueChanged<'t>(x: DSLElement<'t>, func: double -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<double>(RangeBase.ValueProperty, func) ]

    [<CustomOperation("smallChange")>] 
    member _.smallChange<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(RangeBase.SmallChangeProperty, value, ValueNone) ]
        
    [<CustomOperation("largeChange")>] 
    member _.largeChange<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(RangeBase.LargeChangeProperty, value, ValueNone) ]
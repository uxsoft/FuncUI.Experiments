module Avalonia.FuncUI.Experiments.DSL.Track

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Control
open Avalonia.Layout
open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
 
type TrackBuilder<'t when 't :> Track>() =
    inherit ControlBuilder<'t>()
    
    [<CustomOperation("minimum")>]
    member _.minimum<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(Track.MinimumProperty, value, ValueNone) ]
        
    [<CustomOperation("maximum")>]
    member _.maximum<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(Track.MaximumProperty, value, ValueNone) ]
        
    [<CustomOperation("value")>]
    member _.value<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(Track.ValueProperty, value, ValueNone) ]
        
    [<CustomOperation("onValueChanged")>]
    member _.onValueChanged<'t>(x: DSLElement<'t>, func: double -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<double>(Track.ValueProperty, func) ]

    [<CustomOperation("viewportSize")>]
    member _.viewportSize<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(Track.ViewportSizeProperty, value, ValueNone) ]
        
    [<CustomOperation("orientation")>]
    member _.orientation<'t>(x: DSLElement<'t>, orientation: Orientation) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Orientation>(Track.OrientationProperty, orientation, ValueNone) ]
        
    [<CustomOperation("isDirectionReversed")>]
    member _.isDirectionReversed<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(Track.IsDirectionReversedProperty, value, ValueNone) ]
        
    [<CustomOperation("thumb")>] 
    member _.thumb<'t, 'c when 't :> Track and 'c :> obj>(x: DSLElement<'t>, value: 'c) =
        let prop = 
            match box value with
            | :? IView as view -> AttrBuilder<'t>.CreateContentSingle(Track.ThumbProperty, Some view)
            | :? string as text -> AttrBuilder<'t>.CreateProperty<string>(Track.ThumbProperty, text, ValueNone)
            | _ -> AttrBuilder<'t>.CreateProperty<obj>(Track.ThumbProperty, value, ValueNone)
        
        x @@ [ prop ]
    
    [<CustomOperation("ignoreThumbDragProperty")>]
    member _.ignoreThumbDragProperty<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(Track.IgnoreThumbDragProperty, value, ValueNone) ]
    
    [<CustomOperation("increaseButton")>] 
    member _.increaseButton<'t, 'c when 't :> Track and 'c :> obj>(x: DSLElement<'t>, value: 'c) =
        let prop = 
            match box value with
            | :? IView as view -> AttrBuilder<'t>.CreateContentSingle(Track.IncreaseButtonProperty, Some view)
            | :? string as text -> AttrBuilder<'t>.CreateProperty<string>(Track.IncreaseButtonProperty, text, ValueNone)
            | _ -> AttrBuilder<'t>.CreateProperty<obj>(Track.IncreaseButtonProperty, value, ValueNone)
        
        x @@ [ prop ]
        
    [<CustomOperation("decreaseButton")>] 
    member _.decreaseButton<'t, 'c when 't :> Track and 'c :> obj>(x: DSLElement<'t>, value: 'c) =
        let prop = 
            match box value with
            | :? IView as view -> AttrBuilder<'t>.CreateContentSingle(Track.DecreaseButtonProperty, Some view)
            | :? string as text -> AttrBuilder<'t>.CreateProperty<string>(Track.DecreaseButtonProperty, text, ValueNone)
            | _ -> AttrBuilder<'t>.CreateProperty<obj>(Track.DecreaseButtonProperty, value, ValueNone)
        
        x @@ [ prop ]
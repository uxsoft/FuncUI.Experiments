module Avalonia.FuncUI.Experiments.DSL.Slider

open Avalonia.Collections
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.RangeBase
open Avalonia.Layout
open Avalonia.FuncUI.Builder

type SliderBuilder<'t when 't :> Slider>() =
    inherit RangeBaseBuilder<'t>()

    /// <summary>
    /// Sets the orientation of a <see cref="Slider"/>.
    /// </summary>
    [<CustomOperation("orientation")>]
    member _.orientation<'t>(x: DSLElement<'t>, value: Orientation) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Orientation>(Slider.OrientationProperty, value, ValueNone) ]

    /// <summary>
    /// Sets a value that indicates whether the <see cref="Slider"/> automatically moves the <see cref="Thumb"/> to the closest tick mark.
    /// </summary>
    [<CustomOperation("isSnapToTickEnabled")>]
    member _.isSnapToTickEnabled<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(Slider.IsSnapToTickEnabledProperty, value, ValueNone) ]

    /// <summary>
    /// Sets the interval between tick marks.
    /// </summary>
    [<CustomOperation("tickFrequency")>]
    member _.tickFrequency<'t>(x: DSLElement<'t>, value: float) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float>(Slider.TickFrequencyProperty, value, ValueNone) ]

    [<CustomOperation("tickPlacement")>]
    member _.tickPlacement<'t>(x: DSLElement<'t>, value: TickPlacement) =
        x @@ [ AttrBuilder<'t>.CreateProperty<TickPlacement>(Slider.TickPlacementProperty, value, ValueNone) ]

    [<CustomOperation("ticks")>]
    member _.ticks<'t>(x: DSLElement<'t>, value: float seq) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float AvaloniaList>(Slider.TicksProperty, AvaloniaList value, ValueNone) ]
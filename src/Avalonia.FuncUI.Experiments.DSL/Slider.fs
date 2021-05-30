﻿namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module Slider =
    open Avalonia.Collections
    open Avalonia.Controls
    open Avalonia.Layout
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<Slider> list): IView<Slider> =
        ViewBuilder.Create<Slider>(attrs)

    type Slider with            

        /// <summary>
        /// Sets the orientation of a <see cref="Slider"/>.
        /// </summary>
        static member orientation<'t when 't :> Slider>(value: Orientation) =
            AttrBuilder<'t>.CreateProperty<Orientation>(Slider.OrientationProperty, value, ValueNone)

        /// <summary>
        /// Sets a value that indicates whether the <see cref="Slider"/> automatically moves the <see cref="Thumb"/> to the closest tick mark.
        /// </summary>
        static member isSnapToTickEnabled<'t when 't :> Slider>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(Slider.IsSnapToTickEnabledProperty, value, ValueNone)

        /// <summary>
        /// Sets the interval between tick marks.
        /// </summary>
        static member tickFrequency<'t when 't :> Slider>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(Slider.TickFrequencyProperty, value, ValueNone)

        static member tickPlacement<'t when 't :> Slider>(value: TickPlacement) =
            AttrBuilder<'t>.CreateProperty<TickPlacement>(Slider.TickPlacementProperty, value, ValueNone)

        static member ticks<'t when 't :> Slider>(value: AvaloniaList<float>) =
            AttrBuilder<'t>.CreateProperty<float AvaloniaList>(Slider.TicksProperty, value, ValueNone)

        static member ticks<'t when 't :> Slider>(value: seq<float>) =
            value |> AvaloniaList |> Slider.ticks
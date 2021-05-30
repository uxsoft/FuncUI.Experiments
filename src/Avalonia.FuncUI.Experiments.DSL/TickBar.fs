namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module TickBar = 
    open Avalonia
    open Avalonia.Collections
    open Avalonia.Controls
    open Avalonia.Media
    open Avalonia.Media.Immutable
    open Avalonia.Layout
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<TickBar> list): IView<TickBar> =
        ViewBuilder.Create<TickBar>(attrs)
     
    type TickBar with

        static member fill<'t when 't :> TickBar>(value: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(TickBar.FillProperty, value, ValueNone)

        static member fill<'t when 't :> TickBar>(value: Color) =
            value |> ImmutableSolidColorBrush |> TickBar.fill

        static member fill<'t when 't :> TickBar>(color: string) =
            color |> Color.Parse |> TickBar.fill

        static member isDirectionReversed<'t when 't :> TickBar>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(TickBar.IsDirectionReversedProperty, value, ValueNone)

        static member maximum<'t when 't :> TickBar>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(TickBar.MaximumProperty, value, ValueNone)

        static member minimum<'t when 't :> TickBar>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(TickBar.MinimumProperty, value, ValueNone)

        static member orientation<'t when 't :> TickBar>(value: Orientation) =
            AttrBuilder<'t>.CreateProperty<Orientation>(TickBar.OrientationProperty, value, ValueNone)

        static member placement<'t when 't :> TickBar>(value: TickBarPlacement) =
            AttrBuilder<'t>.CreateProperty<TickBarPlacement>(TickBar.PlacementProperty, value, ValueNone)

        static member reservedSpace<'t when 't :> TickBar>(value: Rect) =
            AttrBuilder<'t>.CreateProperty<Rect>(TickBar.ReservedSpaceProperty, value, ValueNone)

        static member tickFrequency<'t when 't :> TickBar>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(TickBar.TickFrequencyProperty, value, ValueNone)

        static member ticks<'t when 't :> TickBar>(value: AvaloniaList<float>) =
            AttrBuilder<'t>.CreateProperty<float AvaloniaList>(TickBar.TicksProperty, value, ValueNone)

        static member ticks<'t when 't :> TickBar>(value: seq<float>) =
            value |> AvaloniaList |> TickBar.ticks

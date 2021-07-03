module Avalonia.FuncUI.Experiments.DSL.ScrollViewer

open Avalonia
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.ContentControl
open Avalonia.FuncUI.Builder

type ScrollViewerBuilder<'t when 't :> ScrollViewer>() =
    inherit ContentControlBuilder<'t>()

    [<CustomOperation("allowAutoHide")>]
    member _.allowAutoHide<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(ScrollViewer.AllowAutoHideProperty, value, ValueNone) ]
    
    /// <summary>
    /// Sets the extent of the scrollable content.
    /// </summary>
    [<CustomOperation("extent")>]
    member _.extent<'t>(x: DSLElement<'t>, value: Size) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Size>(ScrollViewer.ExtentProperty, value, ValueNone) ]

    [<CustomOperation("isExpanded")>]
    member _.isExpanded<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(ScrollViewer.IsExpandedProperty, value, ValueNone) ]

    [<CustomOperation("largeChange")>]
    member _.largeChange<'t>(x: DSLElement<'t>, value: Size) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Size>(ScrollViewer.LargeChangeProperty, value, ValueNone) ]

    /// <summary>
    /// Sets the current scroll offset.
    /// </summary>
    [<CustomOperation("offset")>]
    member _.offset<'t>(x: DSLElement<'t>, value: Vector) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Vector>(ScrollViewer.OffsetProperty, value, ValueNone) ]

    [<CustomOperation("onScrollChanged")>]
    member _.onScrollChanged<'t>(x: DSLElement<'t>, func: ScrollChangedEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<ScrollChangedEventArgs>(ScrollViewer.ScrollChangedEvent, func) ]

    [<CustomOperation("smallChange")>]
    member _.smallChange<'t>(x: DSLElement<'t>, value: Size) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Size>(ScrollViewer.SmallChangeProperty, value, ValueNone) ]

    /// <summary>
    /// Sets the size of the viewport on the scrollable content.
    /// </summary>
    [<CustomOperation("viewport")>]
    member _.viewport<'t>(x: DSLElement<'t>, value: Size) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Size>(ScrollViewer.ViewportProperty, value, ValueNone) ]
        
    /// <summary>
    /// Sets the vertical scrollbar value.
    /// </summary>
    [<CustomOperation("verticalScrollBarValue")>]
    member _.verticalScrollBarValue<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(ScrollViewer.VerticalScrollBarValueProperty, value, ValueNone) ]
        
     /// <summary>
    /// Sets the horizontal scrollbar value.
    /// </summary>
    [<CustomOperation("horizontalScrollBarValue")>]
    member _.horizontalScrollBarValue<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(ScrollViewer.HorizontalScrollBarValueProperty, value, ValueNone) ]
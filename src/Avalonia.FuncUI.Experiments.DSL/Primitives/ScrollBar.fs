module Avalonia.FuncUI.Experiments.DSL.ScrollBar

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.Layout
open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Experiments.DSL.RangeBase

type ScrollBarBuilder<'t when 't :> ScrollBar>() =
    inherit RangeBaseBuilder<'t>()

    [<CustomOperation("allowAutoHide")>]
    member _.allowAutoHide<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(ScrollBar.AllowAutoHideProperty, value, ValueNone) ]

    [<CustomOperation("isExpanded")>]
    member _.isExpanded<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(ScrollBar.IsExpandedProperty, value, ValueNone) ]
    
    /// <summary>
    /// Sets the amount of the scrollable content that is currently visible.
    /// </summary>
    [<CustomOperation("viewportSize")>]
    member _.viewportSize<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(ScrollBar.ViewportSizeProperty, value, ValueNone) ]
        
    /// <summary>
    /// Sets a value that indicates whether the scrollbar should hide itself when it is not needed.
    /// </summary>    
    [<CustomOperation("visibility")>]
    member _.visibility<'t>(x: DSLElement<'t>, visibility: ScrollBarVisibility) =
        x @@ [ AttrBuilder<'t>.CreateProperty<ScrollBarVisibility>(ScrollBar.VisibilityProperty, visibility, ValueNone) ]

    /// <summary>
    /// Sets the orientation of the scrollbar.
    /// </summary>
    [<CustomOperation("orientation")>]
    member _.orientation<'t>(x: DSLElement<'t>, orientation: Orientation) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Orientation>(ScrollBar.OrientationProperty, orientation, ValueNone) ]
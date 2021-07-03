module Avalonia.FuncUI.Experiments.DSL.ProgressBar

open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.RangeBase
open Avalonia.Layout
open Avalonia.Controls
open Avalonia.FuncUI.Builder

type ProgressBarBuilder<'t when 't :> ProgressBar>() =
    inherit RangeBaseBuilder<'t>()

    [<CustomOperation("isIndeterminate")>]
    member _.isIndeterminate<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(ProgressBar.IsIndeterminateProperty, value, ValueNone) ]

    [<CustomOperation("orientation")>]
    member _.orientation<'t>(x: DSLElement<'t>, value: Orientation) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Orientation>(ProgressBar.OrientationProperty, value, ValueNone) ]

    [<CustomOperation("showProgressText")>]
    member _.showProgressText<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(ProgressBar.ShowProgressTextProperty, value, ValueNone) ]

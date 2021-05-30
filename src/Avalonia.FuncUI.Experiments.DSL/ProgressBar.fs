﻿namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module ProgressBar =
    open Avalonia.Layout
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<ProgressBar> list): IView<ProgressBar> =
        ViewBuilder.Create<ProgressBar>(attrs)

    type ProgressBar with

        static member isIndeterminate<'t when 't :> ProgressBar>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(ProgressBar.IsIndeterminateProperty, value, ValueNone)

        static member orientation<'t when 't :> ProgressBar>(value: Orientation) =
            AttrBuilder<'t>.CreateProperty<Orientation>(ProgressBar.OrientationProperty, value, ValueNone)

        static member showProgressText<'t when 't :> ProgressBar>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(ProgressBar.ShowProgressTextProperty, value, ValueNone)

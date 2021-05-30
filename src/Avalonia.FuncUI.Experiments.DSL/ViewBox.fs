﻿namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module ViewBox =
    open Avalonia.Controls
    open Avalonia.Media
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<Viewbox> list): IView<Viewbox> =
        ViewBuilder.Create<Viewbox>(attrs)

    type Viewbox with

        /// <summary>
        /// Sets the stretch mode, which determines how child fits into the available space.
        /// </summary>
        static member stretch<'t when 't :> Viewbox>(value: Stretch) =
            AttrBuilder<'t>.CreateProperty<Stretch>(Viewbox.StretchProperty, value, ValueNone)

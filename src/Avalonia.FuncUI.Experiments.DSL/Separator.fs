﻿namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module Separator =
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<Separator> list): IView<Separator> =
        ViewBuilder.Create<Separator>(attrs)

    type Separator with
        end
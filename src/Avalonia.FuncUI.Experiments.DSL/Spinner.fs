﻿namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module Spinner =
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<Spinner> list): IView<Spinner> =
        ViewBuilder.Create<Spinner>(attrs)

    type Spinner with

        /// <summary>
        /// Sets <see cref="ValidSpinDirections"/> allowed for this control.
        /// </summary>
        static member validSpinDirection<'t when 't :> Spinner>(value: ValidSpinDirections) =
            AttrBuilder<'t>.CreateProperty<ValidSpinDirections>(Spinner.ValidSpinDirectionProperty, value, ValueNone)
        
        /// <summary>
        /// Occurs when spinning is initiated by the end-user.
        /// </summary>
        static member onSpin<'t when 't :> Spinner>(func: SpinEventArgs -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<SpinEventArgs>(Spinner.SpinEvent, func, ?subPatchOptions = subPatchOptions)


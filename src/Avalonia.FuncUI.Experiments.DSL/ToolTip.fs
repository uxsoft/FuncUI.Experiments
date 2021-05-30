﻿namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module ToolTip =
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<ToolTip> list): IView<ToolTip> =
        ViewBuilder.Create<ToolTip>(attrs)

    type Control with

        /// <summary>
        /// A value indicating whether the tool tip is visible.
        /// </summary>
        static member isOpen<'t when 't :> Control>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(ToolTip.IsOpenProperty, value, ValueNone)
       
        /// <summary>
        /// The content to be displayed in the control's tooltip.
        /// </summary>
        static member tip<'t when 't :> Control>(value: string) =
            AttrBuilder<'t>.CreateProperty<string>(ToolTip.TipProperty, value, ValueNone)

        /// <summary>
        /// The content to be displayed in the control's tooltip.
        /// </summary>
        static member tip<'t when 't :> Control>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(ToolTip.TipProperty, value, ValueNone)
            
        /// <summary>
        /// The content to be displayed in the control's tooltip.
        /// </summary>
        static member tip<'t when 't :> Control>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(ToolTip.TipProperty, value)

        /// <summary>
        /// The content to be displayed in the control's tooltip.
        /// </summary>
        static member tip<'t when 't :> Control>(value: IView) =
            value |> Some |> ToolTip.tip

        /// <summary>
        /// A value indicating how the tool tip is positioned.
        /// </summary>
        static member placement<'t when 't :> Control>(value: PlacementMode) =
            AttrBuilder<'t>.CreateProperty<PlacementMode>(ToolTip.PlacementProperty, value, ValueNone)

        /// <summary>
        /// A value indicating how the tool tip is positioned.
        /// </summary>
        static member horizontalOffset<'t when 't :> Control>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(ToolTip.HorizontalOffsetProperty, value, ValueNone)

        /// <summary>
        /// A value indicating how the tool tip is positioned.
        /// </summary>
        static member verticalOffset<'t when 't :> Control>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(ToolTip.VerticalOffsetProperty, value, ValueNone)

        /// <summary>
        /// A value indicating the time, in milliseconds, before a tool tip opens.
        /// </summary>
        static member showDelay<'t when 't :> Control>(value: int) =
            AttrBuilder<'t>.CreateProperty<int>(ToolTip.ShowDelayProperty, value, ValueNone)

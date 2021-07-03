namespace Avalonia.FuncUI.Experiments.DSL


[<AutoOpen>]
module Popup =
    open Avalonia
    open Avalonia.Controls
    open Avalonia.Controls.Primitives
    open Avalonia.Controls.Primitives.PopupPositioning
    open Avalonia.FuncUI.Builder
    open Avalonia.FuncUI.Types
    open System

    let create (attrs: IAttr<Popup> list): IView<Popup> =
        ViewBuilder.Create<Popup>(attrs)
    
    type Popup with
        
        static member child<'t when 't :> Popup>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(Popup.ChildProperty, value)
        
        static member child<'t when 't :> Popup>(value: IView) =
            value |> Some |> Popup.child
            
        static member isOpen<'t when 't :> Popup>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(Popup.IsOpenProperty, value, ValueNone)
            
        static member isLightDismissEnabled<'t when 't :> Popup>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(Popup.IsLightDismissEnabledProperty, value, ValueNone)
            
        static member topmost<'t when 't :> Popup>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(Popup.TopmostProperty, value, ValueNone)

        static member placementAnchor<'t when 't :> Popup>(value: PopupAnchor) =
            AttrBuilder<'t>.CreateProperty<PopupAnchor>(Popup.PlacementModeProperty, value, ValueNone)
            
        static member placementConstraintAdjustment<'t when 't :> Popup>(value: PopupPositionerConstraintAdjustment) =
            AttrBuilder<'t>.CreateProperty<PopupPositionerConstraintAdjustment>(Popup.PlacementConstraintAdjustmentProperty, value, ValueNone)

        static member placementGravity<'t when 't :> Popup>(value: PopupGravity) =
            AttrBuilder<'t>.CreateProperty<PopupGravity>(Popup.PlacementGravityProperty, value, ValueNone)

        static member placementRect<'t when 't :> Popup>(value: Nullable<Rect>) =
            AttrBuilder<'t>.CreateProperty<Rect Nullable>(Popup.PlacementRectProperty, value, ValueNone)

        static member placementRect<'t when 't :> Popup>(value: Rect) =
            value |> Nullable |> Popup.placementRect

        static member placementRect<'t when 't :> Popup>(value: Rect option) =
            value |> Option.toNullable |> Popup.placementRect

        static member placementMode<'t when 't :> Popup>(value: PlacementMode) =
            AttrBuilder<'t>.CreateProperty<PlacementMode>(Popup.PlacementModeProperty, value, ValueNone)
            
        static member placementTarget<'t when 't :> Popup>(value: Control) =
            AttrBuilder<'t>.CreateProperty<Control>(Popup.PlacementTargetProperty, value, ValueNone)
            
        static member verticalOffset<'t when 't :> Popup>(value: double) =
            AttrBuilder<'t>.CreateProperty<double>(Popup.VerticalOffsetProperty, value, ValueNone)
            
        static member horizontalOffset<'t when 't :> Popup>(value: double) =
            AttrBuilder<'t>.CreateProperty<double>(Popup.HorizontalOffsetProperty, value, ValueNone)

        static member windowManagerAddShadowHint<'t when 't :> Popup>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(Popup.WindowManagerAddShadowHintProperty, value, ValueNone)
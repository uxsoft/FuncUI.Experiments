namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module LayoutTransformControl =
    open Avalonia.Media
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<LayoutTransformControl> list): IView<LayoutTransformControl> =
        ViewBuilder.Create<LayoutTransformControl>(attrs)

    type LayoutTransformControl with
        static member layoutTransform<'t when 't :> LayoutTransformControl>(value: Transform) =
            AttrBuilder<'t>.CreateProperty<Transform>(LayoutTransformControl.LayoutTransformProperty, value, ValueNone)
            
        static member useRenderTransform<'t when 't :> LayoutTransformControl>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(LayoutTransformControl.UseRenderTransformProperty, value, ValueNone)
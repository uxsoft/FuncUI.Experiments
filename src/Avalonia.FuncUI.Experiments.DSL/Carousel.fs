namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module Carousel =
    open Avalonia.Animation
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<Carousel> list): IView<Carousel> =
        ViewBuilder.Create<Carousel>(attrs)
     
    type Carousel with

        static member isVirtualized<'t when 't :> Carousel>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(Carousel.IsVirtualizedProperty, value, ValueNone)
        
        static member pageTransition<'t when 't :> Carousel>(transition: IPageTransition) =
            AttrBuilder<'t>.CreateProperty<IPageTransition>(Carousel.PageTransitionProperty, transition, ValueNone)
namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module HeaderedSelectingItemsControl =
    open Avalonia.Controls.Primitives
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<HeaderedSelectingItemsControl> list): IView<HeaderedSelectingItemsControl> =
        ViewBuilder.Create<HeaderedSelectingItemsControl>(attrs)
    
    type HeaderedSelectingItemsControl with
        static member header<'t when 't :> HeaderedSelectingItemsControl>(text: string) =
            AttrBuilder<'t>.CreateProperty<string>(HeaderedSelectingItemsControl.HeaderProperty, text, ValueNone)
            
        static member header<'t when 't :> HeaderedSelectingItemsControl>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(HeaderedSelectingItemsControl.HeaderProperty, value, ValueNone)
            
        static member header<'t when 't :> HeaderedSelectingItemsControl>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(HeaderedSelectingItemsControl.HeaderProperty, value)
            
        static member header<'t when 't :> HeaderedSelectingItemsControl>(value: IView) =
            value |> Some |> HeaderedSelectingItemsControl.header
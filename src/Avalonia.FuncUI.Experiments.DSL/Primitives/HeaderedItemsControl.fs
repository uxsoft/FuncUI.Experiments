namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module HeaderedItemsControl =
    open Avalonia.Controls.Primitives
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<HeaderedItemsControl> list): IView<HeaderedItemsControl> =
        ViewBuilder.Create<HeaderedItemsControl>(attrs)
            
    type HeaderedItemsControl with
    
        static member header<'t when 't :> HeaderedItemsControl>(text: string) =
            AttrBuilder<'t>.CreateProperty<string>(HeaderedItemsControl.HeaderProperty, text, ValueNone)
            
        static member header<'t when 't :> HeaderedItemsControl>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(HeaderedItemsControl.HeaderProperty, value, ValueNone)
            
        static member header<'t when 't :> HeaderedItemsControl>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(HeaderedItemsControl.HeaderProperty, value)
            
        static member header<'t when 't :> HeaderedItemsControl>(value: IView) =
            value |> Some |> HeaderedItemsControl.header
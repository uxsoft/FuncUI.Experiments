namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module ContentControl =  
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    open Avalonia.Controls.Templates
    open Avalonia.Layout

    let create (attrs : IAttr<ContentControl> list) : IView<ContentControl> =
        ViewBuilder.Create<ContentControl>(attrs)

    type ContentControl with
        static member content<'t when 't :> ContentControl>(text: string) =
            AttrBuilder<'t>.CreateProperty<string>(ContentControl.ContentProperty, text, ValueNone)
            
        static member content<'t when 't :> ContentControl>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(ContentControl.ContentProperty, value, ValueNone)
            
        static member content<'t when 't :> ContentControl>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(ContentControl.ContentProperty, value)
            
        static member content<'t when 't :> ContentControl>(value: IView) =
            value |> Some |> ContentControl.content
            
        static member contentTemplate<'t when 't :> ContentControl>(value: IDataTemplate) =
            AttrBuilder<'t>.CreateProperty<IDataTemplate>(ContentControl.ContentTemplateProperty, value, ValueNone)

        static member horizontalAlignment<'t when 't :> ContentControl>(value: HorizontalAlignment) =
            AttrBuilder<'t>.CreateProperty<HorizontalAlignment>(ContentControl.HorizontalAlignmentProperty, value, ValueNone)
            
        static member verticalAlignment<'t when 't :> ContentControl>(value: VerticalAlignment) =
            AttrBuilder<'t>.CreateProperty<VerticalAlignment>(ContentControl.VerticalAlignmentProperty, value, ValueNone)
        
        static member horizontalContentAlignment<'t when 't :> ContentControl>(value: HorizontalAlignment) =
            AttrBuilder<'t>.CreateProperty<HorizontalAlignment>(ContentControl.HorizontalContentAlignmentProperty, value, ValueNone)

        static member verticalContentAlignment<'t when 't :> ContentControl>(value: VerticalAlignment) =
            AttrBuilder<'t>.CreateProperty<VerticalAlignment>(ContentControl.VerticalContentAlignmentProperty, value, ValueNone)

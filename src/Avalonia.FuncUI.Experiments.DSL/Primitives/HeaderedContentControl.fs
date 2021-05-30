namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module HeaderedContentControl =
    open Avalonia.Controls.Primitives
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    open Avalonia.Controls.Templates
     
    let create (attrs: IAttr<HeaderedContentControl> list): IView<HeaderedContentControl> =
        ViewBuilder.Create<HeaderedContentControl>(attrs)
     
    type HeaderedContentControl with
        static member header<'t when 't :> HeaderedContentControl>(text: string) =
            AttrBuilder<'t>.CreateProperty<string>(HeaderedContentControl.HeaderProperty, text, ValueNone)
            
        static member header<'t when 't :> HeaderedContentControl>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(HeaderedContentControl.HeaderProperty, value, ValueNone)
            
        static member header<'t when 't :> HeaderedContentControl>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(HeaderedContentControl.HeaderProperty, value)
            
        static member header<'t when 't :> HeaderedContentControl>(value: IView) =
            value |> Some |> HeaderedContentControl.header
            
        static member headerTemplate<'t when 't :> HeaderedContentControl>(value: IDataTemplate) =
            AttrBuilder<'t>.CreateProperty<IDataTemplate>(HeaderedContentControl.HeaderTemplateProperty, value, ValueNone)
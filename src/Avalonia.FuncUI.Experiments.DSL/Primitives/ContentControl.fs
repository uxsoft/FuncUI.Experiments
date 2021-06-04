module Avalonia.FuncUI.Experiments.DSL.ContentControl
  
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
open Avalonia.Controls.Templates
open Avalonia.Layout

type ContentControlBuilder<'t when 't :> ContentControl>() =
    inherit TemplatedControlBuilder<'t>()
    
    member inline x.Yield(text: string) =
        [ AttrBuilder<'t>.CreateProperty<string>(ContentControl.ContentProperty, text, ValueNone) ]
    
    member inline x.Yield(child: obj) =
        [ AttrBuilder<'t>.CreateProperty<obj>(ContentControl.ContentProperty, child, ValueNone) ]
        
    member inline x.Yield(child: IView) =
        [ AttrBuilder<'t>.CreateContentSingle(ContentControl.ContentProperty, Some child) ]
            
    [<CustomOperation("contentTemplate")>] 
    member _.contentTemplate<'t>(x: IAttr<'t> list, value: IDataTemplate) =
        x @ [ AttrBuilder<'t>.CreateProperty<IDataTemplate>(ContentControl.ContentTemplateProperty, value, ValueNone) ]

    [<CustomOperation("horizontalAlignment")>] 
    member _.horizontalAlignment<'t>(x: IAttr<'t> list, value: HorizontalAlignment) =
        x @ [ AttrBuilder<'t>.CreateProperty<HorizontalAlignment>(ContentControl.HorizontalAlignmentProperty, value, ValueNone) ]
        
    [<CustomOperation("verticalAlignment")>] 
    member _.verticalAlignment<'t>(x: IAttr<'t> list, value: VerticalAlignment) =
        x @ [ AttrBuilder<'t>.CreateProperty<VerticalAlignment>(ContentControl.VerticalAlignmentProperty, value, ValueNone) ]
    
    [<CustomOperation("horizontalContentAlignment")>] 
    member _.horizontalContentAlignment<'t>(x: IAttr<'t> list, value: HorizontalAlignment) =
        x @ [ AttrBuilder<'t>.CreateProperty<HorizontalAlignment>(ContentControl.HorizontalContentAlignmentProperty, value, ValueNone) ]

    [<CustomOperation("verticalContentAlignment")>] 
    member _.verticalContentAlignment<'t>(x: IAttr<'t> list, value: VerticalAlignment) =
        x @ [ AttrBuilder<'t>.CreateProperty<VerticalAlignment>(ContentControl.VerticalContentAlignmentProperty, value, ValueNone) ]

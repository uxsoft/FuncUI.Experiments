namespace Avalonia.FuncUI.Experiments.DSL.Control
  
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.InputElement
open Avalonia.FuncUI.Builder

type ControlBuilder<'t when 't :> Control>() =
    inherit InputElementBuilder<'t>()
    
    [<CustomOperation("focusAdorner")>] 
    member _.focusAdorner<'t, 'c when 'c :> IControl>(x: DSLElement<'t>, value: ITemplate<'c>) =
        x.attr <| AttrBuilder<'t>.CreateProperty<ITemplate<'c>>(Control.FocusAdornerProperty, value, ValueNone)
                                                      
    [<CustomOperation("tag")>]
    member _.tag<'t>(x: DSLElement<'t>, value: obj) =
        x.attr <| AttrBuilder<'t>.CreateProperty<obj>(Control.TagProperty, value, ValueNone)
    
    [<CustomOperation("contextMenu")>] 
    member _.contextMenu<'t>(x: DSLElement<'t>, menu: ContextMenu) =
        x.attr <| AttrBuilder<'t>.CreateProperty<ContextMenu>(Control.ContextMenuProperty, menu, ValueNone)

module Avalonia.FuncUI.Experiments.DSL.Control
  
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.InputElement
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Types
open Avalonia.Visuals.Media.Imaging

type ControlBuilder<'t when 't :> Control>() =
    inherit InputElementBuilder<'t>()
    
    [<CustomOperation("focusAdorner")>] 
    member _.focusAdorner<'t, 'c when 'c :> IControl>(x: IAttr<'t> list, value: ITemplate<'c>) =
        x @ [  AttrBuilder<'t>.CreateProperty<ITemplate<'c>>(Control.FocusAdornerProperty, value, ValueNone) ]
                                                      
    [<CustomOperation("tag")>]
    member _.tag<'t>(x: IAttr<'t> list, value: obj) =
        x @ [  AttrBuilder<'t>.CreateProperty<obj>(Control.TagProperty, value, ValueNone) ]
    
    [<CustomOperation("contextMenu")>] 
    member _.contextMenu<'t>(x: IAttr<'t> list, menu: ContextMenu) =
        x @ [  AttrBuilder<'t>.CreateProperty<ContextMenu>(Control.ContextMenuProperty, menu, ValueNone) ]
    
    [<CustomOperation("bitmapInterpolationMode")>]
    member _.bitmapInterpolationMode<'t>(x: IAttr<'t> list, mode: BitmapInterpolationMode) =
        x @ [  AttrBuilder<'t>.CreateProperty<BitmapInterpolationMode>(Avalonia.Media.RenderOptions.BitmapInterpolationModeProperty, mode, ValueNone) ]
    
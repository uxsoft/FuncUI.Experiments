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
    member _.focusAdorner<'t, 'c when 'c :> IControl>(x: DSLElement<'t>, value: ITemplate<'c>) =
        x @@ [  AttrBuilder<'t>.CreateProperty<ITemplate<'c>>(Control.FocusAdornerProperty, value, ValueNone) ]
                                                      
    [<CustomOperation("tag")>]
    member _.tag<'t>(x: DSLElement<'t>, value: obj) =
        x @@ [  AttrBuilder<'t>.CreateProperty<obj>(Control.TagProperty, value, ValueNone) ]
    
    [<CustomOperation("contextMenu")>] 
    member _.contextMenu<'t>(x: DSLElement<'t>, menu: ContextMenu) =
        x @@ [  AttrBuilder<'t>.CreateProperty<ContextMenu>(Control.ContextMenuProperty, menu, ValueNone) ]
    
    [<CustomOperation("bitmapInterpolationMode")>]
    member _.bitmapInterpolationMode<'t>(x: DSLElement<'t>, mode: BitmapInterpolationMode) =
        x @@ [  AttrBuilder<'t>.CreateProperty<BitmapInterpolationMode>(Avalonia.Media.RenderOptions.BitmapInterpolationModeProperty, mode, ValueNone) ]
    
    [<CustomOperation("dock")>]
    member _.dock<'t>(x: DSLElement<'t>, dock: Dock) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Dock>(DockPanel.DockProperty, dock, ValueNone) ]
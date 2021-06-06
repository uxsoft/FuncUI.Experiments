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
        
    [<CustomOperation("left")>] 
    member _.left<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(Canvas.LeftProperty, value, ValueNone) ]
        
    [<CustomOperation("top")>] 
    member _.top<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(Canvas.TopProperty, value, ValueNone) ]
        
    [<CustomOperation("right")>] 
    member _.right<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(Canvas.RightProperty, value, ValueNone) ]
        
    [<CustomOperation("bottom")>] 
    member _.bottom<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(Canvas.BottomProperty, value, ValueNone) ]
        
    [<CustomOperation("row")>] 
    member _.row<'t>(x: DSLElement<'t>, row: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(Grid.RowProperty, row, ValueNone) ]
        
    [<CustomOperation("rowSpan")>] 
    member _.rowSpan<'t>(x: DSLElement<'t>, span: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(Grid.RowSpanProperty, span, ValueNone) ]
        
    [<CustomOperation("column")>] 
    member _.column<'t>(x: DSLElement<'t>, column: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(Grid.ColumnProperty, column, ValueNone) ]
        
    [<CustomOperation("columnSpan")>] 
    member _.columnSpan<'t>(x: DSLElement<'t>, span: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(Grid.ColumnSpanProperty, span, ValueNone) ]
        
    [<CustomOperation("isSharedSizeScope")>] 
    member _.isSharedSizeScope<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(Grid.IsSharedSizeScopeProperty, value, ValueNone) ]
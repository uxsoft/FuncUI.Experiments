module Avalonia.FuncUI.Experiments.DSL.ComboBox

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.SelectingItemsControl
open Avalonia.Layout
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type ComboBoxBuilder<'t when 't :> ComboBox>() =
    inherit SelectingItemsControlBuilder<'t>() =
    
    member _.isDropDownOpen<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(ComboBox.IsDropDownOpenProperty, value, ValueNone) ]
        
    member _.horizontalContentAlignment<'t>(x: DSLElement<'t>, alignment: HorizontalAlignment) =
        x @@ [ AttrBuilder<'t>.CreateProperty<HorizontalAlignment>(ComboBox.HorizontalContentAlignmentProperty, alignment, ValueNone) ]
        
    member _.maxDropDownHeight<'t>(x: DSLElement<'t>, height: float) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float>(ComboBox.MaxDropDownHeightProperty, height, ValueNone) ]
        
    member _.verticalContentAlignment<'t>(x: DSLElement<'t>, alignment: VerticalAlignment) =
        x @@ [ AttrBuilder<'t>.CreateProperty<VerticalAlignment>(ComboBox.VerticalContentAlignmentProperty, alignment, ValueNone) ]
        
    member _.virtualizationMode<'t>(x: DSLElement<'t>, mode: ItemVirtualizationMode) =
        x @@ [ AttrBuilder<'t>.CreateProperty<ItemVirtualizationMode>(ComboBox.VirtualizationModeProperty, mode, ValueNone) ]
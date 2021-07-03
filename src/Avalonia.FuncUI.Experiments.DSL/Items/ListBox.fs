module Avalonia.FuncUI.Experiments.DSL.ListBox

open System.Collections
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.SelectingItemsControl
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

let create (attrs: IAttr<ListBox> list): IView<ListBox> =
    ViewBuilder.Create<ListBox>(attrs)
 
type ListBoxBuilder<'t when 't :> ListBox>() =
    inherit SelectingItemsControlBuilder<'t>()

    member _.selectedItems<'t>(x: DSLElement<'t>, items: IList) =
        x @@ [AttrBuilder<'t>.CreateProperty<IList>(ListBox.SelectedItemsProperty, items, ValueNone) ]

    member _.onSelectedItemsChanged<'t>(x: DSLElement<'t>, func: IList -> unit) =
        x @@ [AttrBuilder<'t>.CreateSubscription<IList>(ListBox.SelectedItemsProperty, func) ]
    
    member _.selectionMode<'t>(x: DSLElement<'t>, mode: SelectionMode) =
        x @@ [AttrBuilder<'t>.CreateProperty<SelectionMode>(ListBox.SelectionModeProperty, mode, ValueNone) ]
    
    member _.virtualizationMode<'t>(x: DSLElement<'t>, mode: ItemVirtualizationMode) =
        x @@ [AttrBuilder<'t>.CreateProperty<ItemVirtualizationMode>(ListBox.VirtualizationModeProperty, mode, ValueNone) ]
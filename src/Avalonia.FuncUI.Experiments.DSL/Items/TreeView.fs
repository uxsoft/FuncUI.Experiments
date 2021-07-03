module Avalonia.FuncUI.Experiments.DSL.TreeView

    open System.Collections
    open Avalonia.Controls
    open Avalonia.FuncUI.Experiments.DSL.Common
    open Avalonia.FuncUI.Experiments.DSL.ItemsControl
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder

    type TreeViewBuilder<'t when 't :> TreeView>() =
        inherit ItemsControlBuilder<'t>()

        /// <summary>
        /// Sets a value indicating whether to automatically scroll to newly selected items.
        /// </summary>
        [<CustomOperation("autoScrollToSelectedItem")>] 
        member _.autoScrollToSelectedItem<'t>(x: DSLElement<'t>, value: bool) =
            x @@ [ AttrBuilder<'t>.CreateProperty<bool>(TreeView.AutoScrollToSelectedItemProperty, value, ValueNone) ]
        
        /// <summary>
        /// Sets the selected items.
        /// </summary>
        [<CustomOperation("selectedItem")>] 
        member _.selectedItem<'t>(x: DSLElement<'t>, value: obj) =
            x @@ [ AttrBuilder<'t>.CreateProperty<obj>(TreeView.SelectedItemProperty, value, ValueNone) ]
         
        /// <summary>
        /// Sets the selected item.
        /// </summary>
        [<CustomOperation("selectedItems")>] 
        member _.selectedItems<'t>(x: DSLElement<'t>, value: IList) =
            x @@ [ AttrBuilder<'t>.CreateProperty<IList>(TreeView.SelectedItemsProperty, value, ValueNone) ]

        /// <summary>
        /// Sets the selection mode.
        /// </summary>
        [<CustomOperation("selectionMode")>] 
        member _.selectionMode<'t>(x: DSLElement<'t>, value: SelectionMode) =
            x @@ [ AttrBuilder<'t>.CreateProperty<SelectionMode>(TreeView.SelectionModeProperty, value, ValueNone) ]
namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module TreeView =
    open System.Collections
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<TreeView> list): IView<TreeView> =
        ViewBuilder.Create<TreeView>(attrs)

    type TreeView with

        /// <summary>
        /// Sets a value indicating whether to automatically scroll to newly selected items.
        /// </summary>
        static member autoScrollToSelectedItem<'t when 't :> TreeView>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(TreeView.AutoScrollToSelectedItemProperty, value, ValueNone)
        
        /// <summary>
        /// Sets the selected items.
        /// </summary>
        static member selectedItem<'t when 't :> TreeView>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(TreeView.SelectedItemProperty, value, ValueNone)
         
        /// <summary>
        /// Sets the selected item.
        /// </summary>
        static member selectedItems<'t when 't :> TreeView>(value: IList) =
            AttrBuilder<'t>.CreateProperty<IList>(TreeView.SelectedItemsProperty, value, ValueNone)

        /// <summary>
        /// Sets the selection mode.
        /// </summary>
        static member selectionMode<'t when 't :> TreeView>(value: SelectionMode) =
            AttrBuilder<'t>.CreateProperty<SelectionMode>(TreeView.SelectionModeProperty, value, ValueNone)
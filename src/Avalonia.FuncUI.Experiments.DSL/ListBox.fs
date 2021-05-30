namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module ListBox =
    open System.Collections
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<ListBox> list): IView<ListBox> =
        ViewBuilder.Create<ListBox>(attrs)
     
    type ListBox with

        static member selectedItems<'t when 't :> ListBox>(items: IList) =
            AttrBuilder<'t>.CreateProperty<IList>(ListBox.SelectedItemsProperty, items, ValueNone)

        static member onSelectedItemsChanged<'t when 't :> ListBox>(func: IList -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<IList>(ListBox.SelectedItemsProperty, func, ?subPatchOptions = subPatchOptions)
        
        static member selectionMode<'t when 't :> ListBox>(mode: SelectionMode) =
            AttrBuilder<'t>.CreateProperty<SelectionMode>(ListBox.SelectionModeProperty, mode, ValueNone)
        
        static member virtualizationMode<'t when 't :> ListBox>(mode: ItemVirtualizationMode) =
            AttrBuilder<'t>.CreateProperty<ItemVirtualizationMode>(ListBox.VirtualizationModeProperty, mode, ValueNone)
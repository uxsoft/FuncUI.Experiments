module Avalonia.FuncUI.Experiments.DSL.AutoCompleteBox

open System
open System.Collections
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.Controls
open Avalonia.Controls.Templates    
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type AutoCompleteBoxBuilder<'t when 't :> AutoCompleteBox>() =
    inherit TemplatedControlBuilder<'t>()
    
    [<CustomOperation("onSelectionChanged")>] 
    member _.onSelectionChanged<'t>(x: DSLElement<'t>, func: SelectionChangedEventArgs -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<_>(AutoCompleteBox.SelectionChangedEvent, func) ]
    
    [<CustomOperation("watermark")>] 
    member _.watermark<'t>(x: DSLElement<'t>, watermark: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(AutoCompleteBox.WatermarkProperty, watermark, ValueNone) ]
        
    [<CustomOperation("minimumPrefixLength")>] 
    member _.minimumPrefixLength<'t>(x: DSLElement<'t>, length: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(AutoCompleteBox.MinimumPrefixLengthProperty, length, ValueNone) ]
        
    [<CustomOperation("minimumPopulationDelay")>] 
    member _.minimumPopulationDelay<'t>(x: DSLElement<'t>, delay: TimeSpan) =
        x @@ [ AttrBuilder<'t>.CreateProperty<TimeSpan>(AutoCompleteBox.MinimumPopulateDelayProperty, delay, ValueNone) ]
        
    [<CustomOperation("maxDropDownHeight")>] 
    member _.maxDropDownHeight<'t>(x: DSLElement<'t>, height: float) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float>(AutoCompleteBox.MaxDropDownHeightProperty, height, ValueNone) ]
        
    [<CustomOperation("isTextCompletionEnabled")>] 
    member _.isTextCompletionEnabled<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(AutoCompleteBox.IsTextCompletionEnabledProperty, value, ValueNone) ]
        
    [<CustomOperation("itemTemplate")>] 
    member _.itemTemplate<'t>(x: DSLElement<'t>, template: IDataTemplate) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IDataTemplate>(AutoCompleteBox.ItemTemplateProperty, template, ValueNone) ]
        
    [<CustomOperation("isDropDownOpen")>] 
    member _.isDropDownOpen<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(AutoCompleteBox.IsDropDownOpenProperty, value, ValueNone) ]
        
    [<CustomOperation("selectedItem")>] 
    member _.selectedItem<'t>(x: DSLElement<'t>, value: obj) =
        x @@ [ AttrBuilder<'t>.CreateProperty<obj>(AutoCompleteBox.SelectedItemProperty, value, ValueNone) ]
        
    [<CustomOperation("onSelectedItemChanged")>] 
    member _.onSelectedItemChanged<'t>(x: DSLElement<'t>, func: obj -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<obj>(AutoCompleteBox.SelectedItemProperty, func) ]

    [<CustomOperation("text")>] 
    member _.text<'t>(x: DSLElement<'t>, text: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(AutoCompleteBox.TextProperty, text, ValueNone) ]
        
    [<CustomOperation("onTextChanged")>] 
    member _.onTextChanged<'t>(x: DSLElement<'t>, func: string -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<string>(AutoCompleteBox.TextProperty, func) ]
        
    [<CustomOperation("searchText")>] 
    member _.searchText<'t>(x: DSLElement<'t>, text: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(AutoCompleteBox.SearchTextProperty, text, ValueNone) ]
        
    [<CustomOperation("onSearchTextChanged")>] 
    member _.onSearchTextChanged<'t>(x: DSLElement<'t>, func: string -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<string>(AutoCompleteBox.SearchTextProperty, func) ]
        
    [<CustomOperation("filterMode")>] 
    member _.filterMode<'t>(x: DSLElement<'t>, mode: AutoCompleteFilterMode) =
        x @@ [ AttrBuilder<'t>.CreateProperty<AutoCompleteFilterMode>(AutoCompleteBox.FilterModeProperty, mode, ValueNone) ]
        
    [<CustomOperation("itemFilter")>] 
    member _.itemFilter<'t>(x: DSLElement<'t>, filterFunc: string -> obj -> bool) =
        // TODO: implement custom comparer (value is a function)
        x @@ [ AttrBuilder<'t>.CreateProperty<_>(AutoCompleteBox.ItemFilterProperty, filterFunc, ValueNone) ]
        
    [<CustomOperation("textFilter")>] 
    member _.textFilter<'t>(x: DSLElement<'t>, filter: string -> obj -> bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<_>(AutoCompleteBox.TextFilterProperty, filter, ValueNone) ]
        
    [<CustomOperation("dataItems")>] 
    member _.dataItems<'t>(x: DSLElement<'t>, items: IEnumerable) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IEnumerable>(AutoCompleteBox.ItemsProperty, items, ValueNone) ]
        
    [<CustomOperation("viewItems")>] 
    member _.viewItems<'t>(x: DSLElement<'t>, views: IView list) =
        x @@ [ AttrBuilder<'t>.CreateContentMultiple(AutoCompleteBox.ItemsProperty, views) ]
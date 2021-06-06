module Avalonia.FuncUI.Experiments.DSL.ItemsRepeater

open System.Collections
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Panel
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
open Avalonia.Controls.Templates

type ItemsRepeaterBuilder<'t when 't :> ItemsRepeater>() =
    inherit PanelBuilder<'t>()
    
    [<CustomOperation("viewItems")>] 
    member _.viewItems<'t>(x: DSLElement<'t>, views: List<IView>) =
        x @@ [ AttrBuilder<'t>.CreateContentMultiple(ItemsRepeater.ItemsProperty, views) ]
    
    [<CustomOperation("dataItems")>] 
    member _.dataItems<'t>(x: DSLElement<'t>, data : IEnumerable) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IEnumerable>(ItemsRepeater.ItemsProperty, data, ValueNone) ]
        
    [<CustomOperation("itemTemplate")>] 
    member _.itemTemplate<'t>(x: DSLElement<'t>, value : IDataTemplate) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IDataTemplate>(ItemsRepeater.ItemTemplateProperty, value, ValueNone) ]

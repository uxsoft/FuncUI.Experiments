module Avalonia.FuncUI.Experiments.DSL.ItemsControl

open Avalonia.Controls.Templates
open System.Collections
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
 
type ItemsControlBuilder<'t when 't :> ItemsControl>() =
    inherit TemplatedControlBuilder<'t>()

    override _.Flatten x =
        let views = 
            x.Children
            |> List.filter (fun it -> it :? IView)
            |> List.map (fun it -> it :?> IView)
        
        let prop =
            if views.Length > 0 then
                AttrBuilder<'t>.CreateContentMultiple(ItemsControl.ItemsProperty, views)
            else
                AttrBuilder<'t>.CreateProperty<IEnumerable>(ItemsControl.ItemsProperty, x.Children, ValueNone)
        
        x.Attributes @ [ prop ]
    
    [<CustomOperation("viewItems")>] 
    member _.viewItems<'t>(x: DSLElement<'t>, views: IView list) =
        x @@ [ AttrBuilder<'t>.CreateContentMultiple(ItemsControl.ItemsProperty, views) ]
        
    [<CustomOperation("dataItems")>] 
    member _.dataItems<'t>(x: DSLElement<'t>, data: IEnumerable) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IEnumerable>(ItemsControl.ItemsProperty, data, ValueNone) ]
        
    [<CustomOperation("itemsPanel")>] 
    member _.itemsPanel<'t>(x: DSLElement<'t>, value: ITemplate<IPanel>) =
        x @@ [ AttrBuilder<'t>.CreateProperty<ITemplate<IPanel>>(ItemsControl.ItemsPanelProperty, value, ValueNone) ]
        
    [<CustomOperation("itemTemplate")>] 
    member _.itemTemplate<'t>(x: DSLElement<'t>, value: IDataTemplate) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IDataTemplate>(ItemsControl.ItemTemplateProperty, value, ValueNone) ]
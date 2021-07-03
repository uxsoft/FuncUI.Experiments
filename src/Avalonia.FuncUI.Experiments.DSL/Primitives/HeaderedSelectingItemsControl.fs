module Avalonia.FuncUI.Experiments.DSL.HeaderedSelectingItemsControl

open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.SelectingItemsControl
open Avalonia.FuncUI.Types
    
type HeaderedSelectingItemsControlBuilder<'t when 't :> HeaderedSelectingItemsControl>() =
    inherit SelectingItemsControlBuilder<'t>()
    
    [<CustomOperation("header")>] 
    member _.header<'t, 'c when 't :> HeaderedSelectingItemsControl and 'c :> obj>(x: DSLElement<'t>, value: 'c) =
        let prop = 
            match box value with
            | :? IView as view -> AttrBuilder<'t>.CreateContentSingle(HeaderedSelectingItemsControl.HeaderProperty, Some view)
            | :? string as text -> AttrBuilder<'t>.CreateProperty<string>(HeaderedSelectingItemsControl.HeaderProperty, text, ValueNone)
            | _ -> AttrBuilder<'t>.CreateProperty<obj>(HeaderedSelectingItemsControl.HeaderProperty, value, ValueNone)
        
        x @@ [ prop ]
namespace Avalonia.FuncUI.Experiments.DSL.Grid
  
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Panel
open Avalonia.FuncUI.Builder
    
module private Internals =
    open System.Collections.Generic
    open System.Linq
    
    let compareColumnDefinitions (a: obj, b: obj): bool =
        let a = a :?> ColumnDefinitions
        let b = b :?> ColumnDefinitions
            
        let comparer =
            {
                new IEqualityComparer<ColumnDefinition> with
                    member this.Equals (a, b) : bool =
                        a.Width = b.Width &&
                        a.MinWidth = b.MinWidth &&
                        a.MaxWidth = b.MaxWidth &&
                        a.SharedSizeGroup = b.SharedSizeGroup
                        
                    member this.GetHashCode (a) =
                        (a.Width, a.MinWidth, a.MaxWidth, a.SharedSizeGroup).GetHashCode()
            }
        
        Enumerable.SequenceEqual(a, b, comparer);
        
    let compareRowDefinitions (a: obj, b: obj): bool =
        let a = a :?> RowDefinitions
        let b = b :?> RowDefinitions
            
        let comparer =
            {
                new IEqualityComparer<RowDefinition> with
                    member this.Equals (a, b) : bool =
                        a.Height = b.Height &&
                        a.MinHeight = b.MinHeight &&
                        a.MaxHeight = b.MaxHeight &&
                        a.SharedSizeGroup = b.SharedSizeGroup

                    member this.GetHashCode (a) =
                        (a.Height, a.MinHeight, a.MaxHeight, a.SharedSizeGroup).GetHashCode()
            }
        
        Enumerable.SequenceEqual(a, b, comparer);

type GridBuilder<'t when 't :> Grid>() =
    inherit PanelBuilder<'t>()
    
    [<CustomOperation("showGridLines")>] 
    member _.showGridLines<'t>(x: DSLElement<'t>, value: bool) =
        AttrBuilder<'t>.CreateProperty<bool>(Grid.ShowGridLinesProperty, value, ValueNone)

    [<CustomOperation("columnDefinitions")>] 
    member _.columnDefinitions<'t>(x: DSLElement<'t>, value: string) =
        let columnDefinitions = ColumnDefinitions.Parse value        
        let getter : 't -> ColumnDefinitions = fun view -> view.ColumnDefinitions
        let setter : 't * ColumnDefinitions -> unit = fun (view, value) -> view.ColumnDefinitions <- value
        
        AttrBuilder<'t>.CreateProperty<_>(
            "ColumnDefinitions",
            columnDefinitions,
            ValueSome getter,
            ValueSome setter,
            ValueSome Internals.compareColumnDefinitions,
            (fun () -> ColumnDefinitions()))

    [<CustomOperation("rowDefinitions")>] 
    member _.rowDefinitions<'t>(x: DSLElement<'t>, value: string) =
        let rowDefinitions = RowDefinitions.Parse value
        let getter : 't -> RowDefinitions = fun view -> view.RowDefinitions
        let setter : 't * RowDefinitions -> unit = fun (view, value) -> view.RowDefinitions <- value
        
        AttrBuilder<'t>.CreateProperty<_>(
            "RowDefinitions",
            rowDefinitions,
            ValueSome getter,
            ValueSome setter,
            ValueSome Internals.compareRowDefinitions,
            (fun () -> RowDefinitions()))
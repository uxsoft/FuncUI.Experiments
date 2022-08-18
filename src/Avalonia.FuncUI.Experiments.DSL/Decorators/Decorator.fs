module Avalonia.FuncUI.Experiments.DSL.Decorator

open Avalonia
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Control
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type DecoratorBuilder<'t when 't :> Decorator>() =
    inherit ControlBuilder<'t>()
        
    override _.Flatten x =
        match x.Children |> List.tryLast with
        | None -> x.Attributes
        | Some lastChild -> 
            let contentProp =
                match lastChild with
                | :? IView as view -> [ AttrBuilder<'t>.CreateContentSingle(Decorator.ChildProperty, Some view) ]
                | :? IControl as control -> [ AttrBuilder<'t>.CreateProperty(Decorator.ChildProperty, control, ValueNone) ]
                | _ ->
                    printfn "Child of a Decorator must be an IControl"
                    []                    
        
            x.Attributes @ contentProp
        
    [<CustomOperation("padding")>]
    member _.padding<'t>(x: DSLElement<'t>, value: Thickness) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Thickness>(Decorator.PaddingProperty, value, ValueNone) ]
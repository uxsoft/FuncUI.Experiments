module Avalonia.FuncUI.Experiments.DSL.Common

open System.Collections.Generic
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
    
type DSLElement<'t>(?attrs : IAttr<'t> list, ?children : obj list) =
    member val Attributes : IAttr<'t> list = defaultArg attrs [] with get, set
    member val Children : obj list = defaultArg children [] with get, set
    
    static member (@@) (a: DSLElement<'t>, b: DSLElement<'t>) =
        printf $"{a.Children}"
        a.Attributes <- a.Attributes @ b.Attributes
        a.Children <- b.Children @ b.Children
        a
        
    static member (@@) (a: DSLElement<'t>, b: IAttr<'t> list) =
        a.Attributes <- a.Attributes @ b
        a
        
type DSLBuilder<'t>() =
    
    abstract member Flatten : DSLElement<'t> -> IAttr<'t> list
        default _.Flatten x = x.Attributes
    
    member inline _.Zero() = DSLElement<'t>()

    member inline _.Delay(f) = f ()

    member inline _.Combine(a: DSLElement<'t>, b: DSLElement<'t>) = a @@ b

    member inline x.For(s: DSLElement<'t>, f) = x.Combine(s, f ())
        
    member inline x.For(list: 'a seq, f: 'a -> DSLElement<'t>) =
        Seq.map f list |> Seq.toList

    member inline x.Yield child =
        match box child with
        | null -> DSLElement<'t>()
        | _ -> DSLElement<'t>([], [child])
    
    member inline this.Run(x: DSLElement<'t>) =
        ViewBuilder.Create<'t>(this.Flatten x)
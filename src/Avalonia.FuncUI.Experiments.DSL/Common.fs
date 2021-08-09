module Avalonia.FuncUI.Experiments.DSL.Common

open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
        
type DSLElement<'t> =
    { Attributes : IAttr<'t> list
      Children: obj list }
    with
        static member (@@) (a: DSLElement<'t>, b: DSLElement<'t>) =
            { a with Attributes = a.Attributes @ b.Attributes
                     Children = a.Children @ b.Children }
            
        static member (@@) (a: DSLElement<'t>, b: IAttr<'t> list) =
            { a with Attributes = a.Attributes @ b }
        
type DSLBuilder<'t>() =
    
    abstract member Flatten : DSLElement<'t> -> IAttr<'t> list
        default _.Flatten x = x.Attributes
    
    member inline _.Zero() = { Attributes = []; Children = [] }

    member inline _.Delay(f) = f ()

    member inline _.Combine(a: DSLElement<'t>, b: DSLElement<'t>) = a @@ b

    member inline x.For(s: DSLElement<'t>, f) =
        x.Combine(s, f ())

    member inline x.For(attr: IAttr<'t>, f: unit -> DSLElement<'t>) =
        (f ()) @@ [ attr ]
        
    member inline x.For(items: 'item seq, f: 'item -> DSLElement<_>) =
        items
        |> Seq.map f 
        |> Seq.fold (fun acc t -> x.Combine(acc, t)) (x.Zero())
    
    member inline x.Yield child =
        match box child with
        | null -> x.Zero()
        | _ -> { Attributes = []; Children = [ child ] }
        
    member inline x.YieldFrom(arr: 'a seq) =
        { Attributes = []; Children = arr |> Seq.map box |> Seq.toList }
    
    member inline this.Run(x: DSLElement<'t>) =
        ViewBuilder.Create<'t>(this.Flatten x)
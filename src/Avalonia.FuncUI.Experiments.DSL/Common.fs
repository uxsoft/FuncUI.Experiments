module Avalonia.FuncUI.Experiments.DSL.Common

open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type DSLElement<'TView> =
    { Attributes: IAttr<'TView> list
      Children: obj list }
    
    member inline x.attr value =
        { x with Attributes = x.Attributes @ [ value ] }
        
type DSLBuilder<'TView>() =
    member inline _.Zero() = { Attributes = []; Children = [] }

    member inline _.Delay(f) = f ()

    member inline x.Yield() = x.Zero()

    member inline _.Yield(child: string) =
        { Attributes = []; Children = [ child ] }
    
    member inline _.Yield(child: IView) =
        { Attributes = []; Children = [ child ] }
        
    member inline _.Yield(children: IView list) =
        { Attributes = []; Children = children |> List.map (fun i -> i :> obj) }

    member inline x.Yield _ = x.Zero()

    member inline _.Combine(a: DSLElement<'TView>, b: DSLElement<'TView>) =
        { Attributes = a.Attributes @ b.Attributes
          Children = a.Children @ b.Children }

    member inline x.For(s: DSLElement<'TView>, f) =
        x.Combine(s, f ())
        
    member inline x.For(list: 'a seq, f: 'a -> DSLElement<'TView>) =
        let elements = Seq.map f list
        { Attributes = elements |> Seq.map (fun i -> i.Attributes) |> List.concat
          Children =  elements |> Seq.map (fun i -> i.Children) |> List.concat }

    member _.Run(x: DSLElement<'t>) = 
        ViewBuilder.Create<'t>(x.Attributes)
    
module Avalonia.FuncUI.Experiments.DSL.Common

open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
        
type DSLBuilder<'t>() =
    member inline _.Zero() = []

    member inline _.Delay(f) = f ()

    member inline x.Yield() = x.Zero()

    member inline x.Yield _ = x.Zero()

    member inline _.Combine(a: IAttr<'t> list, b: IAttr<'t> list) = a @ b

    member inline x.For(s: IAttr<'t> list, f) =
        x.Combine(s, f ())
        
    member inline x.For(list: 'a seq, f: 'a -> IAttr<'t> list) =
        Seq.map f list |> Seq.toList

    member _.Run(x: IAttr<'t> list) = 
        ViewBuilder.Create<'t>(x)
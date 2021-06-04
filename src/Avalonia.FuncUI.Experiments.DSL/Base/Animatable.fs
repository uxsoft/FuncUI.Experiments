module Avalonia.FuncUI.Experiments.DSL.Animatable

open Avalonia.Animation
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Types

type AnimatableBuilder<'t when 't :> Animatable>() =
    inherit DSLBuilder<'t>()
    
    [<CustomOperation("transitions")>]
    member _.transitions<'t>(x: IAttr<'t> list, v: Transitions) =
        x @ [ AttrBuilder<'t>.CreateProperty<Transitions>(Animatable.TransitionsProperty, v, ValueNone) ]
        
    [<CustomOperation("clock")>]
    member _.clock<'t>(x: IAttr<'t> list, clock: IClock) =
        x @ [ AttrBuilder<'t>.CreateProperty<IClock>(Animatable.ClockProperty, clock, ValueNone) ]
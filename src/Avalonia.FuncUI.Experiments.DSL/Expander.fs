module Avalonia.FuncUI.Experiments.DSL.Expander

open Avalonia.Animation
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.HeaderedContentControl
open Avalonia.FuncUI.Builder

type ExpanderBuilder<'t when 't :> Expander>() =
    inherit HeaderedContentControlBuilder<'t>()

    [<CustomOperation("contentTransition")>]
    member _.contentTransition<'t>(x: DSLElement<'t>, value: IPageTransition) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IPageTransition>(Expander.ContentTransitionProperty, value, ValueNone) ]

    [<CustomOperation("expandDirection")>]
    member _.expandDirection<'t>(x: DSLElement<'t>, value: ExpandDirection) =
        x @@ [ AttrBuilder<'t>.CreateProperty<ExpandDirection>(Expander.ExpandDirectionProperty, value, ValueNone) ]

    [<CustomOperation("isExpanded")>]
    member _.isExpanded<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(Expander.IsExpandedProperty, value, ValueNone) ]

    [<CustomOperation("onIsExpandedChanged")>]
    member _.onIsExpandedChanged<'t>(x: DSLElement<'t>, func: bool -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription(Expander.IsExpandedProperty, func) ]

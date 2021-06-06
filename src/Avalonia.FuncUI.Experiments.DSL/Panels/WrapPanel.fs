module Avalonia.FuncUI.Experiments.DSL.WrapPanel

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Panel
open Avalonia.Layout
open Avalonia.FuncUI.Builder

type WrapPanelBuilder<'t when 't :> WrapPanel>() =
    inherit PanelBuilder<'t>()
    
    [<CustomOperation("itemHeight")>] 
    member _.itemHeight<'t>(x: DSLElement<'t>, value: float) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float>(WrapPanel.ItemHeightProperty, value, ValueNone) ]

    [<CustomOperation("itemWidth")>] 
    member _.itemWidth<'t>(x: DSLElement<'t>, value: float) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float>(WrapPanel.ItemWidthProperty, value, ValueNone) ]
       
    [<CustomOperation("orientation")>] 
    member _.orientation<'t>(x: DSLElement<'t>, orientation: Orientation) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Orientation>(WrapPanel.OrientationProperty, orientation, ValueNone) ]
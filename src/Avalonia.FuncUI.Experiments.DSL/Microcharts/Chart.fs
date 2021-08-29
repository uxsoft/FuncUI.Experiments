module Avalonia.FuncUI.Experiments.DSL.Microcharts.Chart

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Control
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.Layout
open Avalonia.Media
open Avalonia.FuncUI.Builder
open Microcharts

type ChartBuilder<'t when 't :> ChartView.ChartView>() =
    inherit ControlBuilder<'t>()

    override _.Flatten x =
        let charts = 
            x.Children
            |> List.filter (fun it -> it :? Chart)
            |> List.map (fun it -> it :?> Chart)
        
        match charts |> List.tryLast with
        | None -> x.Attributes
        | Some chart ->
            let prop = AttrBuilder<'t>.CreateProperty<Chart option>(ChartView.ChartView.ChartProperty, Some chart, ValueNone)
            x.Attributes @ [ prop ]

module Avalonia.FuncUI.Experiments.DSL.Microcharts.ChartView

open Avalonia
open Avalonia.Controls
open Avalonia.Media
open Avalonia.Platform
open Avalonia.Rendering.SceneGraph
open Avalonia.Skia
open Microcharts

type ChartView() as this =
    inherit Control()
    
    let drawOperation = new ChartDrawOperation(this)
    let mutable chart : Chart option = None
    
    static let chartProperty = 
        AvaloniaProperty.RegisterDirect<ChartView, Chart option>(
                nameof(Chart),
                (fun c -> c.Chart),
                (fun c v -> c.Chart <- v))
        
    do
        this.GetObservable(ChartView.ChartProperty).Subscribe(fun _ -> this.InvalidateVisual()) |> ignore
    
    static member ChartProperty = chartProperty 
    
    member this.Chart
        with get () = chart
        and set value = this.SetAndRaise(ChartView.ChartProperty, &chart, value) |> ignore

    override _.Render(context: DrawingContext) =
        context.Custom(drawOperation) 
    
and ChartDrawOperation(parent: ChartView) =
    
    member val Parent = parent with get
    
    interface ICustomDrawOperation with  
        member _.Dispose() = ()
        member this.HitTest(p: Point) = this.Parent.Bounds.Contains(p)
        member this.Equals(other: ICustomDrawOperation) = (this :> ICustomDrawOperation) = other
        member _.Bounds = parent.Bounds
        
        member this.Render(context: IDrawingContextImpl) =
            match context with
            | :? ISkiaDrawingContextImpl as skia ->
                this.Parent.Chart |> Option.iter (fun chart ->
                    chart.Draw(skia.SkCanvas, int this.Parent.Bounds.Width, int this.Parent.Bounds.Height))
            | _ -> ()
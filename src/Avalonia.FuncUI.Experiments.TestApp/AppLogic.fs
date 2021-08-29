module Avalonia.FuncUI.Experiments.TestApp.AppLogic

open Avalonia
open Avalonia.Layout
open Avalonia.FuncUI.Experiments.DSL.DSL
open Avalonia.Media
open Avalonia.Media.Immutable
open Microcharts
open SkiaSharp

type State = { count : int }
let init = { count = 0 }

type Msg = Increment | Decrement | Reset

let update (msg: Msg) (state: State) : State =
    match msg with
    | Increment -> { state with count = state.count + 1 }
    | Decrement -> { state with count = state.count - 1 }
    | Reset -> init


let entries =
    [|
        ChartEntry(212f,
            Label = "UWP",
            ValueLabel = "112",
            Color = SKColor.Parse("#2c3e50"))
        ChartEntry(248f,
            Label = "Android",
            ValueLabel = "648",
            Color = SKColor.Parse("#77d065"))
        ChartEntry(128f,
            Label = "iOS",
            ValueLabel = "428",
            Color = SKColor.Parse("#b455b6"))
        ChartEntry(514f,
            Label = "Forms",
            ValueLabel = "214",
            Color = SKColor.Parse("#3498db"))
    |]

let view (state: State) (dispatch) =
    tabControl {        
        tabItem {
            header "Counter"
            
            grid {
                rowDefinitions "*, *, *, *, *"
                margin (Thickness(2.))
                
                border {
                    label {
                        row 0
                        fontSize 48.0
                        verticalAlignment VerticalAlignment.Center
                        horizontalAlignment HorizontalAlignment.Center
                        $"{state.count}"
                    }
                }

                button {
                    row 2
                    onClick (fun _ -> dispatch Reset)
                    "reset"
                }
                button {
                    row 3
                    onClick (fun _ -> dispatch Decrement)
                    "-"
                }
                button {
                    row 4
                    onClick (fun _ -> dispatch Increment)
                    "+"
                }
            }
        }
        tabItem {
            header "ComboBox"
            
            comboBox {
                dataItems ([1..5] |> List.map (fun i -> $"item{i}"))
                selectedItem "item2"
            }
        }
        tabItem {
            header "Code"
            stackPanel {
                label { "For" }
                
                for item in [1..5] do
                    label { $"{item}" }
                    
                label { "Yield!" }
                yield! [
                    label { "item1" }
                    label { "item2" }
                ]
            }
        }
        tabItem {
            header "Charts"
            chart {
                BarChart(Entries = entries)
            }
        }
    }

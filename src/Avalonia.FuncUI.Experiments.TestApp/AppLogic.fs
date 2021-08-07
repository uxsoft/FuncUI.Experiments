﻿module Avalonia.FuncUI.Experiments.TestApp.AppLogic

open Avalonia
open Avalonia.Layout
open Avalonia.FuncUI.Experiments.DSL.DSL
open Avalonia.Media
open Avalonia.Media.Immutable

type State = { count : int }
let init = { count = 0 }

type Msg = Increment | Decrement | Reset

let update (msg: Msg) (state: State) : State =
    match msg with
    | Increment -> { state with count = state.count + 1 }
    | Decrement -> { state with count = state.count - 1 }
    | Reset -> init


let view (state: State) (dispatch) =
    tabControl {        
        tabItem {
            header "Grid"
            
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
                stackPanel {
                    row 1
                    for item in [1..5] do
                        button { $"{item}" }
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
    }

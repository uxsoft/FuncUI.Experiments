module Avalonia.FuncUI.Experiments.TestApp.AppLogic

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
        background (ImmutableSolidColorBrush Colors.Red)
        
        tabItem {
            background (ImmutableSolidColorBrush Colors.Green)
            header "Grid"
            
            grid {
                rowDefinitions "*,*,*,*"
                margin (Thickness(2.))
                
                text {
                    row 0
                    fontSize 48.0
                    verticalAlignment VerticalAlignment.Center
                    horizontalAlignment HorizontalAlignment.Center
                    text (string state.count)
                }
                button {
                    row 1
                    onClick (fun _ -> dispatch Reset)
                    "reset"
                }
                button {
                    row 2
                    onClick (fun _ -> dispatch Decrement)
                    "-"
                }
                button {
                    row 3
                    onClick (fun _ -> dispatch Increment)
                    "+"
                }
            }
        }
    }

namespace Avalonia.FuncUI.Experiments.TestApp

open Avalonia.Controls.Presenters
open Avalonia.FuncUI.DSL
open Avalonia.FuncUI.Experiments.DSL.Button
open Avalonia.FuncUI.Experiments.DSL.ContentPresenter
open Avalonia.FuncUI.Experiments.DSL.Control
open Avalonia.FuncUI.Experiments.DSL.Layoutable
open Avalonia.FuncUI.Experiments.DSL.Panel
open Avalonia.Layout
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.DSL

module Counter =    
    type State = { count : int }
    let init = { count = 0 }

    type Msg = Increment | Decrement | Reset

    let update (msg: Msg) (state: State) : State =
        match msg with
        | Increment -> { state with count = state.count + 1 }
        | Decrement -> { state with count = state.count - 1 }
        | Reset -> init
    
    
    let view (state: State) (dispatch) =
        dockPanel {
            lastChildFill false
            
            textBlock {
                dock Dock.Top
                fontSize 48.0
                verticalAlignment VerticalAlignment.Center
                horizontalAlignment HorizontalAlignment.Center
                text (string state.count)
            }
            button {
                dock Dock.Bottom
                onClick (fun _ -> dispatch Reset)
                "reset"
            }
            button {
                dock Dock.Bottom
                onClick (fun _ -> dispatch Decrement)
                "-"
            }
            button {
                dock Dock.Bottom
                onClick (fun _ -> dispatch Increment)
                "+"
            }
        }   
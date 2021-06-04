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

module Counter =    
    type State = { count : int }
    let init = { count = 0 }

    type Msg = Increment | Decrement | Reset

    let update (msg: Msg) (state: State) : State =
        match msg with
        | Increment -> { state with count = state.count + 1 }
        | Decrement -> { state with count = state.count - 1 }
        | Reset -> init
    
    let button = ButtonBuilder<Button>()
    
    let view (state: State) (dispatch) =
        let tree = button {
            "my button"
        }
        printf $"{tree}"
        tree
//        DockPanel.create [
//            DockPanel.children [
//                Button.create [
//                    Button.dock Dock.Bottom
//                    Button.onClick (fun _ -> dispatch Reset)
//                    Button.content "reset"
//                ]                
//                Button.create [
//                    Button.dock Dock.Bottom
//                    Button.onClick (fun _ -> dispatch Decrement)
//                    Button.content "-"
//                ]
//                Button.create [
//                    Button.dock Dock.Bottom
//                    Button.onClick (fun _ -> dispatch Increment)
//                    Button.content "+"
//                ]
//                TextBlock.create [
//                    TextBlock.dock Dock.Top
//                    TextBlock.fontSize 48.0
//                    TextBlock.verticalAlignment VerticalAlignment.Center
//                    TextBlock.horizontalAlignment HorizontalAlignment.Center
//                    TextBlock.text (string state.count)
//                ]
//            ]
//        ]       
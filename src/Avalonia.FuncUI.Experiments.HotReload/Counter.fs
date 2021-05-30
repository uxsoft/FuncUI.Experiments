module FuncUI.Experiments.Counter

open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Avalonia.Layout

type Model = { count : int }
let init () = { count = 0 }, []

type Msg = Increment | Decrement | Reset

let update (msg: Msg) (model: Model) =
    match msg with
    | Increment -> { model with count = model.count + 1 }, []
    | Decrement -> { model with count = model.count - 1 }, []
    | Reset -> { count = 0 }, []

let view (state: Model) (dispatch) =
    DockPanel.create [
        DockPanel.children [
            Button.create [
                Button.dock Dock.Bottom
                Button.onClick (fun _ -> dispatch Reset)
                Button.content "RESET"
            ]                
            Button.create [
                Button.dock Dock.Bottom
                Button.onClick (fun _ -> dispatch Decrement)
                Button.content "-"
            ]
            Button.create [
                Button.dock Dock.Bottom
                Button.onClick (fun _ -> dispatch Increment)
                Button.content "+"
            ]
            TextBlock.create [
                TextBlock.dock Dock.Top
                TextBlock.fontSize 48.0
                TextBlock.verticalAlignment VerticalAlignment.Center
                TextBlock.horizontalAlignment HorizontalAlignment.Center
                TextBlock.text (string state.count)
            ]
        ]
    ]       
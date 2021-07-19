module FuncUI.Experiments.Counter

open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Avalonia.Layout
open Elmish

type Model = { count : int }
type Msg = Increment | Decrement | Reset

let init () : Model * Cmd<Msg> = { count = 0 }, []

let update (msg: Msg) (model: Model) : Model * Cmd<Msg> =
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
                Button.content "MINUS"
            ]
            Button.create [
                Button.dock Dock.Bottom
                Button.onClick (fun _ -> dispatch Increment)
                Button.content "PLUS"
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
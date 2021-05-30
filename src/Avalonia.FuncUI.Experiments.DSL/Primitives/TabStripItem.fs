namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module TabStripItem =
    open Avalonia.Controls.Primitives
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<TabStripItem> list): IView<TabStripItem> =
        ViewBuilder.Create<TabStripItem>(attrs)
    
    type TabStripItem with
        end
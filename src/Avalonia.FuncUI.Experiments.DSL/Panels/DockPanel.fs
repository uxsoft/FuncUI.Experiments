namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module DockPanel =  
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<DockPanel> list): IView<DockPanel> =
        ViewBuilder.Create<DockPanel>(attrs)
    
    type Control with
        static member dock<'t when 't :> Control>(dock: Dock) =
            AttrBuilder<'t>.CreateProperty<Dock>(DockPanel.DockProperty, dock, ValueNone)
    
    type DockPanel with
        static member lastChildFill<'t when 't :> DockPanel>(fill: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(DockPanel.LastChildFillProperty, fill, ValueNone)
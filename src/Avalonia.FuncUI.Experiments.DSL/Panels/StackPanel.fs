module Avalonia.FuncUI.Experiments.DSL.StackPanel

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Panel
open Avalonia.Layout
open Avalonia.FuncUI.Builder

type StackPanelBuilder<'t when 't :> StackPanel>() =
    inherit PanelBuilder<'t>()
    
    /// <summary>
    /// Gets or sets the size of the spacing to place between child controls.
    /// </summary>
    [<CustomOperation("spacing")>] 
    member _.spacing<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(StackPanel.SpacingProperty, value, ValueNone) ]
    
    /// <summary>
    /// Gets or sets the orientation in which child controls will be laid out.
    /// </summary>
    [<CustomOperation("orientation")>] 
    member _.orientation<'t>(x: DSLElement<'t>, orientation: Orientation) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Orientation>(StackPanel.OrientationProperty, orientation, ValueNone) ]
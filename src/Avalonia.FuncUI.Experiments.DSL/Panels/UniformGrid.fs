module Avalonia.FuncUI.Experiments.DSL.UniformGrid

open Avalonia.Controls.Primitives
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Panel
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type UniformGridBuilder<'t when 't :> UniformGrid>() =
    inherit PanelBuilder<'t>() 

    /// <summary>
    /// Specifies the column count. If set to 0, column count will be calculated automatically.
    /// </summary>
    [<CustomOperation("columns")>] 
    member _.columns<'t>(x: DSLElement<'t>, value: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(UniformGrid.ColumnsProperty, value, ValueNone) ]

    /// <summary>
    /// Specifies the row count. If set to 0, row count will be calculated automatically.
    /// </summary>
    [<CustomOperation("rows")>] 
    member _.rows<'t>(x: DSLElement<'t>, value: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(UniformGrid.RowsProperty, value, ValueNone) ]
       
    /// <summary>
    /// Specifies, for the first row, the column where the items should start.
    /// </summary>
    [<CustomOperation("firstColumn")>] 
    member _.firstColumn<'t>(x: DSLElement<'t>, value: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(UniformGrid.FirstColumnProperty, value, ValueNone) ]
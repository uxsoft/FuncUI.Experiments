module Avalonia.FuncUI.Experiments.DSL.Image

open Avalonia.Controls
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Control
open Avalonia.Media
open Avalonia.Media.Imaging

type ImageBuilder<'t when 't :> Image>() =
    inherit ControlBuilder<'t>()
    
    [<CustomOperation("source")>]
    member _.source<'t>(x: DSLElement<'t>, value: IBitmap) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBitmap>(Image.SourceProperty, value, ValueNone) ]
        
    [<CustomOperation("stretch")>]
    member _.stretch<'t>(x: DSLElement<'t>, value: Stretch) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Stretch>(Image.StretchProperty, value, ValueNone) ]
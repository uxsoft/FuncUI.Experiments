module Avalonia.FuncUI.Experiments.DSL.Visual

open Avalonia
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.StyledElement
open Avalonia.Media
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
        
type VisualBuilder<'t when 't :> Visual>() =
    inherit StyledElementBuilder<'t>()

    [<CustomOperation("clipToBounds")>]
    member _.clipToBounds<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [  AttrBuilder<'t>.CreateProperty<bool>(Visual.ClipToBoundsProperty, value, ValueNone) ]
    
    [<CustomOperation("clip")>]
    member _.clip<'t>(x: DSLElement<'t>, mask: Geometry) =
        x @@ [  AttrBuilder<'t>.CreateProperty<Geometry>(Visual.ClipProperty, mask, ValueNone) ]
        
    [<CustomOperation("isVisible")>]
    member _.isVisible<'t>(x: DSLElement<'t>, visible: bool) =
        x @@ [  AttrBuilder<'t>.CreateProperty<bool>(Visual.IsVisibleProperty, visible, ValueNone) ]

    [<CustomOperation("opacity")>]
    member _.opacity<'t>(x: DSLElement<'t>, value: float) =
        x @@ [  AttrBuilder<'t>.CreateProperty<float>(Visual.IsVisibleProperty, value, ValueNone) ]
  
    [<CustomOperation("opacityMask")>]
    member _.opacityMask<'t>(x: DSLElement<'t>, value: IBrush) =
        x @@ [  AttrBuilder<'t>.CreateProperty<IBrush>(Visual.OpacityMaskProperty, value, ValueNone) ]

    [<CustomOperation("renderTransform")>]
    member _.renderTransform<'t>(x: DSLElement<'t>, transform: Transform) =
        x @@ [  AttrBuilder<'t>.CreateProperty<Transform>(Visual.RenderTransformProperty, transform, ValueNone) ]

    [<CustomOperation("renderTransformOrigin")>]
    member _.renderTransformOrigin<'t>(x: DSLElement<'t>, origin: RelativePoint) =
        x @@ [  AttrBuilder<'t>.CreateProperty<RelativePoint>(Visual.RenderTransformOriginProperty, origin, ValueNone) ]
        
    [<CustomOperation("zIndex")>]
    member _.zIndex<'t>(x: DSLElement<'t>, index: int) =
        x @@ [  AttrBuilder<'t>.CreateProperty<int>(Visual.ZIndexProperty, index, ValueNone) ]
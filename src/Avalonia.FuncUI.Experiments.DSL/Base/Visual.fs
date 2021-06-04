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
    member _.clipToBounds<'t>(x: IAttr<'t> list, value: bool) =
        x @ [  AttrBuilder<'t>.CreateProperty<bool>(Visual.ClipToBoundsProperty, value, ValueNone) ]
    
    [<CustomOperation("clip")>]
    member _.clip<'t>(x: IAttr<'t> list, mask: Geometry) =
        x @ [  AttrBuilder<'t>.CreateProperty<Geometry>(Visual.ClipProperty, mask, ValueNone) ]
        
    [<CustomOperation("isVisible")>]
    member _.isVisible<'t>(x: IAttr<'t> list, visible: bool) =
        x @ [  AttrBuilder<'t>.CreateProperty<bool>(Visual.IsVisibleProperty, visible, ValueNone) ]

    [<CustomOperation("opacity")>]
    member _.opacity<'t>(x: IAttr<'t> list, value: float) =
        x @ [  AttrBuilder<'t>.CreateProperty<float>(Visual.IsVisibleProperty, value, ValueNone) ]
  
    [<CustomOperation("opacityMask")>]
    member _.opacityMask<'t>(x: IAttr<'t> list, value: IBrush) =
        x @ [  AttrBuilder<'t>.CreateProperty<IBrush>(Visual.OpacityMaskProperty, value, ValueNone) ]

    [<CustomOperation("renderTransform")>]
    member _.renderTransform<'t>(x: IAttr<'t> list, transform: Transform) =
        x @ [  AttrBuilder<'t>.CreateProperty<Transform>(Visual.RenderTransformProperty, transform, ValueNone) ]

    [<CustomOperation("renderTransformOrigin")>]
    member _.renderTransformOrigin<'t>(x: IAttr<'t> list, origin: RelativePoint) =
        x @ [  AttrBuilder<'t>.CreateProperty<RelativePoint>(Visual.RenderTransformOriginProperty, origin, ValueNone) ]
        
    [<CustomOperation("zIndex")>]
    member _.zIndex<'t>(x: IAttr<'t> list, index: int) =
        x @ [  AttrBuilder<'t>.CreateProperty<int>(Visual.ZIndexProperty, index, ValueNone) ]
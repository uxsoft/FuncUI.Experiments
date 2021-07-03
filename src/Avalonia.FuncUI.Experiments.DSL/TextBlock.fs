module Avalonia.FuncUI.Experiments.DSL.TextBlock
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.Control

open Avalonia
open Avalonia.Controls
open Avalonia.Media    
open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.Types

let create (attrs: IAttr<TextBlock> list): IView<TextBlock> =
    ViewBuilder.Create<TextBlock>(attrs)

type TextBlockBuilder<'t when 't :> TextBlock>() =
    inherit ControlBuilder<'t>()
        
    [<CustomOperation("text")>] 
    member _.text<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(TextBlock.TextProperty, value, ValueNone) ]
        
    [<CustomOperation("background")>] 
    member _.background<'t>(x: DSLElement<'t>, value: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(TextBlock.BackgroundProperty, value, ValueNone) ]
    
    [<CustomOperation("fontFamily")>] 
    member _.fontFamily<'t>(x: DSLElement<'t>, value: FontFamily) =
        x @@ [ AttrBuilder<'t>.CreateProperty<FontFamily>(TextBlock.FontFamilyProperty, value, ValueNone) ]
        
    [<CustomOperation("fontSize")>] 
    member _.fontSize<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(TextBlock.FontSizeProperty, value, ValueNone) ]
        
    [<CustomOperation("fontStyle")>] 
    member _.fontStyle<'t>(x: DSLElement<'t>, value: FontStyle) =
        x @@ [ AttrBuilder<'t>.CreateProperty<FontStyle>(TextBlock.FontStyleProperty, value, ValueNone) ]
        
    [<CustomOperation("fontWeight")>] 
    member _.fontWeight<'t>(x: DSLElement<'t>, value: FontWeight) =
        x @@ [ AttrBuilder<'t>.CreateProperty<FontWeight>(TextBlock.FontWeightProperty, value, ValueNone) ]
        
    [<CustomOperation("foreground")>] 
    member _.foreground<'t>(x: DSLElement<'t>, value: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(TextBlock.ForegroundProperty, value, ValueNone) ]

    [<CustomOperation("lineHeight")>] 
    member _.lineHeight<'t>(x: DSLElement<'t>, value: float) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float>(TextBlock.LineHeightProperty, value, ValueNone) ]
        
    [<CustomOperation("maxLines")>] 
    member _.maxLines<'t>(x: DSLElement<'t>, value: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(TextBlock.MaxLinesProperty, value, ValueNone) ]

    [<CustomOperation("padding")>] 
    member _.padding<'t>(x: DSLElement<'t>, value: Thickness) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Thickness>(TextBlock.PaddingProperty, value, ValueNone) ]

    [<CustomOperation("textAlignment")>] 
    member _.textAlignment<'t>(x: DSLElement<'t>, alignment: TextAlignment) =
        x @@ [ AttrBuilder<'t>.CreateProperty<TextAlignment>(TextBlock.TextAlignmentProperty, alignment, ValueNone) ]

    [<CustomOperation("textDecorations")>] 
    member _.textDecorations<'t>(x: DSLElement<'t>, value: TextDecorationCollection) =
        x @@ [ AttrBuilder<'t>.CreateProperty<TextDecorationCollection>(TextBlock.TextDecorationsProperty, value, ValueNone) ]

    [<CustomOperation("textTrimming")>] 
    member _.textTrimming<'t>(x: DSLElement<'t>, value: TextTrimming) =
        x @@ [ AttrBuilder<'t>.CreateProperty<TextTrimming>(TextBlock.TextTrimmingProperty, value, ValueNone) ]
        
    [<CustomOperation("textWrapping")>] 
    member _.textWrapping<'t>(x: DSLElement<'t>, value: TextWrapping) =
        x @@ [ AttrBuilder<'t>.CreateProperty<TextWrapping>(TextBlock.TextWrappingProperty, value, ValueNone) ]
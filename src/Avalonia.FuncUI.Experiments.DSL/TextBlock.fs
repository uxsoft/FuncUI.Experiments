namespace Avalonia.FuncUI.Experiments.DSL
open Avalonia.Media.Immutable

[<AutoOpen>]
module TextBlock =  
    open Avalonia
    open Avalonia.Controls
    open Avalonia.Media    
    open Avalonia.FuncUI.Builder
    open Avalonia.FuncUI.Types

    let create (attrs: IAttr<TextBlock> list): IView<TextBlock> =
        ViewBuilder.Create<TextBlock>(attrs)
    
    type TextBlock with
            
        static member text<'t when 't :> TextBlock>(value: string) =
            AttrBuilder<'t>.CreateProperty<string>(TextBlock.TextProperty, value, ValueNone)
            
        static member background<'t when 't :> TextBlock>(value: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(TextBlock.BackgroundProperty, value, ValueNone)
            
        static member background<'t when 't :> TextBlock>(color: string) =
            color |> Color.Parse |> ImmutableSolidColorBrush |> TextBlock.background
        
        static member fontFamily<'t when 't :> TextBlock>(value: FontFamily) =
            AttrBuilder<'t>.CreateProperty<FontFamily>(TextBlock.FontFamilyProperty, value, ValueNone)
            
        static member fontSize<'t when 't :> TextBlock>(value: double) =
            AttrBuilder<'t>.CreateProperty<double>(TextBlock.FontSizeProperty, value, ValueNone)
            
        static member fontStyle<'t when 't :> TextBlock>(value: FontStyle) =
            AttrBuilder<'t>.CreateProperty<FontStyle>(TextBlock.FontStyleProperty, value, ValueNone)
            
        static member fontWeight<'t when 't :> TextBlock>(value: FontWeight) =
            AttrBuilder<'t>.CreateProperty<FontWeight>(TextBlock.FontWeightProperty, value, ValueNone)
            
        static member foreground<'t when 't :> TextBlock>(value: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(TextBlock.ForegroundProperty, value, ValueNone)
            
        static member foreground<'t when 't :> TextBlock>(color: string) =
            color |> Color.Parse |> ImmutableSolidColorBrush |> TextBlock.foreground

        static member lineHeight<'t when 't :> TextBlock>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(TextBlock.LineHeightProperty, value, ValueNone)
            
        static member maxLines<'t when 't :> TextBlock>(value: int) =
            AttrBuilder<'t>.CreateProperty<int>(TextBlock.MaxLinesProperty, value, ValueNone)

        static member padding<'t when 't :> TextBlock>(value: Thickness) =
            AttrBuilder<'t>.CreateProperty<Thickness>(TextBlock.PaddingProperty, value, ValueNone)

        static member padding<'t when 't :> TextBlock>(horizontal: float, vertical: float) =
            (horizontal, vertical) |> Thickness |> TextBlock.padding

        static member padding<'t when 't :> TextBlock>(left: float, top: float, right: float, bottom: float) =
            (left, top, right, bottom) |> Thickness |> TextBlock.padding

        static member textAlignment<'t when 't :> TextBlock>(alignment: TextAlignment) =
            AttrBuilder<'t>.CreateProperty<TextAlignment>(TextBlock.TextAlignmentProperty, alignment, ValueNone)

        static member textDecorations<'t when 't :> TextBlock>(value: TextDecorationCollection) =
            AttrBuilder<'t>.CreateProperty<TextDecorationCollection>(TextBlock.TextDecorationsProperty, value, ValueNone)

        static member textTrimming<'t when 't :> TextBlock>(value: TextTrimming) =
            AttrBuilder<'t>.CreateProperty<TextTrimming>(TextBlock.TextTrimmingProperty, value, ValueNone)
            
        static member textWrapping<'t when 't :> TextBlock>(value: TextWrapping) =
            AttrBuilder<'t>.CreateProperty<TextWrapping>(TextBlock.TextWrappingProperty, value, ValueNone)
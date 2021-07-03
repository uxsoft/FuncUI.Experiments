module Avalonia.FuncUI.Experiments.DSL.TextBox

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.Layout
open Avalonia.Media
open Avalonia.FuncUI.Builder

type TextBoxBuilder<'t when 't :> TextBox>() =
    inherit TemplatedControlBuilder<'t>()

    [<CustomOperation("acceptsReturn")>]
    member _.acceptsReturn<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(TextBox.AcceptsReturnProperty, value, ValueNone) ]

    [<CustomOperation("acceptsTab")>]
    member _.acceptsTab<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(TextBox.AcceptsTabProperty, value, ValueNone) ]        

    [<CustomOperation("caretIndex")>]
    member _.caretIndex<'t>(x: DSLElement<'t>, value: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(TextBox.CaretIndexProperty, value, ValueNone) ]                
                    
    [<CustomOperation("isReadOnly")>]
    member _.isReadOnly<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(TextBox.IsReadOnlyProperty, value, ValueNone) ]

    [<CustomOperation("horizontalContentAlignment")>]
    member _.horizontalContentAlignment<'t>(x: DSLElement<'t>, value: HorizontalAlignment) =
        x @@ [ AttrBuilder<'t>.CreateProperty<HorizontalAlignment>(TextBox.HorizontalContentAlignmentProperty, value, ValueNone) ]

    [<CustomOperation("passwordChar")>]
    member _.passwordChar<'t>(x: DSLElement<'t>, value: char) =
        x @@ [ AttrBuilder<'t>.CreateProperty<char>(TextBox.PasswordCharProperty, value, ValueNone) ]
        
    [<CustomOperation("selectionBrush")>]
    member _.selectionBrush<'t>(x: DSLElement<'t>, value: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(TextBox.SelectionBrushProperty, value, ValueNone) ]
        
    [<CustomOperation("selectionForegroundBrush")>]
    member _.selectionForegroundBrush<'t>(x: DSLElement<'t>, value: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(TextBox.SelectionForegroundBrushProperty, value, ValueNone) ]  
        
    [<CustomOperation("caretBrush")>]
    member _.caretBrush<'t>(x: DSLElement<'t>, value: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(TextBox.CaretBrushProperty, value, ValueNone) ]
        
    [<CustomOperation("selectionStart")>]
    member _.selectionStart<'t>(x: DSLElement<'t>, value: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(TextBox.SelectionStartProperty, value, ValueNone) ]     
        
    [<CustomOperation("selectionEnd")>]
    member _.selectionEnd<'t>(x: DSLElement<'t>, value: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(TextBox.SelectionEndProperty, value, ValueNone) ]     
        
    [<CustomOperation("maxLength")>]
    member _.maxLength<'t>(x: DSLElement<'t>, value: int) =
        x @@ [ AttrBuilder<'t>.CreateProperty<int>(TextBox.MaxLengthProperty, value, ValueNone) ]     
        
    [<CustomOperation("text")>]
    member _.text<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(TextBox.TextProperty, value, ValueNone) ]
        
    [<CustomOperation("onTextChanged")>]
    member _.onTextChanged<'t>(x: DSLElement<'t>, func: string -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<string>(TextBox.TextProperty, func) ]
        
    [<CustomOperation("textAlignment")>]
    member _.textAlignment<'t>(x: DSLElement<'t>, alignment: TextAlignment) =
        x @@ [ AttrBuilder<'t>.CreateProperty<TextAlignment>(TextBox.TextAlignmentProperty, alignment, ValueNone) ]
        
    [<CustomOperation("textWrapping")>]
    member _.textWrapping<'t>(x: DSLElement<'t>, value: TextWrapping) =
        x @@ [ AttrBuilder<'t>.CreateProperty<TextWrapping>(TextBox.TextWrappingProperty, value, ValueNone) ]
        
    [<CustomOperation("useFloatingWatermark")>]
    member _.useFloatingWatermark<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(TextBox.UseFloatingWatermarkProperty, value, ValueNone) ]
        
    [<CustomOperation("newLine")>]
    member _.newLine<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(TextBox.NewLineProperty, value, ValueNone) ]

    [<CustomOperation("verticalContentAlignment")>]
    member _.verticalContentAlignment<'t>(x: DSLElement<'t>, value: VerticalAlignment) =
        x @@ [ AttrBuilder<'t>.CreateProperty<VerticalAlignment>(TextBox.VerticalContentAlignmentProperty, value, ValueNone) ]
        
    [<CustomOperation("watermark")>]
    member _.watermark<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(TextBox.WatermarkProperty, value, ValueNone) ]
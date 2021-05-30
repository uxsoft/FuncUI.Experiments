namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module TemplatedControl =  
    open Avalonia.Media.Immutable
    open Avalonia
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    open Avalonia.Media
    open Avalonia.Controls.Primitives
    open Avalonia.Controls.Templates
    
    let create (attrs: IAttr<TemplatedControl> list): IView<TemplatedControl> =
        ViewBuilder.Create<TemplatedControl>(attrs)
        
    type TemplatedControl with
        static member background<'t when 't :> TemplatedControl>(value: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(TemplatedControl.BackgroundProperty, value, ValueNone)
            
        static member background<'t when 't :> TemplatedControl>(color: string) =
            Color.Parse(color) |> ImmutableSolidColorBrush |> TemplatedControl.background

        static member borderBrush<'t when 't :> TemplatedControl>(value: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(TemplatedControl.BorderBrushProperty, value, ValueNone)
            
        static member borderBrush<'t when 't :> TemplatedControl>(color: string) =
            Color.Parse(color) |> ImmutableSolidColorBrush |> TemplatedControl.borderBrush
            
        static member borderThickness<'t when 't :> TemplatedControl>(value: Thickness) =
            AttrBuilder<'t>.CreateProperty<Thickness>(TemplatedControl.BorderThicknessProperty, value, ValueNone)
            
        static member borderThickness<'t when 't :> TemplatedControl>(value: float) =
            value |> Thickness |> TemplatedControl.borderThickness

        static member borderThickness<'t when 't :> TemplatedControl>(horizontal: float, vertical: float) =
            (horizontal, vertical) |> Thickness |> TemplatedControl.borderThickness
            
        static member borderThickness<'t when 't :> TemplatedControl>(left: float, top: float, right: float, bottom: float) =
            (left, top, right, bottom) |> Thickness |> TemplatedControl.borderThickness
            
        static member fontFamily<'t when 't :> TemplatedControl>(value: FontFamily) =
            AttrBuilder<'t>.CreateProperty<FontFamily>(TemplatedControl.FontFamilyProperty, value, ValueNone)
            
        static member fontSize<'t when 't :> TemplatedControl>(value: double) =
            AttrBuilder<'t>.CreateProperty<double>(TemplatedControl.FontSizeProperty, value, ValueNone)
            
        static member fontStyle<'t when 't :> TemplatedControl>(value: FontStyle) =
            AttrBuilder<'t>.CreateProperty<FontStyle>(TemplatedControl.FontStyleProperty, value, ValueNone)

        static member fontWeight<'t when 't :> TemplatedControl>(value: FontWeight) =
            AttrBuilder<'t>.CreateProperty<FontWeight>(TemplatedControl.FontWeightProperty, value, ValueNone)
            
        static member foreground<'t when 't :> TemplatedControl>(value: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(TemplatedControl.ForegroundProperty, value, ValueNone)
            
        static member foreground<'t when 't :> TemplatedControl>(color: string) =
            Color.Parse(color) |> ImmutableSolidColorBrush |> TemplatedControl.foreground
            
        static member padding<'t when 't :> TemplatedControl>(value: Thickness) =
            AttrBuilder<'t>.CreateProperty<Thickness>(TemplatedControl.PaddingProperty, value, ValueNone)
            
        static member padding<'t when 't :> TemplatedControl>(value: float) =
            Thickness(value) |> TemplatedControl.padding
            
        static member padding<'t when 't :> TemplatedControl>(horizontal: float, vertical: float) =
            Thickness(horizontal, vertical) |> TemplatedControl.padding
            
        static member padding<'t when 't :> TemplatedControl>(left: float, top: float, right: float, bottom: float) =
            Thickness(left, top, right, bottom) |> TemplatedControl.padding 

        static member template<'t when 't :> TemplatedControl>(value: IControlTemplate) =
            AttrBuilder<'t>.CreateProperty<IControlTemplate>(TemplatedControl.TemplateProperty, value, ValueNone)  
        
        static member isTemplateFocusTarget<'t when 't :> TemplatedControl>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(TemplatedControl.IsTemplateFocusTargetProperty, value, ValueNone)  
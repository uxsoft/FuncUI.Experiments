namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module Border =
    open Avalonia
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    open Avalonia.Media
    open Avalonia.Media.Immutable
    
    let create (attrs: IAttr<Border> list): IView<Border> =
        ViewBuilder.Create<Border>(attrs)
    
    type Border with
        static member background<'t when 't :> Border>(brush: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(Border.BackgroundProperty, brush, ValueNone)
            
        static member background<'t when 't :> Border>(color: string) =
            color |> Color.Parse |> ImmutableSolidColorBrush |> Border.background

        static member background<'t when 't :> Border>(color: Color) =
            color |> ImmutableSolidColorBrush |> Border.background
            
        static member borderBrush<'t when 't :> Border>(brush: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(Border.BorderBrushProperty, brush, ValueNone)
            
        static member borderBrush<'t when 't :> Border>(color: string) =
            color |> Color.Parse |> ImmutableSolidColorBrush |> Border.borderBrush
            
        static member borderThickness<'t when 't :> Border>(value: Thickness) =
            AttrBuilder<'t>.CreateProperty<Thickness>(Border.BorderThicknessProperty, value, ValueNone)
            
        static member borderThickness<'t when 't :> Border>(value: float) =
            value |> Thickness |> Border.borderThickness
            
        static member borderThickness<'t when 't :> Border>(horizontal: float, vertical: float) =
            (horizontal, vertical) |> Thickness |> Border.borderThickness
            
        static member borderThickness<'t when 't :> Border>(left: float, top: float, right: float, bottom: float) =
            (left, top, right, bottom) |> Thickness |> Border.borderThickness
            
        static member cornerRadius<'t when 't :> Border>(value: CornerRadius) =
            AttrBuilder<'t>.CreateProperty<CornerRadius>(Border.CornerRadiusProperty, value, ValueNone)
            
        static member cornerRadius<'t when 't :> Border>(value: float) =
            value |> CornerRadius |> Border.cornerRadius
                
        static member cornerRadius<'t when 't :> Border>(horizontal: float, vertical: float) =
            (horizontal, vertical) |> CornerRadius |> Border.cornerRadius
            
        static member cornerRadius<'t when 't :> Border>(left: float, top: float, right: float, bottom: float) =
            (left, top, right, bottom) |> CornerRadius |> Border.cornerRadius
            
        static member boxShadows<'t when 't :> Border>(value: BoxShadows) =
            AttrBuilder<'t>.CreateProperty(Border.BoxShadowProperty, value, ValueNone)
            
        static member boxShadow<'t when 't :> Border>(value: BoxShadow) =
            value |> BoxShadows |> Border.boxShadows
            
        static member child<'t when 't :> Border>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(Border.ChildProperty, value)
        
        static member child<'t when 't :> Border>(value: IView) =
            value |> Some |> Border.child
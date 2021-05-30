namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module SplitView =
    open Avalonia.Controls
    open Avalonia.Media
    open Avalonia.Media.Immutable
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
   
    let create (attrs: IAttr<SplitView> list): IView<SplitView> =
        ViewBuilder.Create<SplitView>(attrs)

    type SplitView with            

        static member content<'t when 't :> SplitView>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(SplitView.ContentProperty, value)

        static member content<'t when 't :> SplitView>(value: IView) =
            value |> Some |> SplitView.content

        static member compactPaneLengthProperty<'t when 't :> SplitView>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(SplitView.CompactPaneLengthProperty, value, ValueNone)

        static member displayMode<'t when 't :> SplitView>(value: SplitViewDisplayMode) =
            AttrBuilder<'t>.CreateProperty<SplitViewDisplayMode>(SplitView.DisplayModeProperty, value, ValueNone)

        static member isPaneOpen<'t when 't :> SplitView>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(SplitView.IsPaneOpenProperty, value, ValueNone)

        static member openPaneLength<'t when 't :> SplitView>(value: float) =
            AttrBuilder<'t>.CreateProperty<float>(SplitView.OpenPaneLengthProperty, value, ValueNone)

        static member paneBackground<'t when 't :> SplitView>(value: IBrush) =
            AttrBuilder<'t>.CreateProperty<IBrush>(SplitView.PaneBackgroundProperty, value, ValueNone)

        static member paneBackground<'t when 't :> SplitView>(color: string) =
            color |> Color.Parse |> ImmutableSolidColorBrush |> SplitView.paneBackground

        static member paneBackground<'t when 't :> SplitView>(value: Color) =
            value |> ImmutableSolidColorBrush |> SplitView.paneBackground

        static member panePlacement<'t when 't :> SplitView>(value: SplitViewPanePlacement) =
            AttrBuilder<'t>.CreateProperty<SplitViewPanePlacement>(SplitView.PanePlacementProperty, value, ValueNone)

        static member pane<'t when 't :> SplitView>(value: IView option) =
            AttrBuilder<'t>.CreateContentSingle(SplitView.PaneProperty, value)

        static member pane<'t when 't :> SplitView>(value: IView) =
            value |> Some |> SplitView.pane

        static member useLightDismissOverlayMode<'t when 't :> SplitView>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(SplitView.UseLightDismissOverlayModeProperty, value, ValueNone)

        static member templateSettings<'t when 't :> SplitView>(value: SplitViewTemplateSettings) =
            AttrBuilder<'t>.CreateProperty<SplitViewTemplateSettings>(SplitView.TemplateSettingsProperty, value, ValueNone)

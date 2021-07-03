module Avalonia.FuncUI.Experiments.DSL.SplitView

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.ContentControl
open Avalonia.Media
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder

type SplitViewBuilder<'t when 't :> SplitView>() = 
    inherit ContentControlBuilder<'t>()

    [<CustomOperation("compactPaneLengthProperty")>]
    member _.compactPaneLengthProperty<'t>(x: DSLElement<'t>, value: float) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float>(SplitView.CompactPaneLengthProperty, value, ValueNone) ]

    [<CustomOperation("displayMode")>]
    member _.displayMode<'t>(x: DSLElement<'t>, value: SplitViewDisplayMode) =
        x @@ [ AttrBuilder<'t>.CreateProperty<SplitViewDisplayMode>(SplitView.DisplayModeProperty, value, ValueNone) ]

    [<CustomOperation("isPaneOpen")>]
    member _.isPaneOpen<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(SplitView.IsPaneOpenProperty, value, ValueNone) ]

    [<CustomOperation("openPaneLength")>]
    member _.openPaneLength<'t>(x: DSLElement<'t>, value: float) =
        x @@ [ AttrBuilder<'t>.CreateProperty<float>(SplitView.OpenPaneLengthProperty, value, ValueNone) ]

    [<CustomOperation("paneBackground")>]
    member _.paneBackground<'t>(x: DSLElement<'t>, value: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(SplitView.PaneBackgroundProperty, value, ValueNone) ]

    [<CustomOperation("panePlacement")>]
    member _.panePlacement<'t>(x: DSLElement<'t>, value: SplitViewPanePlacement) =
        x @@ [ AttrBuilder<'t>.CreateProperty<SplitViewPanePlacement>(SplitView.PanePlacementProperty, value, ValueNone) ]

    [<CustomOperation("pane")>]
    member _.pane<'t>(x: DSLElement<'t>, value: IView) =
        x @@ [ AttrBuilder<'t>.CreateContentSingle(SplitView.PaneProperty, Some value) ]

    [<CustomOperation("useLightDismissOverlayMode")>]
    member _.useLightDismissOverlayMode<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(SplitView.UseLightDismissOverlayModeProperty, value, ValueNone) ]

    [<CustomOperation("templateSettings")>]
    member _.templateSettings<'t>(x: DSLElement<'t>, value: SplitViewTemplateSettings) =
        x @@ [ AttrBuilder<'t>.CreateProperty<SplitViewTemplateSettings>(SplitView.TemplateSettingsProperty, value, ValueNone) ]

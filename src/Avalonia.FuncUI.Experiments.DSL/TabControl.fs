namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module TabControl =
    open Avalonia.Controls
    open Avalonia.Controls.Templates
    open Avalonia.Layout
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<TabControl> list): IView<TabControl> =
        ViewBuilder.Create<TabControl>(attrs)
     
    type TabControl with

        static member tabStripPlacement<'t when 't :> TabControl>(placement: Dock) =
            AttrBuilder<'t>.CreateProperty<Dock>(TabControl.TabStripPlacementProperty, placement, ValueNone)
            
        static member horizontalContentAlignment<'t when 't :> TabControl>(alignment: HorizontalAlignment) =
            AttrBuilder<'t>.CreateProperty<HorizontalAlignment>(TabControl.HorizontalContentAlignmentProperty, alignment, ValueNone)
            
        static member verticalContentAlignment<'t when 't :> TabControl>(alignment: VerticalAlignment) =
            AttrBuilder<'t>.CreateProperty<VerticalAlignment>(TabControl.VerticalContentAlignmentProperty, alignment, ValueNone)
            
        static member contentTemplate<'t when 't :> TabControl>(value: IDataTemplate) =
            AttrBuilder<'t>.CreateProperty<IDataTemplate>(TabControl.ContentTemplateProperty, value, ValueNone)
            
        static member selectedContent<'t when 't :> TabControl>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(TabControl.ContentTemplateProperty, value, ValueNone)
            
        static member onSelectedContentChanged<'t when 't :> TabControl>(func: obj -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<obj>(TabControl.SelectedContentProperty, func, ?subPatchOptions = subPatchOptions)
            
        static member selectedContentTemplate<'t when 't :> TabControl>(value: IDataTemplate) =
            AttrBuilder<'t>.CreateProperty<IDataTemplate>(TabControl.SelectedContentTemplateProperty, value, ValueNone)
            
        static member onSelectedContentTemplateChanged<'t when 't :> TabControl>(func: IDataTemplate -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<IDataTemplate>(TabControl.SelectedContentTemplateProperty, func, ?subPatchOptions = subPatchOptions)
namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module TimePicker =
    open System
    open Avalonia.Controls
    open Avalonia.Controls.Templates
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<TimePicker> list): IView<TimePicker> =
        ViewBuilder.Create<TimePicker>(attrs)
     
    type TimePicker with

        static member clockIdentifier<'t when 't :> TimePicker>(value: string) =
            AttrBuilder<'t>.CreateProperty<string>(TimePicker.ClockIdentifierProperty, value, ValueNone)
        
        static member header<'t when 't :> TimePicker>(value: obj) =
            AttrBuilder<'t>.CreateProperty<obj>(TimePicker.HeaderProperty, value, ValueNone)
        
        static member headerTemplate<'t when 't :> TimePicker>(template: IDataTemplate) =
            AttrBuilder<'t>.CreateProperty<IDataTemplate>(TimePicker.HeaderTemplateProperty, template, ValueNone)
        
        static member minuteIncrement<'t when 't :> TimePicker>(value: int) =
            AttrBuilder<'t>.CreateProperty<int>(TimePicker.MinuteIncrementProperty, value, ValueNone)
        
        static member selectedTime<'t when 't :> TimePicker>(value: Nullable<TimeSpan>) =
            AttrBuilder<'t>.CreateProperty<TimeSpan Nullable>(TimePicker.SelectedTimeProperty, value, ValueNone)
        
        static member onSelectedTimeChanged<'t when 't :> TimePicker>(func: Nullable<TimeSpan> -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<TimeSpan Nullable>(TimePicker.SelectedTimeProperty, func, ?subPatchOptions = subPatchOptions)

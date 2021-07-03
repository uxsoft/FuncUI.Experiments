namespace Avalonia.FuncUI.Experiments.DSL.DatePicker

open System
open Avalonia.Controls
open Avalonia.Controls.Templates
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.FuncUI.Builder
 
type DatePickerBuilder<'t when 't :> DatePicker>() =
    inherit TemplatedControlBuilder<'t>()

     [<CustomOperation("selectedDate")>] 
     member _.selectedDate<'t>(x: DSLElement<'t>, value: DateTimeOffset) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTimeOffset Nullable>(DatePicker.SelectedDateProperty, Nullable value, ValueNone) ]

     [<CustomOperation("onSelectedDateChanged")>] 
     member _.onSelectedDateChanged<'t>(x: DSLElement<'t>, func: Nullable<DateTimeOffset> -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<DateTimeOffset Nullable>(DatePicker.SelectedDateProperty, func) ]

     [<CustomOperation("dayVisible")>] 
     member _.dayVisible<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(DatePicker.DayVisibleProperty, value, ValueNone) ]

     [<CustomOperation("monthVisible")>] 
     member _.monthVisible<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(DatePicker.MonthVisibleProperty, value, ValueNone) ]

     [<CustomOperation("yearVisible")>] 
     member _.yearVisible<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(DatePicker.YearVisibleProperty, value, ValueNone) ]

     [<CustomOperation("dayFormat")>] 
     member _.dayFormat<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(DatePicker.DayFormatProperty, value, ValueNone) ]

     [<CustomOperation("monthFormat")>] 
     member _.monthFormat<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(DatePicker.MonthFormatProperty, value, ValueNone) ]

     [<CustomOperation("yearFormat")>] 
     member _.yearFormat<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(DatePicker.YearFormatProperty, value, ValueNone) ]

     [<CustomOperation("minYear")>] 
     member _.minYear<'t>(x: DSLElement<'t>, value: DateTimeOffset) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTimeOffset>(DatePicker.MinYearProperty, value, ValueNone) ]
        
     [<CustomOperation("maxYear")>] 
     member _.maxYear<'t>(x: DSLElement<'t>, value: DateTimeOffset) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTimeOffset>(DatePicker.MaxYearProperty, value, ValueNone) ]

     [<CustomOperation("header")>] 
     member _.header<'t>(x: DSLElement<'t>, value: obj) =
        x @@ [ AttrBuilder<'t>.CreateProperty<obj>(DatePicker.HeaderProperty, value, ValueNone) ]
    
     [<CustomOperation("headerTemplate")>] 
     member _.headerTemplate<'t>(x: DSLElement<'t>, template: IDataTemplate) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IDataTemplate>(DatePicker.HeaderTemplateProperty, template, ValueNone) ]
    
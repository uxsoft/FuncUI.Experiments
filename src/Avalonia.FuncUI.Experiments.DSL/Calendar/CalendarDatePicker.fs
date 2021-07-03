module Avalonia.FuncUI.Experiments.DSL.CalendarDatePicker

open System
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.FuncUI.Builder

type CalendarDatePickerBuilder<'t when 't :> CalendarDatePicker>() =
    inherit TemplatedControlBuilder<'t>()

     [<CustomOperation("displayDate")>] 
     member _.displayDate<'t>(x: DSLElement<'t>, value: DateTime) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTime>(CalendarDatePicker.DisplayDateProperty, value, ValueNone) ]

     [<CustomOperation("displayDateStart")>] 
     member _.displayDateStart<'t>(x: DSLElement<'t>, value: DateTime) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTime Nullable>(CalendarDatePicker.DisplayDateStartProperty, Nullable value, ValueNone) ]

     [<CustomOperation("displayDateEnd")>] 
     member _.displayDateEnd<'t>(x: DSLElement<'t>, value: DateTime) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTime Nullable>(CalendarDatePicker.DisplayDateEndProperty, Nullable value, ValueNone) ]

     [<CustomOperation("firstDayOfWeek")>] 
     member _.firstDayOfWeek<'t>(x: DSLElement<'t>, value: DayOfWeek) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DayOfWeek>(CalendarDatePicker.FirstDayOfWeekProperty, value, ValueNone) ]

     [<CustomOperation("isDropDownOpen")>] 
     member _.isDropDownOpen<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(CalendarDatePicker.IsDropDownOpenProperty, value, ValueNone) ]

     [<CustomOperation("onDropDownOpenChanged")>] 
     member _.onDropDownOpenChanged<'t>(x: DSLElement<'t>, func: bool -> unit, ?subPatchOptions) =
        x @@ [ AttrBuilder<'t>.CreateSubscription(CalendarDatePicker.IsDropDownOpenProperty, func, ?subPatchOptions = subPatchOptions) ]
    
     [<CustomOperation("isTodayHighlighted")>] 
     member _.isTodayHighlighted<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(CalendarDatePicker.IsTodayHighlightedProperty , value, ValueNone) ]

     [<CustomOperation("selectedDate")>] 
     member _.selectedDate<'t>(x: DSLElement<'t>, value: DateTime) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTime Nullable>(CalendarDatePicker.SelectedDateProperty, Nullable value, ValueNone) ]

     [<CustomOperation("onSelectedDateChanged")>] 
     member _.onSelectedDateChanged<'t>(x: DSLElement<'t>, func: Nullable<DateTime> -> unit, ?subPatchOptions) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<DateTime Nullable>(CalendarDatePicker.SelectedDateProperty, func, ?subPatchOptions = subPatchOptions) ]

     [<CustomOperation("selectedDateFormat")>] 
     member _.selectedDateFormat<'t>(x: DSLElement<'t>, value: CalendarDatePickerFormat) =
        x @@ [ AttrBuilder<'t>.CreateProperty<CalendarDatePickerFormat>(CalendarDatePicker.SelectedDateFormatProperty, value, ValueNone) ]

     [<CustomOperation("customDateFormatString")>] 
     member _.customDateFormatString<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(CalendarDatePicker.CustomDateFormatStringProperty, value, ValueNone) ]

     [<CustomOperation("text")>] 
     member _.text<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(CalendarDatePicker.TextProperty, value, ValueNone) ]

     [<CustomOperation("watermark")>] 
     member _.watermark<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(CalendarDatePicker.WatermarkProperty, value, ValueNone) ]

     [<CustomOperation("useFloatingWatermark")>] 
     member _.useFloatingWatermark<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(CalendarDatePicker.UseFloatingWatermarkProperty, value, ValueNone) ]
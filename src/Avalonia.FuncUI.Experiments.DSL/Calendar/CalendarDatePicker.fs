﻿namespace Avalonia.FuncUI.Experiments.DSL

[<AutoOpen>]
module CalendarDatePicker =
    open System
    open Avalonia.Controls
    open Avalonia.FuncUI.Types
    open Avalonia.FuncUI.Builder
    
    let create (attrs: IAttr<CalendarDatePicker> list): IView<CalendarDatePicker> =
        ViewBuilder.Create<CalendarDatePicker>(attrs)
     
    type CalendarDatePicker with
  
        static member displayDate<'t when 't :> CalendarDatePicker>(value: DateTime) =
            AttrBuilder<'t>.CreateProperty<DateTime>(CalendarDatePicker.DisplayDateProperty, value, ValueNone)

        static member displayDateStart<'t when 't :> CalendarDatePicker>(value: DateTime Nullable) =
            AttrBuilder<'t>.CreateProperty<DateTime Nullable>(CalendarDatePicker.DisplayDateStartProperty, value, ValueNone)

        static member displayDateStart<'t when 't :> CalendarDatePicker>(value: DateTime) =
            value |> Nullable |> CalendarDatePicker.displayDateStart

        static member displayDateStart<'t when 't :> CalendarDatePicker>(value: DateTime option) =
            value |> Option.toNullable |> CalendarDatePicker.displayDateStart

        static member displayDateEnd<'t when 't :> CalendarDatePicker>(value: DateTime Nullable) =
            AttrBuilder<'t>.CreateProperty<DateTime Nullable>(CalendarDatePicker.DisplayDateEndProperty, value, ValueNone)

        static member displayDateEnd<'t when 't :> CalendarDatePicker>(value: DateTime) =
            value |> Nullable |> CalendarDatePicker.displayDateEnd

        static member displayDateEnd<'t when 't :> CalendarDatePicker>(value: DateTime option) =
            value |> Option.toNullable |> CalendarDatePicker.displayDateEnd

        static member firstDayOfWeek<'t when 't :> CalendarDatePicker>(value: DayOfWeek) =
            AttrBuilder<'t>.CreateProperty<DayOfWeek>(CalendarDatePicker.FirstDayOfWeekProperty, value, ValueNone)

        static member isDropDownOpen<'t when 't :> CalendarDatePicker>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(CalendarDatePicker.IsDropDownOpenProperty, value, ValueNone)

        static member onDropDownOpenChanged<'t when 't :> CalendarDatePicker>(func: bool -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription(CalendarDatePicker.IsDropDownOpenProperty, func, ?subPatchOptions = subPatchOptions)
        
        static member isTodayHighlighted<'t when 't :> CalendarDatePicker>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(CalendarDatePicker.IsTodayHighlightedProperty , value, ValueNone)

        static member selectedDate<'t when 't :> CalendarDatePicker>(value: DateTime Nullable) =
            AttrBuilder<'t>.CreateProperty<DateTime Nullable>(CalendarDatePicker.SelectedDateProperty, value, ValueNone)

        static member selectedDate<'t when 't :> CalendarDatePicker>(value: DateTime) =
            value |> Nullable |> CalendarDatePicker.selectedDate

        static member selectedDate<'t when 't :> CalendarDatePicker>(value: DateTime option) =
            value |> Option.toNullable |> CalendarDatePicker.selectedDate

        static member onSelectedDateChanged<'t when 't :> CalendarDatePicker>(func: Nullable<DateTime> -> unit, ?subPatchOptions) =
            AttrBuilder<'t>.CreateSubscription<DateTime Nullable>(CalendarDatePicker.SelectedDateProperty, func, ?subPatchOptions = subPatchOptions)

        static member selectedDateFormat<'t when 't :> CalendarDatePicker>(value: CalendarDatePickerFormat) =
            AttrBuilder<'t>.CreateProperty<CalendarDatePickerFormat>(CalendarDatePicker.SelectedDateFormatProperty, value, ValueNone)

        static member customDateFormatString<'t when 't :> CalendarDatePicker>(value: string) =
            AttrBuilder<'t>.CreateProperty<string>(CalendarDatePicker.CustomDateFormatStringProperty, value, ValueNone)

        static member text<'t when 't :> CalendarDatePicker>(value: string) =
            AttrBuilder<'t>.CreateProperty<string>(CalendarDatePicker.TextProperty, value, ValueNone)

        static member watermark<'t when 't :> CalendarDatePicker>(value: string) =
            AttrBuilder<'t>.CreateProperty<string>(CalendarDatePicker.WatermarkProperty, value, ValueNone)

        static member useFloatingWatermark<'t when 't :> CalendarDatePicker>(value: bool) =
            AttrBuilder<'t>.CreateProperty<bool>(CalendarDatePicker.UseFloatingWatermarkProperty, value, ValueNone)


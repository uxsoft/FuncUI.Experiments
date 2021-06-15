module Avalonia.FuncUI.Experiments.DSL.Calendar

open System
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.Media
open Avalonia.Media.Immutable
open Avalonia.Controls
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
 
type CalendarBuilder<'t when 't :> Calendar>() =
    inherit TemplatedControlBuilder<'t>()

     [<CustomOperation("firstDayOfWeek")>] 
     member _.firstDayOfWeek<'t>(x: DSLElement<'t>, value: DayOfWeek) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DayOfWeek>(Calendar.FirstDayOfWeekProperty, value, ValueNone) ]
    
     [<CustomOperation("isTodayHighlighted")>] 
     member _.isTodayHighlighted<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(Calendar.IsTodayHighlightedProperty , value, ValueNone) ]

     [<CustomOperation("headerBackground")>] 
     member _.headerBackground<'t>(x: DSLElement<'t>, value: IBrush) =
        x @@ [ AttrBuilder<'t>.CreateProperty<IBrush>(Calendar.HeaderBackgroundProperty, value, ValueNone) ]

     [<CustomOperation("displayMode")>] 
     member _.displayMode<'t>(x: DSLElement<'t>, value: CalendarMode) =
        x @@ [ AttrBuilder<'t>.CreateProperty<CalendarMode>(Calendar.DisplayModeProperty, value, ValueNone) ]

     [<CustomOperation("onDisplayModeChanged")>] 
     member _.onDisplayModeChanged<'t>(x: DSLElement<'t>, func: CalendarMode -> unit, ?subPatchOptions) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<CalendarMode>(Calendar.DisplayModeProperty, func, ?subPatchOptions = subPatchOptions) ]

     [<CustomOperation("selectionMode")>] 
     member _.selectionMode<'t>(x: DSLElement<'t>, value: CalendarSelectionMode) =
        x @@ [ AttrBuilder<'t>.CreateProperty<CalendarSelectionMode>(Calendar.SelectionModeProperty, value, ValueNone) ]

     [<CustomOperation("onSelectionModeChanged")>] 
     member _.onSelectionModeChanged<'t>(x: DSLElement<'t>, func: CalendarSelectionMode  -> unit, ?subPatchOptions) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<CalendarSelectionMode >(Calendar.SelectionModeProperty, func, ?subPatchOptions = subPatchOptions) ]

     [<CustomOperation("selectedDate")>] 
     member _.selectedDate<'t>(x: DSLElement<'t>, value: DateTime) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTime Nullable>(Calendar.SelectedDateProperty, Nullable value, ValueNone) ]

     [<CustomOperation("onSelectedDateChanged")>] 
     member _.onSelectedDateChanged<'t>(x: DSLElement<'t>, func: Nullable<DateTime> -> unit, ?subPatchOptions) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<DateTime Nullable>(Calendar.SelectedDateProperty, func, ?subPatchOptions = subPatchOptions) ]

     [<CustomOperation("displayDate")>] 
     member _.displayDate<'t>(x: DSLElement<'t>, value: DateTime) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTime>(Calendar.DisplayDateProperty, value, ValueNone) ]

     [<CustomOperation("displayDateStart")>] 
     member _.displayDateStart<'t>(x: DSLElement<'t>, value: DateTime) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTime Nullable>(Calendar.DisplayDateStartProperty, Nullable value, ValueNone) ]

     [<CustomOperation("displayDateEnd")>] 
     member _.displayDateEnd<'t>(x: DSLElement<'t>, value: DateTime) =
        x @@ [ AttrBuilder<'t>.CreateProperty<DateTime Nullable>(Calendar.DisplayDateEndProperty, Nullable value, ValueNone) ]
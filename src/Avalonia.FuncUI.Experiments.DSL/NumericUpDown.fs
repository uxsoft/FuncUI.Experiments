module Avalonia.FuncUI.Experiments.DSL.NumericUpDown

open System.Globalization

open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Experiments.DSL.TemplatedControl
open Avalonia.FuncUI.Builder

type NumericUpDownBuilder<'t when 't :> NumericUpDown>() =
    inherit TemplatedControlBuilder<'t>()

    /// <summary>
    /// Sets a value indicating whether the <see cref="NumericUpDown"/> should allow to spin.
    /// </summary>
    [<CustomOperation("allowSpin")>]
    member _.allowSpin<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(NumericUpDown.AllowSpinProperty, value, ValueNone) ]

    /// <summary>
    /// Sets a value indicating whether the up and down buttons should be shown.
    /// </summary>
    [<CustomOperation("showButtonSpinner")>]
    member _.showButtonSpinner<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(NumericUpDown.ShowButtonSpinnerProperty, value, ValueNone) ]

    /// <summary>
    /// Sets current location of the <see cref="NumericUpDown"/>.
    /// </summary>
    [<CustomOperation("buttonSpinnerLocation")>]
    member _.buttonSpinnerLocation<'t>(x: DSLElement<'t>, value: Location) =
        x @@ [ AttrBuilder<'t>.CreateProperty<Location>(NumericUpDown.ButtonSpinnerLocationProperty, value, ValueNone) ]

    /// <summary>
    /// Sets if the value should be clipped if the minimum/maximum is reached
    /// </summary>
    [<CustomOperation("clipValueToMinMax")>]
    member _.clipValueToMinMax<'t>(x: DSLElement<'t>, value: bool) =
        let getter : ('t -> bool) = (fun control -> control.ClipValueToMinMax)
        let setter : ('t * bool -> unit) = (fun (control, value) -> control.ClipValueToMinMax <- value)

        x @@ [ AttrBuilder<'t>.CreateProperty<bool>("ClipValueToMinMax", value, ValueSome getter, ValueSome setter, ValueNone) ]

    /// <summary>
    /// Sets the culture info used for formatting
    /// </summary>
    [<CustomOperation("cultureInfo")>]
    member _.cultureInfo<'t>(x: DSLElement<'t>, value: CultureInfo) =
        let getter : ('t -> CultureInfo) = (fun control -> control.CultureInfo)
        let setter : ('t * CultureInfo -> unit) = (fun (control, value) -> control.CultureInfo <- value)

        x @@ [ AttrBuilder<'t>.CreateProperty<CultureInfo>("CultureInfo", value, ValueSome getter, ValueSome setter, ValueNone) ]

    [<CustomOperation("formatString")>]
    member _.formatString<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(NumericUpDown.FormatStringProperty, value, ValueNone) ]

    [<CustomOperation("increment")>]
    member _.increment<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(NumericUpDown.IncrementProperty, value, ValueNone) ]

    [<CustomOperation("isReadOnly")>]
    member _.isReadOnly<'t>(x: DSLElement<'t>, value: bool) =
        x @@ [ AttrBuilder<'t>.CreateProperty<bool>(NumericUpDown.IsReadOnlyProperty, value, ValueNone) ]

    [<CustomOperation("minimum")>]
    member _.minimum<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(NumericUpDown.MinimumProperty, value, ValueNone) ]

    [<CustomOperation("maximum")>]
    member _.maximum<'t>(x: DSLElement<'t>, value: double) =
        x @@ [ AttrBuilder<'t>.CreateProperty<double>(NumericUpDown.MaximumProperty, value, ValueNone) ]

    [<CustomOperation("parsingNumberStyle")>]
    member _.parsingNumberStyle<'t>(x: DSLElement<'t>, value: NumberStyles) =
        let getter : ('t -> NumberStyles) = (fun control -> control.ParsingNumberStyle)
        let setter : ('t * NumberStyles -> unit) = (fun (control, value) -> control.ParsingNumberStyle <- value)

        x @@ [ AttrBuilder<'t>.CreateProperty<NumberStyles>("ParsingNumberStyle", value, ValueSome getter, ValueSome setter, ValueNone) ]

    [<CustomOperation("text")>]
    member _.text<'t>(x: DSLElement<'t>, value: string) =
        let getter : ('t -> string) = (fun control -> control.Text)
        let setter : ('t * string -> unit) = (fun (control, value) -> control.Text <- value)

        x @@ [ AttrBuilder<'t>.CreateProperty<string>("Text", value, ValueSome getter, ValueSome setter, ValueNone) ]

    [<CustomOperation("onTextChanged")>]
    member _.onTextChanged<'t>(x: DSLElement<'t>, func: string -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<string>(NumericUpDown.TextProperty, func) ]

    [<CustomOperation("value")>]
    member _.value<'t>(x: DSLElement<'t>, value: double) =
        let getter : ('t -> double) = (fun control -> control.Value)
        let setter : ('t * double -> unit) = (fun (control, value) -> control.Value <- value)

        x @@ [ AttrBuilder<'t>.CreateProperty<double>("Value", value, ValueSome getter, ValueSome setter, ValueNone) ]

    [<CustomOperation("onValueChanged")>]
    member _.onValueChanged<'t>(x: DSLElement<'t>, func: double -> unit) =
        x @@ [ AttrBuilder<'t>.CreateSubscription<double>(NumericUpDown.ValueProperty, func) ]

    [<CustomOperation("watermark")>]
    member _.watermark<'t>(x: DSLElement<'t>, value: string) =
        x @@ [ AttrBuilder<'t>.CreateProperty<string>(NumericUpDown.WatermarkProperty, value, ValueNone) ]
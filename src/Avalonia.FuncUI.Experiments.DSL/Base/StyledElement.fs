namespace Avalonia.FuncUI.Experiments.DSL.StyledElement

open Avalonia
open Avalonia.FuncUI.Experiments.DSL.Common
open Avalonia.FuncUI.Types
open Avalonia.FuncUI.Builder
open Avalonia.Styling
open Avalonia.Controls
open Avalonia.FuncUI.Experiments.DSL.Animatable
        
type StyledElementBuilder<'t when 't :> StyledElement>() =
    inherit AnimatableBuilder<'t>()
    
    [<CustomOperation("dataContext")>]
    member _.dataContext<'t>(x: DSLElement<'t>, dataContext: obj) =
        AttrBuilder<'t>.CreateProperty<obj>(StyledElement.DataContextProperty, dataContext, ValueNone)
        |> x.attr
        
    [<CustomOperation("name")>]
    member _.name<'t>(x: DSLElement<'t>, name: string) =
        AttrBuilder<'t>.CreateProperty<string>(StyledElement.NameProperty, name, ValueNone)
        |> x.attr
        
    [<CustomOperation("templatedParent")>]
    member _.templatedParent<'t>(x: DSLElement<'t>, template: ITemplatedControl) =
        AttrBuilder<'t>.CreateProperty<ITemplatedControl>(StyledElement.TemplatedParentProperty, template, ValueNone)
        |> x.attr
        
    [<CustomOperation("classes")>]
    member _.classes<'t>(x: DSLElement<'t>, value: string list) =
        let getter : ('t -> Classes) = (fun control -> control.Classes)
        let setter : ('t * Classes -> unit) = (fun (control, value) -> control.Classes <- value)
        
        AttrBuilder<'t>.CreateProperty<Classes>("Classes", Classes value, ValueSome getter, ValueSome setter, ValueNone, fun () -> Classes())
        |> x.attr
        
    /// Use 'classes' instead when possible.
    [<CustomOperation("styles")>]
    member _.styles<'t>(x: DSLElement<'t>, value: Styles) =
        let getter : ('t -> Styles) = (fun control -> control.Styles)
        let setter : ('t * Styles -> unit) = 
            (fun (control, value) -> 
                 control.Styles.Clear()
                 control.Styles.AddRange(value))

        AttrBuilder<'t>.CreateProperty<Styles>("Styles", value, ValueSome getter, ValueSome setter, ValueNone, fun () -> Styles())
        |> x.attr
        
    [<CustomOperation("resources")>]
    member _.resources<'t>(x: DSLElement<'t>, value: IResourceDictionary) =
        let getter : ('t -> IResourceDictionary) = (fun control -> control.Resources)
        let setter : ('t * IResourceDictionary -> unit) = (fun (control, value) -> control.Resources <- value)
        let factory = fun () -> ResourceDictionary() :> IResourceDictionary
        
        AttrBuilder<'t>.CreateProperty<IResourceDictionary>("Resources", value, ValueSome getter, ValueSome setter, ValueNone, factory)
        |> x.attr
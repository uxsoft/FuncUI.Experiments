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
    member _.dataContext<'t>(x: IAttr<'t> list, dataContext: obj) =
        x @ [ AttrBuilder<'t>.CreateProperty<obj>(StyledElement.DataContextProperty, dataContext, ValueNone) ]
        
    [<CustomOperation("name")>]
    member _.name<'t>(x: IAttr<'t> list, name: string) =
        x @ [ AttrBuilder<'t>.CreateProperty<string>(StyledElement.NameProperty, name, ValueNone) ]
        
    [<CustomOperation("templatedParent")>]
    member _.templatedParent<'t>(x: IAttr<'t> list, template: ITemplatedControl) =
        x @ [ AttrBuilder<'t>.CreateProperty<ITemplatedControl>(StyledElement.TemplatedParentProperty, template, ValueNone) ]
        
    [<CustomOperation("classes")>]
    member _.classes<'t>(x: IAttr<'t> list, value: string list) =
        let getter : ('t -> Classes) = (fun control -> control.Classes)
        let setter : ('t * Classes -> unit) = (fun (control, value) -> control.Classes <- value)
        
        x @ [ AttrBuilder<'t>.CreateProperty<Classes>("Classes", Classes value, ValueSome getter, ValueSome setter, ValueNone, fun () -> Classes()) ]
        
    /// Use 'classes' instead when possible.
    [<CustomOperation("styles")>]
    member _.styles<'t>(x: IAttr<'t> list, value: Styles) =
        let getter : ('t -> Styles) = (fun control -> control.Styles)
        let setter : ('t * Styles -> unit) = 
            (fun (control, value) -> 
                 control.Styles.Clear()
                 control.Styles.AddRange(value))

        x @ [ AttrBuilder<'t>.CreateProperty<Styles>("Styles", value, ValueSome getter, ValueSome setter, ValueNone, fun () -> Styles()) ]
        
    [<CustomOperation("resources")>]
    member _.resources<'t>(x: IAttr<'t> list, value: IResourceDictionary) =
        let getter : ('t -> IResourceDictionary) = (fun control -> control.Resources)
        let setter : ('t * IResourceDictionary -> unit) = (fun (control, value) -> control.Resources <- value)
        let factory = fun () -> ResourceDictionary() :> IResourceDictionary
        
        x @ [ AttrBuilder<'t>.CreateProperty<IResourceDictionary>("Resources", value, ValueSome getter, ValueSome setter, ValueNone, factory) ]
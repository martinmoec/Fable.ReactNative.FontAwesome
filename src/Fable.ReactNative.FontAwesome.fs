module Fable.ReactNative.FontAwesome

open Fable.Core
open Fable.React
open Fable.Core.JsInterop
open Fable
open Fable.ReactNative.Types

type IFontAwesomeProperties =
    inherit TextProperties

and IFontAwesomeStatic =
    inherit React.ReactElementType<IFontAwesomeProperties>

and FontAwesome =
    FontAwesomeStatic

type Globals = 
    [<Import("default", "react-native-fontawesome")>] 
    static member FontAwesome with get(): IFontAwesomeStatic = jsNative and set(v: IFontAwesomeStatic): unit = jsNative
    
    //static member FontAwesome : ReactElementType<FontAwesomeProperties> = importDefault "react-native-fontawesome"
    [<Import("parseIconFromClassName", from="react-native-fontawesome")>]
    static member ParseIconFromClassName with get(): string -> System.Enum = failwith "JS only"


let fa className ( style: Props.IStyle list ) =    
    let props = 
        createObj [ 
            "style" ==> keyValueList CaseRules.LowerFirst style
            "icon"  ==> Globals.ParseIconFromClassName className 
        ] |> unbox
    
    ReactBindings.React.createElement( Globals.FontAwesome, props, [] )
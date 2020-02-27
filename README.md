# Fable.ReactNative.FontAwesome - Fable bindings for react-native-fontawesome

Provides simple Fable bindings for the [react-native-fontawesome](https://github.com/entria/react-native-fontawesome) module for Fable.ReactNative projects.

## Setup

Add the [nuget](https://www.nuget.org/packages/Fable.ReactNative.FontAwesome) to your F# project:

`paket add Fable.ReactNative.FontAwesome`


You will need to install the `react-native-fontawesome` package to your react-native project. 

`yarn add react-native-fontawesome`

You will also need to add the `.ttf` files to your project. You can get these [here.](https://github.com/entria/react-native-fontawesome/tree/master/sample/assets/fonts) 

How to add the `.ttf` files:
- [iOS](https://medium.com/react-native-training/adding-custom-fonts-to-react-native-b266b41bff7f)
- [Android](https://medium.com/@gattermeier/custom-fonts-in-react-native-for-android-b8a331a7d2a7)

For further info see the [react-native-fontawesome](https://github.com/entria/react-native-fontawesome) project.

## Samples
The `fa` function takes a Font Awesome class string and a list of Fable.ReactNative style properties. See [FontAwesome](https://fontawesome.com/) for class names.

Minimum sample:
```FSharp
open Fable.ReactNative.FontAwesome

fa "fas fa-arrow-right" [] 
```


Sample use with Fable.ReactNative:
```FSharp

...
// Fable.ReactNative modules
module R = Fable.ReactNative.Helpers
open Fable.ReactNative.Props

open Fable.ReactNative.FontAwesome

let view model dispatch = 
    R.view [] [

        // plus icon
        fa "far fa-plus" []
        

        // trash icon with styling
        fa "fas fa-trash" [
            TextAlign TextAlignment.Center
            FontSize 20.
            Color "#1bc489"
        ]


        // button with arrow
        fontAwesome "fas fa-arrow-right" [
            TextAlign TextAlignment.Center
            FontSize 15.
        ]
        |> R.touchableHighlightWithChild [
            P.TouchableHighlightProperties.Style [
                FlexStyle.Padding ( R.dip 10. )
                JustifyContent JustifyContent.Center
            ]
            OnPress ( fun _ -> dispatch ( SomeMessage ) )
        ]
    ]

```
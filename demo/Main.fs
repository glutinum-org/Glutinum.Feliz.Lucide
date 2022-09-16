module Demo.Hook

open Feliz
open Browser.Dom
open Fable.Core.JsInterop
open Feliz.Lucide

// Workaround to have React-refresh working
// I need to open an issue on react-refresh to see if they can improve the detection
emitJsStatement () "import React from \"react\""

importSideEffects "./index.scss"

[<ReactComponent>]
let private Component () =
    Html.div [
        prop.className "wrapper"

        prop.children [
            Lucide.Camera [
                lucide.size 48
                svg.fill "lightblue"
            ]
        ]
    ]

ReactDOM.render(
    Component ()
    ,
    document.getElementById("root")
)

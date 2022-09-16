namespace Feliz.Lucide

open Feliz
open Fable.Core

[<Erase>]
type lucide =
    /// Function that will be invoked with observable element's width and height.
    /// Default: undefined
    static member inline size(value: string) = Interop.svgAttribute "size" value

    static member inline size(value: float) = Interop.svgAttribute "size" value

    static member inline size(value: int) = Interop.svgAttribute "size" value

# Glutinum.Feliz.Lucide

Binding for [lucide-react](https://www.npmjs.com/package/lucide-react)

## Usage

### Prefixed usage

```fs
open Feliz
open Feliz.Lucide

[<ReactComponent>]
let private App () =
    Lucide.Camera [
        lucide.size 48 // Use lucide specific props
        svg.fill "lightblue" // Use any svg props
    ]
```

### Non-prefixed usage

```fs
open Feliz
open Feliz.Lucide

open type Lucide

[<ReactComponent>]
let private App () =
    Camera [
        lucide.size 48 // Use lucide specific props
        svg.fill "lightblue" // Use any svg props
    ]
```

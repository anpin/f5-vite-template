module App

open Browser.Dom
open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape
let maxLevel = 10
let rec drawCircle p5 x radius level =
    let height = height p5 |> float
    let tt = (126 * level) / maxLevel
    fill p5 (Grayscale tt)
    circle p5 x (height / 2.0) (radius * 2.0)

    if level > 1 then
        do
            drawCircle p5 (x - radius / 2.0) (radius / 2.0) (level - 1)
            drawCircle p5 (x + radius / 2.0) (radius / 2.0) (level - 1)

// Instead of global variables, Perfect Fifth allows you to use a state data
// type. This data type gets updated every frame using the `update` function.
let node = document.querySelector (".canvas-wrapper")

type State = int

let setup p5 =
    let cn = node.getBoundingClientRect()
    resizeCanvas p5 (cn.width |> int) (cn.height |> int)
    stroke p5 (Grayscale 255)

    // The intial state.
    0

let update p5 state  =
    match state + (height p5 / 100) with
    | y when y > height p5 * height p5 -> 0
    | y -> y

let draw p5 (state : int) =
    background p5 (Grayscale 0)
    drawCircle p5 ( (p5 |> width  |> float) / 2.0 ) ( state |> float)  maxLevel 


let run node =
    simulate
        node // Target canvas wrapper
        setup // Function called once at startup
        update // Function that updates state every fraem
        draw // Function that draws something based on the state

node |> Element |> run 
/// KAIST CS220 In-Class Activity Project

module CS220.Program

type IShape =
  abstract Area: float

type Rectangle (width: float, height: float) =
  interface IShape with
    member __.Area = width * height

type Circle (radius: float) =
  interface IShape with
    member __.Area = System.Math.PI * radius * radius

let isCircleLargerThanRectangle (circ: IShape) (rect: IShape) =
  circ.Area > rect.Area

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  let circ = Circle (2.0)
  let rect = Rectangle (4.0, 2.0)
  isCircleLargerThanRectangle circ rect
  |> printfn "%b"
  0 (* Never modify this *)

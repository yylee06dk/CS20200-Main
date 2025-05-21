open Test.Point



[<EntryPoint>]
let main _ =
  let a = Point (1.0, 3.0)
  let b = Point (3.0, 4.0)
  let c = a+b
  let (x: float) = c.x
  let (y: float) = c.y
  printfn "%f" x
  printfn "%f" y
  0

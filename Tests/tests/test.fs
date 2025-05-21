open System.Threading

let f () =
  let thread = new Thread (fun () ->
    for _ = 1 to 10 do printfn "New Thread!")
  thread.Start ()
  for _ = 1 to 10 do printfn "Main Thread!"


[<EntryPoint>]
let main _ =
  f ()
  0

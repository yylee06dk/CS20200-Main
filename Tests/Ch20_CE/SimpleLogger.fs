// Simple logger

type logger () =
  member _.Bind (m, f) = 
    match m with
    | None -> 
      printfn "None Case"
      None
    | Some x ->
      x |> printfn "Current Value : %d"
      f x
    
  member _.Return m =
    Some m

let posadd a b =
  let c = a+b
  if c < 0 then None
  else Some c

let log = logger ()

let workflow a b c d =
  log 
    {
      let! r = posadd a b
      let! r = posadd r c
      let! r = posadd r d
      return r
    }


[<EntryPoint>]
let main _ =
  match (workflow 1 3 5 6) with
  | None -> printfn "Case1 : None"
  | Some x -> printfn "Case1 : Sum is %d" x

  match (workflow 1 -2 4 7) with
  | None -> printfn "Case2 : None"
  | Some x -> printfn "Case2 : Sum is %d" x
  0

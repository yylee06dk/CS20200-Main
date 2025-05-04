/// KAIST CS220 In-Class Activity Project

module CS220.Program

open Stream

let rec ones = Cons (1, fun () -> ones)

let rec map fn stream =
  match stream with
  | Cons (elt, thunk) -> Cons (fn elt, fun () -> map fn (thunk ()))
  | Nil -> Nil

let rec fold fn acc stream =
  match stream with
  | Cons (elt, thunk) -> fold fn (fn acc elt) (thunk ())
  | Nil -> acc

let rec filter fn acc stream =
  match stream with
  | Cons (elt, thunk) when fn elt -> filter fn (Cons (elt, fun () -> acc)) (thunk ())
  | Cons (_, thunk) -> filter fn acc (thunk ())
  | Nil -> acc

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  ones
  |> fold (fun acc elt -> acc+elt) 0
  |> printfn "%d"
  0 (* Never modify this *)

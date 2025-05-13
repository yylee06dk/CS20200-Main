/// KAIST CS220 In-Class Activity Project

module CS220.Program

open FSharpx.Collections

let inf =
  LazyList.unfold (fun n -> Some (n, n + 1)) 1

// Problem
let rec pairwise lst =
  match lst with
  | LazyList.Cons (hd1, LazyList.Cons (hd2, tl)) ->
    LazyList.consDelayed ((hd1, hd2), (fun () -> pairwise (tl)))
  | _ -> failwith "Err"

  

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  inf
  |> pairwise
  |> LazyList.take 10
  |> LazyList.iter (fun (a, b) -> printfn "%d, %d" a b)
  0 (* Never modify this *)

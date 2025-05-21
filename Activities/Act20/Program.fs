/// KAIST CS220 In-Class Activity Project

module CS220.Program

type ListBuilder () =
  // seq<list<int>> -> list<int>
  member _.For (exprs, f) =
    exprs |> Seq.collect f |> Seq.toList

  // = Return (Wrap the value)
  member _.Yield (x) =
    [ x ] 

let mylist = ListBuilder ()

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  mylist { for i in [1 .. 10] do yield i * i }
  |> List.iter (printfn "%d")
  printfn ""
  mylist { for i = 10 downto 1 do yield i }
  |> List.iter (printfn "%d")
  0 (* Never modify this *)

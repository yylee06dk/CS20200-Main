/// KAIST CS220 In-Class Activity Project

module CS220.Program

[<AbstractClass>]
type Animal () =
  abstract Age: int
  abstract MakeSound: unit -> unit

type Dog (age: int) =
  inherit Animal ()
  override __.Age = age
  override __.MakeSound () = printfn "Woof"

type Cat (age: int) =
  inherit Animal ()
  override __.Age = age
  override __.MakeSound () = printfn "Woof"

let makeAnimalList cnt =
  List.init cnt (fun idx ->
    if idx % 2 = 0 then Dog (idx % 10) :> Animal
    else Cat (idx % 10) :> Animal)

/// Compute the sum of ages of the given animals.
let sumAnimalAges (lst: Animal list) =
  lst
  |> List.fold (fun sum animal -> sum + animal.Age) 0

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  makeAnimalList 100
  |> sumAnimalAges
  |> printfn "sum: %d"
  0 (* Never modify this *)

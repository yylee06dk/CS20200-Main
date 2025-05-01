/// KAIST CS220 In-Class Activity Project

namespace CS220

type Stream<'a> =
  | Nil
  | Cons of 'a * (unit -> Stream<'a>)

module Stream =
  let car stream =
    match stream with
    | Cons (hd, tl) -> hd
    | Nil -> failwith "Empty"

  let cdr stream = 
    match stream with
    | Cons (hd, tl) -> tl ()
    | Nil -> failwith "Empty"

  let rec take n stream = 
    match stream with
    | Cons (hd, tl) ->
      if n = 0 then Nil
      else Cons (hd, fun () -> take (n-1) (tl ()))
    | Nil -> Nil

  let rec fromList lst = 
    match lst with
    | hd :: tl -> Cons (hd, fun () -> fromList tl)
    | [] -> Nil


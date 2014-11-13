namespace FSharpSeminarLibrary

open System

module Utils =

  let ParseDate(dateString: string): DateTime =
    let (success, date) = DateTime.TryParse(dateString)
    if success then date else DateTime.MinValue

  let GetNumbers(fromNumber: int, toNumber: int) = Array.ofList [fromNumber..toNumber]

  let SumSquaresOrElse(numbers: int[]) =
    match numbers with
    | [||] -> 100
    | [|10|] -> 20
    | [|p|] -> p    
    | [|p1; p2|] when p1 = p2 -> p1 + p2
    | [|p1; p2|]  -> p1 * p2
    | _ -> numbers |> Array.map (fun n -> n * n) |> Array.sum

  let Add = fun x y -> x + y

  let Add2 x y = x + y

  let Add3(x, y) = x + y
module Synthesis

let abelar v = 
    (v>12) && (v<3097) && (v%2=0)

let area b h = 
    match b<0.0 || h<0.0 with
    | true -> failwith "ShouldFail"
    | _ -> 0.5 * b * h 

let zollo v = 
    match v<0 with
    | true -> v*(-1)
    | false -> v*2

let min a b = 
    match a<b with
    | true -> a
    | false -> b

let max a b = 
    match a> b with
    | true -> a
    | false -> b

let ofTime h m s = 
    (h*3600) + (m*60) + s

let toTime = fun s -> 
                match s<0 with
                | true -> (0,0,0)
                | false -> (s/3600, (s%3600)/60, s % 60)

let digits d = 
    let rec count n = 
        match n <> 0 with 
        | false -> 1
        | _ ->
            match n/10=0 with 
            | true -> 1
            | _ -> 1 + count (n/10)
    count d

let minmax (a,b,c,d) =
    min a b |> min c |> min d, max a b |> max c |> max d

let isLeap y = 
    match y < 1582 with 
    | true -> failwith "failed"
    | _-> match (y%4=0) && (y%100<>0) with
          | true -> true
          | _ -> y% 400 =0

let month = function
     | 1 -> ("January",31)
     | 2 -> ("February", 28)
     | 3 -> ("March", 31)
     | 4 -> ("April", 30)
     | 5 -> ("May", 31)
     | 6 -> ("June", 30)
     | 7 -> ("July", 31)
     | 8 -> ("August", 31)
     | 9 -> ("September", 30)
     | 10 -> ("October", 31)
     | 11 -> ("November", 30)
     | 12 -> ("December", 31)  
     | _-> failwith "Not a month"

let toBinary num = 
    match num < 0 with
    | true -> failwith "Negative number"
    | _-> match num =0 with 
          | true -> "0"
          | _-> let rec count n result =
                    match n>0 with 
                    | false -> result
                    | _-> match n%2 with
                          | 0 -> count (n/2) ("0" + result)  
                          | _ -> count (n/2) ("1" + result) 
                count num ""
(*
let bizFuzz num =
    let rec biz n (three, five, both) = 
        match n>num with 
        | true -> (three, five, both)
        | _-> 
            match n%3=0 with 
            | true -> (three+1,five,both)
            | _ ->
                match n%5=0 with 
                | true -> (three,five+1,both)
                | _ -> 
                    match (n%3=0&&n%5=0) with
                    | true -> (three,five,both+1)
                    | _ -> biz (n+1) (three, five, both) 
    biz 1 (0,0, 0)
    *)
let bizFuzz num = 
    let rec biz n (three, five, both) = 
        match n>num with 
        | true -> (three, five, both)
        |_->
            match (n%3=0, n%5=0) with
            | true, true -> biz (n+1) (three+1, five+1, both+1)
            | false, true -> biz (n+1) (three, five+1, both)
            | true, false -> biz (n+1) (three+1, five, both)
            | false, false -> biz (n+1) (three, five, both)
            | _ -> (0,0,0)
    biz 1 (0,0,0)


let monthDay d y =
  
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"
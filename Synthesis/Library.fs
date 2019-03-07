module Synthesis

let abelar = fun v -> (v>12) && (v<3097) && (v%2=0)
failwith "Not implemented"
    (*match v > 12 with 
    | false -> false
    | true -> 
        match v <3097 with 
        | false -> false 
        | true -> 
            match v%12=0 with
            | false -> false
            | true -> true
failwith "Not implemented"
*)

let area b h =
    match b<0.0 || h<0.0 with
    | true -> failwith "ShouldFail"
    | _ -> 0.5 * b * h 

failwith "Not implemented"

let zollo v =
    match v<0 with
    | true -> v*(-1)
    | false -> v*2
failwith "Not implemented"

let min a b = 
    match a<b with
    | true -> a
    | false -> b
failwith "Not implemented"

let max a b =
    match a> b with
    | true -> a
    | false -> b
failwith "Not implemented"

let ofTime h m s = (h*3600) + (m*60) + s
failwith "Not implemented"

let toTime = fun s -> 
                match s<0 with
                | true -> (0,0,0)
                | false -> (s/3600, (s%3600)/60, s % 60)
failwith "Not implemented"

let digits d = 
    let rec count n = 
        match n <> 0 with 
        | false -> 1
        | _ ->
            match n/10=0 with 
            | true -> 1
            | _ -> 1 + count (n/10)
    count d
failwith "Not implemented"

let minmax year =
    failwith "Not implemented"

let isLeap year=
    fun year ->
        match year < 1582 with 
        | true -> failwith "Failed"
        | _ -> 
            match (year%4=0) || (year%100=0) || (year%400=0) with 
            | false -> false
            | true -> true   
failwith "Not implemented"

let month mon = 
    match (mon<1)||(mon >12) with
    | true -> failwith "Failed"
    | _ ->
        match mon with
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
        
failwith "Not implemented"

let toBinary binary =
    let rec result n = 
        match n>0 with 
        | false -> 0
        | _-> 
            match n/2=0 with
            | true -> 0
            | _-> n%2 + result (n/2)
    result binary
failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"
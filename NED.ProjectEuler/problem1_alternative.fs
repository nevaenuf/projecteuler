namespace NED.ProjectEuler.Problems
    module Problem1Alternative = 
        let multiples (a:int) = 
            match (a % 3, a % 5) with 
                | (0, _) -> a
                | (_, 0) -> a
                | _ -> 0
        let solve (a:int) = 
            let arr = [|0 .. a - 1|]
            Array.sumBy multiples arr |> printf "Problem 1 alternative solution: %i \n"
            //233168
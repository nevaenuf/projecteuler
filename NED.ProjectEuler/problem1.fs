namespace NED.ProjectEuler.Problems
    module Problem1 = 
        let multiples (a:int) = 
            match a with 
                | a when a % 3 = 0 -> a
                | a when a % 5 = 0 -> a
                | _ -> 0
        let solve (a:int) = 
            let arr = [|0 .. a - 1|]
            Array.sumBy multiples arr |> printf "Problem 1 solution: %i \n"
            //233168
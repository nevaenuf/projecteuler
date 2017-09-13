namespace NED.ProjectEuler.Problems
    
    open NED.ProjectEuler.Utility

    module Problem3 = 
        let solve = 
            let n = 600851475143L        
            factors (1L, n, n) |> Seq.collect(fun (x, y) -> seq{yield x; yield y}) |>  Seq.filter (fun elem -> isPrime elem ) |> Seq.max |> printf "Problem 3 Solution: %i \n"
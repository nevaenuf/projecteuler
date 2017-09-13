namespace NED.ProjectEuler.Problems
    module Problem2 = 
        let solve = 
            let max = 4000000
            let rec fib (i:int) = 
                match i with
                    | 0 -> 0
                    | 1 -> 1
                    | i -> fib(i - 1) + fib(i - 2)

            Seq.initInfinite (id)
                |> Seq.map fib
                |> Seq.filter (fun elem -> elem % 2 = 0)
                |> Seq.takeWhile (fun elem -> elem < max)
                |> Seq.sum
                |> printf "Problem 2 Solution: %i \n" 
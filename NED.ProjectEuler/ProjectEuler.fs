module Program
open NED.ProjectEuler.Problems

[<EntryPoint>]
let main argv =
    Problem1.solve 1000
    Problem1Alternative.solve 1000
    Problem2.solve
    Problem3.solve
    Problem4.solve    
    0 // return an integer exit code

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

(*
    Problem 5 work...
 2, 2, 2, 2, 5, 19, 3, 3, 17, 7, 13, 11 = 232792560
 
 foreach number
  get all prime factors
    group prime factors by factor, count
    
    foreach group
      if(list of factors contains factor)
        if (count of factor in list < count of group)
          add factor to count
      else add count factors

multiply all added factors together

*)
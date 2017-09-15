(*
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?   

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

    see https://en.wikipedia.org/wiki/Prime_factor
*)

namespace NED.ProjectEuler.Problems
    open NED.ProjectEuler.Utility

    module Problem5 =
        let solve = 42
//Largest palindrome product
//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace NED.ProjectEuler.Problems
    open System.Numerics
    open NED.ProjectEuler.Utility

    module Problem4 = 
        let solve =
            let smallestNumDigits = (100 * 100).ToString().ToCharArray().Length
            let largestNumDigits = (999 * 999).ToString().ToCharArray().Length
                              
            let allPalindromes = 
                Seq.append (palindromeMaker smallestNumDigits) (palindromeMaker largestNumDigits) 
                    |> Seq.filter(fun e -> e >= 100I*100I && e <= 999I*999I) //only look at values whose product is made of 2 3-digit numbers 
                    |> Seq.rev //reverse the sequence to look at largest numbers first
            
            let result = 
                allPalindromes 
                |> Seq.filter(fun e -> isPrime ((int64)e) = false) //remove primes
                |> Seq.tryFind(fun e -> 
                    factors (100L,999L,(int64)e) 
                    |> Seq.exists (fun (x,y) -> 
                        x.ToString().ToCharArray().Length = 3 && y.ToString().ToCharArray().Length = 3))  //need to factor these guys to see if I have a pair of 3-digit factors

            match result with 
                | None -> printf "Found None" 
                | Some (x) -> 
                    x.ToString() |> printf "Problem 4 Solution %s \n"
                    printf "\tFactors are : "
                    factors (100L,999L,(int64)x) |> Seq.iter(fun (x,y) -> printf "(%i, %i) " x y)
                    printf "\n"   

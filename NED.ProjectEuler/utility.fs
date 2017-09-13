namespace NED.ProjectEuler
    open System.Numerics
    module Utility =
        //https://en.wikipedia.org/wiki/Primality_test
        let isPrime (n:int64) =
            //https://stackoverflow.com/questions/6288742/initializing-an-infinite-list-of-bigintegers
            let numbers:int64 seq = 
                let rec loop n = seq { yield n; yield! loop (n+6L); } 
                loop 5L
            
            match n with
                | n when n <= 1L -> false
                | n when n <= 3L -> true
                | n when n % 2L = 0L || n % 3L = 0L -> false
                | n ->
                    let coprimes = 
                        numbers |> Seq.takeWhile (fun elem -> elem * elem <= n) |> Seq.tryFind (fun elem -> n % elem = 0L || n % (elem + 2L) = 0L)
                    match coprimes with
                        | None -> true
                        | Some (x) -> false

        let rec factors ((x, y, z): int64*int64*int64) =
            let divisors = seq {x .. y}
            let divisor = divisors |> Seq.tryFind (fun elem -> z % elem = 0L) //tryfind returns option.  No exception!
            seq{ 
                match divisor with
                    | None -> ()    //return unit stops a recursive sequence! https://markheath.net/post/recursive-sequence-expressions-in-f
                    | Some (a) -> 
                        yield (a, (z/a))
                        yield! factors (a+1L, (z/a)-1L, z) 
            }
        
        let reverseString (s:string) = new string(Array.rev(s.ToCharArray()))

        let palindromeMaker (numDigits:int) = 
            let isOdd = numDigits % 2 <> 0
            let rngStart = bigint.Pow(10I, numDigits/2 - 1)
            let rngEnd = bigint.Pow(10I, numDigits/2) - 1I
            
            let rng = seq {rngStart .. rngEnd}
            let zeroThruNine = seq {0..9}

            if(isOdd) then
              Seq.map ((fun (x, y) -> x.ToString() + y.ToString() + reverseString (x.ToString())) >> (fun e -> bigint.Parse(e))) (Seq.allPairs rng zeroThruNine)
            else
               (Seq.map ((fun e -> e.ToString() + reverseString (e.ToString())) >> (fun e -> bigint.Parse(e))) rng)
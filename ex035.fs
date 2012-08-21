let rotate n = (n % 10.0) * (10.0 ** (floor ((log10 n)))) + (floor (n / 10.0));;

let getPrimes max =
  let l = [ 2 .. max ]

  let rec primeList (l1: int list) (primes: int list) =
    match l1 with
    | []      -> List.rev primes @ l1
    | x :: xs -> if (x*x > max) then List.rev primes @ l1 else primeList (List.filter (fun i -> i % x > 0) xs) (x :: primes)

  primeList l [];;

let isPrime i = List.find (fun x -> x = i) (getPrimes i);;

let isPrime2 (i: int) (primes: int list) = List.find (fun x -> x = i) primes;;


let rec isCyclic prime primes position =
  match (isPrime2 prime primes) with
  | true -> printfn "Horray!"
  | false -> printfn "Lol no"
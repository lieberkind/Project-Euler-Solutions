// Prime sieve
let getPrimes max =
  let l = [ 2 .. max ]

  let rec primeList (l1: int list) (primes: int list) =
    match l1 with
    | []      -> List.rev primes @ l1
    | x :: xs -> if (x*x > max) then List.rev primes @ l1 else primeList (List.filter (fun i -> i % x > 0) xs) (x :: primes)

  primeList l [];;

let greatestPrimeFactor (n: float) =
  let max = int (sqrt n)
  let primeList = getPrimes max
  let n2 = int64 n

  let rec solution l currentGPF =
    match l with
    | []      -> currentGPF
    | x :: xs -> if (n2 % (int64 x) = 0L) then solution xs x else solution xs currentGPF

  solution primeList 0;;

greatestPrimeFactor 600851475143.0;;
// What takes time here, is getting the primes. The rest of the execution is about .001 seconds.




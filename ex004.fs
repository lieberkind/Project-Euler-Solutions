let reverse n =
  let rec solve num dig rev =
    match (num > 0) with
    | false -> rev
    | true  -> solve (num / 10) (num % 10) (rev * 10 + (num % 10))

  solve n 0 0;;

let isPalindrome n =
  if (n = reverse n) then true else false;;

// Not the prettiest (nor fastest) solution, but the shortest. Runs in around .165 seconds.
let ex004 =
  [for i in 100 .. 999 do for j in 100 .. 999 do if (isPalindrome (i*j)) then yield (i * j)] |> List.max

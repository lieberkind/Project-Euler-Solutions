let reverse n =
  let rec solve num dig rev =
    match (num > 0) with
    | false -> rev
    | true  -> solve (num / 10) (num % 10) (rev * 10 + (num % 10))

  solve n 0 0;;

let isPalindrome n =
  if (n = reverse n) then true else false;;

let binary n =
  let rec solve i acc =
    match (i / 2 = 0) with
    | false -> solve (i / 2) ((i % 2) :: acc)
    | true  -> (i % 2) :: acc

  solve n [];;

let isListPalindrome l =
  l = (l |> List.rev);;

let ex036 = [for i in 1 .. 1000000 do if (isPalindrome i && (isListPalindrome (binary i))) then yield i] |> List.sum;;

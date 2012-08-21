// One-liner by list comprehension
List.sum [for i in 1 .. 1000 do if (i % 3 = 0 || i % 5 = 0) then yield i];;

// By pattern matching
let rec ex001 cur acc =
  match (cur % 3 = 0 || cur % 5 = 0) with
  | false -> if cur < 1000 then ex001 (cur + 1) acc else acc
  | true  -> if cur < 1000 then ex001 (cur + 1) (acc + cur) else acc;;

ex001 3 0;;
// If the cur(rent) term is even valued, the accumulator is increased
let rec ex002 prev cur acc =
  match (cur % 2 = 0) with
  | false -> if cur < 4000000 then ex002 cur (cur + prev) acc else acc
  | true  -> if cur < 4000000 then ex002 cur (cur + prev) (cur + acc) else acc;;

ex002 1 0 0;;
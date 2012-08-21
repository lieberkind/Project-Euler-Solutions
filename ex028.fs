let ex028 = 
  1 + ([for i in 3 .. 1001 do if (i % 2 = 1) then yield i*i + (i*i-3*(i-1)) + (i*i-2*(i-1)) + (i*i-1*(i-1))] |> List.sum);;
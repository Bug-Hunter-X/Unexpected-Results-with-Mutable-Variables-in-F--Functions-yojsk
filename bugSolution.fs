let mutable x = 10
let mutable y = 20

let add () = x + y

printf "%d\n" (add())

x <- 30
y <- 40

printf "%d\n" (add())
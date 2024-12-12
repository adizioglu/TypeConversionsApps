open System

printf "What is your age: "
let ageText = Console.ReadLine()

let isValidInt, age = 
    match Int32.TryParse(ageText) with
    | true, value -> true, value
    | false, _ -> false, 0

printfn "This is valid: %b. The number was %d." isValidInt age

printfn "%d" (age + 15)

let testDouble = float age
let testDecimal = decimal testDouble


ageText = input("What is your age: ")

try:
    age = int(ageText)
    isValidInt = True
except ValueError:
    age = 0
    isValidInt = False

print(f"This is valid: {isValidInt}. The number was {age}.")

print(age + 15)

testDouble = float(age)
testDecimal = float(testDouble)

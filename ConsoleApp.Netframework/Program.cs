
print("Welcome to Package Express. Please follow the instructions below.")

weight = float(input("Please enter the package weight: "))


if weight > 50:
    
    print("Package too heavy to be shipped via Package Express. Have a good day.")
else:
    
    width = float(input("Please enter the package width: "))
    height = float(input("Please enter the package height: "))
    length = float(input("Please enter the package length: "))

   
if (width + height + length) > 50:
       
        print("Package too big to be shipped via Package Express.")
    else:
       
        quote = (width * height * length * weight) / 100

        
print(f"Your estimated total for shipping this package is: ${quote:.2f}")

        print("Thank you!")

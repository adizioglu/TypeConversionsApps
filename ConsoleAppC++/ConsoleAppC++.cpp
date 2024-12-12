#include <iostream>
#include <string>

int main() {
    std::cout << "What is your age: ";
    std::string ageText;
    std::getline(std::cin, ageText);

    int age;
    bool isValidInt = false;

    try {
        age = std::stoi(ageText);
        isValidInt = true;
    }
    catch (const std::invalid_argument&) {
        age = 0;
    }
    catch (const std::out_of_range&) {
        age = 0;
    }

    std::cout << "This is valid: " << std::boolalpha << isValidInt << ". The number was " << age << "." << std::endl;

    std::cout << age + 15 << std::endl;

    double testDouble = static_cast<double>(age);
    long double testDecimal = static_cast<long double>(testDouble);

    return 0;
}

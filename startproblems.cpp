#include <iostream> // preprocessor directive

using namespace std;

int main()
{
    cout << "Hello world! Piu" << endl; // stannd out, << stream insertion operator
    return 0;
}


// part 2

#include <iostream>

using namespace std;

int main()
{
    cout << "Hello world! Piu" << endl;
    std::cout << "Hello World!";
    return 0;
}

int okay () { std::cout << "Hello World!"; }

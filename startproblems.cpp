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

#include <iostream> // preprocessor directive

using namespace std;

int main()
{
    cout ;
    int x = 14;
    cout << "Hello world! Piu" << endl; // stannd out, << stream insertion operator
    cout << "/" << endl;
    cout << "/  |" << endl;
    cout << 1 + 2 + x << endl;
    return 0;
}


// part 2

#include <iostream>

// custom countdown using while
#include <iostream>
using namespace std;

int main ()
{
  int n = 10;

  while (n>0) {
    cout << n << ", ";
    --n;
  }

  cout << "liftoff!\n";
}

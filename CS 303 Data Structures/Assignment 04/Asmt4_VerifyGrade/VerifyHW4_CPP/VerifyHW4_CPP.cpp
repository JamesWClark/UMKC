// VerifyHW4_CPP.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

double power(double x, int n) {
    if (n == 0)
        return 1;
    else if (n > 0)
        return x * power(x, n - 1);
    else
        return 1.0 / power(x, -n);
}
int _tmain(int argc, _TCHAR* argv[]) {
	double x [] = { 2, 2, 2, 2, 2, 2, 2, 2, -2, -2, -2, -2, -2, -2, -2, -2 };
    int n [] = { 2, 2, -2, -2, 3, 3, -3, -3, 2, 2, -2, -2, 3, 3, -3, -3 };
    for (int i = 0; i < (sizeof(x)/sizeof(*x)); i++) {
        double result = power(x[i], n[i]);
        cout << "x: " << x[i] << "\tn: " << n[i] << "\tresult: " << result << "\tactual: " << pow(x[i], n[i]);
		cout << "\n";
    }
	return 0;
}






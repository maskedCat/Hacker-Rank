#include "stdafx.h"
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {

	int n; 
	cin >> n;
	vector<int> vect(n);
	for (int i = 0; i < n; i++)
		cin >> vect[i];
	
	for (auto rit = vect.rbegin(); rit != vect.rend(); ++rit)
		cout << *rit << ' ';
	cout << endl;
	return 0;
}
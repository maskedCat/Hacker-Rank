// ctutorialpointer.cpp : Defines the entry point for the console application.
//

#include <stdio.h>
#include <cmath>

void update(int *a, int *b) {
	int a_1 = *a + *b;
	int b_1 = *a - *b;
	(*a) = a_1;
	(*b) = abs(b_1);
}

int main() {
	int a, b;
	int *pa = &a, *pb = &b;

	scanf("%d %d", &a, &b);
	update(pa, pb);
	printf("%d\n%d", a, b);

	return 0;
}

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main() {

    float r, area;

    scanf("%f", &r);

    area = 3.14159 * pow(r,2);

    printf("VALOR DA AREA: %.4f\n", area);

    return 0;
}


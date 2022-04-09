#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main() {

    float a, b, c, delta, x1, x2;

    printf("Digite o valor de A:");
    scanf("%f", &a);

    if (a == 0){
        printf("Impossivel calcular");
        return 0;
    }

    printf("Digite o valor de B:");
    scanf("%f", &b);

    printf("Digite o valor de C:");
    scanf("%f", &c);

    delta = pow(b,2) - 4*a*c;

    x1 = (-b + sqrt(delta)) / (2*a);
    x2 = (-b - sqrt(delta)) / (2*a);

    if (delta < 0){
        printf("Impossivel calcular");
        return 0;
    }else{
        printf("O valor de x1: %.2f", x1);
        printf("\n");
        printf("O valor de x2: %.2f", x2);
    }

    return 0;
}

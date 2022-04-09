#include <stdio.h>
#include <stdlib.h>

int main() {

    int cod, quant;
    float total;

    printf("Digite o codigo do pedido:");
    scanf("%d", &cod);

    if (cod > 5){
        printf("Codigo invalido");
        return 0;
    }

    printf("Digite a quantidade:");
    scanf("%d", &quant);

    if (cod == 1){
        total = 4.00 * quant;
    }
    if (cod == 2){
        total = 4.50 * quant;
    }
    if (cod == 3){
        total = 5.00 * quant;
    }
    if (cod == 4){
        total = 2.00 * quant;
    }
    if (cod == 5){
        total = 1.50 * quant;
    }

    printf("VALOR A PAGAR: R$ %.2f\n", total);

    return 0;
}

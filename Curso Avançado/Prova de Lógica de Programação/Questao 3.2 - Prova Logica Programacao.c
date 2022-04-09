//Funcionando com While
#include <stdlib.h>
#include <stdio.h>

int main(){

    int n, x, cont = 0, dentro , fora;

    printf("Digite a quantidade de numeros:");
    scanf("%d", &n);

    dentro = 0;
    fora = 0;

    while (cont < n){
        printf("Digite um valor:");
        scanf("%d", &x);
        cont = cont + 1;

        if (x >= 10 && x <= 20){
            dentro = dentro + 1;
        }else{
            fora = fora + 1;
        }
    }
        printf("Quantidade de valores IN: %d", dentro);
        printf("\n");
        printf("Quantidade de valores OUT: %d", fora);
        return 0;
}

/*
//Funcionando com for
#include <stdlib.h>
#include <stdio.h>

#int main(){

    int quant, num, cont, in, out;

    printf("Digite a quantidade de numeros:");
    scanf("%d", &quant);

    in = 0;
    out = 0;

    for (cont = 0; cont < quant; cont++){
        printf("Digite um valor:");
        scanf("%d", &num);

        if ((num >= 10) && (num <= 20)){
            in++;
        }else{
            out++;
        }
    }
        printf("Quantidade de valores IN: %d", in);
        printf("\n");
        printf("Quantidade de valores OUT: %d", out);
        return 0;
}
*/

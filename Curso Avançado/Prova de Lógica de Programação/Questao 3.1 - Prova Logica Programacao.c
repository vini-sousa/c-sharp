#include <stdlib.h>
#include <stdio.h>

int main(){

    int senha, cont = 0;

    while (senha != 2002){
        printf("Digite sua senha:\n");
        scanf("%d", &senha);
        cont = cont + 1;

        if (senha == 2002){
            printf("Acesso permitido");
        }else{
            printf("Senha invalida\n");
        }
    }
}

#include <stdio.h>

int main()
{

    double largura, comprimento, preco, area, valor;

    printf("Digite a largura do terreno: ");
    scanf("%lf", &largura);

    printf("Digite o comprimento do terreno: ");
    scanf("%lf", &comprimento);

    printf("Digite o valor do metro quadrado: ");
    scanf("%lf", &preco);

    area = largura * comprimento;
    valor = preco * area;

    printf("Area do terreno: %.2lf\n", area);
    printf("Preco do terreno: %.2lf\n", valor);
    return 0;
}
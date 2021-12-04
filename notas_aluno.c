#include <stdio.h>

int main()
{
    double nota1, nota2, media;

    scanf("%lf", &nota1);
    scanf("%lf", &nota2);

    media = (nota1 + nota2) / 2;

    if (media < 7)
    {
        printf("REPROVADO");
    }
    else
    {
        printf("APROVADO");
    }

    return 0;
}
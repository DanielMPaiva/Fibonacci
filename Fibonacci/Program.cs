using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Sequência de Fibonacci

Leonardo Fibonacci (1170 – 1250) foi um matemático italiano que, por seus feitos, chegou a ser considerado por muitos como o maior matemático da Idade Média. Seus estudos o levaram à descoberta de uma sequência de números que ficou conhecida como sequência de Fibonacci. Essa sequência é representada por uma série de números, na qual o primeiro termo é 1, o segundo termo é 1 e os demais termos obedecem a uma sequência construída de acordo com uma regra em que cada número na série é a soma dos dois precedentes, conforme podemos ver no exemplo a seguir:

1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...

 

No mundo da matemática, a sequência de Fibonacci é considerada uma das mais fascinantes descobertas da história.

Situação problematizadora

Considere que você esteja participando de um processo seletivo e uma das questões seja:

Com base nos termos 34 e 55 da sequência de Fibonacci, será preciso dar sequência ao andamento dos novos números até que o valor dos próximos mil termos sejam exibidos.
Procedimentos para elaboração do TD 

Para atender à demanda, faça o pseudocódigo da sequência de Fibonacci para obter os mil termos a partir do 34 e do 55 de acordo com a situação problematizadora.
             */
            ulong num1, num2, soma, count = 0;

            num1 = 34;
            num2 = 55;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            count++;
            while (count <= 1000) {
                soma = num1 + num2;
                Console.WriteLine(count + " : " + soma);
                num1 = num2;
                num2 = soma;
                count++;
            }

            Console.Read();
        }
    }
}

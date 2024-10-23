Console.WriteLine("-------------------------\nEstágio - Ribeirão Preto\n-------------------------");
Console.WriteLine();
Console.WriteLine("1)");
Console.WriteLine();


int numero, a = 1, b = 0;
String s1 = " Não está na sequência de fibonacci.";

do
{
    Console.Write("Digite um número: ");
    String nS = Console.ReadLine();
    int.TryParse(nS, out numero);
} while (numero < 0);

int i;

for (i = 0; i <= numero; i++)
{
    Console.Write(b + ", ");
    a = a + b;
    b = a - b;
    if (numero == b)
    {
        s1 = " Está na sequência de fibonacci.";
    }
}

Console.WriteLine("(" + numero + ")" + s1);

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("2)");
Console.WriteLine();

int contador = 0;

Console.Write("Digite um texto: ");
string s2 = Console.ReadLine();



foreach (char c in s2)
{
    if (c == 'a' || c == 'A')
    {
        contador++;
    }
}

if (contador > 0)
{
    Console.WriteLine($"A letra 'a' (ou 'A') aparece {contador} vezes.");
}
else
{
    Console.WriteLine("A letra 'a' (ou 'A') não foi encontrada.");
}

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("3)");
Console.WriteLine();

//int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);

int indice = 12, s = 0, k = 1;

while (k < indice)
{
    k = k + 1;
    s = s + k;
}

Console.WriteLine("Valor da soma: " + s);

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("4)");
Console.WriteLine();

int resposta;

for (i = 1; i < 9; i += 2)
{
    Console.Write(i + " | " );
}
resposta = i;
Console.WriteLine("A) (" + resposta + ")");

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine();

for ( i = 2; i < 128; i = i + i)
{
    Console.Write(i + " | ");
}
resposta = i;
Console.WriteLine("B) (" + resposta + ")");

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine();

int q1 = 0;

for (i = 0; i < 8; i++)
{
    q1 = i * i;
    Console.Write(q1 + " | ");
}
resposta = q1;
Console.WriteLine("C) (" + resposta + ")");


Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine();

int q2 = 0;

for (i = 2; i < 12; i+=2)
{
    q2 = i * i;
    Console.Write(q2 + " | ");
}
resposta = q2;
Console.WriteLine("D) (" + resposta + ")");

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine();

int a2 = 1, b2 = 1;


for (i = 0; i < 6; i++)
{
    Console.Write(b2 + ", ");
    a2 = a2 + b2;
    b2 = a2 - b2;
}
Console.WriteLine("E) (" + b2 + ")");

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine();

int n1 = 16;

Console.Write("1 | 10 | 12 | ");
for(i = 0; i < 4; i++)
{
    Console.Write((n1 += 1) +  " | ");
}
Console.Write("F) (" + n1 + ")");

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("5)");
Console.WriteLine();

Console.WriteLine("deixaria a primeira lâmpada acessa por alguns minutos," +
    " a segunda deixaria acessa a terceira ficaria apagada, ao entrar nas salas" +
    " saberia através do estado se esta quente ou frio, e se esta aceso ou apagado.");
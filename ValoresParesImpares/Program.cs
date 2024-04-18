
int n1, n2;
int aux;


Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("\nDigite outro número: ");
n2 = int.Parse(Console.ReadLine());



if (n1 > n2)
{
    aux = n2;
    while (aux+1 < n1)
    {

        aux++;
        if (aux % 2 == 0)
        {
            Console.WriteLine("Número Par: {0}", aux);
        }

        else
        {
            Console.WriteLine("Número Impar: {0}", aux);
        }
        

    }

}


aux = n1;
while (aux+1 < n2)
{


    aux++;
    if (aux % 2 == 0)
    {
        Console.WriteLine("Número Par: {0}", aux);
    }

    else 
    {
        Console.WriteLine("Número Impar: {0}", aux);    
    }

    
}


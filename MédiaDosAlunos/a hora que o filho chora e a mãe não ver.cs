Console.WriteLine("Informe 3 notas do aluno separadamente para calcularmos a média ex: primeira nota enter, segunda nota enter, terceira nota enter");
int one = int.Parse(Console.ReadLine());
int two = int.Parse(Console.ReadLine());
int three = int.Parse(Console.ReadLine());
    
int média = (one + two + three)/3;

if(média >= 7)
{
    Console.WriteLine($"Parabéns seu filho(a) tirou {média} está aprovado(a) :)");
}
else
{
    Console.WriteLine($"É uma pena mas seu filho(a) tirou {média} na média final então ele foi reprovado(a) :(");
}
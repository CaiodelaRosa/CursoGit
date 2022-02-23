int ano = 0;
int pa = 100;
double pb = 200;

while (pa < pb)
{
    pa = pa + (pa * 10 / 100);
    pb = pb + (pb * 1.5 / 100);
    ano = ano + 1;

}

Console.WriteLine(ano);
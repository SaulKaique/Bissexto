Console.Clear();

Console.Write("--- Ano Bissexto --- \n");
int Ano = Convert.ToInt32(Console.ReadLine());

bool Divisivelpor400 = Ano % 400 == 0 ;
bool Divisivelpor100 = Ano %  100 == 0 ;
bool Divisivelpor4 = Ano % 4 == 0 ;


if (Divisivelpor400 || (Divisivelpor4 && ! Divisivelpor100)){


     Console . WriteLine ( $" \n { Ano } é bissexto. " );
}

else
{

    Console . WriteLine ( $" \n { Ano } não é bissexto. " );
     
}

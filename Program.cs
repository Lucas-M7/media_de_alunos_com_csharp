int quantidadeDeMaterias = 4;

int lucas1 = 8;
int lucas2 = 9;
int lucas3 = 10;
int lucas4 = 10;

int gabriel1 = 9;
int gabriel2 = 9;
int gabriel3 = 10;
int gabriel4 = 10;

int lucasSoma = lucas1 + lucas2 + lucas3 + lucas4;
int gabrielSoma = gabriel1 + gabriel2 + gabriel3 + gabriel4;

decimal lucasMedia = lucasSoma / quantidadeDeMaterias;
decimal gabrielMedia = gabrielSoma / quantidadeDeMaterias;

Console.WriteLine("Aluno\t\tMédia\n");

Console.WriteLine($"Lucas:\t\t{lucasMedia}");
Console.WriteLine($"Gabriel:\t{gabrielMedia}\n");

Console.WriteLine("Feito por Lucas-M7");
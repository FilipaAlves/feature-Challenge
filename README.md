# feature-Challenge
O desafio passa por desenvolver uma consola C# que recebe comandos de entrada e em seguida, envia o resultado para a consola. 
A lista de cores dos fios disponíveis é a seguinte:
Branco, Vermelho, Preto, Laranja, Verde e Roxo.
Há um conjunto de regras que a aplicação deve analisar e em seguida, fornece o resultado do corte dos fios. 

A lista regras é a seguinte:
* Se cortares um fio branco não podes cortar um fio branco ou preto
* Se cortares um fio vermelho tens de cortar um fio verde
* Se cortares um fio preto não é permitido cortar um fio branco, verde ou laranja 
* Se cortares um fio laranja tu deves cortar um fio vermelho ou preto 
* Se cortares um fio verde tens de cortar um fio laranja ou branco 
* Se cortares um fio roxo não podes cortar um fio roxo, verde, laranja ou branco

# Desenvolvimento:
.NetFramework 4.7.2

# Estrutura da solução:
2 Projectos: BombChallenge e BombChallengeTests

* BombChallenge:
Program.cs : Main() principal da aplicação onde contém a primeira interação com o cliente
Hire.cs: Contém conjunto de valores das cores dos fios
BombVM.cs: Contém os estados que a bomba pode ter e as propriedades necessárias para o output da bomba
Bomb.cs: Contém o output da bomba e as regras de desativação da bomba.


* BombChallengeTests:
UnitTest contém o código de todos os testes unitários que garantem o bom funcionamento da aplicação

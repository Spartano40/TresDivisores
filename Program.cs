using System;
 
class Solution {
    public static void Main(string[] args) {
        int numeroTestado = int.Parse(Console.ReadLine());
        int quantidadeDeDivisores = 0;
 
        for (int i = 1; i <= numeroTestado; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (numeroTestado % i == 0) {
                quantidadeDeDivisores++;
            }
            if (quantidadeDeDivisores >= 3) {
                Console.WriteLine(false);
            }
        }
         Console.WriteLine(quantidadeDeDivisores == 3);
    }
}
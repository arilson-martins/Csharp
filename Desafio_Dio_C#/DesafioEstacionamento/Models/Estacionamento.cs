using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string?> veiculos = new List<string?>();

        public  Estacionamento(decimal precoInicial, decimal precoPorHora){
        this.precoInicial=precoInicial;
        this.precoPorHora=precoPorHora;
        }


       public void AddVeiculo(){
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa;
            placa=Console.ReadLine();
            //verifica se o veiculo nao esta inserido
            if(veiculos.Contains(placa)){
                Console.WriteLine("Veiculo ja estacionado:");

            }

            else{
                veiculos.Add(placa);
                Console.WriteLine("Veiculo estacionado:");

            }

            

       }

       public void RemoverVeiculo(){
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa;
            placa=Console.ReadLine();
            //verifica o conteudo da lista e se contem a placa informada
            if(veiculos.Contains(placa)){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                decimal valorTotal = 0; 
                horas=Convert.ToInt32(Console.ReadLine());
                valorTotal=(horas*precoPorHora)+precoInicial;

                veiculos.Remove(placa);
                Console.WriteLine($"veiculo removido com o valor total de R$ {valorTotal}");
            }

            else{
                Console.WriteLine("veiculo inexistente");
            }
            

       }

       public void ListarVeiculos(){
         
         //verifica se a lista possui elementos 
         if (veiculos.Any()){
            Console.WriteLine("Veículos estacionados:");
            foreach (var placa in veiculos) {   
            Console.WriteLine(placa);
            
         }                     
        }
        else{
           Console.WriteLine("estacionamento vazio"); 
         }
        
       }

    }
}
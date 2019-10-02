using System;
using Ex2.Models;

namespace Ex2.Controllers
{
    public class CelularController
    {
        CelularModel Celular = new CelularModel();


        public void TiporCelular(){
            System.Console.WriteLine("Escolha um modelo: ");
            Celular.Modelo = Console.ReadLine();

            System.Console.WriteLine("Escolha uma cor: {Azel, Preto, Roza}");
            Celular.Cor = Console.ReadLine();

            System.Console.WriteLine("Escolha um tamanho: {tela 5.5, 4, 4.7}");
            Celular.Tamanho = float.Parse(Console.ReadLine());
            
        }


        public void Ligar() {
                                  
            try {
               
               if(!Celular.Ligado) {
                   Celular.Ligado = true;
                   System.Console.WriteLine("Ligado....");
               } else {
                   System.Console.WriteLine("O celular já está ligado");
               }

            } catch(Exception ex) {
                System.Console.WriteLine("Erro :( " + ex);
            }
        }        

        public void Desligar() {   
            
            try {
               
               if(Celular.Ligado) {
                   Celular.Ligado = false;
                   System.Console.WriteLine("Desligado....");
               } else {
                   System.Console.WriteLine("O celular já está desligado");
               }

            } catch(Exception ex) {
                System.Console.WriteLine("Erro :( " + ex);
            }
        } 



        public void FazerLigacao() {  

            try {
               
               if(Celular.Ligado) {
                   System.Console.WriteLine("Fazendo Ligação ....");
               } else {
                   System.Console.WriteLine("O celular não está ligado");
               }

            } catch(Exception ex) {
                System.Console.WriteLine("Erro :( " + ex);
            }
        }

        public void EnviarMensagem(string msg, string destinatario) {        

            try {
               
               if(Celular.Ligado) {
                   System.Console.WriteLine($"Enviando Menssagem\nMenssagem: {msg}\nPara: {destinatario}");
                   System.Console.WriteLine("Menssagem Enviada Com Sucesso");
               } else {
                   System.Console.WriteLine("O celular não está ligado");
               }

            } catch(Exception ex) {
                System.Console.WriteLine("Erro :( " + ex);
            }
        }
    }
}
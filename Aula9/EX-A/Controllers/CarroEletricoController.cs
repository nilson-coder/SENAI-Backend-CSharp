using Aula10.Models;

namespace Aula10.Controllers
{
    public class CarroEletricoController : CarroController
    {

        CarroEletricoModel carroEletrico = new CarroEletricoModel();
        MotorModel motor = new MotorModel();

        public void CarregarBateria(float carga){
            if(carroEletrico.Bateria < 100){
                carroEletrico.Bateria += carga;
            }else{
                System.Console.WriteLine("A bateria do carro já esta completa! Pode viajar!");
            }
        }

        public float StatusBateria(){
            return carroEletrico.Bateria;
        }
        
    }
}
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }
        
        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void MostrarConfiguracao(){
            Console.WriteLine($"Numero: {this.Numero} \n" +
                              $"Modelo: {this.Modelo} \n" +
                              $"Imei: {this.IMEI} \n" +
                              $"Memoria: {this.Memoria} GB \n" );
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
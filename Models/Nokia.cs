namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI,memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeAplicativo) 
        {
            Console.WriteLine($"Instalando aplicativo Nokia {nomeAplicativo}...");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
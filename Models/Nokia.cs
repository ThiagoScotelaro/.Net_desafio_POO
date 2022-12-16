namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}....");
            Console.WriteLine($"{nomeApp} instalado com sucesso");
        }
    }
}
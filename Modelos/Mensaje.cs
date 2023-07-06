namespace WebApplication1.Modelos
{
    public class Mensaje
    {
        
        public Mensaje(string emisor, string receptor, string cuerpo)
        {
            Emisor = "Aaron";
            Receptor = "Brivè";
            Cuerpo = "Hola que tal, saludos";
        }

        public string Emisor { get; set; }
        public string Receptor { get; set; }
        public string Cuerpo { get; set; }
    }

    public class Email 
    {
        string archivo;
        public Email()
        {
            Archivo = "File.txt";
        }
        public string Archivo { get; set; }
    }

    public class Drive : Email
    {
        string url;
        public Drive()
        {
            Url = "Drive.com";
        }
        public string Url { get; set; }
    }
}

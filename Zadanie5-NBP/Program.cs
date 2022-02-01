using Newtonsoft.Json;
using Zadanie5_NBP;

double feild1 = 0;
var webClient = new System.Net.WebClient();
var json = webClient.DownloadString("http://api.nbp.pl/api/exchangerates/rates/c/usd/today?format=json");
double wynik = 0;
StreamWriter sw = new StreamWriter("plik.json");
sw.Write(json);
sw.Close();
string kurs = File.ReadAllText("plik.json");

Root root = JsonConvert.DeserializeObject<Root>(kurs);

foreach (var foo in root.rates)
{
    feild1 = foo.ask;

}
Console.WriteLine("Podaj kwotę");
try
{
int kwota = int.Parse(Console.ReadLine());
     wynik = (double)kwota * feild1;
}
catch (Exception)
{

    throw;
}


Console.WriteLine("Dzisiejszy kurs dolara:  " + feild1+"    Wynik: "+wynik);


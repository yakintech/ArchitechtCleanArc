
using StatePattern.Models;

var asistan = new Asistan();
asistan.Answer(); // Online mod aktif.

Console.ReadLine();



//change mode
asistan.ChangeMode(new NightMode());
asistan.Answer(); // Gece modu aktif.

Console.ReadLine();

//change mode
asistan.ChangeMode(new AwayMode());
asistan.Answer(); // Uzakta modu aktif.

Console.ReadLine();
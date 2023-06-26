using Advanced_Converting_back__and_forth;

Conversion conversion = new Conversion();

Console.Write("fai la tua scelta di conversione (C-F) oopure (F-C)= ");
String choise= Console.ReadLine();

if ( choise == "C-F"){
    Console.Write("inserisci i gradi in Celsus= ");
    int grade= int.Parse(Console.ReadLine());
    conversion.conversionCelsusToFahrenheit(grade);
}
else if (choise == "F-C") {
    Console.Write("inserisci i gradi in Fahrenheit= ");
    double grade = double.Parse(Console.ReadLine());
    conversion.conversionFahrenheitToCelsus(grade);
}

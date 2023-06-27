using Advanced_Converting_back__and_forth;

Conversion conversion = new Conversion();

Console.Write("fai la tua scelta di conversione (C-F) oopure (F-C)= ");
String choise= Console.ReadLine();

if ( choise == "C-F"){
    Console.Write("inserisci i gradi in Celsus= ");
    int grade= int.Parse(Console.ReadLine());            //quando vuole mettere un numero con la virgola mobile, deve usare la virgola (,), per rappresentare la parte decimale, perchè col punto non funziona
    conversion.ConversionCelsusToFahrenheit(grade);
}
else if (choise == "F-C") {
    Console.Write("inserisci i gradi in Fahrenheit= ");
    double grade = double.Parse(Console.ReadLine());
    conversion.ConversionFahrenheitToCelsus(grade);
}

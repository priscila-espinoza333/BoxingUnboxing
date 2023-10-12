List<string> Boxing = new List<string>();

Boxing.Add("7");
Boxing.Add("28");
Boxing.Add("1");
Boxing.Add("true");
Boxing.Add("silla");

for(int i = 0; i < Boxing.Count; i++){
        Console.WriteLine(Boxing[i]); 
}

int suma = 0;

foreach (string elemento in Boxing) {
    int numero;
    if (int.TryParse(elemento, out numero)) {// convierto el elementoen  numero entero 
        suma += numero;
    }
}

Console.WriteLine("La suma de los números enteros es: " + suma);







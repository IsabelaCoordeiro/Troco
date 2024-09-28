decimal valorcompra, valorpago, valortroco; 

Console.WriteLine("--- troco---\n");

Console.Write("Valor da compra:");
valorcompra = Convert.ToDecimal (Console.ReadLine());

Console.Write("Valor pago:");
valorpago = Convert.ToDecimal (Console.ReadLine());

valortroco = valorpago - valorcompra; 

Console.WriteLine($"\nTroco: {valortroco}");

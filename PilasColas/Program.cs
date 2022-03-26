using Arreglos;
using Listas;

Arreglos.Pilas pilas = new Arreglos.Pilas(10);

pilas.Agregar("cero");
pilas.Agregar("uno");
pilas.Agregar("dos");
pilas.Agregar("tres");
pilas.Agregar("cuatro");
pilas.Agregar("cinco");

Console.WriteLine(pilas.Imprimir());

for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("---------------------------------");
        pilas.Eliminar();
        Console.WriteLine(pilas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}

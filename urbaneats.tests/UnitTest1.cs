namespace urbaneats.tests;
using Xunit.Abstractions;

public class UnitTest1
{
    /// <summary>
    /// Nombre del archivo
    /// </summary>
    string archivo_nombre = "testing_data_158179445.csv";

    /// <summary>
    /// Suma de totales
    /// </summary>
    int suma_totales = 158179445;


    /// <summary>
    /// Se usa para escribir información en la salida
    /// </summary>
    private readonly ITestOutputHelper salida;

    public UnitTest1(ITestOutputHelper output)
    {
        this.salida = output;
    }

    [Fact(DisplayName = "Ejemplo que siempre se ejecuta")]
    public void test_Ok()
    {
        Assert.True(true);
    }


    /// <summary>
    /// Verifica que el archivo usado para las pruebas exista. Si no, nada funcionará.
    /// </summary>
    [Fact(DisplayName = "Confirma que el archivo de preubas exista")]
    public void test_ArchivoExiste()
    {

        bool existe = File.Exists(Path.Combine("testdata", archivo_nombre));
        
        Assert.True(existe, $"Archivo no encontrado: [{archivo_nombre}]");
        
        salida.WriteLine($"El archivo fue encontrado y será utilizado para las pruebas: [{archivo_nombre}]");
    }


    [Fact]
    public void test_LeeArchivo()
    {
        // Preparar
        var lector = new LectorCompras();
        lector.LeeArchivo(Path.Combine("testdata", archivo_nombre));
        // Ejecutar
        //  => var suma = lector.suma
        // Validar
        //  => Assert suma=123


        // Assert.Fail("No implementado");
        Assert.Equal(lector.Registros.Count(), 10000);
    }


    [Fact]
    public void test_CalcularTotal()
    {

        // Calcular el total de todo lo que se compro.
        var lector = new LectorCompras();
        var sumaTotal = 0;
        lector.LeeArchivo(Path.Combine("testdata", archivo_nombre));
        sumaTotal = lector.Registros.Sum(x => x.Total);
        Assert.Equal(sumaTotal, suma_totales);
    }


    [Fact(Skip = "No implementado")]
    public void test_CalcularPorCategorias()
    {
        Assert.Fail("No implementado");
    }


    [Fact(Skip = "No implementado")]
    public void test_ValidarCategorias()
    {
        Assert.Fail("No implementado");
    }

    
}
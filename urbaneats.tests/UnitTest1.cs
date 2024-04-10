namespace urbaneats.tests;

public class UnitTest1
{
    string archivo_nombre = "testing_data_158179445.csv";
    int suma_totales = 158179445;


    [Fact(DisplayName = "Ejemplo que siempre se ejecuta")]
    public void test_Ok()
    {
        Assert.True(true);
    }


    [Fact(DisplayName = "Confirma que el archivo de preubas exista")]
    public void test_ArchivoExiste()
    {

        Assert.True(File.Exists(Path.Combine("testdata", archivo_nombre)));
    }


    

    [Fact(Skip = "No implementado")]
    public void test_LeeArchivo()
    {
        // Preparar
        //  => var lector = new LectorCompras();
        // Ejecutar
        //  => var suma = lector.suma
        // Validar
        //  => Assert suma=123

        
        Assert.Fail("No implementado");
    }

    [Fact(Skip = "No implementado")]
    public void test_CalcularTotal()
    {
        Assert.Fail("No implementado");
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
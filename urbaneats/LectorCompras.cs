
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// Lee el archivo y resume la información con estadísticas
/// </summary>
public class LectorCompras
{
    public List<Registro> Registros { get; set; }
    /// <summary>
    /// Lee el archivo y guarda los datos
    /// </summary>
    /// <param name="archivo"></param>
    /// <returns></returns>
    public bool LeeArchivo(string archivo)
    {
        Registros = new List<Registro>();
        int lineas = 0;
        foreach (string line in File.ReadLines(archivo))
        {
            if (lineas++ == 0) continue;

            string[] cadenas = line.Split(',');

            Registro registro = new Registro()
            {
                Id = int.Parse(cadenas[0]),
                Customer = int.Parse(cadenas[1]),
                Category = cadenas[2],
                Amount = int.Parse(cadenas[3]),
                Quantity = int.Parse(cadenas[4]),
                Total = int.Parse(cadenas[5])
            };
            Registros.Add(registro);
        }
        return true;
    }


    /// <summary>
    /// Retorna el total de ventas
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int RetornaTotalVentas()
    {

        throw new NotImplementedException();
    }


    /// <summary>
    /// Retorna un diccionario con los totales por categoría
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Dictionary<string, int> RetornaTotalesPorCategoria()
    {

        throw new NotImplementedException();
    }


}
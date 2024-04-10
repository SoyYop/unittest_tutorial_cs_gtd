using System.Collections.Generic;

/// <summary>
/// Constantes a usar ya que no hay base de datos
/// </summary>
public class Constantes
{
    /// <summary>
    /// Listado de las categorías de alimentos que procesaremos
    /// </summary>
    public HashSet<string> Categorias { get; set; } = new HashSet<string> { "Meat", "Vegetables", "Dairy", "Fruits", "Grains" };
}

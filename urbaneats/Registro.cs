/// <summary>
/// Guarda un registro según el formato y tipo entregado por el cliente
/// </summary>
class Registro
{
    /// <summary>ID del registro</summary>
    public int Id { get; set; }

    /// <summary>ID del cliente</summary>
    public int Customer { get; set; }

    /// <summary>Categoría de la compra</summary>
    /// <remarks>Las categorías válidas están en Constantes.Categorias</remarks>
    public string Category { get; set; }

    // Agregar Quantity, Amount y Total
    
}
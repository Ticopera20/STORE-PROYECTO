namespace STORE_PROYECTO.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

    }

    public class ProductoModel {
        
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

        public double PrecioTotal { get; set; }

    }
}


using Microsoft.AspNetCore.Mvc;
using STORE_PROYECTO.Models;

namespace STORE_PROYECTO.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VenderProducto(string producto, string descripcion, int cantidad)
        {
            // Procesamiento de la venta
            double precio = 0;
            switch (producto)
            {
                case "laptop":
                    precio = 300;
                    break;
                case "teléfono":
                    precio = 500;
                    break;
                case "tableta":
                    precio = 200;
                    break;
                case "impresora":
                    precio = 250;
                    break;
            }
            double precioTotal = precio * cantidad;

            // Redirigir a la acción VentaInfo y pasar los datos de la venta como parámetros
            return RedirectToAction("VentaInfo", new ProductoModel
            {
                Producto = producto,
                Descripcion = descripcion,
                Cantidad = cantidad,
                PrecioTotal = precioTotal
            });
        }

        public IActionResult VentaInfo(ProductoModel venta)
        {
            return View(venta);
        }
    }
}

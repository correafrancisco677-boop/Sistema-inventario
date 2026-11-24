using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LaboratorioProductoInventario.Services
{
    public class Inventario
    {
        private readonly List<Producto> _productos = new List<Producto>();

        public bool AgregarProducto(Producto producto)
        {
            if (producto == null)
            {
                return false;
            }

            bool codigoExiste = _productos.Any(p =>
                string.Equals(p.Codigo, producto.Codigo, StringComparison.OrdinalIgnoreCase));

            if (codigoExiste)
            {
                return false;
            }

            _productos.Add(producto);
            return true;
        }

        public Producto? BuscarPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return null;
            }

            return _productos.FirstOrDefault(p =>
                string.Equals(p.Codigo.Trim(), codigo.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public List<Producto> ListarProductos()
        {
            return new List<Producto>(_productos);
        }
    }
}
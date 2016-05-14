using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClasesBase;

namespace ClaseConexion
{
    public class TrabajarItemOrdenCompra
    {

        public static void insertItems(BindingList<Item_Orden_Compra> listaItems)
        {
            Item_Orden_Compra ItemOrdenADO = new Item_Orden_Compra();
            
            Articulo articuloADO = new Articulo();
            Articulo unArticulo = new Articulo();
            foreach (Item_Orden_Compra item in listaItems)
            {
                ItemOrdenADO.InsertItem(item);
                unArticulo = articuloADO.getArticulo(item.Art_ID);
                unArticulo.Art_Costo = item.ItemCosto;
                unArticulo.Art_Stock_Actual += item.ItemCantidad;
                unArticulo.Art_Precio = item.ItemCosto / (1 - (unArticulo.Art_Margen_Beneficio / 100));

                articuloADO.UpdateArticle(unArticulo);
            }
        }

        public static int getUltimoId()
        {
            Item_Orden_Compra ItemOrdenADO = new Item_Orden_Compra();

            return ItemOrdenADO.getUltimoId();
        }
    }
}

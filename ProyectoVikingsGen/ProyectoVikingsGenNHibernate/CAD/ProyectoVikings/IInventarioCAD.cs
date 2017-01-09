
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IInventarioCAD
{
InventarioEN ReadOIDDefault (int id
                             );

void ModifyDefault (InventarioEN inventario);



int New_ (InventarioEN inventario);

void Modify (InventarioEN inventario);


void Destroy (int id
              );


ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN DameInventarioPorJugador (int ? oid_jugador);


void ObjetoRelationer (int p_Inventario_OID, System.Collections.Generic.IList<int> p_objeto_OIDs);

System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> DameObjetosJugador ();
}
}

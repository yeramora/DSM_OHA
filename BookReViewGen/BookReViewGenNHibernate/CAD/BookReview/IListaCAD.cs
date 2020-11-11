
using System;
using BookReViewGenNHibernate.EN.BookReview;

namespace BookReViewGenNHibernate.CAD.BookReview
{
public partial interface IListaCAD
{
ListaEN ReadOIDDefault (int id
                        );

void ModifyDefault (ListaEN lista);

System.Collections.Generic.IList<ListaEN> ReadAllDefault (int first, int size);



int New_ (ListaEN lista);

void Modify (ListaEN lista);


void Destroy (int id
              );



ListaEN ReadOID (int id
                 );


System.Collections.Generic.IList<ListaEN> ReadAll (int first, int size);
}
}

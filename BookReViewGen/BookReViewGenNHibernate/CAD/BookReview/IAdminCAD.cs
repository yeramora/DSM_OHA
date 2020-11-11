
using System;
using BookReViewGenNHibernate.EN.BookReview;

namespace BookReViewGenNHibernate.CAD.BookReview
{
public partial interface IAdminCAD
{
AdminEN ReadOIDDefault (int usuarioID
                        );

void ModifyDefault (AdminEN admin);

System.Collections.Generic.IList<AdminEN> ReadAllDefault (int first, int size);



int New_ (AdminEN admin);

void Modify (AdminEN admin);


void Destroy (int usuarioID
              );


AdminEN ReadOID (int usuarioID
                 );


System.Collections.Generic.IList<AdminEN> ReadAll (int first, int size);


void BorrarAdmin (int usuarioID
                  );


void ReportarUsuario (AdminEN admin);
}
}


using System;
using BookReViewGenNHibernate.EN.BookReview;

namespace BookReViewGenNHibernate.CAD.BookReview
{
public partial interface IClub_lecCAD
{
Club_lecEN ReadOIDDefault (int clubID
                           );

void ModifyDefault (Club_lecEN club_lec);

System.Collections.Generic.IList<Club_lecEN> ReadAllDefault (int first, int size);



int New_ (Club_lecEN club_lec);

void Modify (Club_lecEN club_lec);


void Destroy (int clubID
              );


Club_lecEN ReadOID (int clubID
                    );


System.Collections.Generic.IList<Club_lecEN> ReadAll (int first, int size);


System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.Club_lecEN> FiltraPagsLeidas ();
}
}

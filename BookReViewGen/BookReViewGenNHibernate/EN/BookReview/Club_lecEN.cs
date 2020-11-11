
using System;
// Definición clase Club_lecEN
namespace BookReViewGenNHibernate.EN.BookReview
{
public partial class Club_lecEN
{
/**
 *	Atributo clubID
 */
private int clubID;



/**
 *	Atributo mensualidad
 */
private Nullable<DateTime> mensualidad;



/**
 *	Atributo libroActual
 */
private string libroActual;



/**
 *	Atributo paginaActual
 */
private int paginaActual;



/**
 *	Atributo estado
 */
private bool estado;



/**
 *	Atributo lector
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.UsuarioEN> lector;






public virtual int ClubID {
        get { return clubID; } set { clubID = value;  }
}



public virtual Nullable<DateTime> Mensualidad {
        get { return mensualidad; } set { mensualidad = value;  }
}



public virtual string LibroActual {
        get { return libroActual; } set { libroActual = value;  }
}



public virtual int PaginaActual {
        get { return paginaActual; } set { paginaActual = value;  }
}



public virtual bool Estado {
        get { return estado; } set { estado = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.UsuarioEN> Lector {
        get { return lector; } set { lector = value;  }
}





public Club_lecEN()
{
        lector = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.UsuarioEN>();
}



public Club_lecEN(int clubID, Nullable<DateTime> mensualidad, string libroActual, int paginaActual, bool estado, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.UsuarioEN> lector
                  )
{
        this.init (ClubID, mensualidad, libroActual, paginaActual, estado, lector);
}


public Club_lecEN(Club_lecEN club_lec)
{
        this.init (ClubID, club_lec.Mensualidad, club_lec.LibroActual, club_lec.PaginaActual, club_lec.Estado, club_lec.Lector);
}

private void init (int clubID
                   , Nullable<DateTime> mensualidad, string libroActual, int paginaActual, bool estado, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.UsuarioEN> lector)
{
        this.ClubID = clubID;


        this.Mensualidad = mensualidad;

        this.LibroActual = libroActual;

        this.PaginaActual = paginaActual;

        this.Estado = estado;

        this.Lector = lector;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Club_lecEN t = obj as Club_lecEN;
        if (t == null)
                return false;
        if (ClubID.Equals (t.ClubID))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.ClubID.GetHashCode ();
        return hash;
}
}
}

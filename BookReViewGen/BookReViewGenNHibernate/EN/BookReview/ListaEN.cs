
using System;
// Definición clase ListaEN
namespace BookReViewGenNHibernate.EN.BookReview
{
public partial class ListaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo enlistado
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> enlistado;



/**
 *	Atributo tipo
 */
private BookReViewGenNHibernate.Enumerated.BookReview.TipolistaEnum tipo;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> Enlistado {
        get { return enlistado; } set { enlistado = value;  }
}



public virtual BookReViewGenNHibernate.Enumerated.BookReview.TipolistaEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}





public ListaEN()
{
        enlistado = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.LibroEN>();
}



public ListaEN(int id, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> enlistado, BookReViewGenNHibernate.Enumerated.BookReview.TipolistaEnum tipo
               )
{
        this.init (Id, enlistado, tipo);
}


public ListaEN(ListaEN lista)
{
        this.init (Id, lista.Enlistado, lista.Tipo);
}

private void init (int id
                   , System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> enlistado, BookReViewGenNHibernate.Enumerated.BookReview.TipolistaEnum tipo)
{
        this.Id = id;


        this.Enlistado = enlistado;

        this.Tipo = tipo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ListaEN t = obj as ListaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}

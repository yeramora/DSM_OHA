
using System;
// Definición clase ComentarioEN
namespace BookReViewGenNHibernate.EN.BookReview
{
public partial class ComentarioEN
{
/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo autor
 */
private string autor;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo comentario
 */
private int comentario;



/**
 *	Atributo lectura
 */
private BookReViewGenNHibernate.EN.BookReview.LibroEN lectura;



/**
 *	Atributo comentador
 */
private BookReViewGenNHibernate.EN.BookReview.UsuarioEN comentador;



/**
 *	Atributo paginasLeidas
 */
private string paginasLeidas;



/**
 *	Atributo autorID
 */
private int autorID;






public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Autor {
        get { return autor; } set { autor = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual int Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual BookReViewGenNHibernate.EN.BookReview.LibroEN Lectura {
        get { return lectura; } set { lectura = value;  }
}



public virtual BookReViewGenNHibernate.EN.BookReview.UsuarioEN Comentador {
        get { return comentador; } set { comentador = value;  }
}



public virtual string PaginasLeidas {
        get { return paginasLeidas; } set { paginasLeidas = value;  }
}



public virtual int AutorID {
        get { return autorID; } set { autorID = value;  }
}





public ComentarioEN()
{
}



public ComentarioEN(int comentario, string titulo, string autor, Nullable<DateTime> fecha, string contenido, BookReViewGenNHibernate.EN.BookReview.LibroEN lectura, BookReViewGenNHibernate.EN.BookReview.UsuarioEN comentador, string paginasLeidas, int autorID
                    )
{
        this.init (Comentario, titulo, autor, fecha, contenido, lectura, comentador, paginasLeidas, autorID);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Comentario, comentario.Titulo, comentario.Autor, comentario.Fecha, comentario.Contenido, comentario.Lectura, comentario.Comentador, comentario.PaginasLeidas, comentario.AutorID);
}

private void init (int comentario
                   , string titulo, string autor, Nullable<DateTime> fecha, string contenido, BookReViewGenNHibernate.EN.BookReview.LibroEN lectura, BookReViewGenNHibernate.EN.BookReview.UsuarioEN comentador, string paginasLeidas, int autorID)
{
        this.Comentario = comentario;


        this.Titulo = titulo;

        this.Autor = autor;

        this.Fecha = fecha;

        this.Contenido = contenido;

        this.Lectura = lectura;

        this.Comentador = comentador;

        this.PaginasLeidas = paginasLeidas;

        this.AutorID = autorID;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
        if (t == null)
                return false;
        if (Comentario.Equals (t.Comentario))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Comentario.GetHashCode ();
        return hash;
}
}
}

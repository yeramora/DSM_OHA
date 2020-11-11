
using System;
// Definición clase LibroEN
namespace BookReViewGenNHibernate.EN.BookReview
{
public partial class LibroEN
{
/**
 *	Atributo libroID
 */
private int libroID;



/**
 *	Atributo autor
 */
private string autor;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo genero
 */
private string genero;



/**
 *	Atributo fechapubli
 */
private Nullable<DateTime> fechapubli;



/**
 *	Atributo idioma
 */
private string idioma;



/**
 *	Atributo portada
 */
private string portada;



/**
 *	Atributo puntuacion
 */
private int puntuacion;



/**
 *	Atributo enlacedecompra
 */
private string enlacedecompra;



/**
 *	Atributo paginas
 */
private int paginas;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo solicitudesRealizada
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> solicitudesRealizada;



/**
 *	Atributo listainfo
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ListaEN> listainfo;



/**
 *	Atributo opinion
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> opinion;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.UsuarioEN> usuario;



/**
 *	Atributo creador
 */
private BookReViewGenNHibernate.EN.BookReview.UsuarioEN creador;






public virtual int LibroID {
        get { return libroID; } set { libroID = value;  }
}



public virtual string Autor {
        get { return autor; } set { autor = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Genero {
        get { return genero; } set { genero = value;  }
}



public virtual Nullable<DateTime> Fechapubli {
        get { return fechapubli; } set { fechapubli = value;  }
}



public virtual string Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual string Portada {
        get { return portada; } set { portada = value;  }
}



public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual string Enlacedecompra {
        get { return enlacedecompra; } set { enlacedecompra = value;  }
}



public virtual int Paginas {
        get { return paginas; } set { paginas = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> SolicitudesRealizada {
        get { return solicitudesRealizada; } set { solicitudesRealizada = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ListaEN> Listainfo {
        get { return listainfo; } set { listainfo = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> Opinion {
        get { return opinion; } set { opinion = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual BookReViewGenNHibernate.EN.BookReview.UsuarioEN Creador {
        get { return creador; } set { creador = value;  }
}





public LibroEN()
{
        solicitudesRealizada = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.CompraEN>();
        listainfo = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.ListaEN>();
        opinion = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.ComentarioEN>();
        usuario = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.UsuarioEN>();
}



public LibroEN(int libroID, string autor, string nombre, string genero, Nullable<DateTime> fechapubli, string idioma, string portada, int puntuacion, string enlacedecompra, int paginas, double precio, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> solicitudesRealizada, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ListaEN> listainfo, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> opinion, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.UsuarioEN> usuario, BookReViewGenNHibernate.EN.BookReview.UsuarioEN creador
               )
{
        this.init (LibroID, autor, nombre, genero, fechapubli, idioma, portada, puntuacion, enlacedecompra, paginas, precio, solicitudesRealizada, listainfo, opinion, usuario, creador);
}


public LibroEN(LibroEN libro)
{
        this.init (LibroID, libro.Autor, libro.Nombre, libro.Genero, libro.Fechapubli, libro.Idioma, libro.Portada, libro.Puntuacion, libro.Enlacedecompra, libro.Paginas, libro.Precio, libro.SolicitudesRealizada, libro.Listainfo, libro.Opinion, libro.Usuario, libro.Creador);
}

private void init (int libroID
                   , string autor, string nombre, string genero, Nullable<DateTime> fechapubli, string idioma, string portada, int puntuacion, string enlacedecompra, int paginas, double precio, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> solicitudesRealizada, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ListaEN> listainfo, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> opinion, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.UsuarioEN> usuario, BookReViewGenNHibernate.EN.BookReview.UsuarioEN creador)
{
        this.LibroID = libroID;


        this.Autor = autor;

        this.Nombre = nombre;

        this.Genero = genero;

        this.Fechapubli = fechapubli;

        this.Idioma = idioma;

        this.Portada = portada;

        this.Puntuacion = puntuacion;

        this.Enlacedecompra = enlacedecompra;

        this.Paginas = paginas;

        this.Precio = precio;

        this.SolicitudesRealizada = solicitudesRealizada;

        this.Listainfo = listainfo;

        this.Opinion = opinion;

        this.Usuario = usuario;

        this.Creador = creador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LibroEN t = obj as LibroEN;
        if (t == null)
                return false;
        if (LibroID.Equals (t.LibroID))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.LibroID.GetHashCode ();
        return hash;
}
}
}

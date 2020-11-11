
using System;
// Definición clase UsuarioEN
namespace BookReViewGenNHibernate.EN.BookReview
{
public partial class UsuarioEN
{
/**
 *	Atributo usuarioID
 */
private int usuarioID;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo mail
 */
private string mail;



/**
 *	Atributo fotoperfil
 */
private string fotoperfil;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo solicitudesRealizadas
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> solicitudesRealizadas;



/**
 *	Atributo solicitudesRecibidas
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> solicitudesRecibidas;



/**
 *	Atributo club
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.Club_lecEN> club;



/**
 *	Atributo pasarelaPago
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> pasarelaPago;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> comentario;



/**
 *	Atributo libro
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> libro;



/**
 *	Atributo librosCreado
 */
private System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> librosCreado;



/**
 *	Atributo dineroventa
 */
private double dineroventa;






public virtual int UsuarioID {
        get { return usuarioID; } set { usuarioID = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual string Mail {
        get { return mail; } set { mail = value;  }
}



public virtual string Fotoperfil {
        get { return fotoperfil; } set { fotoperfil = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> SolicitudesRealizadas {
        get { return solicitudesRealizadas; } set { solicitudesRealizadas = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> SolicitudesRecibidas {
        get { return solicitudesRecibidas; } set { solicitudesRecibidas = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.Club_lecEN> Club {
        get { return club; } set { club = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> PasarelaPago {
        get { return pasarelaPago; } set { pasarelaPago = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> Libro {
        get { return libro; } set { libro = value;  }
}



public virtual System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> LibrosCreado {
        get { return librosCreado; } set { librosCreado = value;  }
}



public virtual double Dineroventa {
        get { return dineroventa; } set { dineroventa = value;  }
}





public UsuarioEN()
{
        solicitudesRealizadas = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.SolicitudEN>();
        solicitudesRecibidas = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.SolicitudEN>();
        club = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.Club_lecEN>();
        pasarelaPago = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.CompraEN>();
        comentario = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.ComentarioEN>();
        libro = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.LibroEN>();
        librosCreado = new System.Collections.Generic.List<BookReViewGenNHibernate.EN.BookReview.LibroEN>();
}



public UsuarioEN(int usuarioID, String password, string mail, string fotoperfil, string nombre, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> solicitudesRealizadas, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> solicitudesRecibidas, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.Club_lecEN> club, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> pasarelaPago, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> comentario, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> libro, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> librosCreado, double dineroventa
                 )
{
        this.init (UsuarioID, password, mail, fotoperfil, nombre, solicitudesRealizadas, solicitudesRecibidas, club, pasarelaPago, comentario, libro, librosCreado, dineroventa);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (UsuarioID, usuario.Password, usuario.Mail, usuario.Fotoperfil, usuario.Nombre, usuario.SolicitudesRealizadas, usuario.SolicitudesRecibidas, usuario.Club, usuario.PasarelaPago, usuario.Comentario, usuario.Libro, usuario.LibrosCreado, usuario.Dineroventa);
}

private void init (int usuarioID
                   , String password, string mail, string fotoperfil, string nombre, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> solicitudesRealizadas, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> solicitudesRecibidas, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.Club_lecEN> club, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> pasarelaPago, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> comentario, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> libro, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> librosCreado, double dineroventa)
{
        this.UsuarioID = usuarioID;


        this.Password = password;

        this.Mail = mail;

        this.Fotoperfil = fotoperfil;

        this.Nombre = nombre;

        this.SolicitudesRealizadas = solicitudesRealizadas;

        this.SolicitudesRecibidas = solicitudesRecibidas;

        this.Club = club;

        this.PasarelaPago = pasarelaPago;

        this.Comentario = comentario;

        this.Libro = libro;

        this.LibrosCreado = librosCreado;

        this.Dineroventa = dineroventa;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (UsuarioID.Equals (t.UsuarioID))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.UsuarioID.GetHashCode ();
        return hash;
}
}
}

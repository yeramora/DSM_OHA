
using System;
// Definición clase AdminEN
namespace BookReViewGenNHibernate.EN.BookReview
{
public partial class AdminEN                                                                        : BookReViewGenNHibernate.EN.BookReview.UsuarioEN


{
public AdminEN() : base ()
{
}



public AdminEN(int usuarioID,
               String password, string mail, string fotoperfil, string nombre, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> solicitudesRealizadas, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.SolicitudEN> solicitudesRecibidas, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.Club_lecEN> club, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.CompraEN> pasarelaPago, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.ComentarioEN> comentario, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> libro, System.Collections.Generic.IList<BookReViewGenNHibernate.EN.BookReview.LibroEN> librosCreado, double dineroventa
               )
{
        this.init (UsuarioID, password, mail, fotoperfil, nombre, solicitudesRealizadas, solicitudesRecibidas, club, pasarelaPago, comentario, libro, librosCreado, dineroventa);
}


public AdminEN(AdminEN admin)
{
        this.init (UsuarioID, admin.Password, admin.Mail, admin.Fotoperfil, admin.Nombre, admin.SolicitudesRealizadas, admin.SolicitudesRecibidas, admin.Club, admin.PasarelaPago, admin.Comentario, admin.Libro, admin.LibrosCreado, admin.Dineroventa);
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
        AdminEN t = obj as AdminEN;
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

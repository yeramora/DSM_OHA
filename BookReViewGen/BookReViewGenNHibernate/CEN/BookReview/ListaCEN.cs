

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BookReViewGenNHibernate.Exceptions;

using BookReViewGenNHibernate.EN.BookReview;
using BookReViewGenNHibernate.CAD.BookReview;


namespace BookReViewGenNHibernate.CEN.BookReview
{
/*
 *      Definition of the class ListaCEN
 *
 */
public partial class ListaCEN
{
private IListaCAD _IListaCAD;

public ListaCEN()
{
        this._IListaCAD = new ListaCAD ();
}

public ListaCEN(IListaCAD _IListaCAD)
{
        this._IListaCAD = _IListaCAD;
}

public IListaCAD get_IListaCAD ()
{
        return this._IListaCAD;
}

public int New_ (BookReViewGenNHibernate.Enumerated.BookReview.TipolistaEnum p_tipo)
{
        ListaEN listaEN = null;
        int oid;

        //Initialized ListaEN
        listaEN = new ListaEN ();
        listaEN.Tipo = p_tipo;

        //Call to ListaCAD

        oid = _IListaCAD.New_ (listaEN);
        return oid;
}

public void Modify (int p_Lista_OID, BookReViewGenNHibernate.Enumerated.BookReview.TipolistaEnum p_tipo)
{
        ListaEN listaEN = null;

        //Initialized ListaEN
        listaEN = new ListaEN ();
        listaEN.Id = p_Lista_OID;
        listaEN.Tipo = p_tipo;
        //Call to ListaCAD

        _IListaCAD.Modify (listaEN);
}

public void Destroy (int id
                     )
{
        _IListaCAD.Destroy (id);
}

public ListaEN ReadOID (int id
                        )
{
        ListaEN listaEN = null;

        listaEN = _IListaCAD.ReadOID (id);
        return listaEN;
}

public System.Collections.Generic.IList<ListaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ListaEN> list = null;

        list = _IListaCAD.ReadAll (first, size);
        return list;
}
public ListaEN ReadOID2 (int id
                         )
{
        ListaEN listaEN = null;

        listaEN = _IListaCAD.ReadOID2 (id);
        return listaEN;
}

public System.Collections.Generic.IList<ListaEN> ReadAll2 (int first, int size)
{
        System.Collections.Generic.IList<ListaEN> list = null;

        list = _IListaCAD.ReadAll2 (first, size);
        return list;
}
}
}

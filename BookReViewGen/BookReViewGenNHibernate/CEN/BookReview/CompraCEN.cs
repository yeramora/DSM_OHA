

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
 *      Definition of the class CompraCEN
 *
 */
public partial class CompraCEN
{
private ICompraCAD _ICompraCAD;

public CompraCEN()
{
        this._ICompraCAD = new CompraCAD ();
}

public CompraCEN(ICompraCAD _ICompraCAD)
{
        this._ICompraCAD = _ICompraCAD;
}

public ICompraCAD get_ICompraCAD ()
{
        return this._ICompraCAD;
}

public void Modify (int p_Compra_OID, string p_tipo_pago, string p_infotarjeta, Nullable<DateTime> p_fechaped, string p_terminal, string p_comercio)
{
        CompraEN compraEN = null;

        //Initialized CompraEN
        compraEN = new CompraEN ();
        compraEN.CompraID = p_Compra_OID;
        compraEN.Tipo_pago = p_tipo_pago;
        compraEN.Infotarjeta = p_infotarjeta;
        compraEN.Fechaped = p_fechaped;
        compraEN.Terminal = p_terminal;
        compraEN.Comercio = p_comercio;
        //Call to CompraCAD

        _ICompraCAD.Modify (compraEN);
}

public void Destroy (int compraID
                     )
{
        _ICompraCAD.Destroy (compraID);
}

public CompraEN ReadOID (int compraID
                         )
{
        CompraEN compraEN = null;

        compraEN = _ICompraCAD.ReadOID (compraID);
        return compraEN;
}

public System.Collections.Generic.IList<CompraEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CompraEN> list = null;

        list = _ICompraCAD.ReadAll (first, size);
        return list;
}
}
}

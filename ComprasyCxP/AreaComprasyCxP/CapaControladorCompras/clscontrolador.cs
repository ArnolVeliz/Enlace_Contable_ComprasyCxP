using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloCompras;

namespace CapaControladorCompras
{
    public class clscontrolador
    {
        //Instanciamos la clase sentencias

        clssentencias sn = new clssentencias();
                public OdbcDataReader insertar_bodegas(string[] dato)
                {
                    return sn.insertar_bodegas(dato);
                }
                public OdbcDataReader insertar_linea(string[] dato)
                {
                    return sn.insertar_linea(dato);
                }
                public OdbcDataReader insertar_marca(string[] dato)
                {
                    return sn.insertar_marca(dato);
                }


        //Arnol Veliz
        public string calculoDebe(string fechaInicio, string fechaFinal)
        {
            string total = sn.calculoDebe(fechaInicio, fechaFinal);
            return total;
        }

        public string calculoHaber(string fechaInicio, string fechaFinal)
        {
            string total = sn.calculoHaber(fechaInicio, fechaFinal);
            return total;
        }

        //Insertar encabezado
        public void insertarEncabezado(string id, string fecha, string tipoPoliza)
        {
            sn.insertarEncabezado(id, fecha, tipoPoliza);

        }
        public string incrementarId()
        {
            string id = sn.incrementarId();

            return id;
        }

        public void insertarDetalle(string Id, string fecha, string idCuenta, string saldo, string idtipoOp, string concepto)
        {
            sn.insertarDetalle(Id, fecha, idCuenta, saldo, idtipoOp, concepto);
        }


    }


}

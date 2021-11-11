using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloCompras
{
    public class clssentencias
    {
        clsconexion cn = new clsconexion(); //crear objeto
        OdbcCommand com; //variable para querys

        public OdbcDataReader insertar_bodegas(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO bodegas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_linea(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO linea Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_marca(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO marca Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        

        //Arnol Veliz 0901-18-1102
        public string calculoDebe(string fechaI, string fechaF)
        {
            //select sum(saldo) from polizaDetalle where concepto = 'Venta' and idTipoOperacion = '1' 
            //and fechaPoliza between cast('2021-10-1' as date) and cast('2021-10-02' as date);

            string total = "";
            string Query = "select sum(total) from facturaencabezado where " + " fecha between cast('" + fechaI + "' as date) and cast('" + fechaF + "' as date) ;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                total = busqueda["sum(total)"].ToString();

            }

            return total;
        }

        public string calculoHaber(string fechaI, string fechaF)
        {
            //select sum(saldo) from polizaDetalle where concepto = 'Venta' and idTipoOperacion = '1' 
            //and fechaPoliza between cast('2021-10-1' as date) and cast('2021-10-02' as date);

            string total = "";
            string Query = "select sum(total) from facturaencabezado where " + " fecha between cast('" + fechaI + "' as date) and cast('" + fechaF + "' as date) ;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                total = busqueda["sum(total)"].ToString();

            }

            return total;
        }

        public string incrementarId()
        {
            string id = "";
            // string Query = "select * from polizaEncabezado order by length (idPolizaEncabezado) DESC limit 1;";
            string Query = " SELECT(idPolizaEncabezado * 1) as `idPolizaEncabezado` from polizaEncabezado order by(idPolizaEncabezado) DESC limit 1;";
            //  string Query = "select * from polizaDetalle ORDER BY length(idPolizaEncabezado ) ASC;";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                id = busqueda["idPolizaEncabezado"].ToString();

            }
            else
            {
                Console.WriteLine("Error acá");
            }
            return id;
        }

        public void insertarEncabezado(string Id, string fecha, string tipoPoliza)
        {
            string cadena = "INSERT INTO" +
            " polizaEncabezado VALUES (" + "'" + Id + "', '" + fecha + "' ,'" + tipoPoliza + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


        public void insertarDetalle(string Id, string fecha, string idCuenta, string saldo, string idtipoOp, string concepto)
        {


            string cadena = "INSERT INTO" +
            " polizaDetalle VALUES (" + "'" + Id + "', '" + fecha + "' ,'" + idCuenta + "','" + saldo + "','" + idtipoOp + "','" + concepto + "' );";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }


    }
}

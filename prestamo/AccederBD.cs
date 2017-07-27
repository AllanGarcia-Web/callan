using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Data;

namespace ControlInventarioUniversidad
{
    class AccederBD
    {
        MySqlConnection con; //conexión
        MySqlCommand com; //comandos a realizar
        //MySqlDataReader dr; //leer los datos
        public static string Error;
        public static string Error2;
        public int valor;
        public DataTable dt;
        public MySqlDataReader Lector;

        //manejo basico de base de datos
        public bool ConectaDB() //inicia conexión a la BD
        {
            bool res = false;
            try
            {
                //                         Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
                //con = new MySqlConnection("Server = MYSQL5013.SmarterASP.NET;Database=db_a14f18_proguth;Uid=a14f18_proguth;Pwd=pr0gCon0");  //online
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                res = true;
            }
            catch (MySqlException mse)
            {
                AccederBD.Error2 = "Error SQL al conectar. " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error2 = "Error general al conectar. " + general.Message;
            }
            return res;
        } //final conectar DB

        public bool DesconectarDB() //Desconecta de BD
        {
            bool res = false;
            try
            {
                if (con.State == System.Data.ConnectionState.Open) //verifica conexión abierta
                {
                    con.Close();
                    res = true;
                }
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL al desconectar. " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error = "Error general al desconectar. " + general.Message;
            }
            return res;
        }// final desconectar
         // fin de manejo basico de base de datos
         // querys de modulo login
        public bool login(string usuario, string pass) //Verifica acceso y mueve al form correcto
        {
            bool res = false;
            try
            {
                string query = "SELECT tipo_usuario FROM usuarios WHERE id_usuario = '" + usuario + "'AND pass_usuario = '" + pass + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                valor = int.Parse(com.ExecuteScalar().ToString()); //obtine el resultado de la query
                res = true;
                if (valor == 0)
                {
                    menu0 form = new menu0(); //Menu de admin
                    form.ShowDialog();
                }
                else if (valor == 1)
                {
                    menu1 form = new menu1(); //Menu de almacen
                    form.ShowDialog();
                }
                else if (valor == 2)
                {
                    menu2 form = new menu2(); //Menu de oficina
                    form.ShowDialog();
                }
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL al Seleccionar. " + mse.Message;
            }
            catch (Exception)
            {
                AccederBD.Error = "Verifica tus datos, no te encuentro en la BD";
            }
            finally
            {
                DesconectarDB();
            }
            return res;
        }
        // fin querys de modulo login
        // inicio querys modulo usuarios
        public bool CrearUsuario(int tipo, string usuario, string pass, string nombre) //Crea usuario
        {
            bool res = false;
            try
            {
                string query = "INSERT INTO `inventory_usuario` (`USER_TYPE`, `USER_NAME`, `PASSWORD`, `NAME`) VALUES ('" + tipo + "', '" + usuario + "', '" + pass + "', '" + nombre + "')";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                res = true;
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL: " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error = "El usuario no existe: " + general.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return res;
        }
        public bool EliminarUsuario(string usuario) //Elimina usuario
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM inventory_usuario WHERE USER_name = '" + usuario + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                res = true; //no lo cambia
            }
            catch (MySqlException msedel)
            {
                AccederBD.Error = "Error SQL: " + msedel.Message;
            }
            catch (Exception generaldel)
            {
                AccederBD.Error = "El usuario no existe o fue eliminado anteriormente: " + generaldel.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return res;
        }
        public bool EditarUsuario(string usuario, string pass) //Edita Usuario
        {
            bool res = false;
            try
            {
                string query = "UPDATE inventory_usuario SET PASSWORD = '" + pass + "' WHERE USER_NAME = '" + usuario + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                res = true; //no lo cambia
            }
            catch (MySqlException msedel)
            {
                AccederBD.Error = "Error SQL: " + msedel.Message;
            }
            catch (Exception generaldel)
            {
                AccederBD.Error = "El usuario no existe o fue eliminado anteriormente: " + generaldel.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return res;
        }
        // fin querys de modulo usarios
        // inicio querys de modulo inventario
        public bool AgregarInventario(string nombre, string carrera, string cantidad, string nota) //Agrega un material a una carrera
        {
            bool res = false;
            try
            {
                string query = "INSERT INTO `inventory_producto` (`nombre`, `carrera`, `cantidad`, `nota`) VALUES ('" + nombre + "', '" + carrera + "', '" + cantidad + "', '" + nota + "')";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                res = true;
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL: " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error = "El usuario no existe: " + general.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return res;
        }
        public bool EliminarInventario(string nombre, string carrera) //borrar item de inventario
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM inventory_producto WHERE nombre = '" + nombre + "' and carrera = '" + carrera + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                res = true;
            }
            catch (MySqlException msedel)
            {
                AccederBD.Error = "Error SQL: " + msedel.Message;
            }
            catch (Exception generaldel)
            {
                AccederBD.Error = "No se elimino: " + generaldel.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return res;
        }
        public bool EditarInventario(string nombre, string carrera, string cantidad, string nota) //edita en un material en una carrera
        {
            bool res = false;
            try
            {
                string query = "UPDATE inventory_producto SET cantidad = '" + cantidad + "', nota = '" + nota + "' WHERE nombre = '" + nombre + "' AND carrera = '" + carrera + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                res = true;
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL: " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error = "El usuario no existe: " + general.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return res;
        }
        // fin inicio querys de modulo inventario
        // inicio querys de modulo reportes
        public DataTable ConsultaTodos(string tabla) //consulta todo en la tabla indicada
        {
            try
            {
                string query = "SELECT * FROM " + tabla;
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                DataTable dt = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(com);
                adaptador.Fill(dt);
                return dt;
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL al insertar. " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error = "Error general al insertar. " + general.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return dt;
        }
        public DataTable ConsultaMaterial(string tabla, string material) //Consulta un material en todas las carreras
        {
            try
            {
                string query = "SELECT nombre as Material, carrera as Carrera, cantidad as Cantidad, nota as Nota FROM " + tabla + " WHERE nombre = '" + material + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                DataTable dt = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(com);
                adaptador.Fill(dt);
                return dt;
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL al insertar. " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error = "Error general al insertar. " + general.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return dt;
        }
        public DataTable ConsultaCarrera(string tabla, string carrera) //consulta materiales en carrera
        {
            try
            {
                string query = "SELECT nombre as Material, carrera as Carrera, cantidad as Cantidad, nota as Nota FROM " + tabla + " WHERE carrera = '" + carrera + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                DataTable dt = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(com);
                adaptador.Fill(dt);
                return dt;
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL al insertar. " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error = "Error general al insertar. " + general.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return dt;
        }
        public DataTable ConsultaCarreraMaterial(string tabla, string carrera, string material) //consulta Carrera y material para inventario
        {
            try
            {
                string query = "SELECT nombre as Material, carrera as Carrera, cantidad as Cantidad, nota as Nota FROM " + tabla + " WHERE carrera = '" + carrera + "' AND nombre = '" + material + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                DataTable dt = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(com);
                adaptador.Fill(dt);
                return dt;
            }
            catch (MySqlException mse)
            {
                AccederBD.Error = "Error SQL al insertar. " + mse.Message;
            }
            catch (Exception general)
            {
                AccederBD.Error = "Error general al insertar. " + general.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return dt;
        } // fin querys de modulo reportes
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Sql;

namespace prestamo
{
    class AccederBD
    {
        MySqlConnection con; //conexión
        MySqlCommand com; //comandos a realizar
        //MySqlDataReader dr; //leer los datos
        public static string Error; //guarda el mensaje de erro
        public static string nombre, ApellidoP, ApellidoM; //datos del usuario activo
        public static int valor; //nivel de acceso
        public DataTable dt;
        public static MySqlDataReader Lector;

        //Conexión a MySQL
        public bool ConectaDB() //inicia conexión a la BD
        {
            bool res = false;
            try
            {
                //                         Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
                //con = new MySqlConnection("Server = MYSQL5013.SmarterASP.NET;Database=db_a14f18_proguth;Uid=a14f18_proguth;Pwd=pr0gCon0");  //online
                con = new MySqlConnection("Server = 127.0.0.1;Database=prestamos;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                res = true;
            }
            catch (MySqlException mse)
            {
                Error = "Error SQL al conectar. " + mse.Message;
            }
            catch (Exception general)
            {
                Error = "Error general al conectar. " + general.Message;
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
        public bool Login(string usuario, string pass) //Verifica acceso y mueve al form correcto
        {
            bool res = false;
            try
            {
                string query = "SELECT * FROM usuarios WHERE user = '" + usuario + "' AND pass = '" + pass + "'";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                Lector = com.ExecuteReader();
                if (!Lector.HasRows)
                {
                    AccederBD.Error = "Usuario y contraseña incorrectos. ";
                    res = false;
                }
                else
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetString(7) == "No") //verifica si usuario esta activo
                        {
                            Error = "Usuario Inactivo. ";
                            res = false;
                        }
                        else
                        {
                            nombre = Lector.GetString(3);
                            ApellidoP = Lector.GetString(4);
                            ApellidoM = Lector.GetString(5);
                            if (Lector.GetString(0) == "Administrador") //verifica si es admin
                            {
                                valor = 0;
                                new menu().ShowDialog();
                                res = true;
                            }
                            if (Lector.GetString(0) == "Cobrador") //verifica si es cobrador
                            {
                                valor = 1;
                                new menu().ShowDialog();
                                res = true;
                            }
                        }
                        
                    }
                }
            }
            catch (MySqlException mse)
            {
                Error = "Error SQL al Seleccionar. " + mse.Message;
            }
            catch (Exception gen)
            {
                Error = "Error de conexión a la BD. " + gen.Message;
            }
            finally
            {
                DesconectarDB();
            }
            return res;
        }
        // fin querys de modulo login
        // cargar lista de usuarios
        public bool LeerUsuarios() //Leer usuarios
        {
            bool res = false;
            try
            {
                string query = "SELECT * FROM usuarios";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                Lector = com.ExecuteReader();
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
                //DesconectarDB();
            }
            return res;
        }
        // fin de cargar lista de usuarios
        // inicio querys modulo usuarios
        public bool CrearUsuario(string nivel, string usuario, string pass, string nombre, string ap1, string ap2, string email, string estado) //Crea usuario
        {
            bool res = false;
            try
            {
                string query = "INSERT INTO `usuarios` (`nivel`, `user`, `pass`, `nombre`, `ap1`, `ap2`, `email`, `estado`) VALUES ('" + nivel + "', '" + usuario + "', '" + pass + "', '" + nombre + "', '" + ap1 + "', '" + ap2 + "', '" + email + "', '" + estado + "')";
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
        // fin de crear usuario
        // inicio de eliminar usuario
        public bool EliminarUsuario(string usuario) //Elimina usuario
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM usuarios WHERE user = '" + usuario + "'";
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
        // fin de eliminar usuario
        // incio de editar usuario
        public bool EditarUsuario(string nivel, string usuario, string pass, string nombre, string ap1, string ap2, string email, string estado) //Edita Usuario
        {
            bool res = false;
            try
            {
                string query = "UPDATE usuarios SET nivel = '" + nivel + "', pass = '" + pass + "', nombre = '" + nombre + "', ap1 = '" + ap1 + "', ap2 = '" + ap2 + "', email = '" + email + "', estado = '" + estado + "' WHERE user = '" + usuario + "'";
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
        // fin de editar usuario
        // cargar lista de deudores
        public bool LeerDeudores() //Leer usuarios
        {
            bool res = false;
            try
            {
                string query = "SELECT * FROM deudores";
                com = new MySqlCommand();   //conexión arreglada inicio
                com.CommandText = query;
                ConectaDB();
                com.Connection = this.con;
                com.ExecuteNonQuery();      //conexión arreglada fin
                Lector = com.ExecuteReader();
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
                //DesconectarDB();
            }
            return res;
        }
        // fin de cargar lista de deudores
        // inicio de crear deudor
        public bool CrearDeudor(string nombre, string ap1, string ap2, string ine, string calle, string nodom, string colonia, string ciudad, string codpostal, string estado, string tel, string AvalNombre, string AvalTelefono, string email) //Agrega un material a una carrera
        {
            bool res = false;
            try
            {
                string query = "INSERT INTO `deudores` (`nombre`, `ap1`, `ap2`, `ine`, `calle`, `nodom`, `colonia`, `ciudad`, `codpostal`, `estado`, `tel`, `AvalNombre`, `AvalTelefono`, `email`) VALUES ('" + nombre + "', '" + ap1 + "', '" + ap2 + "', '" + ine + "', '" + calle + "', '" + nodom + "', '" + colonia + "', '" + ciudad + "', '" + codpostal + "', '" + estado + "', '" + tel + "', '" + AvalNombre + "', '" + AvalTelefono + "', '" + email + "')";
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
        // fin de crear deudor
        // inicio de eliminar deudor
        public bool EliminarDeudor(string id) //Elimina usuario
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM deudores WHERE id = '" + id + "'";
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
        // fin de eliminar deudor
        // incio de editar deudor
        public bool EditarDeudor(string id, string nombre, string ap1, string ap2, string ine, string calle, string nodom, string colonia, string ciudad, string codpostal, string estado, string tel, string AvalNombre, string AvalTelefono, string email) //Edita Usuario
        {
            bool res = false;
            try
            {
                string query = "UPDATE deudores SET nombre = '" + nombre + "', ap1 = '" + ap1 + "', ap2 = '" + ap2 + "', ine = '" + ine + "', calle = '" + calle + "', nodom = '" + nodom + "', colonia = '" + colonia + "', ciudad = '" + ciudad + "', codpostal = '" + codpostal + "', estado = '" + estado + "', tel = '" + tel + "', AvalNombre = '" + AvalNombre + "', AvalTelefono = '" + AvalTelefono + "', email = '" + email + "' WHERE id = '" + id + "'";
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
        // fin de editar deudor


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
        // fin de crear deudor
        // Inicio querys de modulo inventario
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
                dt = new DataTable();
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
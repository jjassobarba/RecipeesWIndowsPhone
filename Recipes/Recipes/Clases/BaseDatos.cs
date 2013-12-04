using System;
using System.Data.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Recipes.Clases
{
    public class BaseDatos : DataContext
    {
        public Table<Recetas> Tareas;

        private static BaseDatos conexion = null;

        private BaseDatos(string cadena)
            : base(cadena)
        {
        }

        public static BaseDatos Conexion
        {
            get
            {
                if (conexion == null)
                {
                    conexion = new BaseDatos("isostore:/recetas.sdf");

                    if (!conexion.DatabaseExists())
                        conexion.CreateDatabase();
                }
                return conexion;
            }
        }
    }
}

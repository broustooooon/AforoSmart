using ControlAforoTFG.Entidades;
using ControlAforoTFG.Modelos_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAforoTFG.ModelosDAO
{
    internal class AjustesDAO
    {
        private ConectionDB conexion = new ConectionDB();
        public bool guardarAjustes(Ajustes ajustes)
        {
            return conexion.GuardarAjustes(ajustes);
        }

        public Ajustes cargarAjustes()
        {
            Ajustes ajustes = conexion.CargarAjustes();
            return ajustes;
        }
    }
}

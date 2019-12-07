using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Renta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "Ifunciones" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Ifunciones
    {
        [OperationContract]
        void guardar(int a, string b, string c, string d, string e, string f);
        [OperationContract]
        bool modificar(int a, string b, string c, string d, string e, string f);
        [OperationContract]
        bool eliminar(int a);
        [OperationContract]
        string[] buscar(int cla);
    }
}

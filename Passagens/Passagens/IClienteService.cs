using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate ="SearchCliente/{nome}")]
        Cliente Buscar(String nome);
        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate ="addCliente/{nome};{cpf}")]
        bool Add(String nome, String cpf);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getClientes/")]
        List<Cliente> GetClientes(); 

    }
}

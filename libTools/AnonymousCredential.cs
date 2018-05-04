using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest;
namespace libTools
{
    /// <summary>
    /// Web API proxy needs an additional class to control authentication,
    /// even if no authentication is required. 
    /// Quick fix is to implement the ServiceClientCredentials interface with 
    /// an empty implementation class cof ServiceClientCredentials to control authentication
    /// . 
    /// </summary>
    public class AnonymousCredential : ServiceClientCredentials
    {
    }
}

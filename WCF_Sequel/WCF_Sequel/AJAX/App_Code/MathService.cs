using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

[ServiceContract(Namespace = "AJAX")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class MathService
{
	// Add [WebGet] attribute to use HTTP GET
    [OperationContract]
    public int Multiplication(int a, int b)
    {
        return a * b;
    }

}

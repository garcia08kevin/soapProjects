using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public double centigradosAfahrenheit(double centigrados)
    {
        return (centigrados * 9 / 5) + 32;
    }
    public double fahrenheitAcentigrados(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

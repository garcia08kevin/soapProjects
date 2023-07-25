
package ec.edu.kgarcia.servicios;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.3.5
 * Generated source version: 2.2
 * 
 */
@WebService(name = "WS_Conversion_Unidades", targetNamespace = "http://servicios.kgarcia.edu.ec/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface WSConversionUnidades {


    /**
     * 
     * @param centigrados
     * @return
     *     returns double
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "centigradosAfahrenheit", targetNamespace = "http://servicios.kgarcia.edu.ec/", className = "ec.edu.kgarcia.servicios.CentigradosAfahrenheit")
    @ResponseWrapper(localName = "centigradosAfahrenheitResponse", targetNamespace = "http://servicios.kgarcia.edu.ec/", className = "ec.edu.kgarcia.servicios.CentigradosAfahrenheitResponse")
    @Action(input = "http://servicios.kgarcia.edu.ec/WS_Conversion_Unidades/centigradosAfahrenheitRequest", output = "http://servicios.kgarcia.edu.ec/WS_Conversion_Unidades/centigradosAfahrenheitResponse")
    public double centigradosAfahrenheit(
        @WebParam(name = "centigrados", targetNamespace = "")
        double centigrados);

    /**
     * 
     * @param fahrenheit
     * @return
     *     returns double
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "fahrenheitAcentigrados", targetNamespace = "http://servicios.kgarcia.edu.ec/", className = "ec.edu.kgarcia.servicios.FahrenheitAcentigrados")
    @ResponseWrapper(localName = "fahrenheitAcentigradosResponse", targetNamespace = "http://servicios.kgarcia.edu.ec/", className = "ec.edu.kgarcia.servicios.FahrenheitAcentigradosResponse")
    @Action(input = "http://servicios.kgarcia.edu.ec/WS_Conversion_Unidades/fahrenheitAcentigradosRequest", output = "http://servicios.kgarcia.edu.ec/WS_Conversion_Unidades/fahrenheitAcentigradosResponse")
    public double fahrenheitAcentigrados(
        @WebParam(name = "fahrenheit", targetNamespace = "")
        double fahrenheit);

}
/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package ec.edu.kgarcia.servicios;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author garci
 */
@WebService(serviceName = "WS_Conversion_Unidades")
public class WS_Conversion_Unidades {

    @WebMethod(operationName = "centigradosAfahrenheit")
    public double centigradosAfahrenheit(@WebParam(name = "centigrados") double centigrados) {
        //TODO write your implementation code here:
        return (centigrados * 9/5) + 32;
    }

    /**
     * Web service operation
     * @param fahrenheit
     * @return 
     */
    @WebMethod(operationName = "fahrenheitAcentigrados")
    public double fahrenheitAcentigrados(@WebParam(name = "fahrenheit") double fahrenheit) {
        //TODO write your implementation code here:
        return (fahrenheit - 32) * 5/9;
    }
}

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package ec.edu.kgarcia.ws;

import ec.edu.kgarcia.modelo.Movimiento;
import ec.edu.kgarcia.servicio.EurekaService;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;

/**
 *
 * @author garci
 */
@WebService(serviceName = "WSEureka")
public class WSEureka {

    /**
     * This is a sample web service operation
     * @param cuenta
     * @return 
     */
    @WebMethod(operationName = "traerMovimientos")
    @WebResult(name = "movimiento")
    public List<Movimiento> traerMovimientos(@WebParam(name = "cuenta") String cuenta){
        List<Movimiento> lista; 
        try{
           EurekaService service =new EurekaService();
           lista = service.leerMovimientos(cuenta);
        }catch (Exception ex){
            lista = new ArrayList<>();
        }
        return lista;
    }
    
    @WebMethod(operationName = "regDeposito")
    @WebResult(name = "estado")    
    public int regDeposito(@WebParam(name = "cuenta") String cuenta, @WebParam(name = "importe") double importe){
        int estado;
        String codEmp = "0001";
        try{
            EurekaService service =new EurekaService();
            service.registrarDeposito(cuenta, importe, codEmp);
            estado = 1;
        }catch (Exception ex){
            estado = -1;
        }
        return estado;
    }
}

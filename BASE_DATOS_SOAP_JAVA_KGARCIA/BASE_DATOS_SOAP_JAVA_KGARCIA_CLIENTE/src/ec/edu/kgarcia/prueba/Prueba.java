/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.kgarcia.prueba;

import ec.edu.kgarcia.servico.EurekaService;
import ec.edu.kgarcia.ws.Movimiento;
import java.util.List;

/**
 *
 * @author garci
 */
public class Prueba {
    public static void main(String[] args){
        try{
            String cuenta="00100001";
            EurekaService service=new EurekaService();
            List<Movimiento> lista=service.traerMovimientos(cuenta);
            for(Movimiento r:lista){
                System.out.println(r.getNromov()+" - " + r.getAccion() + " - "+r.getImporte());
            }     
        }
        catch(Exception e){
            e.printStackTrace();
        }
    }

}

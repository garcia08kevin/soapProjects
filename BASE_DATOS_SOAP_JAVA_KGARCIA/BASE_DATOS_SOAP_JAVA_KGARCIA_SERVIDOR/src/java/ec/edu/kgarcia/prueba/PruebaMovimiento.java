/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.kgarcia.prueba;

import ec.edu.kgarcia.modelo.Movimiento;
import ec.edu.kgarcia.servicio.EurekaService;
import java.util.List;

/**
 *
 * @author garci
 */
public class PruebaMovimiento {
    public static void main(String[] args) {
        try {
            //dato de la prueba
            String cuenta = "00100001";
            
            //proceso
            EurekaService service =new EurekaService();
            List<Movimiento> lista = service.leerMovimientos(cuenta);
            
            //reporte
            for(Movimiento r : lista){
                System.out.println(r.getNromov()+ " - " + r.getAccion() + " - " + r.getImporte());
            }
     
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}


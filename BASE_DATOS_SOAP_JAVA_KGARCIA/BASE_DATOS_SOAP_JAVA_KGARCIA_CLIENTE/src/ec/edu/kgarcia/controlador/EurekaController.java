/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.kgarcia.controlador;

import ec.edu.kgarcia.servico.EurekaService;
import ec.edu.kgarcia.ws.Movimiento;
import java.util.List;

/**
 *
 * @author garci
 */
public class EurekaController {
     public List<Movimiento> traerMovimientos(String cuenta) {
        EurekaService service = new EurekaService();
        return service.traerMovimientos(cuenta);
    }

    public int regDepósito(String cuenta, double importe) {
        EurekaService service = new EurekaService();
        return service.regDeposito(cuenta, importe);
    }

}

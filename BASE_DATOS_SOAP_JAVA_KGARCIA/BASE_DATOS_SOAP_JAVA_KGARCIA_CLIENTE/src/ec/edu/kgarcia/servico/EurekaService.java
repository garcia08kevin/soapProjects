/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.kgarcia.servico;

import java.util.List;

/**
 *
 * @author garci
 */
public class EurekaService {

    public int regDeposito(String cuenta, double importe) {
        ec.edu.kgarcia.ws.WSEureka_Service service = new ec.edu.kgarcia.ws.WSEureka_Service();
        ec.edu.kgarcia.ws.WSEureka port = service.getWSEurekaPort();
        return port.regDeposito(cuenta, importe);
    }

    public List<ec.edu.kgarcia.ws.Movimiento> traerMovimientos(String cuenta) {
        ec.edu.kgarcia.ws.WSEureka_Service service = new ec.edu.kgarcia.ws.WSEureka_Service();
        ec.edu.kgarcia.ws.WSEureka port = service.getWSEurekaPort();
        return port.traerMovimientos(cuenta);
    }
    
    
}

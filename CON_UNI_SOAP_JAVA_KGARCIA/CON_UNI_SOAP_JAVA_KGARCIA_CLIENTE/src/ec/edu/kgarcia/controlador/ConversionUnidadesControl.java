/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.kgarcia.controlador;

/**
 *
 * @author garci
 */
public class ConversionUnidadesControl {
    
    public ConversionUnidadesControl() {
    }
    
    public double centigradosAfahrenheit(double centigrados) {
        ec.edu.kgarcia.servicios.WSConversionUnidades_Service service = new ec.edu.kgarcia.servicios.WSConversionUnidades_Service();
        ec.edu.kgarcia.servicios.WSConversionUnidades port = service.getWSConversionUnidadesPort();
        return port.centigradosAfahrenheit(centigrados);
    }

    public double fahrenheitAcentigrados(double fahrenheit) {
        ec.edu.kgarcia.servicios.WSConversionUnidades_Service service = new ec.edu.kgarcia.servicios.WSConversionUnidades_Service();
        ec.edu.kgarcia.servicios.WSConversionUnidades port = service.getWSConversionUnidadesPort();
        return port.fahrenheitAcentigrados(fahrenheit);
    }
    
    
}

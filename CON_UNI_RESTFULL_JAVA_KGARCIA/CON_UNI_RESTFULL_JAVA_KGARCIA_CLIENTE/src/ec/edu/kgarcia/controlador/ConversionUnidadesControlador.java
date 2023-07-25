/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/JerseyClient.java to edit this template
 */
package ec.edu.kgarcia.controlador;

import javax.ws.rs.ClientErrorException;
import javax.ws.rs.client.Client;
import javax.ws.rs.client.ClientBuilder;
import javax.ws.rs.client.WebTarget;
import javax.ws.rs.core.MediaType;

/**
 * Jersey REST client generated for REST resource:ConversionUnidades
 * [conversionUnidades]<br>
 * USAGE:
 * <pre>
 *        ConversionUnidadesControlador client = new ConversionUnidadesControlador();
 *        Object response = client.XXX(...);
 *        // do whatever with response
 *        client.close();
 * </pre>
 *
 * @author garci
 */
public class ConversionUnidadesControlador {

    private WebTarget target;
    private Client client;
    private static final String BASE_URI = "http://localhost:8080/CON_UNI_RESTFULL_JAVA_KGARCIA_SERVIDOR/webresources/conversionUnidades";

    public double fahrenheitAcentigrados(double fahrenheit){
        client = ClientBuilder.newClient();
        target = client.target(BASE_URI).path("fahrenheitAcentigrados").path(String.valueOf(fahrenheit));
        double centigrados = target.request(MediaType.TEXT_PLAIN).get(Double.class);
        return centigrados;
    }
    
    public double centigradosAfahrenheit(double centigrados){
        client = ClientBuilder.newClient();
        target = client.target(BASE_URI).path("centigradosAfahrenheit").path(String.valueOf(centigrados));
        double fahrenheit = target.request(MediaType.TEXT_PLAIN).get(Double.class);
        return fahrenheit;
    }

    public void close() {
        client.close();
    }
    
}

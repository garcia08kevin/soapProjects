/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/GenericResource.java to edit this template
 */
package ec.edu.kgarcia.controlador;

import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;
import javax.ws.rs.Produces;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Consumes;
import javax.ws.rs.core.MediaType;

/**
 * REST Web Service
 *
 * @author garci
 */
@Path("conversionUnidades")
public class ConversionUnidades {

    @Context
    private UriInfo context;

    /**
     * Creates a new instance of ConversionUnidadesResource
     */
    public ConversionUnidades() {
    }
    
    @GET
    @Path("centigradosAfahrenheit/{centigrados}")
    @Produces(MediaType.TEXT_PLAIN)
    public Double centigradosAfahrenheit(@PathParam("centigrados") double centigrados) {
        //TODO return proper representation object
        return (centigrados * 9/5) + 32;
    }
    
    @GET
    @Path("fahrenheitAcentigrados/{fahrenheit}")
    @Produces(MediaType.TEXT_PLAIN)
    public Double fahrenheitAcentigrados(@PathParam("fahrenheit") double fahrenheit) {
        //TODO return proper representation object
        return (fahrenheit - 32) * 5/9;
    }

}

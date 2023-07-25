/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package ec.edu.kgarcia.controlador;


import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

/**
 *
 * @author garci
 */
public class ConversionUnidadesControlTest {
    
    @Test
    public void testCentigradosAfahrenheit() {
        System.out.println("centigradosAfahrenheit");
        double centigrados = 1.0;
        ConversionUnidadesControl instance = new ConversionUnidadesControl();
        double expResult = 33.8;
        double result = instance.centigradosAfahrenheit(centigrados);
        assertEquals(expResult, result, 0.01);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of fahrenheitAcentigrados method, of class ConversionUnidadesControl.
     */
    @Test
    public void testFahrenheitAcentigrados() {
        System.out.println("fahrenheitAcentigrados");
        double fahrenheit = 32.0;
        ConversionUnidadesControl instance = new ConversionUnidadesControl();
        double expResult = 0.0;
        double result = instance.fahrenheitAcentigrados(fahrenheit);
        assertEquals(expResult, result, 0.01);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}

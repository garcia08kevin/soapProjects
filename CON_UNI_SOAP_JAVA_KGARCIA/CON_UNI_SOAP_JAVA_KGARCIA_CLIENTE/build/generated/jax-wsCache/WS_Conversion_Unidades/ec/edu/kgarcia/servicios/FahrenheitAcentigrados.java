
package ec.edu.kgarcia.servicios;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for fahrenheitAcentigrados complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="fahrenheitAcentigrados"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="fahrenheit" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "fahrenheitAcentigrados", propOrder = {
    "fahrenheit"
})
public class FahrenheitAcentigrados {

    protected double fahrenheit;

    /**
     * Gets the value of the fahrenheit property.
     * 
     */
    public double getFahrenheit() {
        return fahrenheit;
    }

    /**
     * Sets the value of the fahrenheit property.
     * 
     */
    public void setFahrenheit(double value) {
        this.fahrenheit = value;
    }

}

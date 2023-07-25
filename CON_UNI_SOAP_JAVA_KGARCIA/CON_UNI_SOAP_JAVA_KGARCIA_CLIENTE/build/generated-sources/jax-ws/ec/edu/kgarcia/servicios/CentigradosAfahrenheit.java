
package ec.edu.kgarcia.servicios;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for centigradosAfahrenheit complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="centigradosAfahrenheit"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="centigrados" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "centigradosAfahrenheit", propOrder = {
    "centigrados"
})
public class CentigradosAfahrenheit {

    protected double centigrados;

    /**
     * Gets the value of the centigrados property.
     * 
     */
    public double getCentigrados() {
        return centigrados;
    }

    /**
     * Sets the value of the centigrados property.
     * 
     */
    public void setCentigrados(double value) {
        this.centigrados = value;
    }

}

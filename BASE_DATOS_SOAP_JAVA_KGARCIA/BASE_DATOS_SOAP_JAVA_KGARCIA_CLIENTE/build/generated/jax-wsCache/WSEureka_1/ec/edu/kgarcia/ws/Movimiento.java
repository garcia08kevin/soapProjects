
package ec.edu.kgarcia.ws;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for movimiento complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="movimiento"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="accion" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="cuenta" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="fecha" type="{http://ws.kgarcia.edu.ec/}date" minOccurs="0"/&gt;
 *         &lt;element name="importe" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="nromov" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="tipo" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "movimiento", propOrder = {
    "accion",
    "cuenta",
    "fecha",
    "importe",
    "nromov",
    "tipo"
})
public class Movimiento {

    protected String accion;
    protected String cuenta;
    protected Date fecha;
    protected double importe;
    protected int nromov;
    protected String tipo;

    /**
     * Gets the value of the accion property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAccion() {
        return accion;
    }

    /**
     * Sets the value of the accion property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAccion(String value) {
        this.accion = value;
    }

    /**
     * Gets the value of the cuenta property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getCuenta() {
        return cuenta;
    }

    /**
     * Sets the value of the cuenta property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setCuenta(String value) {
        this.cuenta = value;
    }

    /**
     * Gets the value of the fecha property.
     * 
     * @return
     *     possible object is
     *     {@link Date }
     *     
     */
    public Date getFecha() {
        return fecha;
    }

    /**
     * Sets the value of the fecha property.
     * 
     * @param value
     *     allowed object is
     *     {@link Date }
     *     
     */
    public void setFecha(Date value) {
        this.fecha = value;
    }

    /**
     * Gets the value of the importe property.
     * 
     */
    public double getImporte() {
        return importe;
    }

    /**
     * Sets the value of the importe property.
     * 
     */
    public void setImporte(double value) {
        this.importe = value;
    }

    /**
     * Gets the value of the nromov property.
     * 
     */
    public int getNromov() {
        return nromov;
    }

    /**
     * Sets the value of the nromov property.
     * 
     */
    public void setNromov(int value) {
        this.nromov = value;
    }

    /**
     * Gets the value of the tipo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTipo() {
        return tipo;
    }

    /**
     * Sets the value of the tipo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTipo(String value) {
        this.tipo = value;
    }

}

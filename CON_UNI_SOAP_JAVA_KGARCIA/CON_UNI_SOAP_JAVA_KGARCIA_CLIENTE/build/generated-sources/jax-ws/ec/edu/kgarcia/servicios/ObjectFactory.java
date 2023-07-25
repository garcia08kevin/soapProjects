
package ec.edu.kgarcia.servicios;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the ec.edu.kgarcia.servicios package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _CentigradosAfahrenheit_QNAME = new QName("http://servicios.kgarcia.edu.ec/", "centigradosAfahrenheit");
    private final static QName _CentigradosAfahrenheitResponse_QNAME = new QName("http://servicios.kgarcia.edu.ec/", "centigradosAfahrenheitResponse");
    private final static QName _FahrenheitAcentigrados_QNAME = new QName("http://servicios.kgarcia.edu.ec/", "fahrenheitAcentigrados");
    private final static QName _FahrenheitAcentigradosResponse_QNAME = new QName("http://servicios.kgarcia.edu.ec/", "fahrenheitAcentigradosResponse");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: ec.edu.kgarcia.servicios
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link CentigradosAfahrenheit }
     * 
     */
    public CentigradosAfahrenheit createCentigradosAfahrenheit() {
        return new CentigradosAfahrenheit();
    }

    /**
     * Create an instance of {@link CentigradosAfahrenheitResponse }
     * 
     */
    public CentigradosAfahrenheitResponse createCentigradosAfahrenheitResponse() {
        return new CentigradosAfahrenheitResponse();
    }

    /**
     * Create an instance of {@link FahrenheitAcentigrados }
     * 
     */
    public FahrenheitAcentigrados createFahrenheitAcentigrados() {
        return new FahrenheitAcentigrados();
    }

    /**
     * Create an instance of {@link FahrenheitAcentigradosResponse }
     * 
     */
    public FahrenheitAcentigradosResponse createFahrenheitAcentigradosResponse() {
        return new FahrenheitAcentigradosResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link CentigradosAfahrenheit }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link CentigradosAfahrenheit }{@code >}
     */
    @XmlElementDecl(namespace = "http://servicios.kgarcia.edu.ec/", name = "centigradosAfahrenheit")
    public JAXBElement<CentigradosAfahrenheit> createCentigradosAfahrenheit(CentigradosAfahrenheit value) {
        return new JAXBElement<CentigradosAfahrenheit>(_CentigradosAfahrenheit_QNAME, CentigradosAfahrenheit.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link CentigradosAfahrenheitResponse }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link CentigradosAfahrenheitResponse }{@code >}
     */
    @XmlElementDecl(namespace = "http://servicios.kgarcia.edu.ec/", name = "centigradosAfahrenheitResponse")
    public JAXBElement<CentigradosAfahrenheitResponse> createCentigradosAfahrenheitResponse(CentigradosAfahrenheitResponse value) {
        return new JAXBElement<CentigradosAfahrenheitResponse>(_CentigradosAfahrenheitResponse_QNAME, CentigradosAfahrenheitResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FahrenheitAcentigrados }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link FahrenheitAcentigrados }{@code >}
     */
    @XmlElementDecl(namespace = "http://servicios.kgarcia.edu.ec/", name = "fahrenheitAcentigrados")
    public JAXBElement<FahrenheitAcentigrados> createFahrenheitAcentigrados(FahrenheitAcentigrados value) {
        return new JAXBElement<FahrenheitAcentigrados>(_FahrenheitAcentigrados_QNAME, FahrenheitAcentigrados.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FahrenheitAcentigradosResponse }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link FahrenheitAcentigradosResponse }{@code >}
     */
    @XmlElementDecl(namespace = "http://servicios.kgarcia.edu.ec/", name = "fahrenheitAcentigradosResponse")
    public JAXBElement<FahrenheitAcentigradosResponse> createFahrenheitAcentigradosResponse(FahrenheitAcentigradosResponse value) {
        return new JAXBElement<FahrenheitAcentigradosResponse>(_FahrenheitAcentigradosResponse_QNAME, FahrenheitAcentigradosResponse.class, null, value);
    }

}

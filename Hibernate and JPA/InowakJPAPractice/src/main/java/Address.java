import javax.persistence.*;

@Embeddable @Access(AccessType.FIELD)
public class Address {

    private String street2;
    private String city2;
    private String zipCode2;

    public Address(String street, String city, String zipCode) {
        this.street2 = street;
        this.city2 = city;
        this.zipCode2 = zipCode;
    }
    public Address() {
    }

    public void setStreet2(String street2) {
        this.street2 = street2;
    }

    public void setCity2(String city2) {
        this.city2 = city2;
    }

    public void setZipCode2(String zipCode2) {
        this.zipCode2 = zipCode2;
    }

    public String getStreet2() {
        return street2;
    }

    public String getCity2() {
        return city2;
    }

}
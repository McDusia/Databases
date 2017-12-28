import javax.persistence.*;

@Entity
@Inheritance(strategy = InheritanceType.TABLE_PER_CLASS)
public abstract class Company {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;
    private String companyName;
    private String street;
    private String city;
    @Column(nullable = true)
    private String zipcode;

    public Company(String companyName, String street, String city, String zipcode) {
        this.companyName = companyName;
        this.street = street;
        this.city = city;
        this.zipcode = zipcode;
    }

    public Company() {

    }
    protected String getCompanyName() {
        return companyName;
    }

    protected String getStreet() {
        return street;
    }

    protected String getCity() {
        return city;
    }

    protected String getZipcode() {
        return zipcode;
    }


}

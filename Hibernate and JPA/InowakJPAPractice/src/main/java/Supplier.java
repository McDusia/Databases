import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;

@Entity
//@SecondaryTable(name = "ADDRESS_TBL")
public class Supplier extends Company {

    @Id
    @GeneratedValue
    private int id;

    @Column(nullable = true)
    private String bankAccountNumber;
    //private String companyName;
    //@Column(table = "ADDRESS_TBL")
    //private String street;
   // @Column(table = "ADDRESS_TBL")
    //private String city;




    @OneToMany
    @JoinColumn(name = "SUPPLIER_FK")
    private Set<Product> products = new HashSet<>();

    //@Embedded
    //private Address address;

    public Supplier(String companyName, String street, String city, String postCode, String bankAccountNumber) {
        super(companyName, street, city, postCode);//this.street = street;
        this.bankAccountNumber = bankAccountNumber;
        //this.city = city;
        //this.companyName = companyName;
    }

    public Supplier() {}

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }

    public String getSupplierName() {
        return super.getCompanyName();
    }

    public String getStreet() {
        return super.getStreet();
    }

    public String getCity() {
        return super.getCity();
    }

    public Set<Product> getProducts() {
        return products;
    }

    public void addProduct(Product p) {
        this.products.add(p);
        p.setSupplier(this);
    }

    public String getBankAccountNumber() {
        return bankAccountNumber;
    }

    public void setBankAccountNumber(String bankAccountNumber) {
        this.bankAccountNumber = bankAccountNumber;
    }

}
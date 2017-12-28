import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity
public class Customer extends Company {

    @Id
    @GeneratedValue
    private int id;
    @Column(nullable = true)
    private float discount;

    public Customer(String companyName, String street, String city, String postCode, float discount) {
        super(companyName, street, city, postCode);//this.street = street;
        this.discount = discount;
    }

    public Customer() {}

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }

    public float getDiscount() {
        return discount;
    }

    public void setDiscount(int discount) {
        this.discount = discount;
    }

}
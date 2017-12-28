import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;


public class Main2 {

    public static void main(String[] args) {

        EntityManagerFactory emf = Persistence.
                createEntityManagerFactory
                        ("myDatabaseConfig");

        EntityManager em = emf.createEntityManager();
        EntityTransaction etx = em.getTransaction();
        etx.begin();
//do something
        /*Product p1 = new Product("żelki", 10);
        Product p2 = new Product("ciastka kokosowe", 25);
        Product p3 = new Product("sok pomarańczowy", 20);
        Product p4 = new Product("herbata", 40);
        Product p5 = new Product("kawa", 20);

        Supplier s1 = new Supplier("Słodyczność", "Wielicka 3","Krakow");
        Supplier s2 = new Supplier("Kawolandia", "Mazowiecka 12","Krakow");
        Supplier s3 = new Supplier("Herbandela", "Kalwaryjska 4","Krakow");
        Supplier s4 = new Supplier("Soczkowo", "Wielicka 56","Krakow");


        /*Product p1 = em.find(Product.class, 5);
        Product p2 = em.find(Product.class, 6);
        Product p3 = em.find(Product.class, 7);
        Product p4 = em.find(Product.class, 8);
        //Product p5 = new Product("kawa", 20);

        Supplier s1 = em.find(Supplier.class, 1);
        Supplier s2 = em.find(Supplier.class, 2);
        Supplier s3 = em.find(Supplier.class, 3);
        Supplier s4 = em.find(Supplier.class, 4);
*/

     /*   s1.addProduct(p1);
        s1.addProduct(p2);
        //s2.addProduct(p5);
        s3.addProduct(p4);
        s4.addProduct(p3);

        em.persist(s1);
        em.persist(s2);
        em.persist(s3);
        em.persist(s4);

        em.persist(p1);
        em.persist(p2);
        em.persist(p3);
        em.persist(p4);

        //System.out.println(p.getProductName());

        etx.commit();
        em.close();
*/
        /*em = emf.createEntityManager();
        etx = em.getTransaction();
        etx.begin();
*/
  /*s11.addProduct(p11);
        s11.addProduct(p22);
        //s2.addProduct(p5);
        s33.addProduct(p44);
        s44.addProduct(p33);
  Product p1 = new Product("kasza", 10);

      Supplier s1 = em.find(Supplier.class, 1);
        Supplier s2 = em.find(Supplier.class, 2);
        Supplier s3 = em.find(Supplier.class, 3);
        Supplier s4 = em.find(Supplier.class, 4);

        Product p3 = em.find(Product.class, 7);
        Product p2 = em.find(Product.class, 6);

*/

        /*Product p1 = em.find(Product.class, 5);
        Product p2 = em.find(Product.class, 6);
        Product p3 = em.find(Product.class, 7);
        Product p4 = em.find(Product.class, 8);


        HashSet<Product> products = new HashSet<>();
        products.add(p1);
        products.add(p2);
        products.add(p4);

        PurchaseOrder o1 = new PurchaseOrder(12, products);
        em.persist(o1);*/

        //em.persist(p2);
        //em.persist(p4);
        //



        //System.out.println(p1.getOrders());

        /*HashSet<Product> products = new HashSet<>();
        products.add(p1);
        products.add(p4);
        */

        //PurchaseOrder o1 = new PurchaseOrder(1, products);

        //em.persist(o1);

        //Address a = new Address("Krakow", "Wielicka", "30-820");
        //em.persist(a);

        //Company c = new Company()
 /*       Supplier s1 = new Supplier("Producent kawy", "Nowosądecka 12", "Krakow",
                "32-829", "1234");
        Supplier s2 = new Supplier("Producent herbaty", "Myszanowo 5", "Krakow",
                "30-455", "18567");
        Supplier s3 = new Supplier("Jogobella", "Wielicka 12", "Krakow",
                "28-744", "43274");
        Supplier s4 = new Supplier("Lipton", "Kalwaryjska 10", "Krakow",
                "31-853", "48762");



        em.persist(s1);
        em.persist(s2);
        em.persist(s3);
        em.persist(s4);*/

        Customer c = new Customer("Spożywczy", "Nowy Plac 4", "Kraków",
                "32-532", 0.1f);
        etx.commit();
        em.close();


    }

}
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

import javax.servlet.MultipartConfigElement;
import java.util.List;

import static spark.Spark.*;



public class Main {




    public static void main(String[] argv){

        SessionFactory sessionFactory;



        staticFiles.location("/public");

            Configuration configuration = new Configuration();
            configuration.configure();

            sessionFactory = configuration.buildSessionFactory();






        post("/api/task", (req, res) -> {

            System.out.println(req);
            Session session = sessionFactory.openSession();
            try {
                req.attribute("org.eclipse.jetty.multipartConfig", new MultipartConfigElement(""));

                Integer id = Integer.parseInt(req.queryParams("id"));
                String name = req.queryParams("name");

                Product product = new Product(name, id);
                //task.setId(id);
                //task.setProductName(name);
                System.out.println(product);
                org.hibernate.Transaction tx = session.beginTransaction();

                session.save(product);
                tx.commit();


                res.redirect("/list");
                return "";
            } catch (Exception e) {
                return "Error: " + e.getMessage();
            } finally {
                if (session.isOpen()) {
                    session.close();
                }
            }
        });

        post("/addToBusket", (req, res) -> {


            System.out.println(req.queryParams("products"));
            System.out.println((String)req.queryParams("products"));

            //Integer id = Integer.parseInt(req.queryParams("products"));
            //System.out.println(id);


            Session session = sessionFactory.openSession();
            try {
                req.attribute("org.eclipse.jetty.multipartConfig", new MultipartConfigElement(""));

                Integer id = Integer.parseInt(req.queryParams("products"));
                //String name = req.queryParams("name");

                //Product product = new Product(name, id);


                //task.setId(id);
                //task.setProductName(name);
                //System.out.println(product);
                //org.hibernate.Transaction tx = session.beginTransaction();

                //session.save(product);
                //tx.commit();


                res.redirect("/list");
                return "";
            } catch (Exception e) {
                return "Error: " + e.getMessage();
            } finally {
                if (session.isOpen()) {
                    session.close();
                }
            }
         //return "";
        });

        get("/buy", (req, res) -> {

            Session session = sessionFactory.openSession();
            try {

                List<Product> products = session.createQuery("FROM Product").getResultList();
                System.out.println(products);

                StringBuilder builder = new StringBuilder();

                builder.append("<link rel=\"stylesheet\" href=\"style.css\">");
                builder.append("<style>\n" +
                        "table {\n" +
                        "    border-collapse: collapse;\n" +
                        "    width: 50%;\n" +
                        "}" +
                        "td, th {\n" +
                        "    border: 1px solid #dddddd;\n" +
                        "    text-align: left;\n" +
                        "    padding: 8px;\n" +
                        "}\n" +
                        "</style>");

                builder.append("<form method=\"post\" action=\"/addToBusket\"> <select class = products name=\"products\" size=\"10\">");

                for (Product product : products) {
                    builder.append("<option name = \""+ product.getId()+"\" value=\""+product.getId()+"\">"+product.getProductName()+"</option>");
                }

                builder.append("</select><input type=\"submit\"></form><br><br>");

                builder.append("<table><tr><th>Nr produktu</th><th>Nazwa produktu</th></tr>\n");
                for (Product task : products) {
                    builder.append("<tr><td>" + task.getId() + "</td><td>" + task.getProductName() + "</td></tr>\n");
                }
                builder.append("</table>\n");

                return builder.toString();
            } catch (Exception e) {
                return "Error: " + e.getMessage();
            } finally {
                if (session.isOpen()) {
                    session.close();
                }
            }

        });


        get("/list", (req, res) -> {

            Session session = sessionFactory.openSession();
            try {

                List<Product> products = session.createQuery("FROM Product").getResultList();
                System.out.println(products);

                StringBuilder builder = new StringBuilder();

                builder.append("<link rel=\"stylesheet\" href=\"style.css\">");
                builder.append("<style>\n" +
                        "table {\n" +
                        "    border-collapse: collapse;\n" +
                        "    width: 50%;\n" +
                        "}" +
                        "td, th {\n" +
                        "    border: 1px solid #dddddd;\n" +
                        "    text-align: left;\n" +
                        "    padding: 8px;\n" +
                        "}\n" +
                        "</style>");

                builder.append("<table><tr><th>Nr produktu</th><th>Nazwa produktu</th></tr>\n");
                for (Product task : products) {
                    builder.append("<tr><td>" + task.getId() + "</td><td>" + task.getProductName() + "</td></tr>\n");
                }
                builder.append("</table>\n");

                return builder.toString();
            } catch (Exception e) {
                return "Error: " + e.getMessage();
            } finally {
                if (session.isOpen()) {
                    session.close();
                }
            }

        });

        get("/categories", (req, res) -> {

            Session session = sessionFactory.openSession();
            try {

                List<Category> categories = session.createQuery("FROM Category").getResultList();
                System.out.println(categories);

                StringBuilder builder = new StringBuilder();

                builder.append("<link rel=\"stylesheet\" href=\"style.css\">");
                builder.append("<style>\n" +
                        "table {\n" +
                        "    border-collapse: collapse;\n" +
                        "    width: 50%;\n" +
                        "}" +
                        "td, th {\n" +
                        "    border: 1px solid #dddddd;\n" +
                        "    text-align: left;\n" +
                        "    padding: 8px;\n" +
                        "}\n" +
                        "</style>");

                builder.append("<table><tr><th>Nr kategorii</th><th>Nazwa kategorii</th></tr>\n");
                for (Category category : categories) {
                    builder.append("<tr><td>" + category.getId() + "</td><td>" + category.getName() + "</td></tr>\n");
                }
                builder.append("</table>\n");

                return builder.toString();
            } catch (Exception e) {
                return "Error: " + e.getMessage();
            } finally {
                if (session.isOpen()) {
                    session.close();
                }
            }

        });


        get("/suppliers", (req, res) -> {

            Session session = sessionFactory.openSession();
            try {

                List<Supplier> suppliers = session.createQuery("FROM Supplier").getResultList();
                System.out.println(suppliers);

                StringBuilder builder = new StringBuilder();

                builder.append("<link rel=\"stylesheet\" href=\"style.css\">");
                builder.append("<style>\n" +
                        "table {\n" +
                        "    border-collapse: collapse;\n" +
                        "    width: 50%;\n" +
                        "}" +
                        "td, th {\n" +
                        "    border: 1px solid #dddddd;\n" +
                        "    text-align: left;\n" +
                        "    padding: 8px;\n" +
                        "}\n" +
                        "</style>");

                builder.append("<table><tr><th>Nazwa firmy</th><th>Ulica</th><th>Miasto</th></tr>\n");
                for (Supplier supplier : suppliers) {
                    builder.append("<tr><td>" + supplier.getSupplierName() + "</td><td>" + supplier.getStreet() +
                            "</td><td>" + supplier.getCity() + "</td></tr>\n");
                }
                builder.append("</table>\n");

                return builder.toString();
            } catch (Exception e) {
                return "Error: " + e.getMessage();
            } finally {
                if (session.isOpen()) {
                    session.close();
                }
            }

        });




    }

  /*  public static Session getSession() throws HibernateException {
        return sessionFactory.openSession();
    }
*/

 /*   public void addProduct(Product product) {
        sessionFactory.getCurrentSession().save(product);
    }*/

    /*public static void main(final String[] args) throws Exception {

        final Session session = getSession();
        org.hibernate.Transaction tx = session.beginTransaction();

        tx.commit();
        session.close();

    }*/
}

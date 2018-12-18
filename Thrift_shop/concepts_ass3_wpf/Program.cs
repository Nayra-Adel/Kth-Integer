using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace CPL_assignment_3
{
    class Program
    {

        DataContext db = new DataContext(@"Data Source=LENOVO-PC;Initial Catalog=MyShop;Integrated Security=True");
        Table<Product> product;
        Table<Brand> brand;

        public Program()
        {
            product = db.GetTable<Product>();
            brand = db.GetTable<Brand>();
        }

        public List<Product> getAllProducts()
        {
            var products = from _product in product
                           join _brand in brand on _product.brand_id equals _brand.brand_id
                           select _product;
            foreach (var item in products)
            {
                Console.WriteLine(item.product_name);
                Console.WriteLine(item.price);
                Console.WriteLine(item.Brand.brand_name);
                //Console.WriteLine(item.b);
            }
            return products.ToList();

        }

        public List<Brand> getAllBrands()
        {
            var query = from _brand in brand
                        select _brand;

            return query.ToList();
        }

        public void addProduct(Product _product)
        {
            /*int wantedBrandId = 0;
            var wantedBrand = from _brand in brand
                              where _brand.brand_name == brandName
                              select _brand;
            foreach (var item in wantedBrand)
            {
                wantedBrandId = item.brand_id;
            }

            _product.brand_id = wantedBrandId;*/
            try
            {
                product.InsertOnSubmit(_product);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                Console.WriteLine("brand not exist!");
            }
        }

        void addBrand(Brand _brand)
        {
            brand.InsertOnSubmit(_brand);
            db.SubmitChanges();
        }

        public List<Product> getSpecificPriceProducts(float specificPrice)
        {
            var products = from _product in product
                           join _brand in brand on _product.brand_id equals _brand.brand_id
                           where _product.price <= specificPrice
                           select _product;

            return products.ToList();
        }

        public List<BrandStat> getBrandsWithNumOfProducts()
        {
            var query = from _product in product
                        join _brand in brand on _product.brand_id equals _brand.brand_id
                        group _brand by _brand.brand_name into brandGroup
                        select new BrandStat(){ brand_name = brandGroup.Key,  productsNumber = brandGroup.Count()};

            
            return query.ToList();
        }

        public List<Product> getSortedProductsByName(int sortWay)
        {

            if (sortWay == 0)
            {
                var query = from _product in product
                        join _brand in brand on _product.brand_id equals _brand.brand_id
                        orderby _product.product_name ascending
                        select _product;
                return query.ToList();
            }
            else
            {
                var query = from _product in product
                        join _brand in brand on _product.brand_id equals _brand.brand_id
                        orderby _product.product_name descending
                        select _product;
                return query.ToList();
            }
        }

        public List<Product> getSortedProductsByPrice(int sortWay)
        {
            if (sortWay == 0)
            {
                var query = from _product in product
                            join _brand in brand on _product.brand_id equals _brand.brand_id
                            orderby _product.price ascending
                            select _product;

                return query.ToList();
            }
            else
            {
                var query = from _product in product
                            join _brand in brand on _product.brand_id equals _brand.brand_id
                            orderby _product.price descending
                            select _product;

                return query.ToList();
            }
        }

        //static void Main(string[] args)
        //{
        //    Program p = new Program();

        //    //p.getAllProducts();

        //    /*ShopDB db = new ShopDB("try.mdf");
        //    db.CreateDatabase();*/


        //    /*Brand newBrand = new Brand();
        //    newBrand.brand_name = "Nike";

        //    Product newProduct = new Product();
        //    newProduct.product_name = "watch";
        //    newProduct.category = "accessories";
        //    newProduct.price = 500;*/

        //    p.getAllProducts();
        //    //p.addBrand(newBrand);

        //    //p.addProduct(newProduct, "Nike");
        //    //p.getSpecificPriceProducts(300);
        //    //p.getBrandsWithNumOfProducts();
        //    //newProduct.brand_id = newBrand.brand_id;
           
        //    //product.InsertOnSubmit(newProduct);
        //    //brand.InsertOnSubmit(newBrand);

        //    //db.SubmitChanges();

        //}
    }

    class BrandStat
    {
        private string _brand_name;

        public string brand_name { get => _brand_name; set => _brand_name = value; }
        public int productsNumber { get => _productsNumber; set => _productsNumber = value; }

        private int _productsNumber;
    }
}

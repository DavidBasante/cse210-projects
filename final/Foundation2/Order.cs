using System;
namespace Foundation2;
    class Order{

        private List<Product> products;
        private Customer customer;

        public Order(Customer customer){
            this.customer = customer;
            products = new List<Product>();
        }

    public void AddProduct(Product product){
        
        products.Add(product);
    }

    public double GetTotalPrice(){

        double totalPrice = 0;

        foreach (Product product in products){

            totalPrice += product.GetPrice();
        }

        if (customer.IsInUSA()){

            totalPrice += 5;
        }
        else{

            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel(){

        string label = "Packing Label:\n";

        foreach (Product product in products){

            label += $"Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }

        return label;
    }

    public string GetShippingLabel(){
        
        return $"Shipping Label:\nName: {customer.GetName()}\nAddress: {customer.GetAddress()}";
    }
}
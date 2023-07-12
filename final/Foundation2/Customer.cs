using System;
namespace Foundation2;

    class Customer{
    private string name;
    private Address address;

    public Customer(string name, Address address){

        this.name = name;
        this.address = address;
    }

    public string GetName(){

        return name;
    }

    public bool IsInUSA(){

        return address.IsInUSA();
    }

    public string GetAddress(){

        return address.GetAddressInfo();
    }
}
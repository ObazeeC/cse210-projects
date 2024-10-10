using System;
using System.Numerics;
public class Product{
    private string _name;
    private int _id;
    private int _quantity;
    private int _price;


    public int GetTotalCost(){
        int total = 0;
        total = _price * _quantity;
        return total;
    }
}
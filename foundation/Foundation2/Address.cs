using System;
public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public bool IsInUSA (){
        bool usa = false;
        if(_country == "USA"){
            usa = true;
        }
        return usa;
    }
    public string DisplayAllString(){
        string allString = "";
       // allString = _street + _city + _state + _country;
       allString = $"{_street} {_city} {_state} \n{_country}";
        return allString;
    }
}
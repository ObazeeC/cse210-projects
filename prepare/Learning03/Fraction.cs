using System;
using System.Runtime.InteropServices;
public class Fraction {
private int _top;
private int _bottom;

public Fraction () {
    _top = 1;
    _bottom = 1;
}

public Fraction (int number){
_top = number;
_bottom = 1;
}

public Fraction (int firstNumber, int secondNumber){
    _top = firstNumber;
    _bottom = secondNumber;

}

public int GetNumerator (){
    return _top;
}

public int Getdenominator (){
    return _bottom;
}

public int SetNumerator (int top){
_top = top;
return _top;
}

public int SetDenominator (int bottom){
_bottom = bottom;
return _bottom;
}

public string GetFractionString(){
    //string top = _top.ToString();
    //string bottom = _bottom.ToString();
    string fraction = $"{_top} / {_bottom}";
    return fraction;
}

public double GetDecimalValue(){
    double top = _top;
    double bottom = _bottom;
    return top / bottom;
}
}


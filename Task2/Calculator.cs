public class Calculator
{
    double _num1;
    double _num2;
    public Calculator(double num1, double num2)
    {
        _num1 = num1;
        _num2 = num2;
    }
    public double Add(){
        return _num1+_num2;
    }
    public double Subtract(){
        return _num2-_num1;
    }
    public double Multiply(){
        return _num2*_num1;
    }
    public double Divide(){
        return _num2/_num1;
    }
}
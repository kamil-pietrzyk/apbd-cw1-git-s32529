namespace apbd_cw1_git_s32529.features;

public class Calculator
{
    private double _arg1;
    private double _arg2;
    private double _operation;

    public Calculator(double arg1, double arg2, char operation)
    {
        if (operation == '/' && arg2 == 0)
        {
            throw new Exception("Division by zero");
        }
        else
        {
            this._arg1 = arg1;
            this._arg2 = arg2;
            this._operation = operation;
        }
    }
    
    public double Result() 
    {
        switch (_operation)
        {
            case '+':
                return _arg1 + _arg2;
            case '-':
                return _arg1 - _arg2;
            case '*':
                return _arg1 * _arg2;
            case '/':
                return _arg1 / _arg2;
            default:
                return 0;
        }
    }
}
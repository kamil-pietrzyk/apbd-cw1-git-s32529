namespace apbd_cw1_git_s32529.features;

public class Calculator
{
    private decimal _arg1;
    private decimal _arg2;
    private decimal _operation;

    public Calculator(decimal arg1, decimal arg2, char operation)
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
    
    public decimal Result() 
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
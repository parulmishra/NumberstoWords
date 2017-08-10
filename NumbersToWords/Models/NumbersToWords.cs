using System;
using System.Collections.Generic;

namespace NumberstoWords.Models
{
  public class NumberstoWordsClass
  {
    private static long _number;

    public NumberstoWordsClass(long number)
    {
      _number = number;
    }
    public void SetNumber(long number)
    {
      _number = number;
    }
    public long GetNumber()
    {
      return _number;
    }
    public string Words(long number)
    {
      SetNumber(number);
      string result="";
      if(_number == 0)
        result= " zero ";
      else if(_number < 0)
      result = " minus " + Words(Math.Abs(_number));
      else if (_number > 0)
      {
        if ((_number / 1000000000000) > 0)
        {
          result = result + Words(_number / 1000000000000) + " trillion ";
          _number = _number % 1000000000000;
        }
        if ((_number / 1000000000) > 0)
        {
          result = result + Words(_number / 1000000000) + " billion ";
          _number = _number % 1000000000;
        }
        if ((_number / 1000000) > 0)
        {
          result += Words(_number / 1000000) + " million ";
          _number = _number % 1000000;
        }
        if ((_number / 1000) > 0)
        {
          result += Words(_number / 1000) + " thousand ";
          _number = _number % 1000;
        }
        if ((_number / 100) > 0)
        {
          result += Words(_number / 100) + " hundred ";
          _number = _number % 100;
        }
        if (_number > 0)
        {
          if (result != "")
          {
            result += " and ";
          }
          var ones = new[] { " zero ", " one ", " two ", " three ", " four ", " five ", " six ", " seven ", " eight ", " nine ", " ten ", " eleven ", " twelve ", " thirteen ", " fourteen ", " fifteen ", " sixteen ", " seventeen ", " eighteen ", " nineteen " };
          var tens = new[] { " zero ", " ten ", " twenty ", " thirty ", " forty ", " fifty ", " sixty ", " seventy ", " eighty ", " ninety " };
          if (_number < 20)
          {
            result = result + ones[_number];
          }
          else
          {
            result = result + tens[_number / 10];
            if ((_number % 10) > 0)
            {
              result = result + ones[_number % 10];
            }
          }
        }
      }
      return result;
    }
  }
}

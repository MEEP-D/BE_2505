using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validate
{
    public static class ValidateData
    {
        public static double Validation(string message)
        //Đây là một phương thức tĩnh (static), có nghĩa là nó có thể được gọi mà không cần tạo đối tượng của lớp ValidateData.
        {
            double number;
            string input;

            while (true)
            { //Vòng lặp này sẽ tiếp tục yêu cầu người dùng nhập dữ liệu cho đến khi họ nhập một chuỗi hợp lệ.
                //Nếu người dùng nhập không đúng (ví dụ nhập ký tự đặc biệt hoặc chữ cái),
                //chương trình sẽ hiển thị thông báo "Repeat input number!!!" và yêu cầu nhập lại.
                Console.WriteLine(message);
                input = Console.ReadLine();
                // Kiểm tra nếu chuỗi chỉ chứa các chữ số và dấu thập phân (nếu có)
                if (Regex.IsMatch(input, @"^\d+(\.\d+)?$") && double.TryParse(input, out number))
                    break;
                else
                
                    Console.WriteLine("Repeat input number!!!");
            }
        return number;
        }
    }
}
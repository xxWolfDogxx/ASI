using System;
using System.Security.Cryptography;
using System.Text;


namespace ASI.Function
{
    static class SHA256
    {
        //
        //Использование шифрование пример
        //MessageBox.Show(Function.SHA256.hash(LoginTextBox.Text));
        //

        public static string hash(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }
    }
}

namespace Lab
{
using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string data = "Hello AAAAAA";
            string filename = "mesasge.txt";

            TripleDES des = TripleDES.Create();

            des.Mode = CipherMode.CFB;
            des.Padding = PaddingMode.PKCS7;

            String key = "Rewqdvc43321";
            des.Key = Encoding.ASCII.GetBytes(key);

            String value = "hellohellhe";

            var bytesValue = Encoding.ASCII.GetBytes(value);

            

            var enc = des.CreateEncryptor();

            var ms = new MemoryStream();
            
            using(var crypto = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write)){

                crypto.Write(bytesValue, 0, bytesValue.Length);
            }

            byte[] a = new byte[]{};
            Array.Copy(ms.ToArray(), a, a.Length);

            Console.WriteLine(string.Format(a.ToString()));

            



        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void EncryptTextToFile(String Data, String FileName, byte[] Key, byte[] IV)
    {
        try
        {
            FileStream fStream = File.Open(FileName,FileMode.OpenOrCreate);

            DES DESalg = DES.Create();

            // and the passed key and initialization vector (IV).
            CryptoStream cStream = new CryptoStream(fStream,
                DESalg.CreateEncryptor(Key,IV),
                CryptoStreamMode.Write);

            // Create a StreamWriter using the CryptoStream.
            StreamWriter sWriter = new StreamWriter(cStream);

            sWriter.WriteLine(Data);

            sWriter.Close();
            cStream.Close();
            fStream.Close();
        }
        catch(CryptographicException e)
        {
            Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
        }
        catch(UnauthorizedAccessException  e)
        {
            Console.WriteLine("A file error occurred: {0}", e.Message);
        }
    }

    public static string DecryptTextFromFile(String FileName, byte[] Key, byte[] IV)
    {
        try
        {
            FileStream fStream = File.Open(FileName, FileMode.OpenOrCreate);
            DES DESalg = DES.Create();

            CryptoStream cStream = new CryptoStream(fStream,
                DESalg.CreateDecryptor(Key,IV),
                CryptoStreamMode.Read);

            StreamReader sReader = new StreamReader(cStream);

            string val = sReader.ReadLine();

            sReader.Close();
            cStream.Close();
            fStream.Close();

            // Return the string.
            return val;
        }
        catch(CryptographicException e)
        {
            Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            return null;
        }
        catch(UnauthorizedAccessException  e)
        {
            Console.WriteLine("A file error occurred: {0}", e.Message);
            return null;
        }
    }
}
}

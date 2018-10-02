using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TextEncryptor.Crypto
{
    public class Crypto
    {
        public string Encrypt(string dataToEncrypt, string pass)
        {
            byte[] bytesChain = Encoding.UTF8.GetBytes(dataToEncrypt);
            byte[] bytesKey = Encoding.UTF8.GetBytes(pass);
            RijndaelManaged rij = new RijndaelManaged
            {
                Mode = CipherMode.ECB,
                BlockSize = 128,
                Padding = PaddingMode.Zeros
            };
            ICryptoTransform encryptor;
            encryptor = rij.CreateEncryptor(bytesKey, rij.IV);
            MemoryStream memStream = new MemoryStream();
            CryptoStream streamEncryption;
            streamEncryption = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write);
            streamEncryption.Write(bytesChain, 0, bytesChain.Length);
            streamEncryption.FlushFinalBlock();
            byte[] cipherTextBytes = memStream.ToArray();
            memStream.Close();
            streamEncryption.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }

        public string Decrypt(string encryptedData, string pass)
        {
            byte[] bytesChain = Convert.FromBase64String(encryptedData);
            byte[] bytesKey = Encoding.UTF8.GetBytes(pass);
            RijndaelManaged rij = new RijndaelManaged
            {
                Mode = CipherMode.ECB,
                BlockSize = 128,
                Padding = PaddingMode.Zeros
            };
            ICryptoTransform decryptor;
            decryptor = rij.CreateDecryptor(bytesKey, rij.IV);
            MemoryStream memStream = new MemoryStream(bytesChain);
            CryptoStream streamEncryption;
            streamEncryption = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read);
            StreamReader streamReader = new StreamReader(streamEncryption);
            string result = streamReader.ReadToEnd();
            memStream.Close();
            streamEncryption.Close();
            if (result.Contains('\0')) result = result.Substring(0, result.IndexOf('\0'));
            return result;
        }
    }
}

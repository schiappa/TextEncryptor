using System;

namespace TextEncryptor.Crypto
{
    public class Key
    {
        private Crypto encrypter;

        private readonly string key = "clave_encrypt: _ -#$==%n#%$/()@r";

        public string GetMACAddress()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            Drive drive = Drive.GetDrive(root[0].ToString());

            return drive.SerialNumber.ToString();
        }

        public string GetCryptoMACAddress()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            Drive drive = Drive.GetDrive(root[0].ToString());


            encrypter = new Crypto();
            String encryptedData = encrypter.Encrypt(drive.SerialNumber.ToString(), key);
            return encryptedData;
        }

        public string EncriptText(String text)
        {
            String encryptedData = "";
            if (text != null)
            {
                encrypter = new Crypto();
                encryptedData = encrypter.Encrypt(text, key);
            }
            return encryptedData;
        }

        public string DesEncriptText(String text)
        {
            String desEncryptedData = "";
            if (text != null)
            {
                encrypter = new Crypto();
                desEncryptedData = encrypter.Decrypt(text, key);
            }
            return desEncryptedData;
        }
    }
}

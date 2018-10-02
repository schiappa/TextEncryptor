using System;

namespace TextEncryptor.Crypto
{
    public class KeyServer
    {
        private Crypto encryptor;

        private string key = "u$eEaendl&sir8d3j%@654646646546565465465454";

        public string EncryptText(String text, String mac)
        {
            int lengthToInsert = 32 - mac.Length;
            string keyString = mac + key.Substring(0, lengthToInsert);

            String encryptedData = "";
            if (text != null)
            {
                encryptor = new Crypto();
                encryptedData = encryptor.Encrypt(text, keyString);
            }
            return encryptedData;
        }

        public string DecryptText(String text, String mac)
        {
            int lengthToInsert = 32 - mac.Length;
            string keyString = mac + key.Substring(0, lengthToInsert);

            String decryptedData = "";
            if (text != null)
            {
                encryptor = new Crypto();
                decryptedData = encryptor.Decrypt(text, keyString);
            }
            return decryptedData;
        }
    }
}

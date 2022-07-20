using System;
using System.IO;

namespace Encrypted_image
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new FileStream("../../../files/image.jpg",FileMode.Open);
            const byte secretCode = 243;
            using(input)
            {
                var output = new FileStream("../../../files/image-encrypted.jpg", FileMode.Create);
                using(output)
                {
                    var buf = new byte[1024];
                    while (true)
                    {
                        var bytesRead = input.Read(buf, 0, buf.Length);
                        if (bytesRead == 0)
                            break;

                        Encrypt(buf, bytesRead,secretCode);
                        output.Write(buf, 0, bytesRead);
                    }
                }
            }
        }

        private static void Encrypt(byte[] buf, int bytesRead, byte secretCode )
        {
            for (int i = 0; i < bytesRead; i++)
            {
                buf[i] = (byte)(buf[i] ^ secretCode);
            }
        }
    }
}

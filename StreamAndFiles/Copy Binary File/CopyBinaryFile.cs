using System.Diagnostics;
using System.IO;

namespace Copy_Binary_File
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            
            using (FileStream fs=new FileStream("picture.jpg",FileMode.Open))
            {
                using (var destination=new FileStream("empty.jpg",FileMode.Create))
                {
                    fs.CopyTo(destination);
                } 
            }
        }
    }
}

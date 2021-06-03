using System;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage;
using System.IO;

namespace imgupload
{
    class Program
    {
        public static async Task<String> UploadToAzure()
        {
            /* StorageSharedKeyCredential cred = new StorageSharedKeyCredential("samplecon", "thIfrqy4hDqBh8cKBs2qLyllagmiPYhlK9cdCUlNNbbAWPrYBKPEkLCUm1Qtc7KN/nHg485xnpu5sp1PmGhWNA==");
             Uri uri = new Uri("https://myfirstdatan.blob.core.windows.net/samplecon/bird.jpg");
             BlobClient client = new BlobClient(uri, cred);
             FileStream fs = File.OpenRead("pigeon.jpg");
             await client.UploadAsync(fs);
             return "Uploaded Successfully";*/
            StorageSharedKeyCredential cred = new StorageSharedKeyCredential("myfirstdatan", "D61gW9iS2f2be2DAw/Il/SAHjp2Gi73CqbdfWpRxXQ7qpG5dkA2JgJkZarkVXaAL5qWQ1O+suuahIWldRJpEeA==");
            Uri uri = new Uri("https://myfirstdatan.blob.core.windows.net/samplecon/bird.jpg");
            BlobClient client = new BlobClient(uri, cred);
            FileStream fs = File.OpenRead("bird.jpg");
            await client.UploadAsync(fs);
            return "Uploaded Successfully";
        }

        static void Main(string[] args)
        {
            UploadToAzure().Wait();
            Console.WriteLine("Hello World!");
        }
    }
}

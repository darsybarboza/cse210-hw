using System;

class Program
{
    static void Main(string[] args)
    {
        List <Video> videos = new List<Video> {
         new Video ("THE BEST PRICE-QUALITY TABLETS OF 2023" ,"Digital tops", 1045),
         new Video ("THE NEW iPad is INEXPLICABLE", "TecnautaPlus", 3356),
         new Video ("2022 iPad Pro 12.9 vs. Galaxy Tab S8 ULTRA", "Tutecnomundo", 4677)
        };

        foreach (Video video in videos){
            video.display();
        }
    }
}
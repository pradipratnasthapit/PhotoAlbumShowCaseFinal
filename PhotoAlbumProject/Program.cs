using System;

using PhotoAlbumComponents;

namespace PhotoAlbumProject
{
    class Program
    {
        static void Main()
        {
            string photoAlbumRequestURI = System.Configuration.ConfigurationManager.AppSettings["photoAlbumRequestBaseURI"];

            PhotoAlbumDisplayComponent photoAlbumDispComp = new PhotoAlbumDisplayComponent(photoAlbumRequestURI);
            photoAlbumDispComp.DisplayAlbumIdAndTitle();
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadKey();


            photoAlbumDispComp.DisplayAlbumIdAndTitle(3);
            Console.ReadKey();
        }

    }
}

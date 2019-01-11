using System;

using Services;

namespace PhotoAlbumProject
{
    class Program
    {
        static void Main()
        {
            string photoAlbumRequestURI = System.Configuration.ConfigurationManager.AppSettings["photoAlbumRequestBaseURI"];

            PhotoAlbumDisplayService photoAlbumDispService = new PhotoAlbumDisplayService(photoAlbumRequestURI);
            photoAlbumDispService.DisplayAlbumIdAndTitle();
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadKey();


            photoAlbumDispService.DisplayAlbumIdAndTitle(3);
            Console.ReadKey();
        }

    }
}

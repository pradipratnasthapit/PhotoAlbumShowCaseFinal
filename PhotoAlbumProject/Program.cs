using System;
using PhotoAlbumProject;

namespace PhotoAlbumProject
{
    class Program
    {
        private static string photoAlbumRequestURI;
        static void Main()
        {
            photoAlbumRequestURI = GetPhotoURI();

            PhotoAlbumDisplayComponent photoAlbumDispComp = new PhotoAlbumDisplayComponent(photoAlbumRequestURI);
            photoAlbumDispComp.DisplayAlbumIdAndTitle();
            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadKey();


            photoAlbumDispComp.DisplayAlbumIdAndTitle(3);
            Console.ReadKey();
        }

        public static string GetPhotoURI()
        {
            return System.Configuration.ConfigurationManager.AppSettings["photoAlbumRequestBaseURI"];
        }
     

    }
}

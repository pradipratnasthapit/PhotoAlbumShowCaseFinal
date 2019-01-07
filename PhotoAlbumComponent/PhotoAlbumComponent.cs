using System.Collections.Generic;

using Models;
using Newtonsoft.Json;
using PhotoAlbumProjectComponents;

namespace PhotoAlbumComponents
{
    public static  class PhotoAlbumComponent
    {
        public static List<PhotoAlbum> GetPhotoAlbum(string photoAlbumRequestBaseURI)
        {
            return GetPhotoAlbums(photoAlbumRequestBaseURI);
        }

        public static List<PhotoAlbum> GetPhotoAlbums(string photoAlbumRequestBaseURI)
        {
            string responseFromServer = WebRequestComponent.GetWebResponse(photoAlbumRequestBaseURI);

            var photoAlbums = JsonConvert.DeserializeObject<List<PhotoAlbum>>(responseFromServer);

            return photoAlbums;
        }

        public static List<PhotoAlbum> GetPhotoAlbum(string photoAlbumRequestBaseURI,int albumId)
        {
            string newPhotoAlbumRequestBaseURI = string.Format("{0}?albumId={1}", photoAlbumRequestBaseURI, albumId);
            return GetPhotoAlbum(newPhotoAlbumRequestBaseURI);
        }


    }
}

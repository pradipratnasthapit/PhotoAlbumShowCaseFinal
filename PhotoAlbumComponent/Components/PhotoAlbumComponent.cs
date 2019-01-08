using System.Collections.Generic;

using Models;
using Newtonsoft.Json;
using PhotoAlbumProjectComponents;

namespace PhotoAlbumComponents
{
    public class PhotoAlbumComponent
    {
        public List<PhotoAlbum> GetPhotoAlbum(string photoAlbumRequestBaseURI)
        {
            WebRequestComponent webReqComp = new WebRequestComponent();
            string responseFromServer = webReqComp.GetWebResponse(photoAlbumRequestBaseURI);

            var photoAlbums = JsonConvert.DeserializeObject<List<PhotoAlbum>>(responseFromServer);

            return photoAlbums;
        }

        public List<PhotoAlbum> GetPhotoAlbum(string photoAlbumRequestBaseURI,int albumId)
        {
            string newPhotoAlbumRequestBaseURI = string.Format("{0}?albumId={1}", photoAlbumRequestBaseURI, albumId);
            return GetPhotoAlbum(newPhotoAlbumRequestBaseURI);
        }


    }
}

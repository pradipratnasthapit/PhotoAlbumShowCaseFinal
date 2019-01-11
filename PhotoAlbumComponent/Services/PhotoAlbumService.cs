using System.Collections.Generic;

using Newtonsoft.Json;
using Models;



namespace Services
{
    public class PhotoAlbumService
    {
        public List<PhotoAlbum> GetPhotoAlbum(string photoAlbumRequestBaseURI)
        {
            WebRequestService webReqComp = new WebRequestService();
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

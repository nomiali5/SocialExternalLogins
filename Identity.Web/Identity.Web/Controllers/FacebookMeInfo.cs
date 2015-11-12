namespace Identity.Web.Controllers
{
    public class FacebookMeInfo
    {
        public FacebookMeInfo()
        {
        }

        public dynamic Locale { get; set; }
        public dynamic Name { get; set; }
        public dynamic PictureUrl { get; set; }
        public dynamic UpdatedTime { get; set; }
    }
}
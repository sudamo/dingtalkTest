using System;

namespace DDApi.Model
{
    public class AccessTokenModel
    {
        public string access_token { get; set; }

        public int errcode { get; set; }

        public string errmsg { get; set; }
    }
}

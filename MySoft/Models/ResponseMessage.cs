﻿namespace MySoft.Models
{
    public class ResponseMessage
    {
        public ResponseMessage()
        {
            responseDetails="Operation successfully done!!";
            status="success";
        }
        public string status { get; set; }
        public string statusCode { get; set; }
        public string responseDetails { get; set; }
    }
}

﻿using System.Xml;

namespace notes_firebase.Models
{
    public class Note:BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}

﻿using System;
using System.Xml.Serialization;

namespace RJTX.Ogre.Models.Skeleton
{
    [Serializable]
    public class Animation
    {
        [XmlAttribute("length")]
        public decimal Length { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
        
        [XmlArray("tracks")]
        [XmlArrayItem("track")]
        public Track[] Tracks { get; set; }
    }
}

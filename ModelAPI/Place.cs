//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace ModelAPI
{
    using System;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    public partial class Place
    {
        [DataMember]
        public System.Guid PlaceId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual Media Media { get; set; }
    }
}
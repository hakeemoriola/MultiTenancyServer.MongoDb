﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using infusync.Security;
using System;
using System.ComponentModel.DataAnnotations;

namespace OryxDomainServices
{
    public interface IEntityBase<ObjectId>
    {
        [BsonId]
        [JsonConverter(typeof(ObjectIdConverter))]
        ObjectId Id { get; set; }
        [BsonDateTimeOptions(Representation = BsonType.Document, Kind = DateTimeKind.Local)]
        DateTime CreateDate { get; set; }
        [BsonDateTimeOptions(Representation = BsonType.Document, Kind = DateTimeKind.Local)]
        DateTime? UpdateDate { get; set; }
        string CreatedBy { get; set; }
    }

    // <summary>

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Entity abstraction.
    /// </summary>    
    ///
    /// <remarks>   Tayo, 20/03/2018. </remarks>
    ///
    /// <typeparam name="TId">  The entity ID type. </typeparam>
    ////////////////////////////////////////////////////////////////////////////////////////////////////


    //public interface IDocumentEntityBase<TId>
    //{
    //    [Key]
    //    //TId Id { get; set; }
    //    //DateTime CreateDate { get; set; }
    //    //DateTime UpdateDate { get; set; }
    //    //string Status { get; set; }
    //    //string UserSign { get; set; }
    //}

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interface for master data. </summary>
    ///
    /// <remarks>   Tayo, 20/03/2018. </remarks>
    ///
    /// <typeparam name="TId">  Type of the identifier. </typeparam>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public interface IMasterDataBase<TId> : IEntityBase<TId>
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name or description of the masterdata </summary>
        ///
        /// <value> The name. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [MaxLength(100)]
        string Name { get; set; }
        [MaxLength(20)]
        string Code { get; set; }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   Interface for documents. </summary>
    ///
    /// <remarks>   Tayo, 20/03/2018. </remarks>
    ///
    /// <typeparam name="TId">  Type of the identifier. </typeparam>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public interface IDocumentBase<TId> : IEntityBase<TId>
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the document number. This is should be autogenerated </summary>
        ///
        /// <value> The document number. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        int DocNum { get; set; }
    }

}


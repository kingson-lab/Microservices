using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace CategoryService.Models
{
	[BsonIgnoreExtraElements]
	public class Category
	{
		/*
	  This class should have five properties
	  (Id,Name,Description,CreatedBy,CreationDate). Out of these five fields, the field
	  Id should be annotated with [BsonId]. The value of CreationDate should not
	  be accepted from the user but should be always initialized with the system
	  date. 
	 */
		[BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; } = string.Empty;

		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		public string Description { get; set; } = string.Empty;

		[Required]
		public string CreatedBy { get; set; }

		[Required]
		public DateTime CreationDate { get; set; }

	}
}

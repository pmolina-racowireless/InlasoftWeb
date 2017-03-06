using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace InlasoftWeb.Models
{

    public interface IModel
    {
        //bool IsValid();
    }

    public abstract class BaseModel : IModel
    {
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        //public IEnumerable<ValidationResult> Errors = new List<ValidationResult>();
        //public bool IsValid()
        //{
        //    Validate();
        //    return !Errors.Any();
        //}

        //public IEnumerable<ValidationResult> Validate()
        //{
        //    var errors = new List<ValidationResult>();
        //    var validationContext = new ValidationContext(this, null, null);
        //    Validator.TryValidateObject(this, validationContext, errors, true);
        //    Errors = Errors.Concat(errors);
        //    return Errors;
        //}


    }

}

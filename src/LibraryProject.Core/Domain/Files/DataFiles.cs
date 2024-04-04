using Abp.Domain.Entities.Auditing;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Files
{
    public class DataFile : FullAuditedEntity<Guid>
    {
        public virtual string FileName { get; set; }

        public virtual string FileType { get; set; }

        public virtual string Category { get; set; }

        [DataType(DataType.MultilineText)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [NotMapped]
        public virtual IFormFile File { get; set; }
        /// <summary>
        /// The setter is private as it should be set once on creation and not changed.
        /// </summary>
        //[LogChanges]
        public virtual string Folder { get; set; }
        /// <summary>
        /// Owner of file
        /// </summary>
        public string OwnerId { get; set; }
    }
}

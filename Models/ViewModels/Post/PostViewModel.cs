﻿using iNOBStudios.Models.ViewModels.Account;
using iNOBStudios.Models.ViewModels.ExternalFile;
using iNOBStudios.Models.ViewModels.PostVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iNOBStudios.Models.ViewModels.Post {
    public class PostViewModel {
        public int PostId { get; set; }

        public int CurrentVersionId { get; set; }
        public virtual PostVersionViewModel CurrentVersion { get; set; }
        public virtual List<PostVersionViewModel> PostVersions { get; set; }
        public string AuthorId { get; set; }
        public List<string> PostTags { get; set; }
        public List<ExternalFileViewModel> ExternalFiles { get; set; }
    }
}

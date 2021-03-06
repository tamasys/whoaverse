﻿/*
This source file is subject to version 3 of the GPL license, 
that is bundled with this package in the file LICENSE, and is 
available online at http://www.gnu.org/licenses/gpl.txt; 
you may not use this file except in compliance with the License. 

Software distributed under the License is distributed on an "AS IS" basis,
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
the specific language governing rights and limitations under the License.

All portions of the code written by Whoaverse are Copyright (c) 2014 Whoaverse
All Rights Reserved.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Whoaverse.Models
{
    public class AddSubmissionLinkpost
    {
        public int Id { get; set; }
        public Nullable<short> Votes { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public int Type { get; set; }

        public Nullable<double> Rank { get; set; }

        [Required(ErrorMessage = "Post title is required. Please fill this field.")]
        [StringLength(200, ErrorMessage = "The title must be at least 3 and no more than 200 characters long.", MinimumLength = 3)]
        public string Linkdescription { get; set; }

        [Required(ErrorMessage = "URL is required. Please fill this field.")]
        [Url(ErrorMessage="Please enter a valid http, https, or ftp URL.")]
        public string MessageContent { get; set; }

        [Required(ErrorMessage = "You must enter a subverse to send the post to. Examples: programming, videos, pics, funny...")]
        public string Subverse { get; set; }
    }
}
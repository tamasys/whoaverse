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
    public class AddSubverse
    {
        public int Id { get; set; }

        //any upper or lower case alphabetic or numeric character, no spaces or special characters, length: 20
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Sorry, no spaces or special characters, max 20 characters")]
        [StringLength(20, ErrorMessage = "The name length is limited to 20 characters.")]
        [Required(ErrorMessage = "Name is required. Seriously.")]
        public string Name { get; set; }
        
        //this needs to be calculated via name
        [Required(ErrorMessage = "Title is required. Has to be calculated.")]
        public string Title { get; set; }

        public string Type { get; set; }
        public string Sidebar { get; set; }
        public string Submission_text { get; set; }
        public string Language { get; set; }        
        public string Label_submit_new_link { get; set; }
        public string Label_sumit_new_selfpost { get; set; }
        public string Spam_filter_links { get; set; }
        public string Spam_filter_selfpost { get; set; }
        public string Spam_filter_comments { get; set; }
        public Nullable<int> Rated_adult { get; set; }        
        public Nullable<int> Allow_default { get; set; }
        public Nullable<int> Enable_thumbnails { get; set; }
        public Nullable<int> Exclude_sitewide_bans { get; set; }
        public Nullable<int> Traffic_stats_public { get; set; }
        public Nullable<int> Minutes_to_hide_comments { get; set; }        
        public System.DateTime Creation_date { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        
    }
}
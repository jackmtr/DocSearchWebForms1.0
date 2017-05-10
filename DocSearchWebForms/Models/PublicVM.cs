﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DocSearchWebForms.Models
{
    public class PublicVM
    {
        public int Folder_ID { get; set; } //tbl_Folder.Folder_ID

        public int Document_ID { get; set; } //tbl_Document.Document_ID

        public int DocumentType_ID { get; set; } //tbl_DocumentType.DocumentType_ID

        [Display(Name = "Type of Document")]
        public string DocumentTypeName { get; set; } //tbl_DocumentType.Name

        [Display(Name = "Issue Date")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public Nullable<DateTime> IssueDate { get; set; } //tbl_Document.Issue_DT

        public string Description { get; set; } //tbl_Document.Description

        public int Category_ID { get; set; } //tbl_Category.Category_ID

        [Display(Name = "Category")]
        public string CategoryName { get; set; } //tbl_Category.Name

        [Display(Name = "Effective Date")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public Nullable<DateTime> EffectiveDate { get; set; } //tbl_DocReference.Date1_DT

        public string RefNumber { get; set; } //tbl_DocReference.RefNumber

        public string FileType { get; set; } //tbl_Document.FileType

        //////

        //[Optional] would this be usefull?
        public string Method { get; set; } //tbl_Document.Method

        //[Optional]
        public string Originator { get; set; } //tbl_Document.Originator

        //[Optional]
        public string Reason { get; set; } //tbl_Document.Reason

        //[Optional]
        public string Supplier { get; set; } //tbl_DocReference.Number1


        //look into knockout.js
    }
}
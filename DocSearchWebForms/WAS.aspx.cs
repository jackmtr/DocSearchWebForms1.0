using DocSearchWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity.Infrastructure;

namespace DocSearchWebForms
{
    public partial class WAS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<PublicVM> SelectAll() {

            WASEntities _db = new WASEntities();
            List<PublicVM> PublicVMList = new List<PublicVM>();

            var documentList = (from d in _db.tbl_Document
                                join f in _db.tbl_Folder on d.Folder_ID equals f.Folder_ID
                                //left outer join b/c not every document will have a reference number right away (aka no docreference)
                                join dr in _db.tbl_DocReference on d.Document_ID equals dr.Document_ID into ps
                                join dt in _db.tbl_DocumentType on d.DocumentType_ID equals dt.DocumentType_ID
                                join cat in _db.tbl_Category on dt.Category_ID equals cat.Category_ID
                                where d.Folder_ID == 34
                                from dr in ps.DefaultIfEmpty()
                                select new
                                {
                                    f.Folder_ID,
                                    d.Document_ID,
                                    dt.DocumentType_ID,
                                    DtName = dt.Name,
                                    d.Issue_DT,
                                    d.Description,
                                    cat.Category_ID,
                                    CatName = cat.Name,
                                    dr.Date1_DT,
                                    dr.RefNumber,
                                    d.FileType,
                                    d.Method,
                                    d.Originator,
                                    d.Reason,
                                    dr.Number1
                                }).ToList();

            foreach (var item in documentList)
            {
                PublicVM objpvm = new PublicVM();

                objpvm.Folder_ID = item.Folder_ID;
                objpvm.Document_ID = item.Document_ID;
                objpvm.DocumentType_ID = item.DocumentType_ID;
                objpvm.DocumentTypeName = item.DtName;
                objpvm.IssueDate = item.Issue_DT;
                objpvm.Description = item.Description;
                objpvm.Category_ID = item.Category_ID;
                objpvm.CategoryName = item.CatName;
                objpvm.EffectiveDate = item.Date1_DT;
                objpvm.RefNumber = item.RefNumber;
                objpvm.FileType = item.FileType;
                objpvm.Method = item.Method;
                objpvm.Originator = item.Originator;
                objpvm.Reason = item.Reason;
                objpvm.Supplier = item.Number1;

                PublicVMList.Add(objpvm);
            }

            return PublicVMList;

            //var item = _db.tbl_Document.Where(r => r.Folder_ID == 34);

            //var item = _db.tbl_Document.Where(r => r.Folder_ID == 34).Include(d => d.tbl_DocReference).Select( i => new {
            //    Document_ID = i.Document_ID,
            //    Issue_Dt = i.Issue_DT,
            //    Method = i.Method,
            //    Date1_DT = i.tbl_DocReference.Select(lp => lp.Date1_DT)
            //});
            //item = _db.tbl_Document.Where(r => r.Folder_ID == 34);

            //return item;
        }
    }
}
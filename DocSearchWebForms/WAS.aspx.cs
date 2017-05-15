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
        WASEntities _db = null;
        int folderId;

        protected void Page_Load(object sender, EventArgs e)
        {
            int clientId = Int32.Parse(Request.QueryString["clientId"]);

            _db = new WASEntities();

            ClientName.Text = _db.tbl_Folder.SingleOrDefault(folder => folder.Number == clientId).Name;
            ClientIdNum.Text = _db.tbl_Folder.SingleOrDefault(folder => folder.Number == clientId).Number.ToString();
            folderId = _db.tbl_Folder.SingleOrDefault(folder => folder.Number == clientId).Folder_ID;

            //temp list to practice with
            List<string> fakeNav = new List<string>();
            fakeNav.Add("Corrospondance");
            fakeNav.Add("Enhancements");

            TempListBox.DataSource = fakeNav;
            TempListBox.DataBind();
            //set enter outside of input to submit page.
            Page.SetFocus(SearchBoxInput);
            // defaultbutton="SearchBoxBtn" defaultfocus="SearchBoxInput"
        }

        protected void SearchBoxBtn_Click(object sender, EventArgs e)
        {
            var searchText = SearchBoxInput.Text;
            var lowEndYear = LowEndYearDD.SelectedValue;
            var highEndYear = HighEndYearDD.SelectedValue;
            //do something to update the ajax panel for the grid
        }

        public List<PublicVM> SelectAll()
        {
            List<PublicVM> PublicVMList = new List<PublicVM>();

            var documentList = (from d in _db.tbl_Document
                                join f in _db.tbl_Folder on d.Folder_ID equals f.Folder_ID
                                //left outer join b/c not every document will have a reference number right away (aka no docreference)
                                join dr in _db.tbl_DocReference on d.Document_ID equals dr.Document_ID into ps
                                join dt in _db.tbl_DocumentType on d.DocumentType_ID equals dt.DocumentType_ID
                                join cat in _db.tbl_Category on dt.Category_ID equals cat.Category_ID
                                where d.Folder_ID == folderId
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
        }
    }
}
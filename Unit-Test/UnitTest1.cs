using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyNoteBook;
using MyNoteBook.Pages.NoteBooks;
using System.Threading.Tasks;

namespace Unit_Test.test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly CreateModel _createModel;

        public UnitTest1()
        {
            _createModel = new CreateModel();
        }
   
        [TestMethod]
        public void Is_Journal_PostAsync_Exist()
        {
            Task result = _createModel.OnPostAsync();
            Assert.IsNotNull(result, "PostOk");
        }
        [TestMethod]
        public void Is_Journal_GetAsync_Exist()
        {
            Task result = (Task)_createModel.OnGet();
            Assert.IsNotNull(result, "PostOk");
        }
    }
}

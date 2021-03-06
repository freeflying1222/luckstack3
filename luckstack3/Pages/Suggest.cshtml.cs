using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _17bang.Pages.Repository;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17bang
{
    public class SuggestModel : PageModel
    {
        public IList<Suggest> Suggest { set; get; }
        public IList<Suggest> News { set; get; }

        public int SumOfSuggest { set; get; }

        private SuggestRepository _suggest;
        private SuggestRepository _asideSuggest;
        public SuggestModel()
        {
            _suggest = new SuggestRepository();
            _asideSuggest = new SuggestRepository();
        }
        public void OnGet()
        {


            string exclude = Request.Query["exclude"];
            if (string.IsNullOrEmpty(exclude))
            {
                Suggest = _suggest.Get();
            }
            else
            {
                Suggest = _suggest.GetExclude(Enum.Parse<SuggestStatus>(exclude));
            }

            int pageIndex = Convert.ToInt32(Request.RouteValues["id"]);
            int pageSize = 2, newsSize = 20;

            
            SumOfSuggest = _suggest.GetSum();
            Suggest = Suggest.GetPage(pageSize, pageIndex);
            News = _suggest.Get();
            News = News.GetPage(newsSize, pageIndex);

        }
    }
}
